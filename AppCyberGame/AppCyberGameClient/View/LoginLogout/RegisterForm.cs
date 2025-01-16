using AppCyberGameClient.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGameClient.View.LoginLogout
{
    public partial class RegisterForm : Form
    {
        private FormAction _action;
        public RegisterForm()
        {
            InitializeComponent();
            _action = new FormAction();
            this.Dock = DockStyle.Fill;
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            //_action.LoadForm3(new LoginForm());
            _action.LoadLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _action.LoadForm3(new RegisterManuallyForm());
        }

        private void lblLogin_MouseHover(object sender, EventArgs e)
        {
            lblLogin.Cursor = Cursors.Hand;
        }
    }
}
