using AppCyberGameClient.Service;
using AppCyberGameClient.View.LoginLogout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public MainForm()
        {
            InitializeComponent();
            _action = new FormAction(pnContent1,pnContent2,pnContent3, pnContent4);
            _action.LoadForm3(new LoginForm());
        }


    }
}
