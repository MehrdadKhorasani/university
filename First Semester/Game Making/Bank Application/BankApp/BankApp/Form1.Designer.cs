namespace BankApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnIncreaseBalance;
        private System.Windows.Forms.Button btnDecreaseBalance;
        private System.Windows.Forms.Button btnTransferBalance;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListBox lstUsers;

        private void InitializeComponent()
        {
            btnIncreaseBalance = new Button();
            btnDecreaseBalance = new Button();
            btnTransferBalance = new Button();
            btnAddUser = new Button();
            lstUsers = new ListBox();
            SuspendLayout();
            // 
            // btnIncreaseBalance
            // 
            btnIncreaseBalance.Location = new Point(12, 12);
            btnIncreaseBalance.Name = "btnIncreaseBalance";
            btnIncreaseBalance.Size = new Size(120, 23);
            btnIncreaseBalance.TabIndex = 0;
            btnIncreaseBalance.Text = "Increase Balance";
            btnIncreaseBalance.UseVisualStyleBackColor = true;
            // 
            // btnDecreaseBalance
            // 
            btnDecreaseBalance.Location = new Point(12, 41);
            btnDecreaseBalance.Name = "btnDecreaseBalance";
            btnDecreaseBalance.Size = new Size(120, 23);
            btnDecreaseBalance.TabIndex = 1;
            btnDecreaseBalance.Text = "Decrease Balance";
            btnDecreaseBalance.UseVisualStyleBackColor = true;
            // 
            // btnTransferBalance
            // 
            btnTransferBalance.Location = new Point(12, 70);
            btnTransferBalance.Name = "btnTransferBalance";
            btnTransferBalance.Size = new Size(120, 23);
            btnTransferBalance.TabIndex = 2;
            btnTransferBalance.Text = "Transfer Balance";
            btnTransferBalance.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(12, 99);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(120, 23);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Create User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 15;
            lstUsers.Location = new Point(138, 12);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(212, 214);
            lstUsers.TabIndex = 5;
            // 
            // Form1
            // 
            ClientSize = new Size(362, 237);
            Controls.Add(lstUsers);
            Controls.Add(btnAddUser);
            Controls.Add(btnTransferBalance);
            Controls.Add(btnDecreaseBalance);
            Controls.Add(btnIncreaseBalance);
            Name = "Form1";
            Text = "Bank Application";
            ResumeLayout(false);
        }
    }
}
