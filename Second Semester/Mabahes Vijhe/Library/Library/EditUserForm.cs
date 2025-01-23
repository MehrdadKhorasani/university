using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class EditUserForm : Form
    {
        private string connectionString = DatabaseConfig.ConnectionString;
        private int userId;

        public EditUserForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            // پر کردن آیتم‌های کمبوباکس‌ها
            FillComboBoxes();

            // بارگذاری اطلاعات کاربر
            LoadUserDetails();
        }

        private void FillComboBoxes()
        {
            // تنظیم آیتم‌های جنسیت
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new string[] { "مرد", "زن" });

            // تنظیم آیتم‌های وضعیت
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "فعال", "راکد", "منقضی", "بدهکار" });
        }

        private void LoadUserDetails()
        {
            string query = "SELECT * FROM Member WHERE MNumber = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // کد عضویت
                        txtMNCode.Text = reader["MNCode"].ToString();

                        // نام و نام خانوادگی
                        txtFirstName.Text = reader["MFName"].ToString();
                        txtLastName.Text = reader["MLName"].ToString();

                        // تاریخ شروع و انقضا
                        dtpStartDate.Value = reader["MStartDate"] != DBNull.Value
                            ? Convert.ToDateTime(reader["MStartDate"])
                            : DateTime.Today;

                        dtpExpireDate.Value = reader["MExpireDate"] != DBNull.Value
                            ? Convert.ToDateTime(reader["MExpireDate"])
                            : DateTime.Today.AddYears(2);

                        // حداکثر تعداد کتاب‌ها
                        nudMaxBooks.Value = reader["MBMax"] != DBNull.Value
                            ? Convert.ToInt32(reader["MBMax"])
                            : 5;

                        // جنسیت
                        string gender = reader["MGender"] != DBNull.Value
                            ? reader["MGender"].ToString()
                            : "مرد";

                        if (cmbGender.Items.Contains(gender))
                        {
                            cmbGender.SelectedItem = gender;
                        }
                        else
                        {
                            cmbGender.SelectedIndex = 0; // مقدار پیش‌فرض
                        }

                        // تاریخ تولد
                        dtpBirthDate.Value = reader["MBirthDate"] != DBNull.Value
                            ? Convert.ToDateTime(reader["MBirthDate"])
                            : DateTime.Today;

                        // آدرس، شماره تلفن، کد پستی، نام پدر
                        txtAddress.Text = reader["MAddress"] != DBNull.Value ? reader["MAddress"].ToString() : "";
                        txtPhoneNumber.Text = reader["MTellNo"] != DBNull.Value ? reader["MTellNo"].ToString() : "";
                        txtPostCode.Text = reader["MPostCode"] != DBNull.Value ? reader["MPostCode"].ToString() : "";
                        txtFatherName.Text = reader["MFatherName"] != DBNull.Value ? reader["MFatherName"].ToString() : "";

                        // بدهی
                        nudDebt.Value = reader["MDebt"] != DBNull.Value
                            ? Convert.ToDecimal(reader["MDebt"])
                            : 0;

                        // وضعیت
                        string status = reader["MStatus"] != DBNull.Value
                            ? reader["MStatus"].ToString()
                            : "فعال";

                        if (cmbStatus.Items.Contains(status))
                        {
                            cmbStatus.SelectedItem = status;
                        }
                        else
                        {
                            cmbStatus.SelectedIndex = 0; // مقدار پیش‌فرض
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Member SET MNCode = @MNCode, MFName = @FirstName, MLName = @LastName, MStartDate = @StartDate, MExpireDate = @ExpireDate, " +
                               "MBMax = @MaxBooks, MGender = @Gender, MBirthDate = @BirthDate, MAddress = @Address, MTellNo = @PhoneNumber, " +
                               "MPostCode = @PostCode, MFatherName = @FatherName, MDebt = @Debt, MStatus = @Status WHERE MNumber = @UserId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
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
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("اطلاعات کاربر با موفقیت به‌روزرسانی شد.", "موفقیت");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ویرایش اطلاعات: {ex.Message}", "خطا");
            }
        }
    }
}
