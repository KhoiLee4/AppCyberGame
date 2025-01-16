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
            this.components = new System.ComponentModel.Container();
            this.pnContentCart = new Guna.UI2.WinForms.Guna2Panel();
            this.pnProduct = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNameProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nudProduct = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pnLine = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSubTotal1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTaxes1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotal1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTaxes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSubTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.ElipseCart = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CheckCart = new System.Windows.Forms.Timer(this.components);
            this.pnPhuongThucGD = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCash = new Guna.UI2.WinForms.Guna2Button();
            this.btnQR = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnContentCart.SuspendLayout();
            this.pnProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProduct)).BeginInit();
            this.pnPhuongThucGD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContentCart
            // 
            this.pnContentCart.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Background;
            this.pnContentCart.Controls.Add(this.pnProduct);
            this.pnContentCart.Controls.Add(this.lblTitle);
            this.pnContentCart.Controls.Add(this.lblSubTotal1);
            this.pnContentCart.Controls.Add(this.lblTaxes1);
            this.pnContentCart.Controls.Add(this.lblTotal);
            this.pnContentCart.Controls.Add(this.lblTotal1);
            this.pnContentCart.Controls.Add(this.lblTaxes);
            this.pnContentCart.Controls.Add(this.lblSubTotal);
            this.pnContentCart.Controls.Add(this.btnCheckout);
            this.pnContentCart.Location = new System.Drawing.Point(40, 40);
            this.pnContentCart.Name = "pnContentCart";
            this.pnContentCart.Size = new System.Drawing.Size(270, 340);
            this.pnContentCart.TabIndex = 1;
            this.pnContentCart.Visible = false;
            // 
            // pnProduct
            // 
            this.pnProduct.BackColor = System.Drawing.Color.Transparent;
            this.pnProduct.Controls.Add(this.lblNameProduct);
            this.pnProduct.Controls.Add(this.lblPrice);
            this.pnProduct.Controls.Add(this.nudProduct);
            this.pnProduct.Controls.Add(this.pnLine);
            this.pnProduct.Location = new System.Drawing.Point(0, 60);
            this.pnProduct.Name = "pnProduct";
            this.pnProduct.Size = new System.Drawing.Size(270, 95);
            this.pnProduct.TabIndex = 20;
            this.pnProduct.Visible = false;
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProduct.ForeColor = System.Drawing.Color.White;
            this.lblNameProduct.Location = new System.Drawing.Point(20, 5);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(87, 22);
            this.lblNameProduct.TabIndex = 16;
            this.lblNameProduct.Text = "SUBTOTAL";
            this.lblNameProduct.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = false;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(96, 51);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(154, 22);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "0Đ";
            this.lblPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudProduct
            // 
            this.nudProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudProduct.BackColor = System.Drawing.Color.Transparent;
            this.nudProduct.BorderColor = System.Drawing.Color.Transparent;
            this.nudProduct.BorderRadius = 10;
            this.nudProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(226)))), ((int)(((byte)(253)))));
            this.nudProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProduct.Location = new System.Drawing.Point(20, 42);
            this.nudProduct.Name = "nudProduct";
            this.nudProduct.Size = new System.Drawing.Size(70, 39);
            this.nudProduct.TabIndex = 17;
            this.nudProduct.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.nudProduct.ValueChanged += new System.EventHandler(this.nudProduct_ValueChanged);
            // 
            // pnLine
            // 
            this.pnLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLine.BorderColor = System.Drawing.Color.Gray;
            this.pnLine.BorderThickness = 1;
            this.pnLine.FillColor = System.Drawing.Color.Gray;
            this.pnLine.ForeColor = System.Drawing.Color.DarkGray;
            this.pnLine.Location = new System.Drawing.Point(0, 89);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(270, 1);
            this.pnLine.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 33);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Your cart";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTotal1
            // 
            this.lblSubTotal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal1.AutoSize = false;
            this.lblSubTotal1.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal1.ForeColor = System.Drawing.Color.White;
            this.lblSubTotal1.Location = new System.Drawing.Point(113, 174);
            this.lblSubTotal1.Name = "lblSubTotal1";
            this.lblSubTotal1.Size = new System.Drawing.Size(137, 22);
            this.lblSubTotal1.TabIndex = 11;
            this.lblSubTotal1.Text = "0Đ";
            this.lblSubTotal1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxes1
            // 
            this.lblTaxes1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxes1.AutoSize = false;
            this.lblTaxes1.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxes1.ForeColor = System.Drawing.Color.White;
            this.lblTaxes1.Location = new System.Drawing.Point(82, 206);
            this.lblTaxes1.Name = "lblTaxes1";
            this.lblTaxes1.Size = new System.Drawing.Size(168, 22);
            this.lblTaxes1.TabIndex = 10;
            this.lblTaxes1.Text = "0Đ";
            this.lblTaxes1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(20, 238);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 22);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "TOTAL";
            this.lblTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal1
            // 
            this.lblTotal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal1.AutoSize = false;
            this.lblTotal1.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal1.ForeColor = System.Drawing.Color.White;
            this.lblTotal1.Location = new System.Drawing.Point(79, 238);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(171, 22);
            this.lblTotal1.TabIndex = 8;
            this.lblTotal1.Text = "0Đ";
            this.lblTotal1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxes
            // 
            this.lblTaxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTaxes.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxes.ForeColor = System.Drawing.Color.White;
            this.lblTaxes.Location = new System.Drawing.Point(20, 206);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(56, 22);
            this.lblTaxes.TabIndex = 7;
            this.lblTaxes.Text = "TAXES";
            this.lblTaxes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.White;
            this.lblSubTotal.Location = new System.Drawing.Point(20, 174);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(87, 22);
            this.lblSubTotal.TabIndex = 6;
            this.lblSubTotal.Text = "SUBTOTAL";
            this.lblSubTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCheckout.BorderRadius = 10;
            this.btnCheckout.BorderThickness = 1;
            this.btnCheckout.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnCheckout.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(20, 280);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(230, 40);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // ElipseCart
            // 
            this.ElipseCart.BorderRadius = 40;
            this.ElipseCart.TargetControl = this.pnContentCart;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(130, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(137, 22);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "0Đ";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(3, 2);
            this.lblName.TabIndex = 0;
            this.lblName.Text = null;
            // 
            // CheckCart
            // 
            this.CheckCart.Interval = 500;
            this.CheckCart.Tick += new System.EventHandler(this.CheckCart_Tick);
            // 
            // pnPhuongThucGD
            // 
            this.pnPhuongThucGD.BackColor = System.Drawing.Color.Transparent;
            this.pnPhuongThucGD.BackgroundImage = global::AppCyberGameClient.Properties.Resources.Background;
            this.pnPhuongThucGD.Controls.Add(this.btnClose);
            this.pnPhuongThucGD.Controls.Add(this.btnQR);
            this.pnPhuongThucGD.Controls.Add(this.btnCash);
            this.pnPhuongThucGD.Location = new System.Drawing.Point(0, 0);
            this.pnPhuongThucGD.Name = "pnPhuongThucGD";
            this.pnPhuongThucGD.Size = new System.Drawing.Size(350, 930);
            this.pnPhuongThucGD.TabIndex = 2;
            this.pnPhuongThucGD.Visible = false;
            // 
            // btnCash
            // 
            this.btnCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCash.BorderRadius = 10;
            this.btnCash.BorderThickness = 1;
            this.btnCash.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnCash.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnCash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCash.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnCash.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.Location = new System.Drawing.Point(60, 415);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(230, 40);
            this.btnCash.TabIndex = 21;
            this.btnCash.Text = "Cash";
            this.btnCash.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // btnQR
            // 
            this.btnQR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQR.BorderRadius = 10;
            this.btnQR.BorderThickness = 1;
            this.btnQR.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnQR.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnQR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnQR.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQR.ForeColor = System.Drawing.Color.White;
            this.btnQR.Location = new System.Drawing.Point(60, 475);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(230, 40);
            this.btnQR.TabIndex = 22;
            this.btnQR.Text = "QR";
            this.btnQR.Click += new System.EventHandler(this.buttonCheckout_Click);
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
            this.btnClose.Location = new System.Drawing.Point(155, 535);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(350, 930);
            this.Controls.Add(this.pnPhuongThucGD);
            this.Controls.Add(this.pnContentCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.pnContentCart.ResumeLayout(false);
            this.pnContentCart.PerformLayout();
            this.pnProduct.ResumeLayout(false);
            this.pnProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProduct)).EndInit();
            this.pnPhuongThucGD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnContentCart;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2Elipse ElipseCart;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotal1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaxes;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubTotal1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaxes1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnLine;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2Panel pnProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNameProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private System.Windows.Forms.Timer CheckCart;
        private Guna.UI2.WinForms.Guna2Panel pnPhuongThucGD;
        private Guna.UI2.WinForms.Guna2Button btnQR;
        private Guna.UI2.WinForms.Guna2Button btnCash;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}