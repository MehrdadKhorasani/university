using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class MemberReportForm : Form
    {
        public MemberReportForm()
        {
            InitializeComponent();
        }

        private void MemberReportForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            cbFilter.SelectedIndex = 0; // Default to "همه کاربران"
            cbSort.SelectedIndex = 0;   // Default to "تاریخ تولد"
            cbFilter.SelectedIndexChanged += (s, ev) => ApplyFilters();
            cbSort.SelectedIndexChanged += (s, ev) => ApplySorting();
        }

        private void LoadMembers()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT MNo, MNCode, MName, MLastName, MStartDate, MExpireDate, MBirthDate, MDebt, MState FROM Member";

            DatabaseHelper.ReadData(query, reader =>
            {
                if (dataTable.Columns.Count == 0)
                {
                    dataTable.Columns.Add("MNo", typeof(string));
                    dataTable.Columns.Add("MNCode", typeof(string));
                    dataTable.Columns.Add("MName", typeof(string));
                    dataTable.Columns.Add("MLastName", typeof(string));
                    dataTable.Columns.Add("MStartDate", typeof(DateTime));
                    dataTable.Columns.Add("MExpireDate", typeof(DateTime));
                    dataTable.Columns.Add("MBirthDate", typeof(DateTime));
                    dataTable.Columns.Add("MDebt", typeof(decimal));
                    dataTable.Columns.Add("MState", typeof(int));
                    // اضافه کردن ستون محاسبه‌شده برای ماه و روز تولد
                    dataTable.Columns.Add("BirthMonthDay", typeof(string));
                }

                DataRow row = dataTable.NewRow();
                row["MNo"] = reader["MNo"];
                row["MNCode"] = reader["MNCode"];
                row["MName"] = reader["MName"];
                row["MLastName"] = reader["MLastName"];
                row["MStartDate"] = reader["MStartDate"] != DBNull.Value ? (DateTime?)reader["MStartDate"] : null;
                row["MExpireDate"] = reader["MExpireDate"] != DBNull.Value ? (DateTime?)reader["MExpireDate"] : null;
                row["MBirthDate"] = reader["MBirthDate"] != DBNull.Value ? (DateTime?)reader["MBirthDate"] : null;
                row["MDebt"] = reader["MDebt"] != DBNull.Value ? (decimal?)reader["MDebt"] : null;
                row["MState"] = Convert.ToInt32(reader["MState"]);

                // محاسبه ماه و روز تولد برای مرتب‌سازی
                if (row["MBirthDate"] != DBNull.Value)
                {
                    DateTime birthDate = (DateTime)row["MBirthDate"];
                    row["BirthMonthDay"] = birthDate.ToString("MMdd"); // فرمت "ماه و روز" مثلاً "0523" برای 23 می
                }
                else
                {
                    row["BirthMonthDay"] = DBNull.Value; // اگر تاریخ تولد موجود نباشد
                }

                dataTable.Rows.Add(row);
            });

            dgvMembers.DataSource = dataTable;
        }



        private void ApplyFilters()
        {
            DataTable table = dgvMembers.DataSource as DataTable;
            if (table == null) return;

            string filter = "";
            switch (cbFilter.SelectedIndex)
            {
                case 1: // کاربران فعال
                    filter = "MState = 1";
                    break;
                case 2: // کاربران منقضی
                    filter = "MState = 2";
                    break;
                case 3: // کاربران بدهکار
                    filter = "MState = 3 AND MDebt > 0";
                    break;
                default:
                    filter = ""; // همه کاربران
                    break;
            }

            table.DefaultView.RowFilter = filter;
        }

        private void ApplySorting()
        {
            DataTable table = dgvMembers.DataSource as DataTable;
            if (table == null) return;

            string sort = "";
            switch (cbSort.SelectedIndex)
            {
                case 0: // تاریخ تولد
                    sort = "BirthMonthDay ASC"; // استفاده از ستون محاسبه‌شده
                    break;
                case 1: // میزان بدهی
                    sort = "MDebt DESC";
                    break;
                case 2: // تاریخ انقضا
                    sort = "MExpireDate ASC";
                    break;
                case 3: // تاریخ ثبت‌نام
                    sort = "MStartDate DESC";
                    break;
                default:
                    sort = "";
                    break;
            }

            table.DefaultView.Sort = sort;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable table = dgvMembers.DataSource as DataTable;
            if (table == null) return;

            string search = txtSearch.Text.Trim();

            // بررسی مقدار وارد شده
            if (string.IsNullOrEmpty(search))
            {
                table.DefaultView.RowFilter = ""; // نمایش تمام کاربران
            }
            else if (int.TryParse(search, out int mno))
            {
                // اگر مقدار وارد شده عددی است
                table.DefaultView.RowFilter = $"[MNo] = {mno}";
            }
            else
            {
                // مقدار غیر عددی وارد شده است (هیچ فیلتر اعمال نمی‌شود)
                MessageBox.Show("لطفاً فقط از کد عددی کاربر استفاده کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Clear();
            }
        }

    }
}
