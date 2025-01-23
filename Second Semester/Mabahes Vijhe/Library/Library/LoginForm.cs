using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        private string connectionString = DatabaseConfig.ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("لطفاً نام کاربری و رمز عبور را وارد کنید.", "خطا");
                return;
            }

            string query = "SELECT Role, MemberID FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string role = reader["Role"].ToString();

                        // بررسی مقدار MemberID
                        int memberId = reader.IsDBNull(reader.GetOrdinal("MemberID"))
                            ? -1 // مقدار پیش‌فرض برای کاربرانی که MemberID ندارند
                            : Convert.ToInt32(reader["MemberID"]);

                        if (role == "Admin")
                        {
                            this.Hide();
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else if (role == "User")
                        {
                            if (memberId == -1)
                            {
                                MessageBox.Show("این کاربر به یک عضو مرتبط نیست.", "خطا");
                                return;
                            }

                            this.Hide();
                            UserForm userForm = new UserForm(memberId);
                            userForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("نقش کاربری نامعتبر است.", "خطا");
                        }
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.", "خطا");
                    }
                }
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // فرم لاگین بسته می‌شود
        }

    }
}
