namespace Library
{
    partial class AddUserForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtMNCode = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.nudMaxBooks = new System.Windows.Forms.NumericUpDown();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.nudDebt = new System.Windows.Forms.NumericUpDown();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.lblMNCode = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.lblMaxBooks = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();

            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // تنظیم فرم
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Text = "افزودن کاربر";
            this.AutoScroll = true;

            int labelX = 50, textBoxX = 200, y = 20, step = 40;

            // کد عضویت
            this.lblMNCode.Text = "کد عضویت:";
            this.lblMNCode.Location = new System.Drawing.Point(labelX, y);
            this.txtMNCode.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // نام
            this.lblFirstName.Text = "نام:";
            this.lblFirstName.Location = new System.Drawing.Point(labelX, y);
            this.txtFirstName.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // نام خانوادگی
            this.lblLastName.Text = "نام خانوادگی:";
            this.lblLastName.Location = new System.Drawing.Point(labelX, y);
            this.txtLastName.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // تاریخ شروع
            this.lblStartDate.Text = "تاریخ شروع:";
            this.lblStartDate.Location = new System.Drawing.Point(labelX, y);
            this.dtpStartDate.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // تاریخ انقضا
            this.lblExpireDate.Text = "تاریخ انقضا:";
            this.lblExpireDate.Location = new System.Drawing.Point(labelX, y);
            this.dtpExpireDate.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // حداکثر تعداد کتاب‌ها
            this.lblMaxBooks.Text = "حداکثر کتاب‌ها:";
            this.lblMaxBooks.Location = new System.Drawing.Point(labelX, y);
            this.nudMaxBooks.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // جنسیت
            this.lblGender.Text = "جنسیت:";
            this.lblGender.Location = new System.Drawing.Point(labelX, y);
            this.cmbGender.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // تاریخ تولد
            this.lblBirthDate.Text = "تاریخ تولد:";
            this.lblBirthDate.Location = new System.Drawing.Point(labelX, y);
            this.dtpBirthDate.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // آدرس
            this.lblAddress.Text = "آدرس:";
            this.lblAddress.Location = new System.Drawing.Point(labelX, y);
            this.txtAddress.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // شماره تلفن
            this.lblPhoneNumber.Text = "شماره تلفن:";
            this.lblPhoneNumber.Location = new System.Drawing.Point(labelX, y);
            this.txtPhoneNumber.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // کد پستی
            this.lblPostCode.Text = "کد پستی:";
            this.lblPostCode.Location = new System.Drawing.Point(labelX, y);
            this.txtPostCode.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // نام پدر
            this.lblFatherName.Text = "نام پدر:";
            this.lblFatherName.Location = new System.Drawing.Point(labelX, y);
            this.txtFatherName.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // بدهی
            this.lblDebt.Text = "بدهی:";
            this.lblDebt.Location = new System.Drawing.Point(labelX, y);
            this.nudDebt.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // وضعیت
            this.lblStatus.Text = "وضعیت:";
            this.lblStatus.Location = new System.Drawing.Point(labelX, y);
            this.cmbStatus.Location = new System.Drawing.Point(textBoxX, y);

            y += step + 20;

            // دکمه ذخیره
            this.btnSave.Text = "ذخیره";
            this.btnSave.Location = new System.Drawing.Point(250, y);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // افزودن ابزارها به فرم
            this.Controls.Add(this.txtMNCode);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpExpireDate);
            this.Controls.Add(this.nudMaxBooks);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.nudDebt);
            this.Controls.Add(this.cmbStatus);

            this.Controls.Add(this.lblMNCode);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblExpireDate);
            this.Controls.Add(this.lblMaxBooks);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.lblDebt);
            this.Controls.Add(this.lblStatus);

            this.Controls.Add(this.btnSave);

            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtMNCode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpExpireDate;
        private System.Windows.Forms.NumericUpDown nudMaxBooks;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.NumericUpDown nudDebt;
        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Label lblMNCode;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Label lblMaxBooks;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.Button btnSave;

    }
}
