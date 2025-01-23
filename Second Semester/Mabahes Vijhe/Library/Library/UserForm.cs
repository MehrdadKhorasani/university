using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class UserForm : Form
    {
        private string connectionString = DatabaseConfig.ConnectionString;
        private int userId; // ID کاربر فعلی

        public UserForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadBorrowedBooks();
            LoadDebt();
        }

        // بارگذاری لیست کتاب‌های امانت گرفته‌شده
        private void LoadBorrowedBooks()
        {
            string query = @"
                SELECT 
                    Book.BTitle AS 'نام کتاب',
                    Borrow.BRReturnDate AS 'تاریخ بازگشت',
                    Borrow.BRStatus AS 'وضعیت'
                FROM 
                    Borrow
                INNER JOIN 
                    Book ON Borrow.BNumber = Book.BNumber
                WHERE 
                    Borrow.MNumber = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable borrowTable = new DataTable();
                adapter.Fill(borrowTable);
                dgvBorrowedBooks.DataSource = borrowTable;

                // تنظیم رنگ بر اساس وضعیت
                foreach (DataGridViewRow row in dgvBorrowedBooks.Rows)
                {
                    var cellValue = row.Cells["وضعیت"].Value;

                    if (cellValue != null && cellValue.ToString() == "بسته")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                }
            }
        }

        // بارگذاری بدهی کاربر
        private void LoadDebt()
        {
            string query = "SELECT MDebt FROM Member WHERE MNumber = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                connection.Open();
                object debt = command.ExecuteScalar();
                lblDebt.Text = $"بدهی: {debt ?? 0} ریال";
            }
        }

        // تغییر رمز عبور
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = Prompt.ShowDialog("رمز عبور جدید را وارد کنید:", "تغییر رمز عبور");
            if (!string.IsNullOrEmpty(newPassword))
            {
                try
                {
                    string query = "UPDATE Users SET Password = @Password WHERE MemberId = @UserId";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Password", newPassword);
                        command.Parameters.AddWithValue("@UserId", userId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("رمز عبور با موفقیت تغییر یافت.", "موفقیت");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطا در تغییر رمز عبور: {ex.Message}", "خطا");
                }
            }
        }
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form
                {
                    Width = 400,
                    Height = 200,
                    Text = caption
                };

                Label lblText = new Label { Left = 20, Top = 20, Text = text, AutoSize = true };
                TextBox txtInput = new TextBox { Left = 20, Top = 60, Width = 340 };
                Button btnOk = new Button { Text = "تایید", Left = 280, Width = 80, Top = 100, DialogResult = DialogResult.OK };

                prompt.Controls.Add(lblText);
                prompt.Controls.Add(txtInput);
                prompt.Controls.Add(btnOk);
                prompt.AcceptButton = btnOk;

                return prompt.ShowDialog() == DialogResult.OK ? txtInput.Text : string.Empty;
            }
        }


        // خروج از فرم
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
