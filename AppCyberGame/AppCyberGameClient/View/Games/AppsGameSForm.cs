using AppCyberGameClient.Model;
using AppCyberGameClient.Service;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGameClient.View.Games
{
    public partial class AppsGameSForm : Form
    {
        private FormAction _action;
        private CyberGameEntities _entities;
        public AppsGameSForm()
        {
            InitializeComponent();
            _action = new FormAction();
            _entities = new CyberGameEntities();
        }
        private void buttonMouseHover(object sender, EventArgs e)
        {
            if(sender is Guna2Button button)
            {
                button.BackgroundImage = AppCyberGameClient.Properties.Resources.Background;
            }
        }

        private void lblAllApps_Click(object sender, EventArgs e)
        {
            _action.LoadApps();
        }

        private void AppsGameSForm_Load(object sender, EventArgs e)
        {
            var apps = _entities.APPs.ToList();
            int i = 1;
            foreach (var control in this.Controls)
            {
                if(control is Guna2Panel panel)
                {
                    foreach (var controlpn in panel.Controls)
                    {
                        if(controlpn is Guna2HtmlLabel label)
                        {
                            label.Text = apps[i].TenA;
                        }
                        if(controlpn is Guna2CirclePictureBox pic)
                        {
                            pic.Image = Image.FromFile(Path.Combine("C:\\Users\\ADMIN\\Desktop\\BTL_PTTKHT\\AppCyberGame\\AppCyberGame\\AppCyberGameClient\\Images\\AppImg", apps[i].HinhAnh));
                        }
                    }
                    i++;
                }
            }
        }
    }
}
