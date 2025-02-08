namespace Library
{
    partial class ManageBorrowsForm
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
            this.dataGridViewBorrows = new System.Windows.Forms.DataGridView();
            this.txtSearchBorrowId = new System.Windows.Forms.TextBox();
            this.lblSearchBorrowId = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReturnBorrow = new System.Windows.Forms.Button();
            this.btnExtendBorrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrows)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrows
            // 
            this.dataGridViewBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrows.Location = new System.Drawing.Point(10, 43);
            this.dataGridViewBorrows.Name = "dataGridViewBorrows";
            this.dataGridViewBorrows.ReadOnly = true;
            this.dataGridViewBorrows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewBorrows.Size = new System.Drawing.Size(651, 303);
            this.dataGridViewBorrows.TabIndex = 0;
            // 
            // txtSearchBorrowId
            // 
            this.txtSearchBorrowId.Location = new System.Drawing.Point(531, 13);
            this.txtSearchBorrowId.Name = "txtSearchBorrowId";
            this.txtSearchBorrowId.Size = new System.Drawing.Size(86, 20);
            this.txtSearchBorrowId.TabIndex = 1;
            // 
            // lblSearchBorrowId
            // 
            this.lblSearchBorrowId.AutoSize = true;
            this.lblSearchBorrowId.Location = new System.Drawing.Point(621, 17);
            this.lblSearchBorrowId.Name = "lblSearchBorrowId";
            this.lblSearchBorrowId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchBorrowId.Size = new System.Drawing.Size(49, 13);
            this.lblSearchBorrowId.TabIndex = 2;
            this.lblSearchBorrowId.Text = "کد امانت:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(454, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 24);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReturnBorrow
            // 
            this.btnReturnBorrow.Location = new System.Drawing.Point(389, 362);
            this.btnReturnBorrow.Name = "btnReturnBorrow";
            this.btnReturnBorrow.Size = new System.Drawing.Size(129, 26);
            this.btnReturnBorrow.TabIndex = 4;
            this.btnReturnBorrow.Text = "بازگرداندن امانت";
            this.btnReturnBorrow.UseVisualStyleBackColor = true;
            this.btnReturnBorrow.Visible = false;
            // 
            // btnExtendBorrow
            // 
            this.btnExtendBorrow.Location = new System.Drawing.Point(526, 362);
            this.btnExtendBorrow.Name = "btnExtendBorrow";
            this.btnExtendBorrow.Size = new System.Drawing.Size(129, 26);
            this.btnExtendBorrow.TabIndex = 5;
            this.btnExtendBorrow.Text = "تمدید امانت";
            this.btnExtendBorrow.UseVisualStyleBackColor = true;
            this.btnExtendBorrow.Visible = false;
            // 
            // ManageBorrowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 400);
            this.Controls.Add(this.btnExtendBorrow);
            this.Controls.Add(this.btnReturnBorrow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchBorrowId);
            this.Controls.Add(this.txtSearchBorrowId);
            this.Controls.Add(this.dataGridViewBorrows);
            this.Name = "ManageBorrowsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت امانات";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBorrows;
        private System.Windows.Forms.TextBox txtSearchBorrowId;
        private System.Windows.Forms.Label lblSearchBorrowId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReturnBorrow;
        private System.Windows.Forms.Button btnExtendBorrow;
    }
}