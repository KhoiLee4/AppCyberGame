using AppCyberGameClient.Model;
using AppCyberGameClient.Service;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGameClient.View.Games
{
    public partial class SidebarGamesForm : Form
    {
        private Guna2Button _currentButton;
        private CyberGameEntities _entities;
        private FormAction _action;
        public SidebarGamesForm()
        {
            InitializeComponent();
            _entities = new CyberGameEntities();
            _currentButton = btnAll;
            _action = new FormAction();
        }

        private void SidebarGamesForm_Load(object sender, EventArgs e)
        {
            var category = _entities.GAMEs.Select(n=>n.LoaiG).ToList();
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

                    _action.LoadForm3(new GamesForm());
                }
            }
        }

        private void btnBattleRoyale_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new GamesForm("Battle Royale"));
                }
            }
        }

        private void btnMOBA_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new GamesForm("MOBA"));
                }
            }
        }

        private void btnActionRPG_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new GamesForm("Action RPG"));
                }
            }
        }

        private void btnParty_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new GamesForm("Party"));
                }
            }
        }

        private void btnFPS_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new GamesForm("FPS"));
                }
            }
        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _action.LoadForm3(new GamesForm("Sports"));
                }
            }
        }
    }
}
