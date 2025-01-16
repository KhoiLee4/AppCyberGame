using AppCyberGame.Service;
using AppCyberGameClient.Model;
using AppCyberGameClient.Service;
using AppCyberGameClient.View.LoginLogout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGameClient.View
{
    public partial class MainForm : Form
    {
        private FormAction _action;
        private CyberGameEntities _entities;
        public static bool IsLogin = false;
        public MainForm()
        {
            InitializeComponent();
            _action = new FormAction(pnContent1, pnContent2, pnContent3, pnContent4, pnContentOrther, pnAccount);
            _action.LoadForm3(new LoginForm());
            _entities = new CyberGameEntities();
            Session.CurentCom = _entities.MAYs.Where(n => n.SoMay == 63).FirstOrDefault();
            CheckProject.Start();
        }

        private void CheckProject_Tick(object sender, EventArgs e)
        {
            _entities = new CyberGameEntities();
            Session.CurentCom = _entities.MAYs.Where(n => n.SoMay == 63).FirstOrDefault();
            if (Session.CurentCom.TinhTrang == 0 && IsLogin)
            {
                btnLogout_Click(sender, e);
            }
            else
            {
                if (Session.CurentUser != null && Session.CurentCom != null)
                {
                    Session.CurentCom.ThoiGianSD += 0.5;
                    Session.CurentUser.GioChoi -= 0.5;
                    lblTimePlay.Text = Session.CurentUser.GioChoi.ToString();
                    _entities.MAYs.AddOrUpdate(Session.CurentCom);
                    _entities.SaveChanges();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.CurentCom.ThoiGianSD = 0;
            Session.CurentCom.TinhTrang = 0;
            Session.CurentCom.MaTK = null;
            _entities.MAYs.AddOrUpdate(Session.CurentCom);
            _entities.TAIKHOANs.AddOrUpdate(Session.CurentUser);
            _entities.SaveChanges();
            _action.LoadLogin();
        }
    }
}
