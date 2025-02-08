using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
            txtMemberID.Enabled = false;
            txtMemberCode.Focus();
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            cmbMemberState.Items.Add(new KeyValuePair<string, int>("فعال", 1));
            cmbMemberState.Items.Add(new KeyValuePair<string, int>("منقضی", 2));
            cmbMemberState.Items.Add(new KeyValuePair<string, int>("بدهکار", 3));
            cmbMemberState.DisplayMember = "Key";
            cmbMemberState.ValueMember = "Value";
            cmbMemberState.SelectedIndex = 0;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtMemberID.Text = txtMemberCode.Text = txtMemberFirstName.Text = 
            txtMemberLastName.Text = txtMemberStartDate.Text = txtMemberExpireDate.Text = 
            txtMemberMaxBook.Text = txtMemberBirthDate.Text = txtMemberAddress.Text = txtMemberTellNumber.Text =
            txtMemberPostCode.Text = txtMemberFatherName.Text = txtMemberDebt.Text = string.Empty;
            txtMemberCode.Focus();
            cmbMemberState.SelectedIndex = 0;
        }

        private void BtnNewMember_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private bool ValidateMemberData(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(txtMemberFirstName.Text))
            {
                errorMessage = "نام نباید خالی باشد.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMemberLastName.Text))
            {
                errorMessage = "نام خانوادگی نباید خالی باشد.";
                return false;
            }

            if (!DateTime.TryParse(txtMemberStartDate.Text, out _))
            {
                errorMessage = "تاریخ شروع عضویت معتبر نیست.";
                return false;
            }

            if (!DateTime.TryParse(txtMemberExpireDate.Text, out _))
            {
                errorMessage = "تاریخ پایان عضویت معتبر نیست.";
                return false;
            }

            if (!long.TryParse(txtMemberTellNumber.Text, out _))
            {
                errorMessage = "شماره تلفن فقط باید شامل عدد باشد.";
                return false;
            }

            if (!int.TryParse(txtMemberPostCode.Text, out _))
            {
                errorMessage = "کد پستی فقط باید شامل عدد باشد.";
                return false;
            }

            return true;
        }

        private void BtnSaveMember_Click(object sender, EventArgs e)
        {
            if (!ValidateMemberData(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // ذخیره اطلاعات در دیتابیس
                string query = @"INSERT INTO Member (MNCode, MName, MLastName, MStartDate, MExpireDate, MBMax, MBirthDate, MAddress, MTelNo, MPostCode, MFatherName, MDebt, MState) 
                                             VALUES (@MNCode, @MName, @MLastName, @MStartDate, @MExpireDate, @MBMax, @MBirthDate, @MAddress, @MTelNo, @MPostCode, @MFatherName, @MDebt, @MState)";

                int selectedState = ((KeyValuePair<string, int>)cmbMemberState.SelectedItem).Value;

                DatabaseHelper.ExecuteQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@MNCode", txtMemberCode.Text);
                    command.Parameters.AddWithValue("@MName", txtMemberFirstName.Text);
                    command.Parameters.AddWithValue("@MLastName", txtMemberLastName.Text);
                    command.Parameters.AddWithValue("@MStartDate", DateTime.Parse(txtMemberStartDate.Text));
                    command.Parameters.AddWithValue("@MExpireDate", DateTime.Parse(txtMemberExpireDate.Text));
                    command.Parameters.AddWithValue("@MBMax", int.Parse(txtMemberMaxBook.Text));
                    command.Parameters.AddWithValue("@MBirthDate", DateTime.Parse(txtMemberBirthDate.Text));
                    command.Parameters.AddWithValue("@MAddress", txtMemberAddress.Text);
                    command.Parameters.AddWithValue("@MTelNo", txtMemberTellNumber.Text);
                    command.Parameters.AddWithValue("@MPostCode", txtMemberPostCode.Text);
                    command.Parameters.AddWithValue("@MFatherName", txtMemberFatherName.Text);
                    command.Parameters.AddWithValue("@MDebt", decimal.Parse(txtMemberDebt.Text));
                    command.Parameters.AddWithValue("@MState", selectedState);
                });

                MessageBox.Show("اطلاعات با موفقیت ذخیره شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ذخیره اطلاعات: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
