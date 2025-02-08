namespace Library
{
    partial class ManageFineForm
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
            this.dataGridViewFines = new System.Windows.Forms.DataGridView();
            this.txtSearchBorrowId = new System.Windows.Forms.TextBox();
            this.lblSearchBorrowId = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.cmbFineAction = new System.Windows.Forms.ComboBox();
            this.btnUpdateFine = new System.Windows.Forms.Button();
            this.lblAmountFine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFines
            // 
            this.dataGridViewFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFines.Location = new System.Drawing.Point(10, 43);
            this.dataGridViewFines.Name = "dataGridViewFines";
            this.dataGridViewFines.ReadOnly = true;
            this.dataGridViewFines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewFines.Size = new System.Drawing.Size(651, 303);
            this.dataGridViewFines.TabIndex = 0;
            // 
            // txtSearchBorrowId
            // 
            this.txtSearchBorrowId.Location = new System.Drawing.Point(523, 13);
            this.txtSearchBorrowId.Name = "txtSearchBorrowId";
            this.txtSearchBorrowId.Size = new System.Drawing.Size(86, 20);
            this.txtSearchBorrowId.TabIndex = 1;
            // 
            // lblSearchBorrowId
            // 
            this.lblSearchBorrowId.AutoSize = true;
            this.lblSearchBorrowId.Location = new System.Drawing.Point(615, 16);
            this.lblSearchBorrowId.Name = "lblSearchBorrowId";
            this.lblSearchBorrowId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchBorrowId.Size = new System.Drawing.Size(49, 13);
            this.lblSearchBorrowId.TabIndex = 2;
            this.lblSearchBorrowId.Text = "کد امانت:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(440, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 24);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.Location = new System.Drawing.Point(529, 368);
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.Size = new System.Drawing.Size(86, 20);
            this.txtFineAmount.TabIndex = 4;
            this.txtFineAmount.Visible = false;
            // 
            // cmbFineAction
            // 
            this.cmbFineAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFineAction.FormattingEnabled = true;
            this.cmbFineAction.Items.AddRange(new object[] {
            "افزایش جریمه",
            "پرداخت جریمه"});
            this.cmbFineAction.Location = new System.Drawing.Point(399, 368);
            this.cmbFineAction.Name = "cmbFineAction";
            this.cmbFineAction.Size = new System.Drawing.Size(104, 21);
            this.cmbFineAction.TabIndex = 5;
            this.cmbFineAction.Visible = false;
            // 
            // btnUpdateFine
            // 
            this.btnUpdateFine.Location = new System.Drawing.Point(310, 365);
            this.btnUpdateFine.Name = "btnUpdateFine";
            this.btnUpdateFine.Size = new System.Drawing.Size(64, 28);
            this.btnUpdateFine.TabIndex = 6;
            this.btnUpdateFine.Text = "ثبت";
            this.btnUpdateFine.UseVisualStyleBackColor = true;
            this.btnUpdateFine.Visible = false;
            // 
            // lblAmountFine
            // 
            this.lblAmountFine.AutoSize = true;
            this.lblAmountFine.Location = new System.Drawing.Point(631, 371);
            this.lblAmountFine.Name = "lblAmountFine";
            this.lblAmountFine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAmountFine.Size = new System.Drawing.Size(29, 13);
            this.lblAmountFine.TabIndex = 7;
            this.lblAmountFine.Text = "مبلغ:";
            // 
            // ManageFineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 400);
            this.Controls.Add(this.lblAmountFine);
            this.Controls.Add(this.btnUpdateFine);
            this.Controls.Add(this.cmbFineAction);
            this.Controls.Add(this.txtFineAmount);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchBorrowId);
            this.Controls.Add(this.txtSearchBorrowId);
            this.Controls.Add(this.dataGridViewFines);
            this.Name = "ManageFineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت جریمه‌ها";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFines;
        private System.Windows.Forms.TextBox txtSearchBorrowId;
        private System.Windows.Forms.Label lblSearchBorrowId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.ComboBox cmbFineAction;
        private System.Windows.Forms.Button btnUpdateFine;
        private System.Windows.Forms.Label lblAmountFine;
    }
}