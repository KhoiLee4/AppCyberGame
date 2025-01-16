namespace AppCyberGame.View
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAccount = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNotify = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.lblUsername.Location = new System.Drawing.Point(340, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 33);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Name";
            // 
            // txbSearch
            // 
            this.txbSearch.BorderRadius = 15;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.DefaultText = "Search User";
            this.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Location = new System.Drawing.Point(1490, 22);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderText = "";
            this.txbSearch.SelectedText = "";
            this.txbSearch.Size = new System.Drawing.Size(230, 36);
            this.txbSearch.TabIndex = 2;
            // 
            // btnAccount
            // 
            this.btnAccount.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAccount.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAccount.ImageRotate = 0F;
            this.btnAccount.Location = new System.Drawing.Point(1860, 20);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAccount.Size = new System.Drawing.Size(40, 40);
            this.btnAccount.TabIndex = 6;
            // 
            // btnNotify
            // 
            this.btnNotify.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNotify.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNotify.Image = ((System.Drawing.Image)(resources.GetObject("btnNotify.Image")));
            this.btnNotify.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNotify.ImageRotate = 0F;
            this.btnNotify.Location = new System.Drawing.Point(1800, 20);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNotify.Size = new System.Drawing.Size(40, 40);
            this.btnNotify.TabIndex = 5;
            // 
            // btnAddUser
            // 
            this.btnAddUser.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddUser.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddUser.ImageRotate = 0F;
            this.btnAddUser.Location = new System.Drawing.Point(1740, 20);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddUser.Size = new System.Drawing.Size(40, 40);
            this.btnAddUser.TabIndex = 4;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::AppCyberGame.Properties.Resources.Logo_2_1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(10, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(310, 80);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(1920, 80);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnNotify);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddUser;
        private Guna.UI2.WinForms.Guna2ImageButton btnNotify;
        private Guna.UI2.WinForms.Guna2ImageButton btnAccount;
    }
}