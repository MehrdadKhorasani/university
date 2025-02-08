using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class ManageBorrowsForm : Form
    {
        private int selectedBorrowId = -1;

        public ManageBorrowsForm()
        {
            InitializeComponent();
            LoadBorrows();
            dataGridViewBorrows.CellClick += DataGridViewBorrows_CellClick;
            btnReturnBorrow.Click += BtnReturnBorrow_Click;
            btnExtendBorrow.Click += BtnExtendBorrow_Click;
            btnSearch.Click += BtnSearch_Click;
        }

        private void LoadBorrows()
        {
            string query = "SELECT * FROM Borrow WHERE BRRET = 'No'";
            DataTable borrowTable = DatabaseHelper.GetData(query);
            dataGridViewBorrows.DataSource = borrowTable;

            // پنهان کردن دکمه‌ها تا زمانی که ردیفی انتخاب نشود
            btnReturnBorrow.Visible = false;
            btnExtendBorrow.Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string borrowId = txtSearchBorrowId.Text.Trim();
            if (string.IsNullOrWhiteSpace(borrowId))
            {
                LoadBorrows();
                return;
            }

            string query = "SELECT * FROM Borrow WHERE BRNo = @BRNo AND BRRET = 'No'";
            DataTable result = DatabaseHelper.GetData(query, command =>
            {
                command.Parameters.AddWithValue("@BRNo", borrowId);
            });

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("امانتی با این شماره یافت نشد یا قبلاً بازگردانده شده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadBorrows(); // بازگرداندن به حالت اولیه
            }
            else
            {
                dataGridViewBorrows.DataSource = result;
            }
        }

        private void DataGridViewBorrows_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // بررسی اینکه آیا سلول دارای مقدار نیست
            var cellValue = dataGridViewBorrows.Rows[e.RowIndex].Cells["BRNo"].Value;
            if (cellValue == DBNull.Value || cellValue == null)
            {
                MessageBox.Show("لطفاً ردیف معتبر را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // جلوگیری از انتخاب ردیف خالی
            }

            // تبدیل مقدار سلول به int در صورتی که مقدار معتبر باشد
            selectedBorrowId = Convert.ToInt32(cellValue);

            // نمایش دکمه‌های بازگرداندن و تمدید
            btnReturnBorrow.Visible = true;
            btnExtendBorrow.Visible = true;
        }


        private void BtnReturnBorrow_Click(object sender, EventArgs e)
        {
            if (selectedBorrowId == -1) return;

            try
            {
                // بازیابی اطلاعات امانت
                string query = "SELECT BNo FROM Borrow WHERE BRNo = @BRNo";
                string bookBNo = "";
                DatabaseHelper.ReadData(query, reader =>
                {
                    if (reader.Read())
                    {
                        bookBNo = reader["BNo"].ToString();
                    }
                },
                command =>
                {
                    command.Parameters.AddWithValue("@BRNo", selectedBorrowId);
                });

                // به‌روزرسانی اطلاعات امانت
                string updateBorrowQuery = "UPDATE Borrow SET BRRDate = @BRRDate, BRRET = 'Yes' WHERE BRNo = @BRNo";
                DatabaseHelper.ExecuteQuery(updateBorrowQuery, command =>
                {
                    command.Parameters.AddWithValue("@BRRDate", DateTime.Now);
                    command.Parameters.AddWithValue("@BRNo", selectedBorrowId);
                });

                // افزایش موجودی کتاب
                string updateBookQuery = "UPDATE Book SET BCNT = BCNT + 1 WHERE BNo = @BNo";
                DatabaseHelper.ExecuteQuery(updateBookQuery, command =>
                {
                    command.Parameters.AddWithValue("@BNo", bookBNo);
                });

                MessageBox.Show("بازگرداندن امانت با موفقیت انجام شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBorrows();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بازگرداندن امانت: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExtendBorrow_Click(object sender, EventArgs e)
        {
            if (selectedBorrowId == -1) return;

            try
            {
                // تمدید امانت به مدت دو هفته
                string query = "UPDATE Borrow SET BEDate = DATEADD(day, 14, BEDate) WHERE BRNo = @BRNo";
                DatabaseHelper.ExecuteQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@BRNo", selectedBorrowId);
                });

                MessageBox.Show("تمدید امانت با موفقیت انجام شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBorrows();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در تمدید امانت: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}