using System;
using System.Windows.Forms;

namespace BankApp
{
    public partial class TransferBalanceForm : Form
    {
        private Bank bank;

        public TransferBalanceForm(Bank bank)
        {
            InitializeComponent();
            this.bank = bank;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                int senderId = int.Parse(txtSenderId.Text);
                int receiverId = int.Parse(txtReceiverId.Text);
                decimal amount = decimal.Parse(txtAmount.Text);

                var result = bank.Transfer(senderId, amount, receiverId);

                if (result)
                {
                    MessageBox.Show("Balance transferred successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Transfer failed. Please check the details and try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
