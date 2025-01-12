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
        public MenuForm()
        {
            InitializeComponent();
            _action = new FormAction();
            _curentButton = btnHome;
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
    }
}
