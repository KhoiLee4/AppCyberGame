using AppCyberGameClient.Model;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGameClient.View.Shop
{
    public partial class GamePassesForm : Form
    {
        private string _category;
        private CyberGameEntities _entities;
        //private List<DICHVU> shop
        public GamePassesForm(string category = "All")
        {
            InitializeComponent();
            _category = category;
            _entities = new CyberGameEntities();
        }

        private void GamePassesForm_Load(object sender, EventArgs e)
        {
            List<DICHVU> shop = _entities.DICHVUs.Where(n => n.LoaiDV == _category).ToList();

            foreach (var item in shop)
            {
                Guna2Panel panel = new Guna2Panel();
                Guna2HtmlLabel labelName = new Guna2HtmlLabel();
                Guna2HtmlLabel labelPrice = new Guna2HtmlLabel();
                Guna2Button button = new Guna2Button();
                Guna2PictureBox pic = new Guna2PictureBox();

                panel.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Background;
                panel.Controls.Add(labelName);
                panel.Controls.Add(labelPrice);
                panel.Controls.Add(button);
                panel.Controls.Add(pic);
                panel.Location = new System.Drawing.Point(3, 3);
                panel.Name = "pn" + item.TenDV.Replace(" ", "");
                panel.Size = new System.Drawing.Size(226, 340);
                panel.TabIndex = 0;
                panel.Visible = true;

                labelName.BackColor = System.Drawing.Color.Transparent;
                labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelName.ForeColor = System.Drawing.Color.White;
                labelName.Location = new System.Drawing.Point(15, 222);
                labelName.Name = "lbl" + item.TenDV.Replace(" ", "");
                labelName.Size = new System.Drawing.Size(45, 22);
                labelName.TabIndex = 5;
                labelName.Text = item.TenDV;

                labelPrice.BackColor = System.Drawing.Color.Transparent;
                labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelPrice.ForeColor = System.Drawing.Color.White;
                labelPrice.Location = new System.Drawing.Point(15, 250);
                labelPrice.Name = "lbl" + item.TenDV.Replace(" ", "");
                labelPrice.Size = new System.Drawing.Size(35, 31);
                labelPrice.TabIndex = 4;
                labelPrice.Text = $"{item.GiaDV}Đ";

                button.BorderRadius = 10;
                button.BorderThickness = 1;
                button.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
                button.CheckedState.FillColor = System.Drawing.Color.Transparent;
                button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
                button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.Color.White;
                button.Location = new System.Drawing.Point(15, 291);
                button.Name = "btn" + item.TenDV.Replace(" ", "");
                button.Size = new System.Drawing.Size(196, 30);
                button.TabIndex = 3;
                button.Text = "Add to cart";
                button.Click += new System.EventHandler(this.button_Click);

                pic.BackColor = System.Drawing.Color.Transparent;
                pic.Image = Image.FromFile(Path.Combine("C:\\Users\\ADMIN\\Desktop\\BTL_PTTKHT\\AppCyberGame\\AppCyberGame\\AppCyberGameClient\\Images\\ShopImg", item.HinhAnh));
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.BorderRadius = 30;
                pic.ImageRotate = 0F;
                pic.Location = new System.Drawing.Point(10, 10);
                pic.Name = "pic" + item.TenDV.Replace(" ", "");
                pic.Size = new System.Drawing.Size(206, 206);
                pic.TabIndex = 0;
                pic.TabStop = false;

                Guna2Elipse elipse = new Guna2Elipse();

                elipse.BorderRadius = 60;
                elipse.TargetControl = panel;

                pnLayout.Controls.Add(panel);
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    button.Checked = true;
                    var dv = _entities.DICHVUs.Where(n => button.Name.Equals("btn" + n.TenDV.Replace(" ", ""))).FirstOrDefault();
                    if (dv != null)
                    {
                        ShopForm._giohang.Add(dv);
                        CartForm.IsAdd = false;
                    }
                }
            }
        }

    }
}
