using AppCyberGame.Service;
using AppCyberGameClient.Model;
using AppCyberGameClient.Service;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGameClient.View
{
    public partial class MenuForm : Form
    {
        private FormAction _action;
        private Guna2Button _curentButton;
        private CyberGameEntities _entities;
        public MenuForm()
        {
            InitializeComponent();
            _action = new FormAction();
            _entities = new CyberGameEntities();
            _curentButton = btnHome;
            var user = _entities.KHACHes.Where(n => n.MaKH == Session.CurentUser.MaKH).FirstOrDefault();
            if (user != null)
            {
                lblUserName.Text = user.TenKH;
                lblTimePlay.Text = Session.CurentUser.GioChoi.ToString();
            }
            CheckCart.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!btnHome.Checked)
            {
                _curentButton.Checked = false;
                btnHome.Checked = true;
                _curentButton = btnHome;
                _action.LoadHome();
            }
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            if (!btnGames.Checked)
            {
                _curentButton.Checked = false;
                btnGames.Checked = true;
                _curentButton = btnGames;
                _action.LoadGames();
            }
        }

        private void btnApps_Click(object sender, EventArgs e)
        {
            if (!btnApps.Checked)
            {
                _curentButton.Checked = false;
                btnApps.Checked = true;
                _curentButton = btnApps;
                _action.LoadApps();
            }
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            if (!btnShop.Checked)
            {
                _curentButton.Checked = false;
                btnShop.Checked = true;
                _curentButton = btnShop;
                _action.LoadShop();
            }
        }

        private void btnShowPnAccount_Click(object sender, EventArgs e)
        {
            _action.LoadAccount();
        }

        private void CheckCart_Tick(object sender, EventArgs e)
        {
            var wait = _entities.HOADONs.Where(n=>n.IsCheck == false).FirstOrDefault(n => n.MaTK == Session.CurentUser.MaTK);
            if (wait != null)
            {
                btnCheck.Visible = true;
            }
            else
            {
                btnCheck.Visible = false;
            }
            lblTimePlay.Text = Session.CurentUser.GioChoi.ToString();
        }
    }
}
