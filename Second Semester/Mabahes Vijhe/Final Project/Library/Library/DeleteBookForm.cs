using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
            LoadAllBooks();
            txtBno.KeyDown += TxtBno_KeyDown;
            txtBTitle.KeyDown += TxtBTitle_KeyDown;
            dataGridViewBooks.CellClick += DataGridViewBooks_CellClick;
        }

        private void LoadAllBooks()
        {
            string query = "SELECT * FROM Book";
            DataTable booksTable = DatabaseHelper.GetData(query);
            dataGridViewBooks.DataSource = booksTable;
        }

        private void TxtBno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (string.IsNullOrWhiteSpace(txtBno.Text)) { 
                    LoadAllBooks(); 
                };

                string query = "SELECT * FROM Book WHERE BNo = @BNo";
                DataTable result = DatabaseHelper.GetData(query, command =>
                {
                    command.Parameters.AddWithValue("@BNo", txtBno.Text);
                });

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("کتاب موردنظر با این کد یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadAllBooks();
                }
                else
                {
                    dataGridViewBooks.DataSource = result;
                }
            }
        }

        private void TxtBTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (string.IsNullOrWhiteSpace(txtBTitle.Text)) LoadAllBooks();

                string query = "SELECT * FROM Book WHERE BTitle LIKE @BTitle";
                DataTable result = DatabaseHelper.GetData(query, command =>
                {
                    command.Parameters.AddWithValue("@BTitle", "%" + txtBTitle.Text + "%");
                });

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("کتاب موردنظر با این نام یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadAllBooks();
                }
                else
                {
                    dataGridViewBooks.DataSource = result;
                }
            }
        }

        private void DataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string bno = dataGridViewBooks.Rows[e.RowIndex].Cells["BNo"].Value.ToString();
            string title = dataGridViewBooks.Rows[e.RowIndex].Cells["BTitle"].Value.ToString();

            // بررسی اینکه آیا کتاب در جداول Borrow یا Reserve استفاده شده است
            string checkQuery = @"
        IF EXISTS (SELECT 1 FROM Borrow WHERE BNo = @BNo)
            OR EXISTS (SELECT 1 FROM Reserve WHERE BNo = @BNo)
        BEGIN
            SELECT 1
        END
        ELSE
        BEGIN
            SELECT 0
        END";

            bool existsInOtherTables = false;

            // استفاده از ReadData برای بررسی وجود داده
            DatabaseHelper.ReadData(checkQuery, reader =>
            {
                existsInOtherTables = reader.GetInt32(0) == 1;  // بررسی اینکه آیا نتیجه برابر با 1 است
            }, command =>
            {
                command.Parameters.AddWithValue("@BNo", bno);
            });

            if (existsInOtherTables)
            {
                MessageBox.Show("این کتاب قابل حذف نیست زیرا در سیستم امانت یا رزرو شده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"آیا مطمئن هستید که می‌خواهید کتاب '{title}' با کد '{bno}' را حذف کنید؟",
                "حذف کتاب",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Book WHERE BNo = @BNo";
                DatabaseHelper.ExecuteQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@BNo", bno);
                });

                MessageBox.Show("کتاب با موفقیت حذف شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllBooks();
            }
        }

    }
}
