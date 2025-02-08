using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class EditReserveForm : Form
    {
        public EditReserveForm()
        {
            InitializeComponent();
            LoadReserves();
        }

        private void LoadReserves()
        {
            string query = "SELECT * FROM Reserve WHERE isBorrowed = 'No'";
            DataTable reservesTable = DatabaseHelper.GetData(query);
            dataGridViewReserves.DataSource = reservesTable;

            // پنهان کردن دکمه‌ها در ابتدا
            btnDeleteReserve.Visible = false;
            btnChangeStatus.Visible = false;
        }

        private void txtSearchReserve_TextChanged(object sender, EventArgs e)
        {
            btnDeleteReserve.Visible = false;
            btnChangeStatus.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchReserve.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText)) {
                LoadReserves();
                return;
            }

            string query = "SELECT* FROM Reserve WHERE RNo = @RNo AND isBorrowed = 'No'";
            DataTable result = DatabaseHelper.GetData(query, command =>
            {
                command.Parameters.AddWithValue("@RNo", searchText);
            });

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("رزروی با این کد وجود ندارد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchReserve.Clear();
            }
            else
            {
                dataGridViewReserves.DataSource = result;

                // انتخاب اولین سطر نتیجه به صورت دستی
                if (dataGridViewReserves.Rows.Count > 0)
                {
                    dataGridViewReserves.Rows[0].Selected = true;
                }
            }
        }

        private void dataGridViewReserves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // نمایش دکمه‌ها زمانی که یک ردیف انتخاب می‌شود
                btnDeleteReserve.Visible = true;
                btnChangeStatus.Visible = true;
            }
        }

        private void btnDeleteReserve_Click(object sender, EventArgs e)
        {
            if (dataGridViewReserves.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یکی از رزروها را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewReserves.SelectedRows[0];
            int rNo = Convert.ToInt32(selectedRow.Cells["RNo"].Value);

            DialogResult confirmation = MessageBox.Show("آیا از حذف این رزرو مطمئن هستید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                string query = "DELETE FROM Reserve WHERE RNo = @RNo AND isBorrowed = 'No'";
                DatabaseHelper.ExecuteQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@RNo", rNo);
                });

                MessageBox.Show("رزرو با موفقیت حذف شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReserves();
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewReserves.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یکی از رزروها را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewReserves.SelectedRows[0];
            int rNo = Convert.ToInt32(selectedRow.Cells["RNo"].Value);
            int bNo = Convert.ToInt32(selectedRow.Cells["BNo"].Value);
            int mNo = Convert.ToInt32(selectedRow.Cells["MNo"].Value);

            // ثبت امانت جدید
            string borrowInsertQuery = @"
                INSERT INTO Borrow (BNo, MNo, BSDate, BEDate, BFine, BRRET)
                VALUES (@BNo, @MNo, GETDATE(), DATEADD(DAY, 14, GETDATE()), 0, 'No');
                SELECT SCOPE_IDENTITY();";

            //int newBorrowId = DatabaseHelper.ExecuteScalar(borrowInsertQuery, command =>
            //{
            //    command.Parameters.AddWithValue("@BNo", bNo);
            //    command.Parameters.AddWithValue("@MNo", mNo);
            //});

            int newBorrowId = 0;
            object result = DatabaseHelper.ExecuteScalar(borrowInsertQuery, command =>
            {
                command.Parameters.AddWithValue("@BNo", bNo);
                command.Parameters.AddWithValue("@MNo", mNo);
            });

            if (result != null && result != DBNull.Value)
            {
                newBorrowId = Convert.ToInt32(result);
            }


            // به‌روزرسانی رزرو
            string updateReserveQuery = "UPDATE Reserve SET isBorrowed = 'Yes' WHERE RNo = @RNo";
            DatabaseHelper.ExecuteQuery(updateReserveQuery, command =>
            {
                command.Parameters.AddWithValue("@RNo", rNo);
            });

            MessageBox.Show($"رزرو با کد {rNo} به امانت جدید با کد {newBorrowId} تغییر وضعیت داد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadReserves();
        }
    }
}
