using System;
using System.Windows.Forms;

namespace BankApp
{
    public partial class AddUserForm : Form
    {
        private Bank bank;
        private Form1 mainForm;

        public AddUserForm(Bank bank, Form1 mainForm)
        {
            InitializeComponent();
            this.bank = bank;
            this.mainForm = mainForm;
            btnAuthenticate.Click += btnAuthenticate_Click;
            btnAddUser.Click += btnAddUser_Click;
        }

        private void btnAuthenticate_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                pnlAuthentication.Visible = false;
                pnlAddUser.Visible = true;
            }
            else
            {
                MessageBox.Show("Authentication failed. Please try again.");
            }
        }

        private void btnAddUser_Click(object? sender, EventArgs e)
        {
            string name = txtName.Text;
            if (decimal.TryParse(txtBalance.Text, out decimal balance))
            {
                bank.CreateUser(name, balance);
                MessageBox.Show("User created successfully!");
                mainForm.UpdateUserList();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid balance input!");
            }
        }
    }
}
