﻿using AppCyberGame.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGame.View
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            lblUsername.Text = Session.CurentUser.TenQTV.ToString();
        }
    }
}
