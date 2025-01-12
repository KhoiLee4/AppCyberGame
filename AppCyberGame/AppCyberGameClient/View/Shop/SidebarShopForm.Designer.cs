namespace AppCyberGameClient.View.Shop
{
    partial class SidebarShopForm
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
            this.btnMultiplayer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.lblBrowse = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.BorderRadius = 15;
            this.btnMultiplayer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiplayer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiplayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMultiplayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMultiplayer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplayer.ForeColor = System.Drawing.Color.White;
            this.btnMultiplayer.Location = new System.Drawing.Point(25, 188);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(235, 45);
            this.btnMultiplayer.TabIndex = 14;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAll
            // 
            this.btnAll.BorderRadius = 15;
            this.btnAll.Checked = true;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(25, 137);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(235, 45);
            this.btnAll.TabIndex = 13;
            this.btnAll.Text = "All";
            this.btnAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblBrowse
            // 
            this.lblBrowse.BackColor = System.Drawing.Color.Transparent;
            this.lblBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowse.Location = new System.Drawing.Point(25, 97);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(162, 18);
            this.lblBrowse.TabIndex = 12;
            this.lblBrowse.Text = "BROWSE BY CATEGORY";
            this.lblBrowse.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 39);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Shop";
            // 
            // SidebarShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(300, 930);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.lblBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SidebarShopForm";
            this.Text = "SidebarShopForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnMultiplayer;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBrowse;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
    }
}