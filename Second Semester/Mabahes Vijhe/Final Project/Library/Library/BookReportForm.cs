using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class BookReportForm : Form
    {
        public BookReportForm()
        {
            InitializeComponent();
        }

        private void BookReportForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            cbFilter.SelectedIndex = 0; // پیش‌فرض: نمایش همه کتاب‌ها
            cbFilter.SelectedIndexChanged += (s, ev) => ApplyFilters();
            txtSearch.TextChanged += (s, ev) => ApplySearch();
        }

        private void LoadBooks()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT BNo, BTitle, BOName, BOLName, BPublisher, BPyear, BCNT, BCCNT FROM Book";

            DatabaseHelper.ReadData(query, reader =>
            {
                if (dataTable.Columns.Count == 0)
                {
                    dataTable.Columns.Add("BNo", typeof(int));
                    dataTable.Columns.Add("BTitle", typeof(string));
                    dataTable.Columns.Add("BOName", typeof(string));
                    dataTable.Columns.Add("BOLName", typeof(string));
                    dataTable.Columns.Add("BPublisher", typeof(string));
                    dataTable.Columns.Add("BPyear", typeof(int));
                    dataTable.Columns.Add("BCNT", typeof(int));
                    dataTable.Columns.Add("BCCNT", typeof(int));
                }

                DataRow row = dataTable.NewRow();
                row["BNo"] = reader["BNo"];
                row["BTitle"] = reader["BTitle"];
                row["BOName"] = reader["BOName"];
                row["BOLName"] = reader["BOLName"];
                row["BPublisher"] = reader["BPublisher"];
                row["BPyear"] = reader["BPyear"];
                row["BCNT"] = reader["BCNT"];
                row["BCCNT"] = reader["BCCNT"];
                dataTable.Rows.Add(row);
            });

            dgvBooks.DataSource = dataTable;
        }

        private void ApplyFilters()
        {
            DataTable table = dgvBooks.DataSource as DataTable;
            if (table == null) return;

            switch (cbFilter.SelectedIndex)
            {
                case 0: // همه کتاب‌ها
                    table.DefaultView.RowFilter = "";
                    break;
                case 1: // کتاب‌های موجود
                    table.DefaultView.RowFilter = "[BCCNT] > 0";
                    break;
                case 2: // کتاب‌های ناموجود
                    table.DefaultView.RowFilter = "[BCCNT] = 0";
                    break;
                case 3: // کتاب‌های رزروشده
                    ApplyReservedFilter(table);
                    break;
                default:
                    table.DefaultView.RowFilter = "";
                    break;
            }
        }

        private void ApplyReservedFilter(DataTable table)
        {
            // گرفتن لیست کد کتاب‌های رزرو شده از دیتابیس
            var reservedBooks = new DataTable();
            string query = "SELECT DISTINCT BNo FROM Reserve";

            DatabaseHelper.ReadData(query, reader =>
            {
                if (reservedBooks.Columns.Count == 0)
                {
                    reservedBooks.Columns.Add("BNo", typeof(int));
                }

                DataRow row = reservedBooks.NewRow();
                row["BNo"] = reader["BNo"];
                reservedBooks.Rows.Add(row);
            });

            // اعمال فیلتر روی کتاب‌های موجود در DataGridView
            var reservedBookNumbers = reservedBooks.AsEnumerable().Select(r => r.Field<int>("BNo")).ToHashSet();
            var filteredRows = table.AsEnumerable().Where(row => reservedBookNumbers.Contains(row.Field<int>("BNo")));

            DataTable filteredTable = filteredRows.CopyToDataTable();
            dgvBooks.DataSource = filteredTable;
        }

        private void ApplySearch()
        {
            DataTable table = dgvBooks.DataSource as DataTable;
            if (table == null) return;

            string search = txtSearch.Text.Trim();

            // بررسی اینکه مقدار وارد شده عددی است یا نه
            if (string.IsNullOrEmpty(search))
            {
                table.DefaultView.RowFilter = ""; // نمایش تمام کتاب‌ها
            }
            else if (int.TryParse(search, out int bno))
            {
                // اگر مقدار عددی باشد
                table.DefaultView.RowFilter = $"[BNo] = {bno}";
            }
            else
            {
                // مقدار غیر عددی وارد شده است (هیچ فیلتر اعمال نمی‌شود)
                MessageBox.Show("لطفاً فقط از کد عددی کتاب استفاده کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Clear();
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
