using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnNewBook.Click += BtnNewBook_Click;
        }

        private void SaveBookToDatabase()
        {
            //string query = @"INSERT INTO Book (BNo, BStandardCode, BTitle, BOName, BOLName, BOName2, BOLName2, BPublisher, BTName1, BTLName1, BTName2, BTLName2, BPyear, BPRice, BCNT, BISBN, BCCNT)VALUES (@BNo, @BStandardCode, @BTitle, @BOName, @BOLName, @BOName2, @BOLName2, @BPublisher, @BTName1, @BTLName1, @BTName2, @BTLName2, @BPyear, @BPRice, @BCNT, @BISBN, @BCCNT)";
            string query = @"INSERT INTO Book(BStandardCode, BTitle, BOName, BOLName, BOName2, BOLName2, BPublisher, BTName1, BTLName1, BTName2, BTLName2, BPyear, BPRice, BCNT, BISBN, BCCNT) VALUES (@BStandardCode, @BTitle, @BOName, @BOLName, @BOName2, @BOLName2, @BPublisher, @BTName1, @BTLName1, @BTName2, @BTLName2, @BPyear, @BPRice, @BCNT, @BISBN, @BCCNT)";

            DatabaseHelper.ExecuteQuery(query, command =>
            {
                command.Parameters.AddWithValue("@BNo", textBoxes[0].Text);
                command.Parameters.AddWithValue("@BStandardCode", textBoxes[1].Text);
                command.Parameters.AddWithValue("@BTitle", textBoxes[2].Text);
                command.Parameters.AddWithValue("@BOName", textBoxes[3].Text);
                command.Parameters.AddWithValue("@BOLName", textBoxes[4].Text);
                command.Parameters.AddWithValue("@BOName2", textBoxes[5].Text);
                command.Parameters.AddWithValue("@BOLName2", textBoxes[6].Text);
                command.Parameters.AddWithValue("@BPublisher", textBoxes[7].Text);
                command.Parameters.AddWithValue("@BTName1", textBoxes[8].Text);
                command.Parameters.AddWithValue("@BTLName1", textBoxes[9].Text);
                command.Parameters.AddWithValue("@BTName2", textBoxes[10].Text);
                command.Parameters.AddWithValue("@BTLName2", textBoxes[11].Text);
                command.Parameters.AddWithValue("@BPyear", textBoxes[12].Text);
                command.Parameters.AddWithValue("@BPRice", Convert.ToDecimal(textBoxes[13].Text));
                command.Parameters.AddWithValue("@BCNT", Convert.ToInt32(textBoxes[14].Text));
                command.Parameters.AddWithValue("@BISBN", textBoxes[15].Text);
                command.Parameters.AddWithValue("@BCCNT", Convert.ToInt32(textBoxes[16].Text));
            });

            MessageBox.Show("اطلاعات کتاب با موفقیت ذخیره شد.");
        }

        private bool ValidateInputs()
        {
            for (int i = 1; i < textBoxes.Length; i++) 
            {
                if (string.IsNullOrWhiteSpace(textBoxes[i].Text))
                {
                    MessageBox.Show($"لطفاً فیلد '{labels[i].Text}' را پر کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }



        private void BtnNewBook_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = string.Empty;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;
                SaveBookToDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ذخیره اطلاعات: {ex.Message}");
            }
        }


    }
}
