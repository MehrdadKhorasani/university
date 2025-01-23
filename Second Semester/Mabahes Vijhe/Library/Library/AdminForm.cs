using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminForm : Form
    {
        private string connectionString = DatabaseConfig.ConnectionString;
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadBooks();
            LoadBorrows();
        }
        // -------------------- مدیریت کاربران --------------------
        private void LoadUsers()
        {
            string query = "SELECT * FROM Member";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable userTable = new DataTable();
                adapter.Fill(userTable);
                dgvUsers.DataSource = userTable;
            }
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchUser.Text.Trim();
            string query = "SELECT * FROM Member WHERE MNCode LIKE @search OR MFName LIKE @search OR MLName LIKE @search";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@search", $"%{searchValue}%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable userTable = new DataTable();
                adapter.Fill(userTable);
                dgvUsers.DataSource = userTable;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
                MessageBox.Show("کاربر جدید با موفقیت اضافه شد.", "موفقیت");
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int memberId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["MNumber"].Value);
                EditUserForm editUserForm = new EditUserForm(memberId);
                if (editUserForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                    MessageBox.Show("اطلاعات کاربر با موفقیت ویرایش شد.", "موفقیت");
                }
            }
        }

        // -------------------- مدیریت کتاب‌ها --------------------
        private void LoadBooks()
        {
            string query = "SELECT * FROM Book";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable bookTable = new DataTable();
                adapter.Fill(bookTable);
                dgvBooks.DataSource = bookTable;
            }
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchBook.Text.Trim();
            string query = "SELECT * FROM Book WHERE BNumber LIKE @search OR BTitle LIKE @search OR BAuthorFName1 LIKE @search";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@search", $"%{searchValue}%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable bookTable = new DataTable();
                adapter.Fill(bookTable);
                dgvBooks.DataSource = bookTable;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
                MessageBox.Show("کتاب جدید با موفقیت اضافه شد.", "موفقیت");
            }
        }

        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int bookId = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["BNumber"].Value);
                EditBookForm editBookForm = new EditBookForm(bookId);
                if (editBookForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                    MessageBox.Show("اطلاعات کتاب با موفقیت ویرایش شد.", "موفقیت");
                }
            }
        }

        // -------------------- مدیریت امانات --------------------
        private void LoadBorrows()
        {
            string query = @"
        SELECT 
            Borrow.BRNo AS 'شماره امانت',
            Borrow.BRStartDate AS 'تاریخ امانت',
            Borrow.BRReturnDate AS 'تاریخ بازگشت',
            Book.BTitle AS 'نام کتاب',
            Member.MFName + ' ' + Member.MLName AS 'نام کاربر',
            Borrow.BRStatus AS 'وضعیت'
        FROM 
            Borrow
        INNER JOIN 
            Book ON Borrow.BNumber = Book.BNumber
        INNER JOIN 
            Member ON Borrow.MNumber = Member.MNumber";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable borrowTable = new DataTable();
                adapter.Fill(borrowTable);
                dgvBorrows.DataSource = borrowTable;
            }
        }
        private void txtSearchBorrow_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchBorrow.Text.Trim();
            string query;

            if (string.IsNullOrEmpty(searchValue))
            {
                query = @"
            SELECT 
                Borrow.BRNo AS 'شماره امانت',
                Borrow.BRStartDate AS 'تاریخ امانت',
                Borrow.BRReturnDate AS 'تاریخ بازگشت',
                Book.BTitle AS 'نام کتاب',
                Member.MFName + ' ' + Member.MLName AS 'نام کاربر',
                Borrow.BRStatus AS 'وضعیت'
            FROM 
                Borrow
            INNER JOIN 
                Book ON Borrow.BNumber = Book.BNumber
            INNER JOIN 
                Member ON Borrow.MNumber = Member.MNumber";
            }
            else
            {
                query = @"
            SELECT 
                Borrow.BRNo AS 'شماره امانت',
                Borrow.BRStartDate AS 'تاریخ امانت',
                Borrow.BRReturnDate AS 'تاریخ بازگشت',
                Book.BTitle AS 'نام کتاب',
                Member.MFName + ' ' + Member.MLName AS 'نام کاربر',
                Borrow.BRStatus AS 'وضعیت'
            FROM 
                Borrow
            INNER JOIN 
                Book ON Borrow.BNumber = Book.BNumber
            INNER JOIN 
                Member ON Borrow.MNumber = Member.MNumber
            WHERE 
                Book.BTitle LIKE @search OR
                Member.MFName + ' ' + Member.MLName LIKE @search OR
                Borrow.BRNo LIKE @search";

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (!string.IsNullOrEmpty(searchValue))
                {
                    command.Parameters.AddWithValue("@search", $"%{searchValue}%");
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable borrowTable = new DataTable();
                adapter.Fill(borrowTable);
                dgvBorrows.DataSource = borrowTable;
            }
        }
        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            AddBorrowForm addBorrowForm = new AddBorrowForm();
            if (addBorrowForm.ShowDialog() == DialogResult.OK)
            {
                LoadBorrows(); // بارگذاری دوباره اطلاعات
                MessageBox.Show("امانت جدید با موفقیت اضافه شد.", "موفقیت");
            }
        }



        private void dgvBorrows_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int borrowId = Convert.ToInt32(dgvBorrows.Rows[e.RowIndex].Cells["شماره امانت"].Value);
                EditBorrowForm editBorrowForm = new EditBorrowForm(borrowId);
                if (editBorrowForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBorrows();
                    MessageBox.Show("اطلاعات امانت با موفقیت ویرایش شد.", "موفقیت");
                }
            }
        }

        // -------------------- خروج --------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مطمئن هستید که می‌خواهید خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}
