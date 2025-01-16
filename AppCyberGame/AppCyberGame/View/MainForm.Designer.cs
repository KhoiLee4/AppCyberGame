namespace AppCyberGame.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnContent3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContent1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContent2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContent4 = new Guna.UI2.WinForms.Guna2Panel();
            this.CheckProject = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnContent3
            // 
            this.pnContent3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnContent3.BackColor = System.Drawing.Color.Transparent;
            this.pnContent3.Location = new System.Drawing.Point(180, 0);
            this.pnContent3.Name = "pnContent3";
            this.pnContent3.Size = new System.Drawing.Size(600, 540);
            this.pnContent3.TabIndex = 1;
            // 
            // pnContent1
            // 
            this.pnContent1.BackColor = System.Drawing.Color.Transparent;
            this.pnContent1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContent1.Location = new System.Drawing.Point(0, 0);
            this.pnContent1.Name = "pnContent1";
            this.pnContent1.Size = new System.Drawing.Size(960, 80);
            this.pnContent1.TabIndex = 2;
            this.pnContent1.Visible = false;
            // 
            // pnContent2
            // 
            this.pnContent2.BackColor = System.Drawing.Color.Transparent;
            this.pnContent2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContent2.Location = new System.Drawing.Point(0, 80);
            this.pnContent2.Name = "pnContent2";
            this.pnContent2.Size = new System.Drawing.Size(100, 460);
            this.pnContent2.TabIndex = 3;
            this.pnContent2.Visible = false;
            // 
            // pnContent4
            // 
            this.pnContent4.BackColor = System.Drawing.Color.Transparent;
            this.pnContent4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnContent4.Location = new System.Drawing.Point(610, 80);
            this.pnContent4.Name = "pnContent4";
            this.pnContent4.Size = new System.Drawing.Size(350, 460);
            this.pnContent4.TabIndex = 4;
            this.pnContent4.Visible = false;
            // 
            // CheckProject
            // 
            this.CheckProject.Interval = 500;
            this.CheckProject.Tick += new System.EventHandler(this.CheckProject_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(44)))), ((int)(((byte)(76)))));
            this.BackgroundImage = global::AppCyberGame.Properties.Resources.Logo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.pnContent3);
            this.Controls.Add(this.pnContent4);
            this.Controls.Add(this.pnContent2);
            this.Controls.Add(this.pnContent1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnContent3;
        private Guna.UI2.WinForms.Guna2Panel pnContent1;
        private Guna.UI2.WinForms.Guna2Panel pnContent2;
        private Guna.UI2.WinForms.Guna2Panel pnContent4;
        private System.Windows.Forms.Timer CheckProject;
    }
}