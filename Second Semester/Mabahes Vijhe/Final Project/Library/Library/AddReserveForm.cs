using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class AddReserveForm : Form
    {
        private string selectedBookBNo;
        private string selectedMemberMNo;
        private DateTime nearestDate;

        public AddReserveForm()
        {
            InitializeComponent();
            LoadUnavailableBooks();
        }

        private void LoadUnavailableBooks()
        {
            string query = "SELECT * FROM Book WHERE BCCNT = 0";
            DataTable booksTable = DatabaseHelper.GetData(query);
            dataGridViewBooks.DataSource = booksTable;
        }

        private void txtSearchBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (string.IsNullOrWhiteSpace(txtSearchBook.Text)) 
                {
                    LoadUnavailableBooks();
                    return;
                }

            string searchText = txtSearchBook.Text;

            string query = "SELECT * FROM Book WHERE BCCNT = 0 AND BNo LIKE @SearchText";
            DataTable result = DatabaseHelper.GetData(query, command =>
            {
                command.Parameters.AddWithValue("@SearchText", $"%{searchText}%");
            });

            dataGridViewBooks.DataSource = result;
            }
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedBookBNo = dataGridViewBooks.Rows[e.RowIndex].Cells["BNo"].Value.ToString();

            
            string query = @"SELECT MIN(BEDate) AS NearestDate 
                             FROM Borrow 
                             WHERE BNo = @BNo AND BEDate >= GETDATE()";
            DataTable result = DatabaseHelper.GetData(query, command =>
            {
                command.Parameters.AddWithValue("@BNo", selectedBookBNo);
            });

            if (result.Rows.Count > 0 && result.Rows[0]["NearestDate"] != DBNull.Value)
            {
                nearestDate = Convert.ToDateTime(result.Rows[0]["NearestDate"]);
                lblNearestDate.Text = $"نزدیک‌ترین تاریخ بازگشت: {nearestDate.ToShortDateString()}";
            }
            else
            {
                lblNearestDate.Text = "نزدیک‌ترین تاریخ بازگشت: نامشخص";
            }

            LoadMembers();
        }

        private void LoadMembers()
        {
            string query = "SELECT * FROM Member";
            DataTable membersTable = DatabaseHelper.GetData(query);
            dataGridViewMembers.DataSource = membersTable;
        }

        private void dataGridViewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedMemberMNo = dataGridViewMembers.Rows[e.RowIndex].Cells["MNo"].Value.ToString();
            lblSelectedMember.Text = $"کاربر انتخاب‌شده: {selectedMemberMNo}";
        }

        private void btnReserveBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedBookBNo) || string.IsNullOrWhiteSpace(selectedMemberMNo))
            {
                MessageBox.Show("لطفاً ابتدا کتاب و کاربر را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nearestDate == default)
            {
                MessageBox.Show("نمی‌توان کتابی بدون تاریخ بازگشت رزرو کرد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ثبت رزرو در جدول Reserve
            string query = @"INSERT INTO Reserve (BNo, MNo, nearestDate, isBorrowed) 
                             VALUES (@BNo, @MNo, @NearestDate, 'No')";

            DatabaseHelper.ExecuteQuery(query, command =>
            {
                command.Parameters.AddWithValue("@BNo", selectedBookBNo);
                command.Parameters.AddWithValue("@MNo", selectedMemberMNo);
                command.Parameters.AddWithValue("@NearestDate", nearestDate);
            });

            MessageBox.Show("رزرو با موفقیت ثبت شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void ResetForm()
        {
            selectedBookBNo = null;
            selectedMemberMNo = null;
            nearestDate = default;

            lblNearestDate.Text = "نزدیک‌ترین تاریخ بازگشت: -";
            lblSelectedMember.Text = "کاربر انتخاب‌شده: -";

            LoadUnavailableBooks();
        }
    }
}
