using System;
using System.Windows.Forms;

namespace AtmApp
{
    public partial class LoginForm : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            Password = txtPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
