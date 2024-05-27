using System;
using System.Windows.Forms;

namespace BankApp
{
    public partial class DecreaseBalanceForm : Form
    {
        private Bank bank;

        public DecreaseBalanceForm(Bank bank)
        {
            InitializeComponent();
            this.bank = bank;
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = int.Parse(txtUserId.Text);
                decimal amount = decimal.Parse(txtAmount.Text);

                var result = bank.Decrease(userId, amount);

                if (result)
                {
                    MessageBox.Show("Balance decreased successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Decrease failed. Please check the details and try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
