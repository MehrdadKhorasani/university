namespace Library
{
    partial class ManagePasswordForm
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

        private void InitializeComponent()
        {
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.txtCurrentUsername = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentUsername
            // 
            this.lblCurrentUsername.AutoSize = true;
            this.lblCurrentUsername.Location = new System.Drawing.Point(224, 18);
            this.lblCurrentUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrentUsername.Size = new System.Drawing.Size(89, 13);
            this.lblCurrentUsername.TabIndex = 0;
            this.lblCurrentUsername.Text = "نام کاربری فعلی:";
            this.lblCurrentUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurrentUsername
            // 
            this.txtCurrentUsername.Location = new System.Drawing.Point(55, 11);
            this.txtCurrentUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurrentUsername.Name = "txtCurrentUsername";
            this.txtCurrentUsername.Size = new System.Drawing.Size(151, 20);
            this.txtCurrentUsername.TabIndex = 1;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(224, 50);
            this.lblCurrentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrentPassword.Size = new System.Drawing.Size(78, 13);
            this.lblCurrentPassword.TabIndex = 2;
            this.lblCurrentPassword.Text = "رمز عبور فعلی:";
            this.lblCurrentPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(55, 43);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(151, 20);
            this.txtCurrentPassword.TabIndex = 3;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Location = new System.Drawing.Point(224, 83);
            this.lblNewUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNewUsername.Size = new System.Drawing.Size(85, 13);
            this.lblNewUsername.TabIndex = 4;
            this.lblNewUsername.Text = "نام کاربری جدید:";
            this.lblNewUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(55, 76);
            this.txtNewUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(151, 20);
            this.txtNewUsername.TabIndex = 5;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(224, 115);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNewPassword.Size = new System.Drawing.Size(74, 13);
            this.lblNewPassword.TabIndex = 6;
            this.lblNewPassword.Text = "رمز عبور جدید:";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(55, 112);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(151, 20);
            this.txtNewPassword.TabIndex = 7;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 146);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 24);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "تغییر";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(55, 146);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 24);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // ManagePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 195);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.txtCurrentUsername);
            this.Controls.Add(this.lblCurrentUsername);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت رمز عبور و نام کاربری";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.TextBox txtCurrentUsername;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}
