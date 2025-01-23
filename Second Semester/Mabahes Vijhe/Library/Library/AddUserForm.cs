using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class AddUserForm : Form
    {
        private string connectionString = DatabaseConfig.ConnectionString;

        public AddUserForm()
        {
            InitializeComponent();
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            dtpStartDate.Value = DateTime.Today; // تاریخ شروع پیش‌فرض: امروز
            dtpExpireDate.Value = DateTime.Today.AddYears(2); // تاریخ انقضا پیش‌فرض: دو سال بعد
            nudMaxBooks.Value = 5; // پیش‌فرض: حداکثر 5 کتاب
            nudDebt.Value = 0; // پیش‌فرض: بدهی صفر
            cmbGender.Items.AddRange(new string[] { "مرد", "زن" });
            cmbGender.SelectedIndex = 0; // پیش‌فرض: مرد
            cmbStatus.Items.AddRange(new string[] { "فعال", "راکد", "منقضی", "بدهکار" });
            cmbStatus.SelectedIndex = 0; // پیش‌فرض: فعال
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string queryUser = @"
            INSERT INTO Member (MNCode, MFName, MLName, MStartDate, MExpireDate, MBMax, MGender, MBirthDate, MAddress, MTellNo, MPostCode, MFatherName, MDebt, MStatus) 
            VALUES (@MNCode, @FirstName, @LastName, @StartDate, @ExpireDate, @MaxBooks, @Gender, @BirthDate, @Address, @PhoneNumber, @PostCode, @FatherName, @Debt, @Status);
            SELECT SCOPE_IDENTITY();";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryUser, connection))
                {
                    // پارامترهای اطلاعات کاربر
                    command.Parameters.AddWithValue("@MNCode", txtMNCode.Text);
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    command.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    command.Parameters.AddWithValue("@ExpireDate", dtpExpireDate.Value);
                    command.Parameters.AddWithValue("@MaxBooks", nudMaxBooks.Value);
                    command.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    command.Parameters.AddWithValue("@PostCode", txtPostCode.Text);
                    command.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    command.Parameters.AddWithValue("@Debt", nudDebt.Value);
                    command.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());

                    connection.Open();
                    int memberId = Convert.ToInt32(command.ExecuteScalar()); // گرفتن ID کاربر جدید

                    // ایجاد حساب کاربری
                    string username = $"{txtFirstName.Text.ToLower()}{memberId}"; // تولید نام کاربری
                    string password = "12345"; // رمز پیش‌فرض

                    string queryAccount = @"
                INSERT INTO Users (Username, Password, Role, MemberID) 
                VALUES (@Username, @Password, @Role, @MemberID);";

                    using (SqlCommand commandAccount = new SqlCommand(queryAccount, connection))
                    {
                        commandAccount.Parameters.AddWithValue("@Username", username);
                        commandAccount.Parameters.AddWithValue("@Password", password);
                        commandAccount.Parameters.AddWithValue("@Role", "User");
                        commandAccount.Parameters.AddWithValue("@MemberID", memberId);

                        commandAccount.ExecuteNonQuery();
                        MessageBox.Show($"کاربر جدید با موفقیت ایجاد شد.\nنام کاربری: {username}\nرمز عبور: {password}", "موفقیت");

                    }
                }

                MessageBox.Show("کاربر جدید و حساب کاربری مرتبط با موفقیت ایجاد شدند.", "موفقیت");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ذخیره اطلاعات: {ex.Message}", "خطا");
            }
        }

    }
}
