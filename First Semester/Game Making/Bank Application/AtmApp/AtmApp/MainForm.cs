using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AtmApp
{
    public partial class MainForm : Form
    {
        private Bank bank;

        public MainForm()
        {
            InitializeComponent();
            bank = new Bank();
            UpdateUserList();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    string username = loginForm.Username;
                    string password = loginForm.Password;

                    if (username == "boss" && password == "1111")
                    {
                        string name = txtName.Text;
                        if (decimal.TryParse(txtInitialBalance.Text, out decimal balance))
                        {
                            bank.CreateUser(name, balance);
                            MessageBox.Show("کاربر با موفقیت افزوده شد");
                            UpdateUserList();
                            txtName.Clear();
                            txtInitialBalance.Clear();
                        }
                        else
                        {
                            MessageBox.Show("موجودی حساب اشتباه است");
                        }
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا رمز را اشتباه وارد کرده‌اید");
                    }
                }
            }
        }

        private void btnIncreaseBalance_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUserIdIncrease.Text, out int userId) &&
                decimal.TryParse(txtIncreaseAmount.Text, out decimal amount))
            {
                bank.Increase(userId, amount);
                MessageBox.Show("افزایش موجودی موفقیت آمیز بود");
                UpdateUserList();
                txtUserIdIncrease.Clear();
                txtIncreaseAmount.Clear();
            }
            else
            {
                MessageBox.Show("این امکان وجود ندارد");
            }
        }

        private void btnDecreaseBalance_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUserIdDecrease.Text, out int userId) &&
                decimal.TryParse(txtDecreaseAmount.Text, out decimal amount))
            {
                bank.Decrease(userId, amount);
                MessageBox.Show("برداشت از حساب موفقیت آمیز بود");
                UpdateUserList();
                txtUserIdDecrease.Clear();
                txtDecreaseAmount.Clear();
            }
            else
            {
                MessageBox.Show("ورودی اشتباه است");
            }
        }

        private void btnTransferBalance_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSenderId.Text, out int senderId) &&
                int.TryParse(txtReceiverId.Text, out int receiverId) &&
                decimal.TryParse(txtTransferAmount.Text, out decimal amount))
            {
                bank.Transfer(senderId, amount, receiverId);
                MessageBox.Show("مبلغ موردنظر واریز گردید");
                UpdateUserList();
                txtSenderId.Clear();
                txtReceiverId.Clear();
                txtTransferAmount.Clear();
            }
            else
            {
                MessageBox.Show("ورودی اشتباه است");
            }
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

    public class Bank
    {
        private List<User> users;
        private int nextId;

        public Bank()
        {
            users = new List<User>();
            nextId = 1;
        }

        public void CreateUser(string name, decimal initialBalance)
        {
            users.Add(new User { Id = nextId++, Name = name, Balance = initialBalance });
        }

        public void Increase(int userId, decimal amount)
        {
            var user = GetUserById(userId);
            if (user != null)
            {
                user.Balance += amount;
            }
        }

        public void Decrease(int userId, decimal amount)
        {
            var user = GetUserById(userId);
            if (user != null)
            {
                user.Balance -= amount;
            }
        }

        public void Transfer(int senderId, decimal amount, int receiverId)
        {
            var sender = GetUserById(senderId);
            var receiver = GetUserById(receiverId);
            if (sender != null && receiver != null)
            {
                sender.Balance -= amount;
                receiver.Balance += amount;
            }
        }

        public List<User> GetUsers()
        {
            return new List<User>(users);
        }

        private User GetUserById(int userId)
        {
            return users.Find(user => user.Id == userId);
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
