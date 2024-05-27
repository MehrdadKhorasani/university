using System;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form1 : Form
    {
        private Bank bank;

        public Form1()
        {
            InitializeComponent();
            bank = new Bank();

            btnIncreaseBalance.Click += BtnIncreaseBalance_Click;
            btnDecreaseBalance.Click += BtnDecreaseBalance_Click;
            btnTransferBalance.Click += BtnTransferBalance_Click;
            btnAddUser.Click += BtnAddUser_Click;

            UpdateUserList();
        }

        private void BtnIncreaseBalance_Click(object? sender, EventArgs e)
        {
            IncreaseBalanceForm increaseBalanceForm = new IncreaseBalanceForm(bank);
            increaseBalanceForm.ShowDialog();
            UpdateUserList(); 
        }

        private void BtnDecreaseBalance_Click(object? sender, EventArgs e)
        {
            DecreaseBalanceForm decreaseBalanceForm = new DecreaseBalanceForm(bank);
            decreaseBalanceForm.ShowDialog();
            UpdateUserList();
        }

        private void BtnTransferBalance_Click(object? sender, EventArgs e)
        {
            TransferBalanceForm transferBalanceForm = new TransferBalanceForm(bank);
            transferBalanceForm.ShowDialog();
            UpdateUserList();
        }

        private void BtnAddUser_Click(object? sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(bank, this);
            addUserForm.ShowDialog();
            UpdateUserList();
        }

        public void UpdateUserList()
        {
            lstUsers.Items.Clear();
            foreach (var user in bank.GetUsers())
            {
                lstUsers.Items.Add($"ID: {user.Id}, Name: {user.Name}, Balance: {user.Balance}");
            }
        }
    }
}
