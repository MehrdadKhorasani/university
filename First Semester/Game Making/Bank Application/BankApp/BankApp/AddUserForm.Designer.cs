namespace BankApp
{
    partial class AddUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlAuthentication;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnAddUser;

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
            pnlAuthentication = new Panel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnAuthenticate = new Button();
            pnlAddUser = new Panel();
            txtName = new TextBox();
            txtBalance = new TextBox();
            btnAddUser = new Button();
            pnlAuthentication.SuspendLayout();
            pnlAddUser.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAuthentication
            // 
            pnlAuthentication.Controls.Add(txtUsername);
            pnlAuthentication.Controls.Add(txtPassword);
            pnlAuthentication.Controls.Add(btnAuthenticate);
            pnlAuthentication.Location = new Point(12, 12);
            pnlAuthentication.Name = "pnlAuthentication";
            pnlAuthentication.Size = new Size(260, 100);
            pnlAuthentication.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(3, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(254, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(3, 32);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(254, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnAuthenticate
            // 
            btnAuthenticate.Location = new Point(3, 61);
            btnAuthenticate.Name = "btnAuthenticate";
            btnAuthenticate.Size = new Size(254, 23);
            btnAuthenticate.TabIndex = 2;
            btnAuthenticate.Text = "Login";
            btnAuthenticate.UseVisualStyleBackColor = true;
            // 
            // pnlAddUser
            // 
            pnlAddUser.Controls.Add(txtName);
            pnlAddUser.Controls.Add(txtBalance);
            pnlAddUser.Controls.Add(btnAddUser);
            pnlAddUser.Location = new Point(12, 118);
            pnlAddUser.Name = "pnlAddUser";
            pnlAddUser.Size = new Size(260, 100);
            pnlAddUser.TabIndex = 1;
            pnlAddUser.Visible = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(3, 3);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(254, 23);
            txtName.TabIndex = 0;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(3, 32);
            txtBalance.Name = "txtBalance";
            txtBalance.PlaceholderText = "Balance";
            txtBalance.Size = new Size(254, 23);
            txtBalance.TabIndex = 1;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(3, 61);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(254, 23);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Create User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 231);
            Controls.Add(pnlAddUser);
            Controls.Add(pnlAuthentication);
            Name = "AddUserForm";
            Text = "Add User";
            pnlAuthentication.ResumeLayout(false);
            pnlAuthentication.PerformLayout();
            pnlAddUser.ResumeLayout(false);
            pnlAddUser.PerformLayout();
            ResumeLayout(false);
        }
    }
}
