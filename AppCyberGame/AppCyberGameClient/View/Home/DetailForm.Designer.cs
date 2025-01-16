namespace AppCyberGameClient.View.Home
{
    partial class DetailForm
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
            this.btnPlayNow = new Guna.UI2.WinForms.Guna2Button();
            this.lblGameName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnPlayNow
            // 
            this.btnPlayNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayNow.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayNow.BorderRadius = 15;
            this.btnPlayNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlayNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlayNow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnPlayNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayNow.ForeColor = System.Drawing.Color.White;
            this.btnPlayNow.Location = new System.Drawing.Point(30, 990);
            this.btnPlayNow.Name = "btnPlayNow";
            this.btnPlayNow.Size = new System.Drawing.Size(280, 60);
            this.btnPlayNow.TabIndex = 3;
            this.btnPlayNow.Text = "Play now!";
            // 
            // lblGameName
            // 
            this.lblGameName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGameName.BackColor = System.Drawing.Color.Transparent;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(30, 920);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(106, 44);
            this.lblGameName.TabIndex = 6;
            this.lblGameName.Text = "Name";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BorderRadius = 10;
            this.btnClose.BorderThickness = 1;
            this.btnClose.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1868, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.btnPlayNow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPlayNow;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGameName;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}