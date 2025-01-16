namespace AppCyberGameClient.View.Games
{
    partial class GamesForm
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
            this.txbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnApps = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnContentGame = new Guna.UI2.WinForms.Guna2Panel();
            this.pnFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // txbSearch
            // 
            this.txbSearch.BorderRadius = 10;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.DefaultText = "Search game";
            this.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Location = new System.Drawing.Point(320, 95);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderText = "";
            this.txbSearch.SelectedText = "";
            this.txbSearch.Size = new System.Drawing.Size(630, 40);
            this.txbSearch.TabIndex = 0;
            // 
            // pnApps
            // 
            this.pnApps.Location = new System.Drawing.Point(40, 240);
            this.pnApps.Name = "pnApps";
            this.pnApps.Size = new System.Drawing.Size(1190, 230);
            this.pnApps.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(398, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(474, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Discover 33 games available ";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = false;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(40, 200);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(283, 31);
            this.lblTitle2.TabIndex = 3;
            this.lblTitle2.Text = "Access your own games";
            // 
            // pnContentGame
            // 
            this.pnContentGame.Location = new System.Drawing.Point(40, 520);
            this.pnContentGame.Name = "pnContentGame";
            this.pnContentGame.Size = new System.Drawing.Size(1190, 390);
            this.pnContentGame.TabIndex = 3;
            // 
            // pnFooter
            // 
            this.pnFooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(40, 920);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(1190, 10);
            this.pnFooter.TabIndex = 4;
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(1300, 930);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnContentGame);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnApps);
            this.Controls.Add(this.txbSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamesForm";
            this.Text = "GamesForm";
            this.Load += new System.EventHandler(this.GamesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private Guna.UI2.WinForms.Guna2Panel pnApps;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle2;
        private Guna.UI2.WinForms.Guna2Panel pnContentGame;
        private Guna.UI2.WinForms.Guna2Panel pnFooter;
    }
}