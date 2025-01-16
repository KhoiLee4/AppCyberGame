using AppCyberGame.Service;
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

namespace AppCyberGame.View.Admin
{
    public partial class SidebarAdminForm : Form
    {
        private FormAction _action;
        private Guna2Panel _currentPanel;
        public SidebarAdminForm()
        {
            InitializeComponent();
            _action = new FormAction();
            _currentPanel = pnDashboard;
        }

        private void panelClick(Guna2Panel panel)
        {
            if (panel.BackColor == Color.FromArgb(31, 70, 121))
            {
                _currentPanel.BackColor = Color.FromArgb(31, 70, 121);
                panel.BackColor = Color.FromArgb(20, 44, 76);
                _currentPanel = panel;
            }
        }

        private void pnDashboard_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Panel panel)
            {
                panelClick(panel);
                _action.LoadDashboard();
            }

            if (sender is Guna2PictureBox pic)
            {
                panelClick(pic.Parent as Guna2Panel);
                _action.LoadDashboard();
            }

            if (sender is Guna2HtmlLabel label)
            {
                panelClick(label.Parent as Guna2Panel);
                _action.LoadDashboard();
            }
        }

        private void pnShop_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Panel panel)
            {
                panelClick(panel);
                _action.LoadShop();
            }

            if (sender is Guna2PictureBox pic)
            {
                panelClick(pic.Parent as Guna2Panel);
                _action.LoadShop();
            }

            if (sender is Guna2HtmlLabel label)
            {
                panelClick(label.Parent as Guna2Panel);
                _action.LoadShop();
            }
        }

        private void pnOrders_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Panel panel)
            {
                panelClick(panel);
                _action.LoadOrders();
            }

            if (sender is Guna2PictureBox pic)
            {
                panelClick(pic.Parent as Guna2Panel);
                _action.LoadOrders();
            }

            if (sender is Guna2HtmlLabel label)
            {
                panelClick(label.Parent as Guna2Panel);
                _action.LoadOrders();
            }
        }

        private void pnUsers_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Panel panel)
            {
                panelClick(panel);
                _action.LoadUsers();
            }

            if (sender is Guna2PictureBox pic)
            {
                panelClick(pic.Parent as Guna2Panel);
                _action.LoadUsers();
            }

            if (sender is Guna2HtmlLabel label)
            {
                panelClick(label.Parent as Guna2Panel);
                _action.LoadUsers();
            }
        }

        private void pnSetting_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Panel panel)
            {
                panelClick(panel);
                _action.LoadSetting();
            }

            if (sender is Guna2PictureBox pic)
            {
                panelClick(pic.Parent as Guna2Panel);
                _action.LoadSetting();
            }

            if (sender is Guna2HtmlLabel label)
            {
                panelClick(label.Parent as Guna2Panel);
                _action.LoadSetting();
            }
        }
    }
}
