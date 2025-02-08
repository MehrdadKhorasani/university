using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Library
{
    public partial class BorrowsReportForm : Form
    {
        public BorrowsReportForm()
        {
            InitializeComponent();
        }

        private void BorrowsReportForm_Load(object sender, EventArgs e)
        {
            LoadBorrowsData();
        }

        private void LoadBorrowsData(string filter = "", string bNo = "", string mNo = "", DateTime? startDate = null, DateTime? endDate = null)
        {
            string query = "SELECT * FROM Borrow WHERE 1 = 1";

            if (!string.IsNullOrEmpty(filter))
            {
                if (filter == "بازگشتی")
                    query += " AND BRRET = 'Yes'";
                else if (filter == "فعال")
                    query += " AND BRRET = 'No'";
                else if (filter == "دیرکرد")
                    query += " AND BEDate < GETDATE() AND BRRET = 'No'";
            }

            if (!string.IsNullOrEmpty(bNo))
                query += " AND BNo = @BNo";

            if (!string.IsNullOrEmpty(mNo))
                query += " AND MNo = @MNo";

            if (startDate.HasValue)
                query += " AND BSdate >= @StartDate";

            if (endDate.HasValue)
                query += " AND BSdate <= @EndDate";

            var parameters = new Action<SqlCommand>(command =>
            {
                if (!string.IsNullOrEmpty(bNo)) command.Parameters.AddWithValue("@BNo", bNo);
                if (!string.IsNullOrEmpty(mNo)) command.Parameters.AddWithValue("@MNo", mNo);
                if (startDate.HasValue) command.Parameters.AddWithValue("@StartDate", startDate.Value);
                if (endDate.HasValue) command.Parameters.AddWithValue("@EndDate", endDate.Value);
            });

            DataTable data = DatabaseHelper.GetData(query, parameters);
            dataGridViewBorrows.DataSource = data;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = comboBoxFilter.SelectedItem.ToString();
            LoadBorrowsData(filter);
        }

        private void textBoxBNo_TextChanged(object sender, EventArgs e)
        {
            LoadBorrowsData("", textBoxBNo.Text);
        }

        private void textBoxMNo_TextChanged(object sender, EventArgs e)
        {
            LoadBorrowsData("", "", textBoxMNo.Text);
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            LoadBorrowsData("", "", "", dateTimePickerStart.Value, dateTimePickerEnd.Value);
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            LoadBorrowsData("", "", "", dateTimePickerStart.Value, dateTimePickerEnd.Value);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
