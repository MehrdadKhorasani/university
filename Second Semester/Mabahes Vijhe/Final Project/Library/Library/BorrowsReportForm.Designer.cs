namespace Library
{
    partial class BorrowsReportForm
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

        private void InitializeComponent()
        {
            this.dataGridViewBorrows = new System.Windows.Forms.DataGridView();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxBNo = new System.Windows.Forms.TextBox();
            this.textBoxMNo = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelBNo = new System.Windows.Forms.Label();
            this.labelMNo = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrows)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrows
            // 
            this.dataGridViewBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrows.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewBorrows.Name = "dataGridViewBorrows";
            this.dataGridViewBorrows.ReadOnly = true;
            this.dataGridViewBorrows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewBorrows.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewBorrows.TabIndex = 0;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "همه",
            "بازگشتی",
            "فعال",
            "دیرکرد"});
            this.comboBoxFilter.Location = new System.Drawing.Point(566, 9);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter.TabIndex = 1;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // textBoxBNo
            // 
            this.textBoxBNo.Location = new System.Drawing.Point(566, 36);
            this.textBoxBNo.Name = "textBoxBNo";
            this.textBoxBNo.Size = new System.Drawing.Size(121, 20);
            this.textBoxBNo.TabIndex = 2;
            this.textBoxBNo.TextChanged += new System.EventHandler(this.textBoxBNo_TextChanged);
            // 
            // textBoxMNo
            // 
            this.textBoxMNo.Location = new System.Drawing.Point(566, 62);
            this.textBoxMNo.Name = "textBoxMNo";
            this.textBoxMNo.Size = new System.Drawing.Size(121, 20);
            this.textBoxMNo.TabIndex = 3;
            this.textBoxMNo.TextChanged += new System.EventHandler(this.textBoxMNo_TextChanged);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(320, 12);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerStart.TabIndex = 4;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(320, 38);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerEnd.TabIndex = 5;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(707, 12);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFilter.Size = new System.Drawing.Size(52, 13);
            this.labelFilter.TabIndex = 6;
            this.labelFilter.Text = "نوع فیلتر:";
            // 
            // labelBNo
            // 
            this.labelBNo.AutoSize = true;
            this.labelBNo.Location = new System.Drawing.Point(707, 39);
            this.labelBNo.Name = "labelBNo";
            this.labelBNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelBNo.Size = new System.Drawing.Size(48, 13);
            this.labelBNo.TabIndex = 7;
            this.labelBNo.Text = "کد کتاب:";
            // 
            // labelMNo
            // 
            this.labelMNo.AutoSize = true;
            this.labelMNo.Location = new System.Drawing.Point(707, 65);
            this.labelMNo.Name = "labelMNo";
            this.labelMNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelMNo.Size = new System.Drawing.Size(50, 13);
            this.labelMNo.TabIndex = 8;
            this.labelMNo.Text = "کد کاربر:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(448, 16);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelStartDate.Size = new System.Drawing.Size(65, 13);
            this.labelStartDate.TabIndex = 9;
            this.labelStartDate.Text = "تاریخ شروع:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(448, 41);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelEndDate.Size = new System.Drawing.Size(61, 13);
            this.labelEndDate.TabIndex = 10;
            this.labelEndDate.Text = "تاریخ پایان:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 32);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BorrowsReportForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelMNo);
            this.Controls.Add(this.labelBNo);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.textBoxMNo);
            this.Controls.Add(this.textBoxBNo);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.dataGridViewBorrows);
            this.Name = "BorrowsReportForm";
            this.Text = "Borrows Report";
            this.Load += new System.EventHandler(this.BorrowsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBorrows;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox textBoxBNo;
        private System.Windows.Forms.TextBox textBoxMNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelBNo;
        private System.Windows.Forms.Label labelMNo;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Button btnExit;
    }
}
