using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class EditBookForm : Form
    {
        private string connectionString = DatabaseConfig.ConnectionString;
        private int BNumber;

        public EditBookForm(int BNumber)
        {
            InitializeComponent();
            this.BNumber = BNumber;
            LoadBookDetails();
        }

        private void LoadBookDetails()
        {
            string query = "SELECT * FROM Book WHERE BNumber = @BNumber";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BNumber", BNumber);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtBookId.Text = reader["BNumber"].ToString();
                        txtStandardCode.Text = reader["BStandardCode"].ToString();
                        txtTitle.Text = reader["BTitle"].ToString();
                        txtAuthorFName1.Text = reader["BAuthorFName1"].ToString();
                        txtAuthorLName1.Text = reader["BAuthorLName1"].ToString();
                        txtAuthorFName2.Text = reader["BAuthorFName2"].ToString();
                        txtAuthorLName2.Text = reader["BAuthorLName2"].ToString();
                        txtTranslatorFName1.Text = reader["BTranslatorFName1"].ToString();
                        txtTranslatorLName1.Text = reader["BTranslatorLName1"].ToString();
                        txtTranslatorFName2.Text = reader["BTranslatorFName2"].ToString();
                        txtTranslatorLName2.Text = reader["BTranslatorLName2"].ToString();
                        txtPublisher.Text = reader["BPublisher"].ToString();
                        txtYear.Text = reader["BPubYear"].ToString();
                        txtPrice.Text = reader["BPrice"].ToString();
                        txtPubCNT.Text = reader["BPubCNT"].ToString();
                        txtCopies.Text = reader["BCNT"].ToString();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Book SET BStandardCode = @BStandardCode, BTitle = @BTitle, BAuthorFName1 = @BAuthorFName1, " +
                           "BAuthorLName1 = @BAuthorLName1, BAuthorFName2 = @BAuthorFName2, BAuthorLName2 = @BAuthorLName2, " +
                           "BTranslatorFName1 = @BTranslatorFName1, BTranslatorLName1 = @BTranslatorLName1, " +
                           "BTranslatorFName2 = @BTranslatorFName2, BTranslatorLName2 = @BTranslatorLName2, " +
                           "BPublisher = @BPublisher, BPubYear = @BPubYear, BPrice = @BPrice, BPubCNT = @BPubCNT, BCNT = @BCNT " +
                           "WHERE BNumber = @BNumber";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BNumber", BNumber);
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

            MessageBox.Show("اطلاعات کتاب با موفقیت به‌روزرسانی شد.", "موفقیت");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
