namespace AppCyberGameClient.View.Shop
{
    partial class GamePassesForm
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
            this.ElipseGamePass1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnGamePass1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnGamePass1 = new Guna.UI2.WinForms.Guna2Button();
            this.picGamePass1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pnGamePass1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGamePass1)).BeginInit();
            this.pnLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseGamePass1
            // 
            this.ElipseGamePass1.BorderRadius = 60;
            this.ElipseGamePass1.TargetControl = this.pnGamePass1;
            // 
            // pnGamePass1
            // 
            this.pnGamePass1.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Background;
            this.pnGamePass1.Controls.Add(this.lblName);
            this.pnGamePass1.Controls.Add(this.lblPrice);
            this.pnGamePass1.Controls.Add(this.btnGamePass1);
            this.pnGamePass1.Controls.Add(this.picGamePass1);
            this.pnGamePass1.Location = new System.Drawing.Point(3, 3);
            this.pnGamePass1.Name = "pnGamePass1";
            this.pnGamePass1.Size = new System.Drawing.Size(226, 340);
            this.pnGamePass1.TabIndex = 0;
            this.pnGamePass1.Visible = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(15, 222);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 22);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(15, 250);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 31);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "0Đ";
            // 
            // btnGamePass1
            // 
            this.btnGamePass1.BorderRadius = 10;
            this.btnGamePass1.BorderThickness = 1;
            this.btnGamePass1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnGamePass1.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnGamePass1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGamePass1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGamePass1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGamePass1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGamePass1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnGamePass1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGamePass1.ForeColor = System.Drawing.Color.White;
            this.btnGamePass1.Location = new System.Drawing.Point(15, 291);
            this.btnGamePass1.Name = "btnGamePass1";
            this.btnGamePass1.Size = new System.Drawing.Size(196, 30);
            this.btnGamePass1.TabIndex = 3;
            this.btnGamePass1.Text = "Add to cart";
            // 
            // picGamePass1
            // 
            this.picGamePass1.BackColor = System.Drawing.Color.Transparent;
            this.picGamePass1.BorderRadius = 30;
            this.picGamePass1.ImageRotate = 0F;
            this.picGamePass1.Location = new System.Drawing.Point(10, 10);
            this.picGamePass1.Name = "picGamePass1";
            this.picGamePass1.Size = new System.Drawing.Size(206, 206);
            this.picGamePass1.TabIndex = 0;
            this.picGamePass1.TabStop = false;
            // 
            // pnLayout
            // 
            this.pnLayout.Controls.Add(this.pnGamePass1);
            this.pnLayout.Location = new System.Drawing.Point(0, 0);
            this.pnLayout.Name = "pnLayout";
            this.pnLayout.Size = new System.Drawing.Size(1190, 360);
            this.pnLayout.TabIndex = 1;
            // 
            // GamePassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(1190, 360);
            this.Controls.Add(this.pnLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamePassesForm";
            this.Text = "GamePassesForm";
            this.Load += new System.EventHandler(this.GamePassesForm_Load);
            this.pnGamePass1.ResumeLayout(false);
            this.pnGamePass1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGamePass1)).EndInit();
            this.pnLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnGamePass1;
        private Guna.UI2.WinForms.Guna2Button btnGamePass1;
        private Guna.UI2.WinForms.Guna2PictureBox picGamePass1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseGamePass1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private System.Windows.Forms.FlowLayoutPanel pnLayout;
    }
}