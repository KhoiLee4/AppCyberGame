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

namespace AppCyberGameClient.View.Home
{
    public partial class HomeForm : Form
    {
        private Guna2Button _currentButtonGame;
        private CyberGameEntities _entities;
        private List<GAME> _games;
        private FormAction _action;
        public HomeForm()
        {
            InitializeComponent();
            _entities = new CyberGameEntities();
            _games = new List<GAME>();
            _action = new FormAction();
            _currentButtonGame = btnGame1;
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            _games = _entities.GAMEs.ToList();
            int i = 0;
            foreach (var control in pnTopGames.Controls.Cast<Control>().Reverse())
            {
                if (control is Guna2Button button && i < 5)
                {
                    button.BackgroundImage = Image.FromFile(Path.Combine("C:\\Users\\ADMIN\\Desktop\\BTL_PTTKHT\\AppCyberGame\\AppCyberGame\\AppCyberGameClient\\Images\\GameImg", _games[i].HinhAnh));
                    i++;
                }
            }
            lblGameName.Text = _games[_currentButtonGame.TabIndex - 1].TenG;
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButtonGame.Checked = false;
                    _currentButtonGame.Size = new Size(96, 144);
                    button.Size = new Size(144, 216);

                    if (_currentButtonGame.TabIndex > button.TabIndex)
                        _currentButtonGame.Location = new Point(_currentButtonGame.Location.X + 48, _currentButtonGame.Location.Y);
                    else if (_currentButtonGame.TabIndex < button.TabIndex)
                        button.Location = new Point(button.Location.X - 48, button.Location.Y);

                    button.Checked = true;
                    _currentButtonGame = button;
                    lblGameName.Text = _games[button.TabIndex - 1].TenG;
                }
            }
        }

        private void btnGame6_Click(object sender, EventArgs e)
        {
            _action.LoadGames();
        }
    }
}
