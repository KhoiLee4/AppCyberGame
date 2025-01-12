namespace AppCyberGameClient.View.Shop
{
    partial class ShopForm
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
            this.pnPopular = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContentGamePasses = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContentSnacks = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // txbSearch
            // 
            this.txbSearch.BorderRadius = 10;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.DefaultText = "Search GamePass, product, etc";
            this.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Location = new System.Drawing.Point(320, 30);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderText = "";
            this.txbSearch.SelectedText = "";
            this.txbSearch.Size = new System.Drawing.Size(630, 40);
            this.txbSearch.TabIndex = 2;
            // 
            // pnPopular
            // 
            this.pnPopular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnPopular.Location = new System.Drawing.Point(40, 87);
            this.pnPopular.Name = "pnPopular";
            this.pnPopular.Size = new System.Drawing.Size(1190, 320);
            this.pnPopular.TabIndex = 5;
            // 
            // pnContentGamePasses
            // 
            this.pnContentGamePasses.Location = new System.Drawing.Point(40, 427);
            this.pnContentGamePasses.Name = "pnContentGamePasses";
            this.pnContentGamePasses.Size = new System.Drawing.Size(1190, 320);
            this.pnContentGamePasses.TabIndex = 5;
            // 
            // pnContentSnacks
            // 
            this.pnContentSnacks.Location = new System.Drawing.Point(40, 778);
            this.pnContentSnacks.Name = "pnContentSnacks";
            this.pnContentSnacks.Size = new System.Drawing.Size(1190, 320);
            this.pnContentSnacks.TabIndex = 6;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(40, 1125);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1190, 320);
            this.guna2Panel1.TabIndex = 7;
            // 
            // pnFooter
            // 
            this.pnFooter.Location = new System.Drawing.Point(40, 1516);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(1190, 20);
            this.pnFooter.TabIndex = 8;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1300, 930);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnContentSnacks);
            this.Controls.Add(this.pnContentGamePasses);
            this.Controls.Add(this.pnPopular);
            this.Controls.Add(this.txbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private Guna.UI2.WinForms.Guna2Panel pnPopular;
        private Guna.UI2.WinForms.Guna2Panel pnContentGamePasses;
        private Guna.UI2.WinForms.Guna2Panel pnContentSnacks;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnFooter;
    }
}