namespace AtmApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnOK;

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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnOK = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(30, 28);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 69);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(150, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(77, 115);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(150, 23);
            btnOK.TabIndex = 4;
            btnOK.Text = "تأیید";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(215, 36);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(55, 15);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "نام کاربری";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(222, 77);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(48, 15);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "رمز ورود";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 150);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnOK);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "ورود";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblUsername;
        private Label lblPassword;
    }
}
