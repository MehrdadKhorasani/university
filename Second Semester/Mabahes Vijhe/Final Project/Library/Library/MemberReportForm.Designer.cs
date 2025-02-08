namespace Library
{
    partial class MemberReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblSort;

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
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(12, 55);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvMembers.Size = new System.Drawing.Size(760, 341);
            this.dgvMembers.TabIndex = 0;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "همه کاربران",
            "کاربران فعال",
            "کاربران منقضی",
            "کاربران بدهکار"});
            this.cbFilter.Location = new System.Drawing.Point(289, 15);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbFilter.Size = new System.Drawing.Size(150, 21);
            this.cbFilter.TabIndex = 1;
            // 
            // cbSort
            // 
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "تاریخ تولد",
            "میزان بدهی",
            "تاریخ انقضا",
            "تاریخ ثبت‌نام"});
            this.cbSort.Location = new System.Drawing.Point(12, 15);
            this.cbSort.Name = "cbSort";
            this.cbSort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSort.Size = new System.Drawing.Size(150, 21);
            this.cbSort.TabIndex = 2;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(445, 15);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFilter.Size = new System.Drawing.Size(70, 13);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "فیلتر کاربران:";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(168, 15);
            this.lblSort.Name = "lblSort";
            this.lblSort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSort.Size = new System.Drawing.Size(100, 13);
            this.lblSort.TabIndex = 4;
            this.lblSort.Text = "مرتب‌سازی بر اساس:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(691, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Size = new System.Drawing.Size(81, 13);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "جستجوی کاربر:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(536, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 20);
            this.txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MemberReportForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dgvMembers);
            this.Name = "MemberReportForm";
            this.Text = "گزارش کاربران";
            this.Load += new System.EventHandler(this.MemberReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExit;
    }
}
