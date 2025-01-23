using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBookForm : Form
    {
        private string connectionString = DatabaseConfig.ConnectionString;

        public AddBookForm()
        {
            InitializeComponent();
            LoadDefaults();
        }

        private void LoadDefaults()
        {
            txtBookId.Text = "Auto Generated";
            txtYear.Text = DateTime.Now.Year.ToString();
            txtCopies.Text = "1";
            txtPubCNT.Text = "1";
            txtPrice.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Book (BStandardCode, BTitle, BAuthorFName1, BAuthorLName1, BAuthorFName2, BAuthorLName2, " +
                               "BTranslatorFName1, BTranslatorLName1, BTranslatorFName2, BTranslatorLName2, BPublisher, BPubYear, BPrice, " +
                               "BPubCNT, BCNT) VALUES (@BStandardCode, @BTitle, @BAuthorFName1, @BAuthorLName1, @BAuthorFName2, @BAuthorLName2, " +
                               "@BTranslatorFName1, @BTranslatorLName1, @BTranslatorFName2, @BTranslatorLName2, @BPublisher, @BPubYear, @BPrice, @BPubCNT, @BCNT)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BStandardCode", txtStandardCode.Text);
                    command.Parameters.AddWithValue("@BTitle", txtTitle.Text);
                    command.Parameters.AddWithValue("@BAuthorFName1", txtAuthorFName1.Text);
                    command.Parameters.AddWithValue("@BAuthorLName1", txtAuthorLName1.Text);
                    command.Parameters.AddWithValue("@BAuthorFName2", txtAuthorFName2.Text);
                    command.Parameters.AddWithValue("@BAuthorLName2", txtAuthorLName2.Text);
                    command.Parameters.AddWithValue("@BTranslatorFName1", txtTranslatorFName1.Text);
                    command.Parameters.AddWithValue("@BTranslatorLName1", txtTranslatorLName1.Text);
                    command.Parameters.AddWithValue("@BTranslatorFName2", txtTranslatorFName2.Text);
                    command.Parameters.AddWithValue("@BTranslatorLName2", txtTranslatorLName2.Text);
                    command.Parameters.AddWithValue("@BPublisher", txtPublisher.Text);
                    command.Parameters.AddWithValue("@BPubYear", txtYear.Text);
                    command.Parameters.AddWithValue("@BPrice", txtPrice.Text);
                    command.Parameters.AddWithValue("@BPubCNT", txtPubCNT.Text);
                    command.Parameters.AddWithValue("@BCNT", txtCopies.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("کتاب جدید با موفقیت اضافه شد.", "موفقیت");
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
