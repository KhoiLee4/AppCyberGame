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
    public partial class RegisterManuallyForm : Form
    {
        private FormAction _action;
        public RegisterManuallyForm()
        {
            InitializeComponent();
            _action = new FormAction();
        }

        private void lblAsk_Click(object sender, EventArgs e)
        {
            _action.LoadForm3(new RegisterForm());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _action.LoadForm3(new LoginForm());
        }
    }
}
