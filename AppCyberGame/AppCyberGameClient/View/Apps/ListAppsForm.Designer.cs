namespace AppCyberGameClient.View.Apps
{
    partial class ListAppsForm
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
            this.pnApp1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblApp1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picApp1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ElipseApp1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseApp2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseApp3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseApp4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pnApp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApp1)).BeginInit();
            this.pnLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnApp1
            // 
            this.pnApp1.BackColor = System.Drawing.Color.Transparent;
            this.pnApp1.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Background;
            this.pnApp1.Controls.Add(this.lblApp1);
            this.pnApp1.Controls.Add(this.picApp1);
            this.pnApp1.Location = new System.Drawing.Point(3, 3);
            this.pnApp1.Name = "pnApp1";
            this.pnApp1.Size = new System.Drawing.Size(285, 160);
            this.pnApp1.TabIndex = 5;
            this.pnApp1.Visible = false;
            this.pnApp1.Click += new System.EventHandler(this.pnApp1_Click);
            // 
            // lblApp1
            // 
            this.lblApp1.AutoSize = false;
            this.lblApp1.BackColor = System.Drawing.Color.Transparent;
            this.lblApp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp1.ForeColor = System.Drawing.Color.White;
            this.lblApp1.Location = new System.Drawing.Point(92, 110);
            this.lblApp1.Name = "lblApp1";
            this.lblApp1.Size = new System.Drawing.Size(100, 30);
            this.lblApp1.TabIndex = 1;
            this.lblApp1.Text = "Title";
            this.lblApp1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picApp1
            // 
            this.picApp1.ImageRotate = 0F;
            this.picApp1.Location = new System.Drawing.Point(107, 20);
            this.picApp1.Name = "picApp1";
            this.picApp1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picApp1.Size = new System.Drawing.Size(70, 70);
            this.picApp1.TabIndex = 0;
            this.picApp1.TabStop = false;
            // 
            // ElipseApp1
            // 
            this.ElipseApp1.BorderRadius = 30;
            this.ElipseApp1.TargetControl = this.pnApp1;
            // 
            // ElipseApp2
            // 
            this.ElipseApp2.BorderRadius = 30;
            // 
            // ElipseApp3
            // 
            this.ElipseApp3.BorderRadius = 30;
            // 
            // ElipseApp4
            // 
            this.ElipseApp4.BorderRadius = 30;
            // 
            // pnLayout
            // 
            this.pnLayout.Controls.Add(this.pnApp1);
            this.pnLayout.Location = new System.Drawing.Point(0, 0);
            this.pnLayout.Name = "pnLayout";
            this.pnLayout.Size = new System.Drawing.Size(1190, 390);
            this.pnLayout.TabIndex = 6;
            // 
            // ListAppsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(1190, 390);
            this.Controls.Add(this.pnLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListAppsForm";
            this.Text = "ListAppsForm";
            this.Load += new System.EventHandler(this.ListAppsForm_Load);
            this.pnApp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picApp1)).EndInit();
            this.pnLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnApp1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblApp1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picApp1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseApp1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseApp2;
        private Guna.UI2.WinForms.Guna2Elipse ElipseApp3;
        private Guna.UI2.WinForms.Guna2Elipse ElipseApp4;
        private System.Windows.Forms.FlowLayoutPanel pnLayout;
    }
}