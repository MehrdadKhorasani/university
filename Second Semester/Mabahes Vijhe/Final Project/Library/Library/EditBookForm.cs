using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class EditBookForm : Form
    {
        public EditBookForm()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnNewBook.Click += BtnNewBook_Click;
            textBoxes[0].KeyDown += BnoTextBox_KeyDown;
        }

        private void BnoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (string.IsNullOrWhiteSpace(textBoxes[0].Text)) return;

                string query = "SELECT * FROM Book WHERE BNo = @BNo";
                bool bookFound = false;

                string[] columnNames = new string[]
                {
                    "BStandardCode", "BTitle", "BOName", "BOLName",
                    "BOName2", "BOLName2", "BPublisher",
                    "BTName1", "BTLName1", "BTName2", "BTLName2",
                    "BPyear", "BPRice", "BCNT", "BISBN", "BCCNT"
                };

                DatabaseHelper.ReadData(query, reader =>
                {
                    for (int i = 1; i < textBoxes.Length; i++)
                    {
                        textBoxes[i].Text = reader[columnNames[i - 1]].ToString(); // استفاده از نام ستون‌ها
                    }
                    bookFound = true;
                },
                command =>
                {
                    command.Parameters.AddWithValue("@BNo", textBoxes[0].Text);
                });

                if (!bookFound)
                {
                    MessageBox.Show("کتاب موردنظر پیدا نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetForm();
                }
                else
                {
                    EnableTextBoxes(true);
                    textBoxes[0].ReadOnly = true;
                }
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;

                string query = @"
            UPDATE Book
            SET 
                BStandardCode = @BStandardCode, 
                BTitle = @BTitle, 
                BOName = @BOName, 
                BOLName = @BOLName, 
                BOName2 = @BOName2, 
                BOLName2 = @BOLName2, 
                BPublisher = @BPublisher, 
                BTName1 = @BTName1, 
                BTLName1 = @BTLName1, 
                BTName2 = @BTName2, 
                BTLName2 = @BTLName2, 
                BPyear = @BPyear, 
                BPRice = @BPRice, 
                BCNT = @BCNT, 
                BISBN = @BISBN, 
                BCCNT = @BCCNT
            WHERE BNo = @BNo";

                DatabaseHelper.ExecuteQuery(query, command =>
                {
                    // اضافه کردن پارامترها با دقت بالا
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
                    command.Parameters.AddWithValue("@BPRice", textBoxes[13].Text);
                    command.Parameters.AddWithValue("@BCNT", textBoxes[14].Text);
                    command.Parameters.AddWithValue("@BISBN", textBoxes[15].Text);
                    command.Parameters.AddWithValue("@BCCNT", textBoxes[16].Text);
                });

                MessageBox.Show("اطلاعات کتاب با موفقیت به‌روزرسانی شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در به‌روزرسانی اطلاعات: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnNewBook_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            foreach (global::System.Windows.Forms.TextBox textBox in textBoxes)
            {
                textBox.Text = string.Empty;
                textBox.ReadOnly = true;
            }
            textBoxes[0].ReadOnly = false;
        }

        private void EnableTextBoxes(bool enable)
        {
            for (int i = 1; i < textBoxes.Length; i++)
            {
                textBoxes[i].ReadOnly = !enable;
            }
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
    }
}
