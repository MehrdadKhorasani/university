using System;
using System.Windows.Forms;

namespace BankApp
{
    public partial class IncreaseBalanceForm : Form
    {
        private Bank bank;

        public IncreaseBalanceForm(Bank bank)
        {
            InitializeComponent();
            this.bank = bank;
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = int.Parse(txtUserId.Text);
                decimal amount = decimal.Parse(txtAmount.Text);

                var result = bank.Increase(userId, amount);

                if (result)
                {
                    MessageBox.Show("Balance increased successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Increase failed. Please check the details and try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
