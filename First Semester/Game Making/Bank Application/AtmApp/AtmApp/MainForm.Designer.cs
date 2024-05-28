namespace AtmApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstUsers;
        private TextBox txtTransferAmount;
        private TextBox txtReceiverId;
        private TextBox txtSenderId;
        private Label lblTransferAmount;
        private Label lblReceiverId;
        private Label lblSenderId;
        private TextBox txtDecreaseAmount;
        private TextBox txtUserIdDecrease;
        private Label lblDecreaseAmount;
        private Label lblUserIdDecrease;
        private TextBox txtIncreaseAmount;
        private TextBox txtUserIdIncrease;
        private Label lblUserIdIncrease;
        private TextBox txtInitialBalance;
        private TextBox txtName;
        private Label lblInitialBalance;
        private Button btnTransferBalance;
        private Button btnDecreaseBalance;
        private Button btnIncreaseBalance;
        private Button btnRegisterUser;
        private Label lblName;
        private Label lblIncreaseAmount;

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
            lstUsers = new ListBox();
            txtTransferAmount = new TextBox();
            txtReceiverId = new TextBox();
            txtSenderId = new TextBox();
            lblTransferAmount = new Label();
            lblReceiverId = new Label();
            lblSenderId = new Label();
            txtDecreaseAmount = new TextBox();
            txtUserIdDecrease = new TextBox();
            lblDecreaseAmount = new Label();
            lblUserIdDecrease = new Label();
            txtIncreaseAmount = new TextBox();
            txtUserIdIncrease = new TextBox();
            lblUserIdIncrease = new Label();
            txtInitialBalance = new TextBox();
            txtName = new TextBox();
            lblInitialBalance = new Label();
            btnTransferBalance = new Button();
            btnDecreaseBalance = new Button();
            btnIncreaseBalance = new Button();
            btnRegisterUser = new Button();
            lblName = new Label();
            lblIncreaseAmount = new Label();
            SuspendLayout();
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 20;
            lstUsers.Location = new Point(33, 32);
            lstUsers.Margin = new Padding(4, 3, 4, 3);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(373, 484);
            lstUsers.TabIndex = 4;
            // 
            // txtTransferAmount
            // 
            txtTransferAmount.Location = new Point(432, 485);
            txtTransferAmount.Margin = new Padding(4, 3, 4, 3);
            txtTransferAmount.Name = "txtTransferAmount";
            txtTransferAmount.Size = new Size(174, 26);
            txtTransferAmount.TabIndex = 44;
            // 
            // txtReceiverId
            // 
            txtReceiverId.Location = new Point(434, 444);
            txtReceiverId.Margin = new Padding(4, 3, 4, 3);
            txtReceiverId.Name = "txtReceiverId";
            txtReceiverId.Size = new Size(111, 26);
            txtReceiverId.TabIndex = 43;
            // 
            // txtSenderId
            // 
            txtSenderId.Location = new Point(594, 444);
            txtSenderId.Margin = new Padding(4, 3, 4, 3);
            txtSenderId.Name = "txtSenderId";
            txtSenderId.Size = new Size(111, 26);
            txtSenderId.TabIndex = 42;
            // 
            // lblTransferAmount
            // 
            lblTransferAmount.AutoSize = true;
            lblTransferAmount.Location = new Point(677, 491);
            lblTransferAmount.Margin = new Padding(4, 0, 4, 0);
            lblTransferAmount.Name = "lblTransferAmount";
            lblTransferAmount.Size = new Size(28, 20);
            lblTransferAmount.TabIndex = 41;
            lblTransferAmount.Text = "مبلغ";
            // 
            // lblReceiverId
            // 
            lblReceiverId.AutoSize = true;
            lblReceiverId.Location = new Point(471, 421);
            lblReceiverId.Margin = new Padding(4, 0, 4, 0);
            lblReceiverId.Name = "lblReceiverId";
            lblReceiverId.Size = new Size(74, 20);
            lblReceiverId.TabIndex = 40;
            lblReceiverId.Text = "حساب مقصد";
            // 
            // lblSenderId
            // 
            lblSenderId.AutoSize = true;
            lblSenderId.Location = new Point(642, 421);
            lblSenderId.Margin = new Padding(4, 0, 4, 0);
            lblSenderId.Name = "lblSenderId";
            lblSenderId.Size = new Size(63, 20);
            lblSenderId.TabIndex = 39;
            lblSenderId.Text = "حساب مبدا";
            // 
            // txtDecreaseAmount
            // 
            txtDecreaseAmount.Location = new Point(432, 335);
            txtDecreaseAmount.Margin = new Padding(4, 3, 4, 3);
            txtDecreaseAmount.Name = "txtDecreaseAmount";
            txtDecreaseAmount.Size = new Size(174, 26);
            txtDecreaseAmount.TabIndex = 38;
            // 
            // txtUserIdDecrease
            // 
            txtUserIdDecrease.Location = new Point(432, 306);
            txtUserIdDecrease.Margin = new Padding(4, 3, 4, 3);
            txtUserIdDecrease.Name = "txtUserIdDecrease";
            txtUserIdDecrease.Size = new Size(174, 26);
            txtUserIdDecrease.TabIndex = 37;
            // 
            // lblDecreaseAmount
            // 
            lblDecreaseAmount.AutoSize = true;
            lblDecreaseAmount.Location = new Point(677, 341);
            lblDecreaseAmount.Margin = new Padding(4, 0, 4, 0);
            lblDecreaseAmount.Name = "lblDecreaseAmount";
            lblDecreaseAmount.Size = new Size(28, 20);
            lblDecreaseAmount.TabIndex = 36;
            lblDecreaseAmount.Text = "مبلغ";
            // 
            // lblUserIdDecrease
            // 
            lblUserIdDecrease.AutoSize = true;
            lblUserIdDecrease.Location = new Point(630, 312);
            lblUserIdDecrease.Margin = new Padding(4, 0, 4, 0);
            lblUserIdDecrease.Name = "lblUserIdDecrease";
            lblUserIdDecrease.Size = new Size(75, 20);
            lblUserIdDecrease.TabIndex = 35;
            lblUserIdDecrease.Text = "حساب کاربر";
            // 
            // txtIncreaseAmount
            // 
            txtIncreaseAmount.Location = new Point(432, 197);
            txtIncreaseAmount.Margin = new Padding(4, 3, 4, 3);
            txtIncreaseAmount.Name = "txtIncreaseAmount";
            txtIncreaseAmount.Size = new Size(174, 26);
            txtIncreaseAmount.TabIndex = 34;
            // 
            // txtUserIdIncrease
            // 
            txtUserIdIncrease.Location = new Point(432, 168);
            txtUserIdIncrease.Margin = new Padding(4, 3, 4, 3);
            txtUserIdIncrease.Name = "txtUserIdIncrease";
            txtUserIdIncrease.Size = new Size(174, 26);
            txtUserIdIncrease.TabIndex = 33;
            // 
            // lblUserIdIncrease
            // 
            lblUserIdIncrease.AutoSize = true;
            lblUserIdIncrease.Location = new Point(630, 174);
            lblUserIdIncrease.Margin = new Padding(4, 0, 4, 0);
            lblUserIdIncrease.Name = "lblUserIdIncrease";
            lblUserIdIncrease.Size = new Size(75, 20);
            lblUserIdIncrease.TabIndex = 32;
            lblUserIdIncrease.Text = "حساب کاربر";
            // 
            // txtInitialBalance
            // 
            txtInitialBalance.Location = new Point(432, 64);
            txtInitialBalance.Margin = new Padding(4, 3, 4, 3);
            txtInitialBalance.Name = "txtInitialBalance";
            txtInitialBalance.Size = new Size(174, 26);
            txtInitialBalance.TabIndex = 31;
            // 
            // txtName
            // 
            txtName.Location = new Point(432, 32);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 26);
            txtName.TabIndex = 30;
            // 
            // lblInitialBalance
            // 
            lblInitialBalance.AutoSize = true;
            lblInitialBalance.Location = new Point(625, 67);
            lblInitialBalance.Margin = new Padding(4, 0, 4, 0);
            lblInitialBalance.Name = "lblInitialBalance";
            lblInitialBalance.Size = new Size(80, 20);
            lblInitialBalance.TabIndex = 29;
            lblInitialBalance.Text = "موجودی اولیه";
            // 
            // btnTransferBalance
            // 
            btnTransferBalance.Location = new Point(432, 530);
            btnTransferBalance.Margin = new Padding(4, 3, 4, 3);
            btnTransferBalance.Name = "btnTransferBalance";
            btnTransferBalance.Size = new Size(124, 27);
            btnTransferBalance.TabIndex = 28;
            btnTransferBalance.Text = "انتقال موجودی";
            btnTransferBalance.UseVisualStyleBackColor = true;
            btnTransferBalance.Click += btnTransferBalance_Click;
            // 
            // btnDecreaseBalance
            // 
            btnDecreaseBalance.Location = new Point(432, 367);
            btnDecreaseBalance.Margin = new Padding(4, 3, 4, 3);
            btnDecreaseBalance.Name = "btnDecreaseBalance";
            btnDecreaseBalance.Size = new Size(124, 27);
            btnDecreaseBalance.TabIndex = 27;
            btnDecreaseBalance.Text = "کاهش موجودی";
            btnDecreaseBalance.UseVisualStyleBackColor = true;
            btnDecreaseBalance.Click += btnDecreaseBalance_Click;
            // 
            // btnIncreaseBalance
            // 
            btnIncreaseBalance.Location = new Point(432, 229);
            btnIncreaseBalance.Margin = new Padding(4, 3, 4, 3);
            btnIncreaseBalance.Name = "btnIncreaseBalance";
            btnIncreaseBalance.Size = new Size(124, 27);
            btnIncreaseBalance.TabIndex = 26;
            btnIncreaseBalance.Text = "افزایش موجودی";
            btnIncreaseBalance.UseVisualStyleBackColor = true;
            btnIncreaseBalance.Click += btnIncreaseBalance_Click;
            // 
            // btnRegisterUser
            // 
            btnRegisterUser.Location = new Point(432, 106);
            btnRegisterUser.Margin = new Padding(4, 3, 4, 3);
            btnRegisterUser.Name = "btnRegisterUser";
            btnRegisterUser.Size = new Size(124, 27);
            btnRegisterUser.TabIndex = 25;
            btnRegisterUser.Text = "ثبت کاربر";
            btnRegisterUser.UseVisualStyleBackColor = true;
            btnRegisterUser.Click += btnRegisterUser_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(683, 38);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(22, 20);
            lblName.TabIndex = 24;
            lblName.Text = "نام";
            // 
            // lblIncreaseAmount
            // 
            lblIncreaseAmount.AutoSize = true;
            lblIncreaseAmount.Location = new Point(677, 203);
            lblIncreaseAmount.Margin = new Padding(4, 0, 4, 0);
            lblIncreaseAmount.Name = "lblIncreaseAmount";
            lblIncreaseAmount.Size = new Size(28, 20);
            lblIncreaseAmount.TabIndex = 45;
            lblIncreaseAmount.Text = "مبلغ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 585);
            Controls.Add(lblIncreaseAmount);
            Controls.Add(txtTransferAmount);
            Controls.Add(txtReceiverId);
            Controls.Add(txtSenderId);
            Controls.Add(lblTransferAmount);
            Controls.Add(lblReceiverId);
            Controls.Add(lblSenderId);
            Controls.Add(txtDecreaseAmount);
            Controls.Add(txtUserIdDecrease);
            Controls.Add(lblDecreaseAmount);
            Controls.Add(lblUserIdDecrease);
            Controls.Add(txtIncreaseAmount);
            Controls.Add(txtUserIdIncrease);
            Controls.Add(lblUserIdIncrease);
            Controls.Add(txtInitialBalance);
            Controls.Add(txtName);
            Controls.Add(lblInitialBalance);
            Controls.Add(btnTransferBalance);
            Controls.Add(btnDecreaseBalance);
            Controls.Add(btnIncreaseBalance);
            Controls.Add(btnRegisterUser);
            Controls.Add(lblName);
            Controls.Add(lstUsers);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "ATM App";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
