namespace Library
{
    partial class DeleteBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBno;
        private System.Windows.Forms.TextBox txtBno;
        private System.Windows.Forms.Label lblBTitle;
        private System.Windows.Forms.TextBox txtBTitle;
        private System.Windows.Forms.DataGridView dataGridViewBooks;

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
            this.lblBno = new System.Windows.Forms.Label();
            this.txtBno = new System.Windows.Forms.TextBox();
            this.lblBTitle = new System.Windows.Forms.Label();
            this.txtBTitle = new System.Windows.Forms.TextBox();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBno
            // 
            this.lblBno.AutoSize = true;
            this.lblBno.Location = new System.Drawing.Point(710, 20);
            this.lblBno.Name = "lblBno";
            this.lblBno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBno.Size = new System.Drawing.Size(48, 13);
            this.lblBno.TabIndex = 6;
            this.lblBno.Text = "کد کتاب:";
            // 
            // txtBno
            // 
            this.txtBno.Location = new System.Drawing.Point(504, 15);
            this.txtBno.Name = "txtBno";
            this.txtBno.Size = new System.Drawing.Size(200, 20);
            this.txtBno.TabIndex = 5;
            // 
            // lblBTitle
            // 
            this.lblBTitle.AutoSize = true;
            this.lblBTitle.Location = new System.Drawing.Point(710, 55);
            this.lblBTitle.Name = "lblBTitle";
            this.lblBTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBTitle.Size = new System.Drawing.Size(49, 13);
            this.lblBTitle.TabIndex = 4;
            this.lblBTitle.Text = "نام کتاب:";
            // 
            // txtBTitle
            // 
            this.txtBTitle.Location = new System.Drawing.Point(504, 50);
            this.txtBTitle.Name = "txtBTitle";
            this.txtBTitle.Size = new System.Drawing.Size(200, 20);
            this.txtBTitle.TabIndex = 3;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 85);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewBooks.Size = new System.Drawing.Size(760, 365);
            this.dataGridViewBooks.TabIndex = 2;
            // 
            // DeleteBookForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.txtBTitle);
            this.Controls.Add(this.lblBTitle);
            this.Controls.Add(this.txtBno);
            this.Controls.Add(this.lblBno);
            this.Name = "DeleteBookForm";
            this.Text = "حذف کتاب";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
