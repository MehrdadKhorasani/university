namespace Library
{
    partial class UserForm
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
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.lblDebt = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            this.SuspendLayout();

            // تنظیمات DataGridView
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(30, 30);
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(700, 300);
            this.dgvBorrowedBooks.ReadOnly = true;
            this.dgvBorrowedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // برچسب بدهی
            this.lblDebt.Text = "بدهی:";
            this.lblDebt.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDebt.Location = new System.Drawing.Point(30, 350);
            this.lblDebt.Size = new System.Drawing.Size(300, 30);

            // دکمه تغییر رمز
            this.btnChangePassword.Text = "تغییر رمز عبور";
            this.btnChangePassword.Location = new System.Drawing.Point(30, 400);
            this.btnChangePassword.Size = new System.Drawing.Size(150, 40);
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);

            // دکمه خروج
            this.btnLogout.Text = "خروج";
            this.btnLogout.Location = new System.Drawing.Point(200, 400);
            this.btnLogout.Size = new System.Drawing.Size(150, 40);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // افزودن کنترل‌ها به فرم
            this.Controls.Add(this.dgvBorrowedBooks);
            this.Controls.Add(this.lblDebt);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnLogout);

            // تنظیمات فرم
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Text = "فرم کاربر";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogout;
    }
}
