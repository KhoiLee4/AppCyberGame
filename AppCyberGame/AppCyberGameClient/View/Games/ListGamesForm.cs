using AppCyberGameClient.Model;
using AppCyberGameClient.Service;
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

namespace AppCyberGameClient.View.Games
{
    public partial class ListGamesForm : Form
    {
        private string _category;
        private CyberGameEntities _entities;
        private List<GAME> _games;
        private FormAction _action;
        public ListGamesForm(string category = "All")
        {
            InitializeComponent();
            _entities = new CyberGameEntities();
            _games = new List<GAME>();
            _action = new FormAction();
            _category = category;
        }

        private void ListGamesForm_Load(object sender, EventArgs e)
        {
            _games = new List<GAME>();

            if (!_category.Equals("All"))
                _games = _entities.GAMEs.Where(n => n.LoaiG == _category).ToList();
            else
                _games = _entities.GAMEs.ToList();

            foreach (GAME game in _games)
            {
                Guna2Button button = new Guna2Button();

                button.BackgroundImage = Image.FromFile(Path.Combine("C:\\Users\\ADMIN\\Desktop\\BTL_PTTKHT\\AppCyberGame\\AppCyberGame\\AppCyberGameClient\\Images\\GameImg", game.HinhAnh));
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                button.FillColor = System.Drawing.Color.Empty;
                button.Font = new System.Drawing.Font("Segoe UI", 9F);
                button.ForeColor = System.Drawing.Color.White;
                button.Location = new System.Drawing.Point(3, 3);
                button.Name = game.TenG.Replace(" ", "");
                button.Size = new System.Drawing.Size(158, 237);
                button.Click += new System.EventHandler(this.game_Click);

                pnLayout.Controls.Add(button);
            }
        }

        private void game_Click(object sender, EventArgs e)
        {
            if(sender is Guna2Button btn)
            {
                var name = btn.Name;
                _action.LoadDetail(name);
            }
        }
    }
}
