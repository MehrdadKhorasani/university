namespace Library
{
    partial class AdminForm
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.lblSearchBook = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tabBorrows = new System.Windows.Forms.TabPage();
            this.txtSearchBorrow = new System.Windows.Forms.TextBox();
            this.lblSearchBorrow = new System.Windows.Forms.Label();
            this.dgvBorrows = new System.Windows.Forms.DataGridView();
            this.tabExit = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddBorrow = new System.Windows.Forms.Button();
            this.tabControlAdmin.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tabBorrows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrows)).BeginInit();
            this.tabExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabUsers);
            this.tabControlAdmin.Controls.Add(this.tabBooks);
            this.tabControlAdmin.Controls.Add(this.tabBorrows);
            this.tabControlAdmin.Controls.Add(this.tabExit);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(600, 366);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.txtSearchUser);
            this.tabUsers.Controls.Add(this.lblSearchUser);
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Controls.Add(this.btnAddUser);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUsers.Size = new System.Drawing.Size(592, 340);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "کاربران";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(68, 8);
            this.txtSearchUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(151, 20);
            this.txtSearchUser.TabIndex = 3;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(8, 8);
            this.lblSearchUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(43, 13);
            this.lblSearchUser.TabIndex = 2;
            this.lblSearchUser.Text = "جستجو:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(8, 32);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(578, 268);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(8, 309);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(90, 24);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "افزودن کاربر";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.txtSearchBook);
            this.tabBooks.Controls.Add(this.lblSearchBook);
            this.tabBooks.Controls.Add(this.dgvBooks);
            this.tabBooks.Controls.Add(this.btnAddBook);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBooks.Size = new System.Drawing.Size(592, 340);
            this.tabBooks.TabIndex = 1;
            this.tabBooks.Text = "کتاب‌ها";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(68, 8);
            this.txtSearchBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(151, 20);
            this.txtSearchBook.TabIndex = 3;
            this.txtSearchBook.TextChanged += new System.EventHandler(this.txtSearchBook_TextChanged);
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Location = new System.Drawing.Point(8, 8);
            this.lblSearchBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(43, 13);
            this.lblSearchBook.TabIndex = 2;
            this.lblSearchBook.Text = "جستجو:";
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(8, 32);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(578, 268);
            this.dgvBooks.TabIndex = 1;
            this.dgvBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellDoubleClick);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(8, 309);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(90, 24);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "افزودن کتاب";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // tabBorrows
            // 
            this.tabBorrows.Controls.Add(this.btnAddBorrow);
            this.tabBorrows.Controls.Add(this.txtSearchBorrow);
            this.tabBorrows.Controls.Add(this.lblSearchBorrow);
            this.tabBorrows.Controls.Add(this.dgvBorrows);
            this.tabBorrows.Location = new System.Drawing.Point(4, 22);
            this.tabBorrows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBorrows.Name = "tabBorrows";
            this.tabBorrows.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBorrows.Size = new System.Drawing.Size(592, 340);
            this.tabBorrows.TabIndex = 2;
            this.tabBorrows.Text = "امانات";
            this.tabBorrows.UseVisualStyleBackColor = true;
            // 
            // txtSearchBorrow
            // 
            this.txtSearchBorrow.Location = new System.Drawing.Point(68, 8);
            this.txtSearchBorrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchBorrow.Name = "txtSearchBorrow";
            this.txtSearchBorrow.Size = new System.Drawing.Size(151, 20);
            this.txtSearchBorrow.TabIndex = 3;
            this.txtSearchBorrow.TextChanged += new System.EventHandler(this.txtSearchBorrow_TextChanged);
            // 
            // lblSearchBorrow
            // 
            this.lblSearchBorrow.AutoSize = true;
            this.lblSearchBorrow.Location = new System.Drawing.Point(8, 8);
            this.lblSearchBorrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchBorrow.Name = "lblSearchBorrow";
            this.lblSearchBorrow.Size = new System.Drawing.Size(43, 13);
            this.lblSearchBorrow.TabIndex = 2;
            this.lblSearchBorrow.Text = "جستجو:";
            // 
            // dgvBorrows
            // 
            this.dgvBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrows.Location = new System.Drawing.Point(8, 32);
            this.dgvBorrows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBorrows.Name = "dgvBorrows";
            this.dgvBorrows.RowHeadersWidth = 51;
            this.dgvBorrows.RowTemplate.Height = 24;
            this.dgvBorrows.Size = new System.Drawing.Size(578, 268);
            this.dgvBorrows.TabIndex = 1;
            this.dgvBorrows.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrows_CellDoubleClick);
            // 
            // tabExit
            // 
            this.tabExit.Controls.Add(this.btnExit);
            this.tabExit.Location = new System.Drawing.Point(4, 22);
            this.tabExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabExit.Name = "tabExit";
            this.tabExit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabExit.Size = new System.Drawing.Size(592, 340);
            this.tabExit.TabIndex = 3;
            this.tabExit.Text = "خروج";
            this.tabExit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 154);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "خروج از سیستم";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddBorrow
            // 
            this.btnAddBorrow.Location = new System.Drawing.Point(8, 309);
            this.btnAddBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBorrow.Name = "btnAddBorrow";
            this.btnAddBorrow.Size = new System.Drawing.Size(90, 24);
            this.btnAddBorrow.TabIndex = 4;
            this.btnAddBorrow.Text = "افزودن امانت";
            this.btnAddBorrow.UseVisualStyleBackColor = true;
            this.btnAddBorrow.Click += new System.EventHandler(this.btnAddBorrow_Click);
            //this.Controls.Add(this.btnAddBorrow);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControlAdmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پنل مدیریت";
            this.tabControlAdmin.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tabBorrows.ResumeLayout(false);
            this.tabBorrows.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrows)).EndInit();
            this.tabExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Label lblSearchBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TabPage tabBorrows;
        private System.Windows.Forms.TextBox txtSearchBorrow;
        private System.Windows.Forms.Label lblSearchBorrow;
        private System.Windows.Forms.DataGridView dgvBorrows;
        private System.Windows.Forms.TabPage tabExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddBorrow;
    }
}
