namespace Library
{
    partial class DeleteMemberForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMNo;
        private System.Windows.Forms.TextBox txtMNo;
        private System.Windows.Forms.Label lblMCode;
        private System.Windows.Forms.TextBox txtMCode;
        private System.Windows.Forms.DataGridView dataGridViewMembers;

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
            this.lblMNo = new System.Windows.Forms.Label();
            this.txtMNo = new System.Windows.Forms.TextBox();
            this.lblMCode = new System.Windows.Forms.Label();
            this.txtMCode = new System.Windows.Forms.TextBox();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMNo
            // 
            this.lblMNo.AutoSize = true;
            this.lblMNo.Location = new System.Drawing.Point(704, 19);
            this.lblMNo.Name = "lblMNo";
            this.lblMNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMNo.Size = new System.Drawing.Size(59, 13);
            this.lblMNo.TabIndex = 6;
            this.lblMNo.Text = "کد عضویت:";
            this.lblMNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMNo
            // 
            this.txtMNo.Location = new System.Drawing.Point(498, 16);
            this.txtMNo.Name = "txtMNo";
            this.txtMNo.Size = new System.Drawing.Size(200, 20);
            this.txtMNo.TabIndex = 5;
            // 
            // lblMCode
            // 
            this.lblMCode.AutoSize = true;
            this.lblMCode.Location = new System.Drawing.Point(709, 54);
            this.lblMCode.Name = "lblMCode";
            this.lblMCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMCode.Size = new System.Drawing.Size(54, 13);
            this.lblMCode.TabIndex = 4;
            this.lblMCode.Text = "کد ثبت‌نام:";
            // 
            // txtMCode
            // 
            this.txtMCode.Location = new System.Drawing.Point(498, 51);
            this.txtMCode.Name = "txtMCode";
            this.txtMCode.Size = new System.Drawing.Size(200, 20);
            this.txtMCode.TabIndex = 3;
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(12, 85);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewMembers.Size = new System.Drawing.Size(760, 365);
            this.dataGridViewMembers.TabIndex = 2;
            // 
            // DeleteMemberForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.txtMCode);
            this.Controls.Add(this.lblMCode);
            this.Controls.Add(this.txtMNo);
            this.Controls.Add(this.lblMNo);
            this.Name = "DeleteMemberForm";
            this.Text = "حذف عضو";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
