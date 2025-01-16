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

namespace AppCyberGameClient.View.Apps
{
    public partial class AppsForm : Form
    {
        private string _category;
        public AppsForm(string category = "All")
        {
            InitializeComponent();
            _category = category;
        }

        private void AppsForm_Load(object sender, EventArgs e)
        {
            // Load List Apps
            Form AppForm = new ListAppsForm(_category);
            AppForm.TopLevel = false;
            AppForm.FormBorderStyle = FormBorderStyle.None;
            AppForm.AutoScaleMode = AutoScaleMode.Dpi;
            pnContentApp.Controls.Add(AppForm);
            pnContentApp.Tag = AppForm;
            AppForm.Show();
            AppForm.BringToFront();
        }
    }
}
