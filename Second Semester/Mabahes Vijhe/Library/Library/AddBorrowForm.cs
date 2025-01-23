using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBorrowForm : Form
    {
        private string connectionString = DatabaseConfig.ConnectionString;
        public AddBorrowForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Borrow (BNumber, MNumber, BRStartDate, BRReturnDate) " +
                               "VALUES (@BNumber, @MNumber, @BRStartDate, @BRReturnDate)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BNumber", txtBookId.Text);
                    command.Parameters.AddWithValue("@MNumber", txtMemberId.Text);
                    command.Parameters.AddWithValue("@BRStartDate", dtpBorrowDate.Value);
                    command.Parameters.AddWithValue("@BRReturnDate", dtpReturnDate.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("امانت جدید با موفقیت ثبت شد.", "موفقیت");
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
