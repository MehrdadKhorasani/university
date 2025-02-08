using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class DeleteMemberForm : Form
    {
        public DeleteMemberForm()
        {
            InitializeComponent();
            LoadAllMembers();
            txtMNo.KeyDown += TxtMNo_KeyDown;
            txtMCode.KeyDown += txtMCode_KeyDown;
            dataGridViewMembers.CellClick += DataGridViewMembers_CellClick;
        }

        private void LoadAllMembers()
        {
            string query = "SELECT * FROM Member";
            DataTable membersTable = DatabaseHelper.GetData(query);
            dataGridViewMembers.DataSource = membersTable;
            dataGridViewMembers.Columns["MNo"].DisplayIndex = 0;
        }

        private void TxtMNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (string.IsNullOrWhiteSpace(txtMNo.Text)) LoadAllMembers();

                string query = "SELECT * FROM Member WHERE MNo = @MNo";
                DataTable result = DatabaseHelper.GetData(query, command =>
                {
                    command.Parameters.AddWithValue("@MNo", txtMNo.Text.Trim());
                });

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("عضو موردنظر با این کد یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadAllMembers();
                }
                else
                {
                    dataGridViewMembers.DataSource = result;
                }
            }
        }

        private void txtMCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (string.IsNullOrWhiteSpace(txtMCode.Text)) LoadAllMembers();

                string query = "SELECT * FROM Member WHERE MNCode LIKE @MNCode";
                DataTable result = DatabaseHelper.GetData(query, command =>
                {
                    command.Parameters.AddWithValue("@MNCode", "%" + txtMCode.Text.Trim() + "%");
                });

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("عضو موردنظر با این نام یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadAllMembers();
                }
                else
                {
                    dataGridViewMembers.DataSource = result;
                }
            }
        }

        private void DataGridViewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string mNo = dataGridViewMembers.Rows[e.RowIndex].Cells["MNo"].Value.ToString();
            string name = dataGridViewMembers.Rows[e.RowIndex].Cells["MName"].Value.ToString();
            string lastName = dataGridViewMembers.Rows[e.RowIndex].Cells["MLastName"].Value.ToString();

            // بررسی اینکه آیا این عضو در جداول Borrow، Reserve استفاده شده است یا بدهی دارد
            string checkQuery = @"
                IF EXISTS (SELECT 1 FROM Borrow WHERE MNo = @MNo)
                    OR EXISTS (SELECT 1 FROM Reserve WHERE MNo = @MNo)
                    OR EXISTS (SELECT 1 FROM Member WHERE MNo = @MNo AND MDebt > 0)
                BEGIN
                    SELECT 1
                END
                ELSE
                BEGIN
                    SELECT 0
                END";

            bool existsInOtherTables = false;

            DatabaseHelper.ReadData(checkQuery, reader =>
            {
                existsInOtherTables = reader.GetInt32(0) == 1; // بررسی اینکه آیا نتیجه برابر با 1 است
            }, command =>
            {
                command.Parameters.AddWithValue("@MNo", mNo);
            });

            if (existsInOtherTables)
            {
                MessageBox.Show("این کاربر قابل حذف نیست زیرا در سیستم امانت، رزرو یا بدهی دارد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"آیا مطمئن هستید که می‌خواهید عضو '{name} {lastName}' با کد '{mNo}' را حذف کنید؟",
                "حذف عضو",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Member WHERE MNo = @MNo";
                DatabaseHelper.ExecuteQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@MNo", mNo);
                });

                MessageBox.Show("عضو با موفقیت حذف شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllMembers();
            }
        }
    }
}
