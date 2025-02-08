namespace Library
{
    partial class AddBorrowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.lblBookCode = new System.Windows.Forms.Label();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.lblSelectedBook = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.lblMemberCode = new System.Windows.Forms.Label();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.lblSelectedMember = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.btnAddBorrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBookCode
            // 
            this.txtBookCode.Location = new System.Drawing.Point(303, 19);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(172, 20);
            this.txtBookCode.TabIndex = 0;
            // 
            // lblBookCode
            // 
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Location = new System.Drawing.Point(481, 21);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBookCode.Size = new System.Drawing.Size(48, 13);
            this.lblBookCode.TabIndex = 1;
            this.lblBookCode.Text = "کد کتاب:";
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(214, 20);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(64, 20);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "جستجو";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(17, 52);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewBooks.Size = new System.Drawing.Size(514, 130);
            this.dataGridViewBooks.TabIndex = 3;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // lblSelectedBook
            // 
            this.lblSelectedBook.AutoSize = true;
            this.lblSelectedBook.Location = new System.Drawing.Point(17, 191);
            this.lblSelectedBook.Name = "lblSelectedBook";
            this.lblSelectedBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelectedBook.Size = new System.Drawing.Size(92, 13);
            this.lblSelectedBook.TabIndex = 4;
            this.lblSelectedBook.Text = "کتاب انتخاب‌شده: -";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(303, 227);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(172, 20);
            this.txtMemberCode.TabIndex = 5;
            // 
            // lblMemberCode
            // 
            this.lblMemberCode.AutoSize = true;
            this.lblMemberCode.Location = new System.Drawing.Point(481, 229);
            this.lblMemberCode.Name = "lblMemberCode";
            this.lblMemberCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMemberCode.Size = new System.Drawing.Size(50, 13);
            this.lblMemberCode.TabIndex = 6;
            this.lblMemberCode.Text = "کد کاربر:";
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(214, 230);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(64, 20);
            this.btnSearchMember.TabIndex = 7;
            this.btnSearchMember.Text = "جستجو";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(17, 260);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewMembers.Size = new System.Drawing.Size(514, 130);
            this.dataGridViewMembers.TabIndex = 8;
            this.dataGridViewMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMembers_CellClick);
            // 
            // lblSelectedMember
            // 
            this.lblSelectedMember.AutoSize = true;
            this.lblSelectedMember.Location = new System.Drawing.Point(17, 399);
            this.lblSelectedMember.Name = "lblSelectedMember";
            this.lblSelectedMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelectedMember.Size = new System.Drawing.Size(94, 13);
            this.lblSelectedMember.TabIndex = 9;
            this.lblSelectedMember.Text = "کاربر انتخاب‌شده: -";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(286, 431);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(172, 20);
            this.dateStart.TabIndex = 10;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(17, 431);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(172, 20);
            this.dateEnd.TabIndex = 11;
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(464, 433);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDateStart.Size = new System.Drawing.Size(65, 13);
            this.lblDateStart.TabIndex = 12;
            this.lblDateStart.Text = "تاریخ شروع:";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(197, 433);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDateEnd.Size = new System.Drawing.Size(61, 13);
            this.lblDateEnd.TabIndex = 13;
            this.lblDateEnd.Text = "تاریخ پایان:";
            // 
            // btnAddBorrow
            // 
            this.btnAddBorrow.Location = new System.Drawing.Point(17, 468);
            this.btnAddBorrow.Name = "btnAddBorrow";
            this.btnAddBorrow.Size = new System.Drawing.Size(514, 26);
            this.btnAddBorrow.TabIndex = 14;
            this.btnAddBorrow.Text = "ثبت امانت";
            this.btnAddBorrow.UseVisualStyleBackColor = true;
            this.btnAddBorrow.Click += new System.EventHandler(this.btnAddBorrow_Click);
            // 
            // AddBorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 520);
            this.Controls.Add(this.btnAddBorrow);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblSelectedMember);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.lblMemberCode);
            this.Controls.Add(this.txtMemberCode);
            this.Controls.Add(this.lblSelectedBook);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.lblBookCode);
            this.Controls.Add(this.txtBookCode);
            this.Name = "AddBorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت امانت کتاب";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label lblSelectedBook;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Label lblMemberCode;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.Label lblSelectedMember;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Button btnAddBorrow;
    }
}


