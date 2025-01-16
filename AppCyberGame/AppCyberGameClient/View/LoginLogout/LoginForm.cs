using AppCyberGame.Service;
using AppCyberGameClient.Model;
using AppCyberGameClient.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGameClient.View.LoginLogout
{
    public partial class LoginForm : Form
    {
        private FormAction _action;
        private CyberGameEntities _entities;
      
        public LoginForm()
        {
            InitializeComponent();
            _action = new FormAction();
            _entities = new CyberGameEntities();       
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            //_action.LoadForm3(new RegisterForm());
            _action.LoadCreate();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _entities.TAIKHOANs.Where(n => n.TaiKhoan1.Equals(txbUsername.Text)).FirstOrDefault();
            if (user == null)
            {
                return;
            }
            if (!user.MatKhau.Equals(txbPassword.Text))
            {
                return;
            }
            if (Session.CurentCom.TinhTrang == 1 || Session.CurentCom.TinhTrang == -1)
            {
                return;
            }
            Session.CurentUser = user;
            if(Session.CurentCom.MaTK == null)
            {
                Session.CurentCom.MaTK = user.MaTK;
                Session.CurentCom.TinhTrang = 1;
                _entities.MAYs.AddOrUpdate(Session.CurentCom);
                _entities.SaveChanges();
            }
            MainForm.IsLogin = true;
            _action.LoadHome();
        }

        private void lblCreateAccount_MouseHover(object sender, EventArgs e)
        {
            lblCreateAccount.Cursor = Cursors.Hand;
        }

        private void lblForgotPassword_MouseHover(object sender, EventArgs e)
        {
            lblForgotPassword.Cursor = Cursors.Hand;
        }

        private void txbUsername_MouseLeave(object sender, EventArgs e)
        {
            txbUsername.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbUsername_MouseHover(object sender, EventArgs e)
        {
            txbUsername.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbUsername_Leave(object sender, EventArgs e)
        {
            if (txbUsername.Text == string.Empty)
            {
                txbUsername.Text = "Email or Username";
                txbUsername.ForeColor = Color.Silver;
            }
        }

        private void txbUserName_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "Email or Username")
            {
                txbUsername.Text = string.Empty;
                txbUsername.ForeColor = Color.FromArgb(60, 211, 252);
                txbUsername.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbPassword_MouseLeave(object sender, EventArgs e)
        {
            txbPassword.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbPassword_MouseHover(object sender, EventArgs e)
        {
            txbPassword.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == string.Empty)
            {
                txbPassword.Text = "Password";
                txbPassword.PasswordChar = '\0';
                txbPassword.ForeColor = Color.Silver;
            }
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = string.Empty;
                txbPassword.ForeColor = Color.FromArgb(60, 211, 252);
                txbPassword.BorderColor = Color.FromArgb(60, 211, 252);
                txbPassword.PasswordChar = '*';
            }
        }
    }
}
