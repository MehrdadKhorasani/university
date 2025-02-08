namespace Library
{
    partial class ReservesReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewReserves;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxBNo;
        private System.Windows.Forms.Label labelBNo;
        private System.Windows.Forms.TextBox textBoxMNo;
        private System.Windows.Forms.Label labelMNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;

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

        private void InitializeComponent()
        {
            this.dataGridViewReserves = new System.Windows.Forms.DataGridView();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxBNo = new System.Windows.Forms.TextBox();
            this.labelBNo = new System.Windows.Forms.Label();
            this.textBoxMNo = new System.Windows.Forms.TextBox();
            this.labelMNo = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserves)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReserves
            // 
            this.dataGridViewReserves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReserves.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewReserves.Name = "dataGridViewReserves";
            this.dataGridViewReserves.ReadOnly = true;
            this.dataGridViewReserves.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewReserves.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewReserves.TabIndex = 0;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "همه",
            "فعال",
            "انجام شده",
            "گذشته"});
            this.comboBoxFilter.Location = new System.Drawing.Point(534, 21);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(150, 21);
            this.comboBoxFilter.TabIndex = 1;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(699, 24);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(53, 13);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "فیلتر رزرو";
            // 
            // textBoxBNo
            // 
            this.textBoxBNo.Location = new System.Drawing.Point(534, 48);
            this.textBoxBNo.Name = "textBoxBNo";
            this.textBoxBNo.Size = new System.Drawing.Size(150, 20);
            this.textBoxBNo.TabIndex = 3;
            this.textBoxBNo.TextChanged += new System.EventHandler(this.textBoxBNo_TextChanged);
            this.textBoxBNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBNo_KeyPress);
            // 
            // labelBNo
            // 
            this.labelBNo.AutoSize = true;
            this.labelBNo.Location = new System.Drawing.Point(699, 51);
            this.labelBNo.Name = "labelBNo";
            this.labelBNo.Size = new System.Drawing.Size(62, 13);
            this.labelBNo.TabIndex = 4;
            this.labelBNo.Text = "شماره کتاب";
            // 
            // textBoxMNo
            // 
            this.textBoxMNo.Location = new System.Drawing.Point(534, 74);
            this.textBoxMNo.Name = "textBoxMNo";
            this.textBoxMNo.Size = new System.Drawing.Size(150, 20);
            this.textBoxMNo.TabIndex = 5;
            this.textBoxMNo.TextChanged += new System.EventHandler(this.textBoxMNo_TextChanged);
            this.textBoxMNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMNo_KeyPress);
            // 
            // labelMNo
            // 
            this.labelMNo.AutoSize = true;
            this.labelMNo.Location = new System.Drawing.Point(699, 77);
            this.labelMNo.Name = "labelMNo";
            this.labelMNo.Size = new System.Drawing.Size(64, 13);
            this.labelMNo.TabIndex = 6;
            this.labelMNo.Text = "شماره کاربر";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(228, 25);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 7;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(228, 51);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 8;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(438, 28);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(62, 13);
            this.labelStartDate.TabIndex = 9;
            this.labelStartDate.Text = "تاریخ شروع";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(438, 54);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(58, 13);
            this.labelEndDate.TabIndex = 10;
            this.labelEndDate.Text = "تاریخ پایان";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ReservesReportForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.labelMNo);
            this.Controls.Add(this.textBoxMNo);
            this.Controls.Add(this.labelBNo);
            this.Controls.Add(this.textBoxBNo);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.dataGridViewReserves);
            this.Name = "ReservesReportForm";
            this.Text = "گزارش رزروها";
            this.Load += new System.EventHandler(this.ReservesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
    }
}
