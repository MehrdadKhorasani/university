using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBorrowForm : Form
    {
        private string selectedBookBNo;
        private string selectedMemberMNo;

        public AddBorrowForm()
        {
            InitializeComponent();
            LoadBooks();
            LoadMembers();
        }

        private void LoadBooks()
        {
            string query = "SELECT * FROM Book WHERE BCCNT > 0"; 
            DataTable booksTable = DatabaseHelper.GetData(query);
            dataGridViewBooks.DataSource = booksTable;
        }

        private void LoadMembers()
        {
            string query = "SELECT * FROM Member WHERE MDebt = 0";
            DataTable membersTable = DatabaseHelper.GetData(query);
            dataGridViewMembers.DataSource = membersTable;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string bNo = txtBookCode.Text.Trim();
            if (string.IsNullOrWhiteSpace(bNo)) return;

            string query = "SELECT * FROM Book WHERE BNo = @BNo AND BCCNT > 0"; 
            DataTable result = DatabaseHelper.GetData(query, command =>
            {
                command.Parameters.AddWithValue("@BNo", bNo);
            });

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("کتاب موردنظر موجود نیست یا پیدا نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridViewBooks.DataSource = result;
            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            string mNo = txtMemberCode.Text.Trim();
            if (string.IsNullOrWhiteSpace(mNo)) return;

            string query = "SELECT * FROM Member WHERE MNo = @MNo And MDebt = 0";
            DataTable result = DatabaseHelper.GetData(query, command =>
            {
                command.Parameters.AddWithValue("@MNo", mNo);
            });

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("کاربر موردنظر پیدا نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridViewMembers.DataSource = result;
            }
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedBookBNo = dataGridViewBooks.Rows[e.RowIndex].Cells["BNo"].Value.ToString();
            lblSelectedBook.Text = $"کتاب انتخاب‌شده: {selectedBookBNo}";
        }

        private void dataGridViewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedMemberMNo = dataGridViewMembers.Rows[e.RowIndex].Cells["MNo"].Value.ToString();
            lblSelectedMember.Text = $"کاربر انتخاب‌شده: {selectedMemberMNo}";
        }

        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedBookBNo) || string.IsNullOrWhiteSpace(selectedMemberMNo))
            {
                MessageBox.Show("لطفاً ابتدا کتاب و کاربر را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // بررسی تعداد امانت‌های جاری کاربر
            string checkBorrowQuery = @"
                SELECT ISNULL(COUNT(*), 0) AS BorrowCount, MBMax 
                FROM Member 
                LEFT JOIN Borrow ON Member.MNo = Borrow.MNo AND BRRET = 'No'
                WHERE Member.MNo = @MNo
                GROUP BY Member.MBMax";

            bool canBorrow = false;
            DatabaseHelper.ReadData(checkBorrowQuery, reader =>
            {
                int currentBorrowCount = reader.GetInt32(0); 

                int maxBorrowLimit = reader.GetByte(1);

                if (currentBorrowCount < maxBorrowLimit)
                {
                    canBorrow = true;
                }
            }, command =>
            {
                command.Parameters.AddWithValue("@MNo", selectedMemberMNo);
            });


            if (!canBorrow)
            {
                MessageBox.Show("کاربر نمی‌تواند امانت بیشتری بگیرد. حد مجاز امانت‌ها پر شده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ثبت امانت جدید
            string query = @"INSERT INTO Borrow (MNo, BNo, BSdate, BEDate, BRRET) 
                     VALUES (@MNo, @BNo, @BSdate, @BEDate, @BRRET)";

            DatabaseHelper.ExecuteQuery(query, command =>
            {
                command.Parameters.AddWithValue("@MNo", selectedMemberMNo);
                command.Parameters.AddWithValue("@BNo", selectedBookBNo);
                command.Parameters.AddWithValue("@BSdate", dateStart.Value);
                command.Parameters.AddWithValue("@BEDate", dateEnd.Value);
                command.Parameters.AddWithValue("@BRRET", "No");
            });

            // کاهش تعداد موجودی کتاب
            string updateQuery = "UPDATE Book SET BCCNT = BCCNT - 1 WHERE BNo = @BNo";
            DatabaseHelper.ExecuteQuery(updateQuery, command =>
            {
                command.Parameters.AddWithValue("@BNo", selectedBookBNo);
            });

            MessageBox.Show("امانت با موفقیت ثبت شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }


        private void ResetForm()
        {
            selectedBookBNo = null;
            selectedMemberMNo = null;
            lblSelectedBook.Text = "کتاب انتخاب‌شده: -";
            lblSelectedMember.Text = "کاربر انتخاب‌شده: -";
            txtBookCode.Clear();
            txtMemberCode.Clear();
            LoadBooks();
            LoadMembers();
        }
    }
}