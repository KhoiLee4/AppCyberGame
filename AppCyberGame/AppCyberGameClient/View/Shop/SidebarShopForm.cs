using AppCyberGameClient.Model;
using AppCyberGameClient.Service;
using AppCyberGameClient.View.Apps;
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

namespace AppCyberGameClient.View.Shop
{
    public partial class SidebarShopForm : Form
    {
        private Guna2Button _currentButton;
        private CyberGameEntities _entities;
        private FormAction _action;
        public SidebarShopForm()
        {
            InitializeComponent();
            _entities = new CyberGameEntities();
            _currentButton = btnAll;
            _action = new FormAction();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new ShopForm());
                }
            }
        }

        private void btnGamePasses_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new ShopForm("Goi"));
                }
            }
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new ShopForm("DoUong"));
                }
            }
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new ShopForm("DoAn"));
                }
            }
        }
    }
}
