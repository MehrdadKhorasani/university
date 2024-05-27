namespace BankApp
{
    partial class IncreaseBalanceForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnIncrease;

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
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(12, 12);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PlaceholderText = "User ID";
            this.txtUserId.Size = new System.Drawing.Size(260, 23);
            this.txtUserId.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(12, 41);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "Amount";
            this.txtAmount.Size = new System.Drawing.Size(260, 23);
            this.txtAmount.TabIndex = 1;
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(12, 70);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(260, 23);
            this.btnIncrease.TabIndex = 2;
            this.btnIncrease.Text = "Increase";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // IncreaseBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 104);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtUserId);
            this.Name = "IncreaseBalanceForm";
            this.Text = "Increase Balance";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
