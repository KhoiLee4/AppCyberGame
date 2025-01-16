using AppCyberGameClient.Model;
using AppCyberGameClient.View.Games;
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
    public partial class ShopForm : Form
    {
        private string _category;
        public static List<DICHVU> _giohang = new List<DICHVU>();
        public ShopForm(string category = "All")
        {
            InitializeComponent();
            _category = category; 

        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            // Load Game passes
            Form GamePassForm = new GamePassesForm("Goi");
            GamePassForm.TopLevel = false;
            GamePassForm.FormBorderStyle = FormBorderStyle.None;
            GamePassForm.AutoScaleMode = AutoScaleMode.Dpi;
            pnContentGamePasses.Controls.Add(GamePassForm);
            pnContentGamePasses.Tag = GamePassForm;
            GamePassForm.Show();
            GamePassForm.BringToFront();

            // Load Game passes
            Form ListForm = new ListShopForm(_category);
            ListForm.TopLevel = false;
            ListForm.FormBorderStyle = FormBorderStyle.None;
            ListForm.AutoScaleMode = AutoScaleMode.Dpi;
            pnContentFoodDrink.Controls.Add(ListForm);
            pnContentFoodDrink.Tag = ListForm;
            ListForm.Show();
            ListForm.BringToFront();
        }
    }
}
