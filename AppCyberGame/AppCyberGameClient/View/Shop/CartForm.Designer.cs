namespace AppCyberGameClient.View.Shop
{
    partial class CartForm
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
            this.pnBalance = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContentCart = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // pnBalance
            // 
            this.pnBalance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnBalance.Location = new System.Drawing.Point(40, 32);
            this.pnBalance.Name = "pnBalance";
            this.pnBalance.Size = new System.Drawing.Size(270, 120);
            this.pnBalance.TabIndex = 0;
            // 
            // pnContentCart
            // 
            this.pnContentCart.Location = new System.Drawing.Point(40, 175);
            this.pnContentCart.Name = "pnContentCart";
            this.pnContentCart.Size = new System.Drawing.Size(270, 306);
            this.pnContentCart.TabIndex = 1;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(350, 930);
            this.Controls.Add(this.pnContentCart);
            this.Controls.Add(this.pnBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnBalance;
        private Guna.UI2.WinForms.Guna2Panel pnContentCart;
    }
}