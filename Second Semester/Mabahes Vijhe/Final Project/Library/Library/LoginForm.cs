using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // اعتبارسنجی نام کاربری و رمز عبور از جدول Account
            if (ValidateLogin(username, password))
            {
                MessageBox.Show("ورود موفقیت‌آمیز بود!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            bool isValid = false;

            string query = "SELECT COUNT(*) FROM Account WHERE username = @username AND password = @password";

            try
            {
                // استفاده از DatabaseHelper برای اجرای کوئری
                DatabaseHelper.ReadData(query, reader =>
                {
                    if (reader.GetInt32(0) > 0)
                    {
                        isValid = true; // اگر رکوردی یافت شود، اعتبارسنجی موفق است
                    }
                },
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در برقراری ارتباط با پایگاه داده: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
