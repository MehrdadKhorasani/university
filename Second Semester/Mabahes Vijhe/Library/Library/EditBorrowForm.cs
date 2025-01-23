using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class EditBorrowForm : Form
    {
        private string connectionString = DatabaseConfig.ConnectionString;
        private int borrowId;

        public EditBorrowForm(int borrowId)
        {
            InitializeComponent();
            this.borrowId = borrowId;
            LoadBorrowDetails();
        }

        private void LoadBorrowDetails()
        {
            string query = "SELECT * FROM Borrow WHERE BRNo = @BRNo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BRNo", borrowId);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtBookId.Text = reader["BNumber"].ToString();
                        txtMemberId.Text = reader["MNumber"].ToString();
                        dtpBorrowDate.Value = Convert.ToDateTime(reader["BRStartDate"]);
                        dtpReturnDate.Value = Convert.ToDateTime(reader["BRReturnDate"]);
                        string status = reader["BRStatus"].ToString();

                        if (status == "بسته")
                        {
                            DisableForm(); // غیر فعال کردن فرم
                        }
                    }
                }
            }
        }
        private void DisableForm()
        {
            txtBookId.Enabled = false;
            txtMemberId.Enabled = false;
            dtpBorrowDate.Enabled = false;
            dtpReturnDate.Enabled = false;
            btnExtend.Enabled = false;
            btnReturn.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستید که می‌خواهید امانت را تمدید کنید؟", "تمدید امانت", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtpReturnDate.Value = dtpReturnDate.Value.AddDays(14); // تمدید به مدت ۲ هفته
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستید که این امانت بازگشت داده شده است؟", "بازگشت امانت", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE Borrow SET BRStatus = @BRStatus WHERE BRNo = @BRNo";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BRNo", borrowId);
                        command.Parameters.AddWithValue("@BRStatus", "بسته");

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("وضعیت امانت به بسته تغییر یافت.", "بازگشت امانت");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطا در بازگشت امانت: {ex.Message}", "خطا");
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Borrow SET BRReturnDate = @BRReturnDate WHERE BRNo = @BRNo";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BRNo", borrowId);
                    command.Parameters.AddWithValue("@BRReturnDate", dtpReturnDate.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("اطلاعات امانت با موفقیت به‌روزرسانی شد.", "موفقیت");
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
