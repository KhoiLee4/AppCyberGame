﻿using AppCyberGame.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGame.View.LoginLogout
{
    public partial class RegisterForm : Form
    {
        private FormAction _action;
        public RegisterForm()
        {
            InitializeComponent();
            _action = new FormAction();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            _action.LoadForm3(new LoginForm());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _action.LoadForm3(new RegisterManuallyForm());
        }
    }
}
