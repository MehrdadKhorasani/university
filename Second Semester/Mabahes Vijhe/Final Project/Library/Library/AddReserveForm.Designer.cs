namespace Library
{
    partial class AddReserveForm
    {
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.Label lblNearestDate;
        private System.Windows.Forms.Label lblSelectedMember;
        private System.Windows.Forms.Button btnReserveBook;

        private void InitializeComponent()
        {
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.lblNearestDate = new System.Windows.Forms.Label();
            this.lblSelectedMember = new System.Windows.Forms.Label();
            this.btnReserveBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(288, 29);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(500, 20);
            this.txtSearchBook.TabIndex = 0;
            this.txtSearchBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBook_KeyDown);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.Location = new System.Drawing.Point(288, 74);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewBooks.Size = new System.Drawing.Size(500, 200);
            this.dataGridViewBooks.TabIndex = 1;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.Location = new System.Drawing.Point(288, 302);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewMembers.Size = new System.Drawing.Size(500, 200);
            this.dataGridViewMembers.TabIndex = 2;
            this.dataGridViewMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMembers_CellClick);
            // 
            // lblNearestDate
            // 
            this.lblNearestDate.Location = new System.Drawing.Point(20, 74);
            this.lblNearestDate.Name = "lblNearestDate";
            this.lblNearestDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNearestDate.Size = new System.Drawing.Size(262, 23);
            this.lblNearestDate.TabIndex = 3;
            // 
            // lblSelectedMember
            // 
            this.lblSelectedMember.Location = new System.Drawing.Point(20, 302);
            this.lblSelectedMember.Name = "lblSelectedMember";
            this.lblSelectedMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelectedMember.Size = new System.Drawing.Size(262, 23);
            this.lblSelectedMember.TabIndex = 4;
            // 
            // btnReserveBook
            // 
            this.btnReserveBook.Location = new System.Drawing.Point(688, 508);
            this.btnReserveBook.Name = "btnReserveBook";
            this.btnReserveBook.Size = new System.Drawing.Size(100, 30);
            this.btnReserveBook.TabIndex = 5;
            this.btnReserveBook.Text = "ثبت رزرو";
            this.btnReserveBook.Click += new System.EventHandler(this.btnReserveBook_Click);
            // 
            // AddReserveForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.lblNearestDate);
            this.Controls.Add(this.lblSelectedMember);
            this.Controls.Add(this.btnReserveBook);
            this.Name = "AddReserveForm";
            this.Text = "افزودن رزرو";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
