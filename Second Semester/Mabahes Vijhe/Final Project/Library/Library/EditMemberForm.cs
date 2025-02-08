using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class EditMemberForm : Form
    {
        public EditMemberForm()
        {
            InitializeComponent();
            btnSaveMember.Click += btnSaveMember_Click;
            btnNewMember.Click += btnNewMember_Click;
            txtMemberID.KeyDown += txtMemberID_KeyDown;

            ResetForm();
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            // تنظیم وضعیت کاربر در کمبو باکس
            cmbMemberState.Items.Add(new KeyValuePair<string, int>("فعال", 1));
            cmbMemberState.Items.Add(new KeyValuePair<string, int>("منقضی", 2));
            cmbMemberState.Items.Add(new KeyValuePair<string, int>("بدهکار", 3));
            cmbMemberState.DisplayMember = "Key";
            cmbMemberState.ValueMember = "Value";
            cmbMemberState.SelectedIndex = 0;
        }

        private void ResetForm()
        {
            // پاک کردن فیلدها و تنظیم حالت اولیه
            txtMemberID.Text = txtMemberCode.Text = txtMemberFirstName.Text =
            txtMemberLastName.Text = txtMemberStartDate.Text = txtMemberExpireDate.Text =
            txtMemberMaxBook.Text = txtMemberBirthDate.Text = txtMemberAddress.Text =
            txtMemberTellNumber.Text = txtMemberPostCode.Text = txtMemberFatherName.Text =
            txtMemberDebt.Text = string.Empty;

            txtMemberID.Focus();
            txtMemberID.Enabled = true;
            txtMemberCode.Enabled = txtMemberFirstName.Enabled =
            txtMemberLastName.Enabled = txtMemberStartDate.Enabled = txtMemberExpireDate.Enabled =
            txtMemberMaxBook.Enabled = txtMemberBirthDate.Enabled = txtMemberAddress.Enabled =
            txtMemberTellNumber.Enabled = txtMemberPostCode.Enabled = txtMemberFatherName.Enabled =
            txtMemberDebt.Enabled = cmbMemberState.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            try
            {
                // بررسی صحت ورودی‌ها
                if (string.IsNullOrWhiteSpace(txtMemberID.Text) ||
                    string.IsNullOrWhiteSpace(txtMemberFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtMemberLastName.Text))
                {
                    MessageBox.Show("لطفاً تمام فیلدهای ضروری را پر کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"
                    UPDATE Member
                    SET
                        MNCode = @MNCode,
                        MName = @MName,
                        MLastName = @MLastName,
                        MStartDate = @MStartDate,
                        MExpireDate = @MExpireDate,
                        MBMax = @MBMax,
                        MBirthDate = @MBirthDate,
                        MAddress = @MAddress,
                        MTelNo = @MTelNo,
                        MPostCode = @MPostCode,
                        MFatherName = @MFatherName,
                        MDebt = @MDebt,
                        MState = @MState
                    WHERE MNo = @MNo";

                DatabaseHelper.ExecuteQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@MNo", txtMemberID.Text.Trim());
                    command.Parameters.AddWithValue("@MNCode", txtMemberCode.Text.Trim());
                    command.Parameters.AddWithValue("@MName", txtMemberFirstName.Text.Trim());
                    command.Parameters.AddWithValue("@MLastName", txtMemberLastName.Text.Trim());
                    command.Parameters.AddWithValue("@MStartDate", txtMemberStartDate.Text.Trim());
                    command.Parameters.AddWithValue("@MExpireDate", txtMemberExpireDate.Text.Trim());
                    command.Parameters.AddWithValue("@MBMax", txtMemberMaxBook.Text.Trim());
                    command.Parameters.AddWithValue("@MBirthDate", txtMemberBirthDate.Text.Trim());
                    command.Parameters.AddWithValue("@MAddress", txtMemberAddress.Text.Trim());
                    command.Parameters.AddWithValue("@MTelNo", txtMemberTellNumber.Text.Trim());
                    command.Parameters.AddWithValue("@MPostCode", txtMemberPostCode.Text.Trim());
                    command.Parameters.AddWithValue("@MFatherName", txtMemberFatherName.Text.Trim());
                    command.Parameters.AddWithValue("@MDebt", txtMemberDebt.Text.Trim());
                    command.Parameters.AddWithValue("@MState", ((KeyValuePair<string, int>)cmbMemberState.SelectedItem).Value);
                });

                MessageBox.Show("اطلاعات کاربر با موفقیت به‌روزرسانی شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در به‌روزرسانی اطلاعات: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMemberID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (string.IsNullOrWhiteSpace(txtMemberID.Text)) return;

                string query = "SELECT * FROM Member WHERE MNo = @MNo";
                DataTable memberData = DatabaseHelper.GetData(query, command =>
                {
                    command.Parameters.AddWithValue("@MNo", txtMemberID.Text.Trim());
                });

                if (memberData.Rows.Count == 0)
                {
                    MessageBox.Show("کاربری با این شماره یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetForm();
                }
                else
                {
                    DataRow row = memberData.Rows[0];

                    txtMemberID.Enabled = false;
                    txtMemberCode.Text = row["MNCode"].ToString();
                    txtMemberFirstName.Text = row["MName"].ToString();
                    txtMemberLastName.Text = row["MLastName"].ToString();
                    txtMemberStartDate.Text = row["MStartDate"].ToString();
                    txtMemberExpireDate.Text = row["MExpireDate"].ToString();
                    txtMemberMaxBook.Text = row["MBMax"].ToString();
                    txtMemberBirthDate.Text = row["MBirthDate"].ToString();
                    txtMemberAddress.Text = row["MAddress"].ToString();
                    txtMemberTellNumber.Text = row["MTelNo"].ToString();
                    txtMemberPostCode.Text = row["MPostCode"].ToString();
                    txtMemberFatherName.Text = row["MFatherName"].ToString();
                    txtMemberDebt.Text = row["MDebt"].ToString();
                    cmbMemberState.SelectedValue = row["MState"];

                    // فعال کردن فیلدها برای ویرایش
                    txtMemberCode.Enabled = txtMemberFirstName.Enabled =
                    txtMemberLastName.Enabled = txtMemberStartDate.Enabled = txtMemberExpireDate.Enabled =
                    txtMemberMaxBook.Enabled = txtMemberBirthDate.Enabled = txtMemberAddress.Enabled =
                    txtMemberTellNumber.Enabled = txtMemberPostCode.Enabled = txtMemberFatherName.Enabled =
                    txtMemberDebt.Enabled = cmbMemberState.Enabled = true;
                }
            }
        }
    }
}
