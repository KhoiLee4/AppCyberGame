using AppCyberGameClient.Model;
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
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using AppCyberGame.Service;
using AppCyberGameClient.Service;

namespace AppCyberGameClient.View.Shop
{
    public partial class CartForm : Form
    {
        public static bool IsAdd = false;
        private CyberGameEntities _entities;
        private FormAction _action;
        public CartForm()
        {
            InitializeComponent();
            _entities = new CyberGameEntities();
            _action = new FormAction();
            CheckCart.Start();
        }

        private void CheckCart_Tick(object sender, EventArgs e)
        {
            if (ShopForm._giohang.Count() > 0)
            {
                pnContentCart.Visible = true;
                if (!IsAdd)
                {
                    AddCart(ShopForm._giohang[ShopForm._giohang.Count() - 1]);
                }
            }
            else
            {
                pnContentCart.Visible = false;
            }
        }
        private void AddCart(DICHVU dv)
        {
            Guna2Panel panel = new Guna2Panel();
            Guna2HtmlLabel labelName = new Guna2HtmlLabel();
            Guna2HtmlLabel labelPrice = new Guna2HtmlLabel();
            Guna2NumericUpDown nud = new Guna2NumericUpDown();
            Guna2Panel line = new Guna2Panel();

            panel.BackColor = System.Drawing.Color.Transparent;
            panel.Controls.Add(labelName);
            panel.Controls.Add(labelPrice);
            panel.Controls.Add(nud);
            panel.Controls.Add(line);
            panel.Location = new System.Drawing.Point(0, 60 + 95 * (ShopForm._giohang.Count() - 1));
            panel.Name = "pn" + dv.TenDV.Replace(" ", "");
            panel.Size = new System.Drawing.Size(270, 95);
            panel.TabIndex = 20;

            labelName.BackColor = System.Drawing.Color.Transparent;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelName.ForeColor = System.Drawing.Color.White;
            labelName.Location = new System.Drawing.Point(20, 5);
            labelName.Name = "lbl" + dv.TenDV.Replace(" ", "");
            labelName.Size = new System.Drawing.Size(87, 22);
            labelName.TabIndex = 16;
            labelName.Text = dv.TenDV;
            labelName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

            labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            labelPrice.AutoSize = false;
            labelPrice.BackColor = System.Drawing.Color.Transparent;
            labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPrice.ForeColor = System.Drawing.Color.White;
            labelPrice.Location = new System.Drawing.Point(96, 51);
            labelPrice.Name = "lblPrice" + dv.TenDV.Replace(" ", "");
            labelPrice.Size = new System.Drawing.Size(154, 22);
            labelPrice.TabIndex = 16;
            labelPrice.Text = $"{dv.GiaDV}Đ";
            labelPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;

            nud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            nud.BackColor = System.Drawing.Color.Transparent;
            nud.BorderColor = System.Drawing.Color.Transparent;
            nud.BorderRadius = 10;
            nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            nud.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(226)))), ((int)(((byte)(253)))));
            nud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nud.Location = new System.Drawing.Point(20, 42);
            nud.Name = "nud" + dv.TenDV.Replace(" ", "");
            nud.Size = new System.Drawing.Size(70, 39);
            nud.TabIndex = 17;
            nud.Value = 1;
            nud.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            nud.ValueChanged += new System.EventHandler(this.nudProduct_ValueChanged);

            line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            line.BorderColor = System.Drawing.Color.Gray;
            line.BorderThickness = 1;
            line.FillColor = System.Drawing.Color.Gray;
            line.ForeColor = System.Drawing.Color.DarkGray;
            line.Location = new System.Drawing.Point(0, 89);
            line.Name = "pnLine" + dv.TenDV.Replace(" ", "");
            line.Size = new System.Drawing.Size(270, 1);
            line.TabIndex = 14;

            pnContentCart.Controls.Add(panel);
            pnContentCart.Size = new Size(pnContentCart.Size.Width, 340 + 95 * (ShopForm._giohang.Count() - 1));
            lblSubTotal1.Text = $"{(float)dv.GiaDV * (float)nud.Value + float.Parse(lblSubTotal1.Text.Trim('Đ'))}Đ";
            lblTotal1.Text = $"{decimal.Parse(lblSubTotal1.Text.Trim('Đ')) + decimal.Parse(lblTaxes1.Text.Trim('Đ'))}Đ";

            IsAdd = true;
        }

        private void nudProduct_ValueChanged(object sender, EventArgs e)
        {
            if (sender is Guna2NumericUpDown nud)
            {
                decimal giaDV = 0;
                foreach (var item in nud.Parent.Controls)
                {
                    if (item is Guna2HtmlLabel lb && lb.Name.Contains("lblPrice"))
                    {
                        giaDV = decimal.Parse(lb.Text.Trim('Đ'));
                    }
                }

                lblSubTotal1.Text = $"{giaDV * nud.Value + decimal.Parse(lblSubTotal1.Text.Trim('Đ'))}Đ";
                lblTotal1.Text = $"{decimal.Parse(lblSubTotal1.Text.Trim('Đ')) + decimal.Parse(lblTaxes1.Text.Trim('Đ'))}Đ";
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            pnPhuongThucGD.Visible = true;
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            var hoadon = new HOADON
            {
                MaHD = Guid.NewGuid().ToString(),
                NgayGD = DateTime.Now,
                PhuongThucGD = "TienMat",
                TongTien = int.Parse(lblTotal1.Text.Trim('Đ')),
                MaTK = Session.CurentUser.MaTK,
                MaQTV = null
            };
            if (sender is Guna2Button btn)
            {
                if (btn.Text.Equals("QR"))
                {
                    hoadon.PhuongThucGD = "QR";
                }
            }
            _entities.HOADONs.Add(hoadon);
            _entities.SaveChanges();

            foreach (var item in ShopForm._giohang)
            {
                var chitiet = new CHITIETHOADON
                {
                    MaHD = hoadon.MaHD,
                    MaDV = item.MaDV,
                    SoLuong = 1,
                    GhiChu = " "
                };
                _entities.CHITIETHOADONs.Add(chitiet);
            }
            _entities.SaveChanges();

            ShopForm._giohang = new List<DICHVU>();
            _action.LoadForm4(new CartForm());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnPhuongThucGD.Visible = false;
        }
    }
}
