using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Library
{
    public partial class ReservesReportForm : Form
    {
        public ReservesReportForm()
        {
            InitializeComponent();
        }

        private void ReservesReportForm_Load(object sender, EventArgs e)
        {
            // بارگذاری داده‌ها هنگام باز شدن فرم
            LoadReservesData();
        }

        private void LoadReservesData(string filter = "", string bNo = "", string mNo = "", DateTime? startDate = null, DateTime? endDate = null)
        {
            string query = "SELECT * FROM Reserve WHERE 1 = 1";

            try
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    if(filter == "همه")
                        query += "";
                    else if (filter == "فعال")
                        query += " AND isBorrowed = 'No'";
                    else if (filter == "انجام شده")
                        query += " AND isBorrowed = 'Yes'";
                    else if (filter == "گذشته")
                        query += " AND nearestDate < GETDATE() AND isBorrowed = 'No'";
                }

                if (!string.IsNullOrEmpty(bNo))
                    query += " AND BNo = @BNo";

                if (!string.IsNullOrEmpty(mNo))
                    query += " AND MNo = @MNo";

                if (startDate.HasValue)
                    query += " AND nearestDate >= @StartDate";

                if (endDate.HasValue)
                    query += " AND nearestDate <= @EndDate";

                // اضافه کردن پارامترهای کوئری
                var parameters = new Action<SqlCommand>(command =>
                {
                    if (!string.IsNullOrEmpty(bNo)) command.Parameters.AddWithValue("@BNo", bNo);
                    if (!string.IsNullOrEmpty(mNo)) command.Parameters.AddWithValue("@MNo", mNo);
                    if (startDate.HasValue) command.Parameters.AddWithValue("@StartDate", startDate.Value);
                    if (endDate.HasValue) command.Parameters.AddWithValue("@EndDate", endDate.Value);
                });

                // اجرای کوئری و دریافت داده‌ها
                DataTable data = DatabaseHelper.GetData(query, parameters);
                dataGridViewReserves.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بارگذاری داده‌ها: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // اعمال فیلتر انتخاب شده
            string filter = comboBoxFilter.SelectedItem?.ToString();
            if (filter != null)
            {
                LoadReservesData(filter);
            }
        }

        private void textBoxBNo_TextChanged(object sender, EventArgs e)
        {
            // جستجو بر اساس BNo
            LoadReservesData("", textBoxBNo.Text);
        }

        private void textBoxMNo_TextChanged(object sender, EventArgs e)
        {
            // جستجو بر اساس MNo
            LoadReservesData("", "", textBoxMNo.Text);
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            // فیلتر بر اساس تاریخ شروع
            LoadReservesData("", "", "", dateTimePickerStart.Value, dateTimePickerEnd.Value);
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            // فیلتر بر اساس تاریخ پایان
            LoadReservesData("", "", "", dateTimePickerStart.Value, dateTimePickerEnd.Value);
        }

        // برای جلوگیری از وارد کردن کاراکترهای غیر عددی در تکست‌باکس‌ها
        private void textBoxBNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // فقط اجازه وارد کردن اعداد
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxMNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // فقط اجازه وارد کردن اعداد
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
