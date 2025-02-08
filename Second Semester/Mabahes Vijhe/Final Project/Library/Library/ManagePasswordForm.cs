using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class ManagePasswordForm : Form
    {
        public ManagePasswordForm()
        {
            InitializeComponent();
            btnUpdate.Click += BtnUpdate_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string currentUsername = txtCurrentUsername.Text;
            string currentPassword = txtCurrentPassword.Text;
            string newUsername = txtNewUsername.Text;
            string newPassword = txtNewPassword.Text;

            // مرحله اول: بررسی صحت نام کاربری و رمز عبور فعلی
            if (ValidateLogin(currentUsername, currentPassword))
            {
                // مرحله دوم: به‌روزرسانی نام کاربری و رمز عبور در پایگاه داده
                if (UpdateCredentials(currentUsername, currentPassword, newUsername, newPassword))
                {
                    MessageBox.Show("نام کاربری و رمز عبور با موفقیت تغییر یافت!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("خطا در تغییر نام کاربری یا رمز عبور.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور فعلی اشتباه است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Clear();
                txtCurrentPassword.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // متد بررسی صحت نام کاربری و رمز عبور فعلی
        private bool ValidateLogin(string username, string password)
        {
            bool isValid = false;

            string query = "SELECT COUNT(*) FROM Account WHERE username = @username AND password = @password";

            try
            {
                DatabaseHelper.ReadData(query, reader =>
                {
                    if (reader.GetInt32(0) > 0)
                    {
                        isValid = true;
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

        // متد به‌روزرسانی نام کاربری و رمز عبور
        private bool UpdateCredentials(string currentUsername, string currentPassword, string newUsername, string newPassword)
        {
            bool isUpdated = false;

            string query = "UPDATE Account SET username = @newUsername, password = @newPassword " +
                           "WHERE username = @currentUsername AND password = @currentPassword";

            try
            {
                DatabaseHelper.ExecuteQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@newUsername", newUsername);
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    cmd.Parameters.AddWithValue("@currentUsername", currentUsername);
                    cmd.Parameters.AddWithValue("@currentPassword", currentPassword);
                });

                isUpdated = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در به‌روزرسانی اطلاعات: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isUpdated;
        }
    }
}
