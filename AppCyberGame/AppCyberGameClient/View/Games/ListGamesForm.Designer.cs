namespace AppCyberGameClient.View.Games
{
    partial class ListGamesForm
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
            this.btnGame2 = new Guna.UI2.WinForms.Guna2Button();
            this.pnLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pnLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGame2
            // 
            this.btnGame2.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Logo_1;
            this.btnGame2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGame2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGame2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGame2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGame2.FillColor = System.Drawing.Color.Empty;
            this.btnGame2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGame2.ForeColor = System.Drawing.Color.White;
            this.btnGame2.Location = new System.Drawing.Point(3, 3);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Size = new System.Drawing.Size(158, 237);
            this.btnGame2.TabIndex = 10;
            this.btnGame2.Visible = false;
            // 
            // pnLayout
            // 
            this.pnLayout.AutoScroll = true;
            this.pnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.pnLayout.Controls.Add(this.btnGame2);
            this.pnLayout.Location = new System.Drawing.Point(0, 0);
            this.pnLayout.Margin = new System.Windows.Forms.Padding(12);
            this.pnLayout.Name = "pnLayout";
            this.pnLayout.Size = new System.Drawing.Size(1210, 390);
            this.pnLayout.TabIndex = 12;
            // 
            // ListGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1190, 390);
            this.Controls.Add(this.pnLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListGamesForm";
            this.Text = "ListGamesForm";
            this.Load += new System.EventHandler(this.ListGamesForm_Load);
            this.pnLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnGame2;
        private System.Windows.Forms.FlowLayoutPanel pnLayout;
    }
}