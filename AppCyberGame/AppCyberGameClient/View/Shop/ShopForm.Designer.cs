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
            this.pnContentGamePasses = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContentFoodDrink = new Guna.UI2.WinForms.Guna2Panel();
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
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Location = new System.Drawing.Point(320, 30);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderText = "";
            this.txbSearch.SelectedText = "";
            this.txbSearch.Size = new System.Drawing.Size(630, 40);
            this.txbSearch.TabIndex = 2;
            // 
            // pnContentGamePasses
            // 
            this.pnContentGamePasses.Location = new System.Drawing.Point(40, 110);
            this.pnContentGamePasses.Name = "pnContentGamePasses";
            this.pnContentGamePasses.Size = new System.Drawing.Size(1190, 360);
            this.pnContentGamePasses.TabIndex = 5;
            // 
            // pnContentFoodDrink
            // 
            this.pnContentFoodDrink.Location = new System.Drawing.Point(40, 490);
            this.pnContentFoodDrink.Name = "pnContentFoodDrink";
            this.pnContentFoodDrink.Size = new System.Drawing.Size(1190, 700);
            this.pnContentFoodDrink.TabIndex = 6;
            // 
            // pnFooter
            // 
            this.pnFooter.Location = new System.Drawing.Point(40, 1218);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(1190, 20);
            this.pnFooter.TabIndex = 8;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(1300, 930);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnContentFoodDrink);
            this.Controls.Add(this.pnContentGamePasses);
            this.Controls.Add(this.txbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private Guna.UI2.WinForms.Guna2Panel pnContentGamePasses;
        private Guna.UI2.WinForms.Guna2Panel pnContentFoodDrink;
        private Guna.UI2.WinForms.Guna2Panel pnFooter;
    }
}