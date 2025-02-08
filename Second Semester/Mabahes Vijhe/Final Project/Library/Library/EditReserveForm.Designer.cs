namespace Library
{
    partial class EditReserveForm
    {
        private System.Windows.Forms.TextBox txtSearchReserve;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewReserves;
        private System.Windows.Forms.Button btnDeleteReserve;
        private System.Windows.Forms.Button btnChangeStatus;

        private void InitializeComponent()
        {
            this.txtSearchReserve = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewReserves = new System.Windows.Forms.DataGridView();
            this.btnDeleteReserve = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserves)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchReserve
            // 
            this.txtSearchReserve.Location = new System.Drawing.Point(315, 15);
            this.txtSearchReserve.Name = "txtSearchReserve";
            this.txtSearchReserve.Size = new System.Drawing.Size(300, 20);
            this.txtSearchReserve.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(221, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewReserves
            // 
            this.dataGridViewReserves.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewReserves.Name = "dataGridViewReserves";
            this.dataGridViewReserves.ReadOnly = true;
            this.dataGridViewReserves.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewReserves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReserves.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewReserves.TabIndex = 2;
            this.dataGridViewReserves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReserves_CellClick);
            // 
            // btnDeleteReserve
            // 
            this.btnDeleteReserve.Location = new System.Drawing.Point(12, 360);
            this.btnDeleteReserve.Name = "btnDeleteReserve";
            this.btnDeleteReserve.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteReserve.TabIndex = 3;
            this.btnDeleteReserve.Text = "حذف رزرو";
            this.btnDeleteReserve.Visible = false;
            this.btnDeleteReserve.Click += new System.EventHandler(this.btnDeleteReserve_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(492, 360);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(120, 30);
            this.btnChangeStatus.TabIndex = 4;
            this.btnChangeStatus.Text = "تغییر وضعیت رزرو";
            this.btnChangeStatus.Visible = false;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // EditReserveForm
            // 
            this.ClientSize = new System.Drawing.Size(630, 400);
            this.Controls.Add(this.txtSearchReserve);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewReserves);
            this.Controls.Add(this.btnDeleteReserve);
            this.Controls.Add(this.btnChangeStatus);
            this.Name = "EditReserveForm";
            this.Text = "ویرایش رزروها";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
