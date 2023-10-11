namespace GUI_QLBanHang
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.ibtnThongKe = new FontAwesome.Sharp.IconButton();
            this.ibtnHuongDan = new FontAwesome.Sharp.IconButton();
            this.ibtnKhachHang = new FontAwesome.Sharp.IconButton();
            this.tbtnSanPham = new FontAwesome.Sharp.IconButton();
            this.ibtnNhanVien = new FontAwesome.Sharp.IconButton();
            this.ibtnDangXuat = new FontAwesome.Sharp.IconButton();
            this.ibtnDangNhap = new FontAwesome.Sharp.IconButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.ibtnMenu = new FontAwesome.Sharp.IconButton();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.ibtnHide = new FontAwesome.Sharp.IconButton();
            this.labelMain = new System.Windows.Forms.Label();
            this.ibtnMaximize = new FontAwesome.Sharp.IconButton();
            this.ibtnClosed = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.ibtnTaiKhoan);
            this.panelMenu.Controls.Add(this.ibtnThongKe);
            this.panelMenu.Controls.Add(this.ibtnHuongDan);
            this.panelMenu.Controls.Add(this.ibtnKhachHang);
            this.panelMenu.Controls.Add(this.tbtnSanPham);
            this.panelMenu.Controls.Add(this.ibtnNhanVien);
            this.panelMenu.Controls.Add(this.ibtnDangXuat);
            this.panelMenu.Controls.Add(this.ibtnDangNhap);
            this.panelMenu.Controls.Add(this.panelHeader);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 827);
            this.panelMenu.TabIndex = 0;
            // 
            // ibtnTaiKhoan
            // 
            this.ibtnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ibtnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.ibtnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTaiKhoan.Font = new System.Drawing.Font("Verdana", 10F);
            this.ibtnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.ibtnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.ibtnTaiKhoan.IconColor = System.Drawing.Color.White;
            this.ibtnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTaiKhoan.Location = new System.Drawing.Point(0, 423);
            this.ibtnTaiKhoan.Name = "ibtnTaiKhoan";
            this.ibtnTaiKhoan.Size = new System.Drawing.Size(230, 50);
            this.ibtnTaiKhoan.TabIndex = 8;
            this.ibtnTaiKhoan.Tag = "Tài Khoản";
            this.ibtnTaiKhoan.Text = "Tài Khoản";
            this.ibtnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTaiKhoan.UseVisualStyleBackColor = false;
            this.ibtnTaiKhoan.Click += new System.EventHandler(this.ibtnTaiKhoan_Click);
            // 
            // ibtnThongKe
            // 
            this.ibtnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ibtnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnThongKe.FlatAppearance.BorderSize = 0;
            this.ibtnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThongKe.Font = new System.Drawing.Font("Verdana", 10F);
            this.ibtnThongKe.ForeColor = System.Drawing.Color.White;
            this.ibtnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.ibtnThongKe.IconColor = System.Drawing.Color.White;
            this.ibtnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThongKe.Location = new System.Drawing.Point(0, 373);
            this.ibtnThongKe.Name = "ibtnThongKe";
            this.ibtnThongKe.Size = new System.Drawing.Size(230, 50);
            this.ibtnThongKe.TabIndex = 7;
            this.ibtnThongKe.Tag = "Thống Kê";
            this.ibtnThongKe.Text = "Thống Kê";
            this.ibtnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThongKe.UseVisualStyleBackColor = false;
            this.ibtnThongKe.Click += new System.EventHandler(this.ibtnThongKe_Click);
            // 
            // ibtnHuongDan
            // 
            this.ibtnHuongDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ibtnHuongDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnHuongDan.FlatAppearance.BorderSize = 0;
            this.ibtnHuongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHuongDan.Font = new System.Drawing.Font("Verdana", 10F);
            this.ibtnHuongDan.ForeColor = System.Drawing.Color.White;
            this.ibtnHuongDan.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.ibtnHuongDan.IconColor = System.Drawing.Color.White;
            this.ibtnHuongDan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHuongDan.Location = new System.Drawing.Point(0, 323);
            this.ibtnHuongDan.Name = "ibtnHuongDan";
            this.ibtnHuongDan.Size = new System.Drawing.Size(230, 50);
            this.ibtnHuongDan.TabIndex = 6;
            this.ibtnHuongDan.Tag = "Hướng Dẫn";
            this.ibtnHuongDan.Text = "Hướng Dẫn";
            this.ibtnHuongDan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnHuongDan.UseVisualStyleBackColor = false;
            this.ibtnHuongDan.Click += new System.EventHandler(this.ibtnHuongDan_Click);
            // 
            // ibtnKhachHang
            // 
            this.ibtnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ibtnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnKhachHang.FlatAppearance.BorderSize = 0;
            this.ibtnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnKhachHang.Font = new System.Drawing.Font("Verdana", 10F);
            this.ibtnKhachHang.ForeColor = System.Drawing.Color.White;
            this.ibtnKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.ibtnKhachHang.IconColor = System.Drawing.Color.White;
            this.ibtnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnKhachHang.Location = new System.Drawing.Point(0, 273);
            this.ibtnKhachHang.Name = "ibtnKhachHang";
            this.ibtnKhachHang.Size = new System.Drawing.Size(230, 50);
            this.ibtnKhachHang.TabIndex = 5;
            this.ibtnKhachHang.Tag = "Khách Hàng";
            this.ibtnKhachHang.Text = "Khách Hàng";
            this.ibtnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnKhachHang.UseVisualStyleBackColor = false;
            this.ibtnKhachHang.Click += new System.EventHandler(this.ibtnKhachHang_Click);
            // 
            // tbtnSanPham
            // 
            this.tbtnSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.tbtnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbtnSanPham.FlatAppearance.BorderSize = 0;
            this.tbtnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbtnSanPham.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbtnSanPham.ForeColor = System.Drawing.Color.White;
            this.tbtnSanPham.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.tbtnSanPham.IconColor = System.Drawing.Color.White;
            this.tbtnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tbtnSanPham.Location = new System.Drawing.Point(0, 223);
            this.tbtnSanPham.Name = "tbtnSanPham";
            this.tbtnSanPham.Size = new System.Drawing.Size(230, 50);
            this.tbtnSanPham.TabIndex = 4;
            this.tbtnSanPham.Tag = "Sản Phẩm";
            this.tbtnSanPham.Text = "Sản Phẩm";
            this.tbtnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbtnSanPham.UseVisualStyleBackColor = false;
            this.tbtnSanPham.Click += new System.EventHandler(this.tbtnSanPham_Click);
            // 
            // ibtnNhanVien
            // 
            this.ibtnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ibtnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnNhanVien.FlatAppearance.BorderSize = 0;
            this.ibtnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNhanVien.Font = new System.Drawing.Font("Verdana", 10F);
            this.ibtnNhanVien.ForeColor = System.Drawing.Color.White;
            this.ibtnNhanVien.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ibtnNhanVien.IconColor = System.Drawing.Color.White;
            this.ibtnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNhanVien.Location = new System.Drawing.Point(0, 173);
            this.ibtnNhanVien.Name = "ibtnNhanVien";
            this.ibtnNhanVien.Size = new System.Drawing.Size(230, 50);
            this.ibtnNhanVien.TabIndex = 3;
            this.ibtnNhanVien.Tag = "Nhân Viên";
            this.ibtnNhanVien.Text = "Nhân Viên";
            this.ibtnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnNhanVien.UseVisualStyleBackColor = false;
            this.ibtnNhanVien.Click += new System.EventHandler(this.ibtnNhanVien_Click);
            // 
            // ibtnDangXuat
            // 
            this.ibtnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ibtnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnDangXuat.FlatAppearance.BorderSize = 0;
            this.ibtnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDangXuat.Font = new System.Drawing.Font("Verdana", 10F);
            this.ibtnDangXuat.ForeColor = System.Drawing.Color.White;
            this.ibtnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtnDangXuat.IconColor = System.Drawing.Color.White;
            this.ibtnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDangXuat.Location = new System.Drawing.Point(0, 766);
            this.ibtnDangXuat.Name = "ibtnDangXuat";
            this.ibtnDangXuat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.ibtnDangXuat.Size = new System.Drawing.Size(230, 61);
            this.ibtnDangXuat.TabIndex = 2;
            this.ibtnDangXuat.Tag = "Đăng Xuất";
            this.ibtnDangXuat.Text = "Đăng Xuất";
            this.ibtnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDangXuat.UseVisualStyleBackColor = false;
            this.ibtnDangXuat.Click += new System.EventHandler(this.ibtnDangXuat_Click);
            // 
            // ibtnDangNhap
            // 
            this.ibtnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ibtnDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnDangNhap.FlatAppearance.BorderSize = 0;
            this.ibtnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDangNhap.Font = new System.Drawing.Font("Verdana", 10F);
            this.ibtnDangNhap.ForeColor = System.Drawing.Color.White;
            this.ibtnDangNhap.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ibtnDangNhap.IconColor = System.Drawing.Color.White;
            this.ibtnDangNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDangNhap.Location = new System.Drawing.Point(0, 123);
            this.ibtnDangNhap.Name = "ibtnDangNhap";
            this.ibtnDangNhap.Size = new System.Drawing.Size(230, 50);
            this.ibtnDangNhap.TabIndex = 1;
            this.ibtnDangNhap.Tag = "Đăng Nhập";
            this.ibtnDangNhap.Text = "Đăng Nhập";
            this.ibtnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDangNhap.UseVisualStyleBackColor = false;
            this.ibtnDangNhap.Click += new System.EventHandler(this.ibtnDangNhap_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pboxLogo);
            this.panelHeader.Controls.Add(this.ibtnMenu);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(230, 123);
            this.panelHeader.TabIndex = 0;
            // 
            // pboxLogo
            // 
            this.pboxLogo.BackgroundImage = global::GUI_QLBanHang.Properties.Resources.Lazada;
            this.pboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxLogo.Location = new System.Drawing.Point(0, 3);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Padding = new System.Windows.Forms.Padding(3);
            this.pboxLogo.Size = new System.Drawing.Size(167, 50);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 0;
            this.pboxLogo.TabStop = false;
            // 
            // ibtnMenu
            // 
            this.ibtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ibtnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnMenu.FlatAppearance.BorderSize = 0;
            this.ibtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMenu.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.ibtnMenu.IconColor = System.Drawing.Color.White;
            this.ibtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMenu.Location = new System.Drawing.Point(173, 2);
            this.ibtnMenu.Name = "ibtnMenu";
            this.ibtnMenu.Size = new System.Drawing.Size(57, 53);
            this.ibtnMenu.TabIndex = 1;
            this.ibtnMenu.UseVisualStyleBackColor = false;
            this.ibtnMenu.Click += new System.EventHandler(this.ibtnMenu_Click);
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.labelEmail);
            this.panelUserInfo.Controls.Add(this.iconPictureBox1);
            this.panelUserInfo.Location = new System.Drawing.Point(6, 55);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(345, 42);
            this.panelUserInfo.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(48, 10);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(27, 20);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "...";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(42, 41);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.panelUserInfo);
            this.panelTitleBar.Controls.Add(this.ibtnHide);
            this.panelTitleBar.Controls.Add(this.labelMain);
            this.panelTitleBar.Controls.Add(this.ibtnMaximize);
            this.panelTitleBar.Controls.Add(this.ibtnClosed);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(990, 103);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // ibtnHide
            // 
            this.ibtnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnHide.BackColor = System.Drawing.Color.Turquoise;
            this.ibtnHide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnHide.FlatAppearance.BorderSize = 0;
            this.ibtnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHide.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ibtnHide.IconColor = System.Drawing.Color.White;
            this.ibtnHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHide.IconSize = 28;
            this.ibtnHide.Location = new System.Drawing.Point(820, 3);
            this.ibtnHide.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ibtnHide.Name = "ibtnHide";
            this.ibtnHide.Size = new System.Drawing.Size(56, 33);
            this.ibtnHide.TabIndex = 3;
            this.ibtnHide.UseVisualStyleBackColor = false;
            this.ibtnHide.Click += new System.EventHandler(this.ibtnHide_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(3, 2);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(233, 40);
            this.labelMain.TabIndex = 5;
            this.labelMain.Text = "DASHBOARD";
            // 
            // ibtnMaximize
            // 
            this.ibtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ibtnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnMaximize.FlatAppearance.BorderSize = 0;
            this.ibtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.ibtnMaximize.IconColor = System.Drawing.Color.White;
            this.ibtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMaximize.IconSize = 28;
            this.ibtnMaximize.Location = new System.Drawing.Point(876, 3);
            this.ibtnMaximize.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ibtnMaximize.Name = "ibtnMaximize";
            this.ibtnMaximize.Size = new System.Drawing.Size(56, 33);
            this.ibtnMaximize.TabIndex = 4;
            this.ibtnMaximize.UseVisualStyleBackColor = false;
            this.ibtnMaximize.Click += new System.EventHandler(this.ibtnMaximize_Click);
            // 
            // ibtnClosed
            // 
            this.ibtnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnClosed.BackColor = System.Drawing.Color.OrangeRed;
            this.ibtnClosed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnClosed.FlatAppearance.BorderSize = 0;
            this.ibtnClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClosed.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ibtnClosed.IconColor = System.Drawing.Color.White;
            this.ibtnClosed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnClosed.IconSize = 28;
            this.ibtnClosed.Location = new System.Drawing.Point(932, 3);
            this.ibtnClosed.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ibtnClosed.Name = "ibtnClosed";
            this.ibtnClosed.Size = new System.Drawing.Size(56, 33);
            this.ibtnClosed.TabIndex = 2;
            this.ibtnClosed.UseVisualStyleBackColor = false;
            this.ibtnClosed.Click += new System.EventHandler(this.ibtnClosed_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 103);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(990, 724);
            this.panelDesktop.TabIndex = 2;
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1220, 827);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Resize += new System.EventHandler(this.Frm_Main_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton ibtnMenu;
        private FontAwesome.Sharp.IconButton ibtnDangNhap;
        private FontAwesome.Sharp.IconButton ibtnDangXuat;
        private FontAwesome.Sharp.IconButton ibtnThongKe;
        private FontAwesome.Sharp.IconButton ibtnHuongDan;
        private FontAwesome.Sharp.IconButton ibtnKhachHang;
        private FontAwesome.Sharp.IconButton tbtnSanPham;
        private FontAwesome.Sharp.IconButton ibtnNhanVien;
        private FontAwesome.Sharp.IconButton ibtnHide;
        private FontAwesome.Sharp.IconButton ibtnClosed;
        private FontAwesome.Sharp.IconButton ibtnMaximize;
        private System.Windows.Forms.Label labelMain;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label labelEmail;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton ibtnTaiKhoan;
    }
}