namespace BankApp
{
    partial class TransferBalanceForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSenderId;
        private System.Windows.Forms.TextBox txtReceiverId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTransfer;

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
            this.txtSenderId = new System.Windows.Forms.TextBox();
            this.txtReceiverId = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSenderId
            // 
            this.txtSenderId.Location = new System.Drawing.Point(12, 12);
            this.txtSenderId.Name = "txtSenderId";
            this.txtSenderId.PlaceholderText = "Sender ID";
            this.txtSenderId.Size = new System.Drawing.Size(260, 23);
            this.txtSenderId.TabIndex = 0;
            // 
            // txtReceiverId
            // 
            this.txtReceiverId.Location = new System.Drawing.Point(12, 41);
            this.txtReceiverId.Name = "txtReceiverId";
            this.txtReceiverId.PlaceholderText = "Receiver ID";
            this.txtReceiverId.Size = new System.Drawing.Size(260, 23);
            this.txtReceiverId.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(12, 70);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "Amount";
            this.txtAmount.Size = new System.Drawing.Size(260, 23);
            this.txtAmount.TabIndex = 2;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(12, 99);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(260, 23);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // TransferBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtReceiverId);
            this.Controls.Add(this.txtSenderId);
            this.Name = "TransferBalanceForm";
            this.Text = "Transfer Balance";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
