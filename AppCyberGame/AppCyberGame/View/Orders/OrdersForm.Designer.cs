namespace AppCyberGame.View.Orders
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txbTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbCot = new System.Windows.Forms.ComboBox();
            this.lblCot = new System.Windows.Forms.Label();
            this.lblSapXep = new System.Windows.Forms.Label();
            this.cbbSapXep = new System.Windows.Forms.ComboBox();
            this.pnContent = new Guna.UI2.WinForms.Guna2Panel();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.cbbSoDong = new System.Windows.Forms.ComboBox();
            this.lblSoDong = new System.Windows.Forms.Label();
            this.btnTrangTruoc = new System.Windows.Forms.Button();
            this.btnTrangKe = new System.Windows.Forms.Button();
            this.lblSoTrang = new System.Windows.Forms.Label();
            this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongThucGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnHeader.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.btnTimKiem);
            this.pnHeader.Controls.Add(this.txbTimKiem);
            this.pnHeader.Controls.Add(this.cbbCot);
            this.pnHeader.Controls.Add(this.lblCot);
            this.pnHeader.Controls.Add(this.lblSapXep);
            this.pnHeader.Controls.Add(this.cbbSapXep);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1820, 50);
            this.pnHeader.TabIndex = 24;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 5;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(10, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 30);
            this.btnTimKiem.TabIndex = 26;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_ClickAsync);
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTimKiem.DefaultText = "Search";
            this.txbTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTimKiem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTimKiem.Location = new System.Drawing.Point(96, 10);
            this.txbTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.PasswordChar = '\0';
            this.txbTimKiem.PlaceholderText = "";
            this.txbTimKiem.SelectedText = "";
            this.txbTimKiem.Size = new System.Drawing.Size(1387, 30);
            this.txbTimKiem.TabIndex = 15;
            this.txbTimKiem.Click += new System.EventHandler(this.txbTimKiem_Click);
            this.txbTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTimKiem_KeyPress);
            this.txbTimKiem.Leave += new System.EventHandler(this.txbTimKiem_Leave);
            // 
            // cbbCot
            // 
            this.cbbCot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCot.FormattingEnabled = true;
            this.cbbCot.Location = new System.Drawing.Point(1695, 13);
            this.cbbCot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCot.Name = "cbbCot";
            this.cbbCot.Size = new System.Drawing.Size(115, 26);
            this.cbbCot.TabIndex = 11;
            this.cbbCot.SelectedIndexChanged += new System.EventHandler(this.cbbCot_SelectedIndexChanged);
            // 
            // lblCot
            // 
            this.lblCot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCot.AutoSize = true;
            this.lblCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCot.ForeColor = System.Drawing.Color.White;
            this.lblCot.Location = new System.Drawing.Point(1657, 16);
            this.lblCot.Name = "lblCot";
            this.lblCot.Size = new System.Drawing.Size(32, 18);
            this.lblCot.TabIndex = 10;
            this.lblCot.Text = "Cột";
            // 
            // lblSapXep
            // 
            this.lblSapXep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSapXep.AutoSize = true;
            this.lblSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSapXep.ForeColor = System.Drawing.Color.White;
            this.lblSapXep.Location = new System.Drawing.Point(1489, 16);
            this.lblSapXep.Name = "lblSapXep";
            this.lblSapXep.Size = new System.Drawing.Size(61, 18);
            this.lblSapXep.TabIndex = 8;
            this.lblSapXep.Text = "Sắp xếp";
            // 
            // cbbSapXep
            // 
            this.cbbSapXep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSapXep.FormattingEnabled = true;
            this.cbbSapXep.Items.AddRange(new object[] {
            "Tăng dần",
            "Giảm dần"});
            this.cbbSapXep.Location = new System.Drawing.Point(1556, 13);
            this.cbbSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSapXep.Name = "cbbSapXep";
            this.cbbSapXep.Size = new System.Drawing.Size(95, 26);
            this.cbbSapXep.TabIndex = 9;
            this.cbbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbbSapXep_SelectedIndexChanged);
            // 
            // pnContent
            // 
            this.pnContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContent.Controls.Add(this.pnFooter);
            this.pnContent.Controls.Add(this.dataGridView);
            this.pnContent.Location = new System.Drawing.Point(50, 60);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1720, 600);
            this.pnContent.TabIndex = 25;
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.cbbSoDong);
            this.pnFooter.Controls.Add(this.lblSoDong);
            this.pnFooter.Controls.Add(this.btnTrangTruoc);
            this.pnFooter.Controls.Add(this.btnTrangKe);
            this.pnFooter.Controls.Add(this.lblSoTrang);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 560);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(1720, 40);
            this.pnFooter.TabIndex = 18;
            // 
            // cbbSoDong
            // 
            this.cbbSoDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSoDong.FormattingEnabled = true;
            this.cbbSoDong.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cbbSoDong.Location = new System.Drawing.Point(80, 7);
            this.cbbSoDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSoDong.Name = "cbbSoDong";
            this.cbbSoDong.Size = new System.Drawing.Size(70, 26);
            this.cbbSoDong.TabIndex = 3;
            this.cbbSoDong.SelectedIndexChanged += new System.EventHandler(this.cbbSoDong_SelectedIndexChanged);
            // 
            // lblSoDong
            // 
            this.lblSoDong.AutoSize = true;
            this.lblSoDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDong.ForeColor = System.Drawing.Color.White;
            this.lblSoDong.Location = new System.Drawing.Point(10, 10);
            this.lblSoDong.Name = "lblSoDong";
            this.lblSoDong.Size = new System.Drawing.Size(64, 18);
            this.lblSoDong.TabIndex = 2;
            this.lblSoDong.Text = "Số dòng";
            // 
            // btnTrangTruoc
            // 
            this.btnTrangTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangTruoc.Location = new System.Drawing.Point(156, 4);
            this.btnTrangTruoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrangTruoc.Name = "btnTrangTruoc";
            this.btnTrangTruoc.Size = new System.Drawing.Size(100, 30);
            this.btnTrangTruoc.TabIndex = 4;
            this.btnTrangTruoc.Text = "Trang Trước";
            this.btnTrangTruoc.UseVisualStyleBackColor = true;
            this.btnTrangTruoc.Click += new System.EventHandler(this.btnTrangTruoc_Click);
            // 
            // btnTrangKe
            // 
            this.btnTrangKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangKe.Location = new System.Drawing.Point(318, 4);
            this.btnTrangKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrangKe.Name = "btnTrangKe";
            this.btnTrangKe.Size = new System.Drawing.Size(100, 30);
            this.btnTrangKe.TabIndex = 5;
            this.btnTrangKe.Text = "Trang Kế";
            this.btnTrangKe.UseVisualStyleBackColor = true;
            this.btnTrangKe.Click += new System.EventHandler(this.btnTrangKe_Click);
            // 
            // lblSoTrang
            // 
            this.lblSoTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTrang.ForeColor = System.Drawing.Color.White;
            this.lblSoTrang.Location = new System.Drawing.Point(262, 9);
            this.lblSoTrang.Name = "lblSoTrang";
            this.lblSoTrang.Size = new System.Drawing.Size(50, 20);
            this.lblSoTrang.TabIndex = 7;
            this.lblSoTrang.Text = "Trang";
            this.lblSoTrang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 30;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TimeStamp,
            this.PhuongThucGD,
            this.Price,
            this.Username,
            this.IsCheck,
            this.Action,
            this.Action2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(1720, 600);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridView.ThemeStyle.ReadOnly = false;
            this.dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 5;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(50, 666);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã hóa đơn";
            this.ID.Name = "ID";
            // 
            // TimeStamp
            // 
            this.TimeStamp.FillWeight = 66.1519F;
            this.TimeStamp.HeaderText = "Ngày giao dịch";
            this.TimeStamp.Name = "TimeStamp";
            // 
            // PhuongThucGD
            // 
            this.PhuongThucGD.FillWeight = 66.1519F;
            this.PhuongThucGD.HeaderText = "Phương thức giao dịch";
            this.PhuongThucGD.Name = "PhuongThucGD";
            // 
            // Price
            // 
            this.Price.FillWeight = 66.1519F;
            this.Price.HeaderText = "Tổng tiền";
            this.Price.Name = "Price";
            // 
            // Username
            // 
            this.Username.FillWeight = 66.1519F;
            this.Username.HeaderText = "Tên khách";
            this.Username.Name = "Username";
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IsCheck
            // 
            this.IsCheck.FillWeight = 66.1519F;
            this.IsCheck.HeaderText = "Trạng thái";
            this.IsCheck.Name = "IsCheck";
            this.IsCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Action
            // 
            this.Action.FillWeight = 50F;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Text = "Duyệt";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // Action2
            // 
            this.Action2.FillWeight = 50F;
            this.Action2.HeaderText = "";
            this.Action2.Name = "Action2";
            this.Action2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action2.Text = "Chỉ tiết";
            this.Action2.UseColumnTextForButtonValue = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(44)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1820, 1000);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnContent.ResumeLayout(false);
            this.pnFooter.ResumeLayout(false);
            this.pnFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private Guna.UI2.WinForms.Guna2TextBox txbTimKiem;
        private System.Windows.Forms.ComboBox cbbCot;
        private System.Windows.Forms.Label lblCot;
        private System.Windows.Forms.Label lblSapXep;
        private System.Windows.Forms.ComboBox cbbSapXep;
        private Guna.UI2.WinForms.Guna2Panel pnContent;
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.ComboBox cbbSoDong;
        private System.Windows.Forms.Label lblSoDong;
        private System.Windows.Forms.Button btnTrangKe;
        private System.Windows.Forms.Label lblSoTrang;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.Button btnTrangTruoc;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongThucGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsCheck;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
    }
}