using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGameClient.View.Games
{
    public partial class GamesForm : Form
    {
        private string _category;
        public GamesForm(string category = "All")
        {
            InitializeComponent();
            _category = category;
        }

        private void GamesForm_Load(object sender, EventArgs e)
        {
            // Load Apps
            Form AppForm = new AppsGameSForm();
            AppForm.TopLevel = false;
            AppForm.FormBorderStyle = FormBorderStyle.None;
            AppForm.AutoScaleMode = AutoScaleMode.Dpi;
            pnApps.Controls.Add(AppForm);
            pnApps.Tag = AppForm;
            AppForm.Show();
            AppForm.BringToFront();

            // Load List Game
            Form GameForm = new ListGamesForm(_category);
            GameForm.TopLevel = false;
            GameForm.FormBorderStyle = FormBorderStyle.None;
            GameForm.AutoScaleMode = AutoScaleMode.Dpi;
            pnContentGame.Controls.Add(GameForm);
            pnContentGame.Tag = GameForm;
            GameForm.Show();
            GameForm.BringToFront();
        }
    }
}
