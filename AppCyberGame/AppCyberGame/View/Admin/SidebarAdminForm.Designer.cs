namespace AppCyberGame.View.Admin
{
    partial class SidebarAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SidebarAdminForm));
            this.btnDashboard = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDashboard.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDashboard.ImageRotate = 0F;
            this.btnDashboard.Location = new System.Drawing.Point(0, 10);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDashboard.Size = new System.Drawing.Size(80, 54);
            this.btnDashboard.TabIndex = 1;
            // 
            // SidebarAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(100, 1000);
            this.Controls.Add(this.btnDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SidebarAdminForm";
            this.Text = "SidebarAdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnDashboard;
    }
}