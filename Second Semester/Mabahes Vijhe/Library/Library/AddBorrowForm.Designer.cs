namespace Library
{
    partial class AddBorrowForm
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
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();

            this.lblBookId = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();

            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // تنظیم فرم
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Text = "افزودن امانت";

            int labelX = 50, textBoxX = 200, y = 20, step = 50;

            // شماره کتاب
            this.lblBookId.Text = "شماره کتاب:";
            this.lblBookId.Location = new System.Drawing.Point(labelX, y);
            this.txtBookId.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // شماره کاربر
            this.lblMemberId.Text = "شماره کاربر:";
            this.lblMemberId.Location = new System.Drawing.Point(labelX, y);
            this.txtMemberId.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // تاریخ امانت
            this.lblBorrowDate.Text = "تاریخ امانت:";
            this.lblBorrowDate.Location = new System.Drawing.Point(labelX, y);
            this.dtpBorrowDate.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // تاریخ بازگشت
            this.lblReturnDate.Text = "تاریخ بازگشت:";
            this.lblReturnDate.Location = new System.Drawing.Point(labelX, y);
            this.dtpReturnDate.Location = new System.Drawing.Point(textBoxX, y);

            y += step;

            // دکمه ذخیره
            this.btnSave.Text = "ذخیره";
            this.btnSave.Location = new System.Drawing.Point(200, y);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // افزودن ابزارها
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.dtpReturnDate);

            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.lblBorrowDate);
            this.Controls.Add(this.lblReturnDate);

            this.Controls.Add(this.btnSave);

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Button btnSave;
    }
}
