namespace AppCyberGameClient.View
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
            this.pnContentOrther = new Guna.UI2.WinForms.Guna2Panel();
            this.pnAccount = new Guna.UI2.WinForms.Guna2Panel();
            this.pnLine = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.lblTimePlay = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSoMay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.ElipseAcount = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnAccount.SuspendLayout();
            this.pnFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContent3
            // 
            this.pnContent3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnContent3.BackColor = System.Drawing.Color.IndianRed;
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
            this.pnContent1.Size = new System.Drawing.Size(960, 150);
            this.pnContent1.TabIndex = 2;
            this.pnContent1.Visible = false;
            // 
            // pnContent2
            // 
            this.pnContent2.BackColor = System.Drawing.Color.Transparent;
            this.pnContent2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContent2.Location = new System.Drawing.Point(0, 150);
            this.pnContent2.Name = "pnContent2";
            this.pnContent2.Size = new System.Drawing.Size(300, 390);
            this.pnContent2.TabIndex = 3;
            this.pnContent2.Visible = false;
            // 
            // pnContent4
            // 
            this.pnContent4.BackColor = System.Drawing.Color.Transparent;
            this.pnContent4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnContent4.Location = new System.Drawing.Point(610, 150);
            this.pnContent4.Name = "pnContent4";
            this.pnContent4.Size = new System.Drawing.Size(350, 390);
            this.pnContent4.TabIndex = 4;
            this.pnContent4.Visible = false;
            // 
            // CheckProject
            // 
            this.CheckProject.Tick += new System.EventHandler(this.CheckProject_Tick);
            // 
            // pnContentOrther
            // 
            this.pnContentOrther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContentOrther.Location = new System.Drawing.Point(300, 150);
            this.pnContentOrther.Name = "pnContentOrther";
            this.pnContentOrther.Size = new System.Drawing.Size(310, 390);
            this.pnContentOrther.TabIndex = 6;
            this.pnContentOrther.Visible = false;
            // 
            // pnAccount
            // 
            this.pnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnAccount.BackColor = System.Drawing.Color.White;
            this.pnAccount.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Background;
            this.pnAccount.Controls.Add(this.pnLine);
            this.pnAccount.Controls.Add(this.btnAccount);
            this.pnAccount.Controls.Add(this.btnSetting);
            this.pnAccount.Controls.Add(this.lblTimePlay);
            this.pnAccount.Controls.Add(this.lblTitle);
            this.pnAccount.Controls.Add(this.pnFooter);
            this.pnAccount.Controls.Add(this.btnLogout);
            this.pnAccount.Location = new System.Drawing.Point(580, 100);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(250, 290);
            this.pnAccount.TabIndex = 7;
            this.pnAccount.Visible = false;
            // 
            // pnLine
            // 
            this.pnLine.BorderColor = System.Drawing.Color.DimGray;
            this.pnLine.BorderThickness = 1;
            this.pnLine.FillColor = System.Drawing.Color.DimGray;
            this.pnLine.ForeColor = System.Drawing.Color.DarkGray;
            this.pnLine.Location = new System.Drawing.Point(0, 94);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(300, 1);
            this.pnLine.TabIndex = 15;
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccount.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Background;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(0, 105);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(250, 45);
            this.btnAccount.TabIndex = 14;
            this.btnAccount.Text = "Account";
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Background;
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.FillColor = System.Drawing.Color.Transparent;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(0, 150);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(250, 45);
            this.btnSetting.TabIndex = 13;
            this.btnSetting.Text = "Setting";
            // 
            // lblTimePlay
            // 
            this.lblTimePlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimePlay.BackColor = System.Drawing.Color.Transparent;
            this.lblTimePlay.BorderColor = System.Drawing.Color.Silver;
            this.lblTimePlay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTimePlay.DefaultText = "Time";
            this.lblTimePlay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblTimePlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblTimePlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblTimePlay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblTimePlay.Enabled = false;
            this.lblTimePlay.FillColor = System.Drawing.Color.Silver;
            this.lblTimePlay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTimePlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePlay.ForeColor = System.Drawing.Color.White;
            this.lblTimePlay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTimePlay.Location = new System.Drawing.Point(10, 52);
            this.lblTimePlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTimePlay.Name = "lblTimePlay";
            this.lblTimePlay.PasswordChar = '\0';
            this.lblTimePlay.PlaceholderText = "";
            this.lblTimePlay.ReadOnly = true;
            this.lblTimePlay.SelectedText = "";
            this.lblTimePlay.Size = new System.Drawing.Size(230, 35);
            this.lblTimePlay.TabIndex = 12;
            this.lblTimePlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(45, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 22);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ACCOUNT BALANCE";
            // 
            // pnFooter
            // 
            this.pnFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnFooter.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Background;
            this.pnFooter.Controls.Add(this.lblSoMay);
            this.pnFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnFooter.Location = new System.Drawing.Point(0, 240);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(250, 50);
            this.pnFooter.TabIndex = 1;
            // 
            // lblSoMay
            // 
            this.lblSoMay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSoMay.BackColor = System.Drawing.Color.Transparent;
            this.lblSoMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoMay.ForeColor = System.Drawing.Color.White;
            this.lblSoMay.Location = new System.Drawing.Point(92, 14);
            this.lblSoMay.Name = "lblSoMay";
            this.lblSoMay.Size = new System.Drawing.Size(60, 22);
            this.lblSoMay.TabIndex = 0;
            this.lblSoMay.Text = "MAY 63";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Background;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 195);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 45);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ElipseAcount
            // 
            this.ElipseAcount.BorderRadius = 30;
            this.ElipseAcount.TargetControl = this.pnAccount;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.pnAccount);
            this.Controls.Add(this.pnContentOrther);
            this.Controls.Add(this.pnContent3);
            this.Controls.Add(this.pnContent4);
            this.Controls.Add(this.pnContent2);
            this.Controls.Add(this.pnContent1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            this.pnFooter.ResumeLayout(false);
            this.pnFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnContent3;
        private Guna.UI2.WinForms.Guna2Panel pnContent1;
        private Guna.UI2.WinForms.Guna2Panel pnContent2;
        private Guna.UI2.WinForms.Guna2Panel pnContent4;
        private System.Windows.Forms.Timer CheckProject;
        private Guna.UI2.WinForms.Guna2Panel pnContentOrther;
        private Guna.UI2.WinForms.Guna2Panel pnAccount;
        private Guna.UI2.WinForms.Guna2Panel pnLine;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private Guna.UI2.WinForms.Guna2TextBox lblTimePlay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnFooter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoMay;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Elipse ElipseAcount;
    }
}