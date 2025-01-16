using AppCyberGameClient.Model;
using AppCyberGameClient.Service;
using AppCyberGameClient.View.Games;
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

namespace AppCyberGameClient.View.Apps
{
    public partial class SidebarAppsForm : Form
    {
        private Guna2Button _currentButton;
        private CyberGameEntities _entities;
        private FormAction _action;
        public SidebarAppsForm()
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

                    _action.LoadForm3(new AppsForm());
                }
            }
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new AppsForm("Tools"));
                }
            }
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new AppsForm("Social"));
                }
            }
        }

        private void btnWebBrowsers_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new AppsForm("Web Browser"));
                }
            }
        }
    }
}
