using AppCyberGameClient.Model;
using AppCyberGameClient.Service;
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
    public partial class DetailForm : Form
    {
        private GAME _game;
        private CyberGameEntities _entities;
        private FormAction _action;
        public DetailForm(string gamename)
        {
            InitializeComponent();
            _entities = new CyberGameEntities();
            _action = new FormAction();
            _game = _entities.GAMEs.Where(n => n.TenG.Replace(" ", "") == gamename).FirstOrDefault();
            if (_game != null)
            {
                lblGameName.Text = _game.TenG;
                this.BackgroundImage = Image.FromFile(Path.Combine("C:\\Users\\ADMIN\\Desktop\\BTL_PTTKHT\\AppCyberGame\\AppCyberGame\\AppCyberGameClient\\Images\\GameImg", _game.HinhAnh));
            }
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _action.LoadGames();
        }
    }
}
