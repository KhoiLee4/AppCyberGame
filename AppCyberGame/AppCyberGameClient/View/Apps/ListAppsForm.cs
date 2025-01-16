using AppCyberGameClient.Model;
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

namespace AppCyberGameClient.View.Apps
{
    public partial class ListAppsForm : Form
    {
        private string _category;
        private CyberGameEntities _entities;
        public ListAppsForm(string category = "All")
        {
            InitializeComponent();
            _category = category;
            _entities = new CyberGameEntities();
        }

        private void pnApp1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com.vn/");
        }

        private void ListAppsForm_Load(object sender, EventArgs e)
        {
            List<APP> apps = new List<APP>();
            if (!_category.Equals("All"))
                apps = _entities.APPs.Where(n => n.LoaiA == _category).ToList();
            else
                apps = _entities.APPs.ToList();

            foreach (APP app in apps)
            {
                Guna2Panel panel = new Guna2Panel();
                Guna2HtmlLabel label = new Guna2HtmlLabel();
                Guna2CirclePictureBox pic  = new Guna2CirclePictureBox();

                panel.BackColor = System.Drawing.Color.Transparent;
                panel.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Background;
                panel.Controls.Add(label);
                panel.Controls.Add(pic);
                panel.Location = new System.Drawing.Point(3, 3);
                panel.Name = "pn" + app.TenA.Replace(" ", "");
                panel.Size = new System.Drawing.Size(285, 160);
                panel.Visible = true;
                //panel.Click += new System.EventHandler(this.pnApp1_Click);


                label.AutoSize = false;
                label.BackColor = System.Drawing.Color.Transparent;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.ForeColor = System.Drawing.Color.White;
                label.Location = new System.Drawing.Point(92, 110);
                label.Name = "lbl" + app.TenA.Replace(" ", "");
                label.Size = new System.Drawing.Size(100, 30);
                label.TabIndex = 1;
                label.Text = "Title";
                label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                

                pic.ImageRotate = 0F;
                pic.Image = Image.FromFile(Path.Combine("C:\\Users\\ADMIN\\Desktop\\BTL_PTTKHT\\AppCyberGame\\AppCyberGame\\AppCyberGameClient\\Images\\AppImg", app.HinhAnh));
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Location = new System.Drawing.Point(107, 20);
                pic.Name = "pic" + app.TenA.Replace(" ", "");
                pic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
                pic.Size = new System.Drawing.Size(70, 70);
                pic.TabIndex = 0;
                pic.TabStop = false;
                
                Guna2Elipse elipse = new Guna2Elipse();

                elipse.BorderRadius = 30;
                elipse.TargetControl = panel;

                pnLayout.Controls.Add(panel);
            }

        }
    }
}
