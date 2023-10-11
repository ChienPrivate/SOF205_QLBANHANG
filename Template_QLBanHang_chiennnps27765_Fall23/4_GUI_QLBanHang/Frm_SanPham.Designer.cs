namespace GUI_QLBanHang
{
    partial class Frm_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SanPham));
            this.numDonGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.numDonGiaBan = new System.Windows.Forms.NumericUpDown();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtviewDanhMucSanPham = new System.Windows.Forms.DataGridView();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtHinh = new System.Windows.Forms.RichTextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnDong = new FontAwesome.Sharp.IconButton();
            this.ibtnDanhSach = new FontAwesome.Sharp.IconButton();
            this.ibtnBoQua = new FontAwesome.Sharp.IconButton();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.pboxHinhAnh = new System.Windows.Forms.PictureBox();
            this.ibtnChonHinh = new FontAwesome.Sharp.IconButton();
            this.ibtnXoaHinh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewDanhMucSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // numDonGiaNhap
            // 
            this.numDonGiaNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numDonGiaNhap.Location = new System.Drawing.Point(185, 289);
            this.numDonGiaNhap.Name = "numDonGiaNhap";
            this.numDonGiaNhap.Size = new System.Drawing.Size(182, 22);
            this.numDonGiaNhap.TabIndex = 90;
            this.numDonGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDonGiaNhap_KeyPress);
            // 
            // numDonGiaBan
            // 
            this.numDonGiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numDonGiaBan.Location = new System.Drawing.Point(185, 251);
            this.numDonGiaBan.Name = "numDonGiaBan";
            this.numDonGiaBan.Size = new System.Drawing.Size(182, 22);
            this.numDonGiaBan.TabIndex = 89;
            this.numDonGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDonGiaBan_KeyPress);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSoLuong.Location = new System.Drawing.Point(185, 211);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(182, 22);
            this.numSoLuong.TabIndex = 88;
            this.numSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numSoLuong_KeyPress);
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(658, 60);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(16, 16);
            this.labelEmail.TabIndex = 87;
            this.labelEmail.Text = "...";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.ibtnTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dtviewDanhMucSanPham);
            this.panel2.Location = new System.Drawing.Point(94, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 353);
            this.panel2.TabIndex = 79;
            // 
            // ibtnTimKiem
            // 
            this.ibtnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ibtnTimKiem.FlatAppearance.BorderSize = 0;
            this.ibtnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ibtnTimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.ibtnTimKiem.IconColor = System.Drawing.Color.White;
            this.ibtnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTimKiem.IconSize = 28;
            this.ibtnTimKiem.Location = new System.Drawing.Point(520, 69);
            this.ibtnTimKiem.Name = "ibtnTimKiem";
            this.ibtnTimKiem.Size = new System.Drawing.Size(111, 35);
            this.ibtnTimKiem.TabIndex = 35;
            this.ibtnTimKiem.Text = "Tìm Kiếm";
            this.ibtnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTimKiem.UseVisualStyleBackColor = false;
            this.ibtnTimKiem.Click += new System.EventHandler(this.ibtnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(256, 73);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(247, 26);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(310, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Danh Mục Sản Phẩm";
            // 
            // dtviewDanhMucSanPham
            // 
            this.dtviewDanhMucSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtviewDanhMucSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtviewDanhMucSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtviewDanhMucSanPham.Location = new System.Drawing.Point(0, 123);
            this.dtviewDanhMucSanPham.MultiSelect = false;
            this.dtviewDanhMucSanPham.Name = "dtviewDanhMucSanPham";
            this.dtviewDanhMucSanPham.ReadOnly = true;
            this.dtviewDanhMucSanPham.RowHeadersWidth = 51;
            this.dtviewDanhMucSanPham.RowTemplate.Height = 24;
            this.dtviewDanhMucSanPham.Size = new System.Drawing.Size(862, 227);
            this.dtviewDanhMucSanPham.TabIndex = 0;
            this.dtviewDanhMucSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtviewDanhMucSanPham_SelectionChanged);
            this.dtviewDanhMucSanPham.SelectionChanged += new System.EventHandler(this.dtviewDanhMucSanPham_SelectionChanged);
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtGhiChu.Location = new System.Drawing.Point(484, 229);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(302, 78);
            this.rtxtGhiChu.TabIndex = 78;
            this.rtxtGhiChu.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 77;
            this.label8.Text = "Ghi Chú";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 76;
            this.label7.Text = "Hình";
            // 
            // rtxtHinh
            // 
            this.rtxtHinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtHinh.Location = new System.Drawing.Point(484, 134);
            this.rtxtHinh.Name = "rtxtHinh";
            this.rtxtHinh.Size = new System.Drawing.Size(174, 78);
            this.rtxtHinh.TabIndex = 75;
            this.rtxtHinh.Text = "";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenHang.Location = new System.Drawing.Point(185, 171);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(226, 22);
            this.txtTenHang.TabIndex = 71;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHang.Location = new System.Drawing.Point(185, 131);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(226, 22);
            this.txtMaHang.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "Đơn Giá Nhập:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 68;
            this.label5.Text = "Đơn Giá Bán:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Tên Hàng:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Mã Hàng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 64;
            this.label1.Text = "Sản Phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 100);
            this.panel1.TabIndex = 91;
            // 
            // ibtnDong
            // 
            this.ibtnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ibtnDong.FlatAppearance.BorderSize = 0;
            this.ibtnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ibtnDong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtnDong.IconChar = FontAwesome.Sharp.IconChar.SquareCaretDown;
            this.ibtnDong.IconColor = System.Drawing.Color.White;
            this.ibtnDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDong.IconSize = 28;
            this.ibtnDong.Location = new System.Drawing.Point(893, 713);
            this.ibtnDong.Name = "ibtnDong";
            this.ibtnDong.Size = new System.Drawing.Size(136, 50);
            this.ibtnDong.TabIndex = 98;
            this.ibtnDong.Text = "Đóng";
            this.ibtnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDong.UseVisualStyleBackColor = false;
            this.ibtnDong.Click += new System.EventHandler(this.ibtnDong_Click);
            // 
            // ibtnDanhSach
            // 
            this.ibtnDanhSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ibtnDanhSach.FlatAppearance.BorderSize = 0;
            this.ibtnDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ibtnDanhSach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtnDanhSach.IconChar = FontAwesome.Sharp.IconChar.List;
            this.ibtnDanhSach.IconColor = System.Drawing.Color.White;
            this.ibtnDanhSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDanhSach.IconSize = 28;
            this.ibtnDanhSach.Location = new System.Drawing.Point(751, 713);
            this.ibtnDanhSach.Name = "ibtnDanhSach";
            this.ibtnDanhSach.Size = new System.Drawing.Size(136, 50);
            this.ibtnDanhSach.TabIndex = 97;
            this.ibtnDanhSach.Text = "Danh Sách";
            this.ibtnDanhSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDanhSach.UseVisualStyleBackColor = false;
            this.ibtnDanhSach.Click += new System.EventHandler(this.ibtnDanhSach_Click);
            // 
            // ibtnBoQua
            // 
            this.ibtnBoQua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnBoQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ibtnBoQua.FlatAppearance.BorderSize = 0;
            this.ibtnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ibtnBoQua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtnBoQua.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.ibtnBoQua.IconColor = System.Drawing.Color.White;
            this.ibtnBoQua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBoQua.IconSize = 28;
            this.ibtnBoQua.Location = new System.Drawing.Point(612, 713);
            this.ibtnBoQua.Name = "ibtnBoQua";
            this.ibtnBoQua.Size = new System.Drawing.Size(133, 50);
            this.ibtnBoQua.TabIndex = 96;
            this.ibtnBoQua.Text = "Bỏ Qua";
            this.ibtnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnBoQua.UseVisualStyleBackColor = false;
            this.ibtnBoQua.Click += new System.EventHandler(this.ibtnBoQua_Click);
            // 
            // ibtnLuu
            // 
            this.ibtnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ibtnLuu.FlatAppearance.BorderSize = 0;
            this.ibtnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ibtnLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtnLuu.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.ibtnLuu.IconColor = System.Drawing.Color.White;
            this.ibtnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLuu.IconSize = 28;
            this.ibtnLuu.Location = new System.Drawing.Point(470, 713);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(136, 50);
            this.ibtnLuu.TabIndex = 95;
            this.ibtnLuu.Text = "Lưu";
            this.ibtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLuu.UseVisualStyleBackColor = false;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Click);
            // 
            // ibtnSua
            // 
            this.ibtnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ibtnSua.FlatAppearance.BorderSize = 0;
            this.ibtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ibtnSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtnSua.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.ibtnSua.IconColor = System.Drawing.Color.White;
            this.ibtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSua.IconSize = 28;
            this.ibtnSua.Location = new System.Drawing.Point(328, 713);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(136, 50);
            this.ibtnSua.TabIndex = 94;
            this.ibtnSua.Text = "Sửa";
            this.ibtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSua.UseVisualStyleBackColor = false;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // ibtnXoa
            // 
            this.ibtnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ibtnXoa.FlatAppearance.BorderSize = 0;
            this.ibtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ibtnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnXoa.IconColor = System.Drawing.Color.White;
            this.ibtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoa.IconSize = 28;
            this.ibtnXoa.Location = new System.Drawing.Point(188, 713);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(136, 50);
            this.ibtnXoa.TabIndex = 93;
            this.ibtnXoa.Text = "Xóa";
            this.ibtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXoa.UseVisualStyleBackColor = false;
            this.ibtnXoa.Click += new System.EventHandler(this.ibtnXoa_Click);
            // 
            // ibtnThem
            // 
            this.ibtnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ibtnThem.FlatAppearance.BorderSize = 0;
            this.ibtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ibtnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtnThem.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibtnThem.IconColor = System.Drawing.Color.White;
            this.ibtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThem.IconSize = 28;
            this.ibtnThem.Location = new System.Drawing.Point(46, 713);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(136, 50);
            this.ibtnThem.TabIndex = 92;
            this.ibtnThem.Text = "Thêm";
            this.ibtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThem.UseVisualStyleBackColor = false;
            this.ibtnThem.Click += new System.EventHandler(this.ibtnThem_Click);
            // 
            // pboxHinhAnh
            // 
            this.pboxHinhAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxHinhAnh.BackColor = System.Drawing.Color.Azure;
            this.pboxHinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("pboxHinhAnh.Image")));
            this.pboxHinhAnh.Location = new System.Drawing.Point(801, 127);
            this.pboxHinhAnh.Name = "pboxHinhAnh";
            this.pboxHinhAnh.Size = new System.Drawing.Size(175, 180);
            this.pboxHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxHinhAnh.TabIndex = 72;
            this.pboxHinhAnh.TabStop = false;
            this.pboxHinhAnh.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxHinhAnh_Paint);
            // 
            // ibtnChonHinh
            // 
            this.ibtnChonHinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnChonHinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ibtnChonHinh.FlatAppearance.BorderSize = 0;
            this.ibtnChonHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnChonHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ibtnChonHinh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtnChonHinh.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.ibtnChonHinh.IconColor = System.Drawing.Color.White;
            this.ibtnChonHinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnChonHinh.IconSize = 28;
            this.ibtnChonHinh.Location = new System.Drawing.Point(667, 134);
            this.ibtnChonHinh.Name = "ibtnChonHinh";
            this.ibtnChonHinh.Size = new System.Drawing.Size(119, 35);
            this.ibtnChonHinh.TabIndex = 36;
            this.ibtnChonHinh.Text = "Chọn Hình";
            this.ibtnChonHinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnChonHinh.UseVisualStyleBackColor = false;
            this.ibtnChonHinh.Click += new System.EventHandler(this.ibtnChonHinh_Click);
            // 
            // ibtnXoaHinh
            // 
            this.ibtnXoaHinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnXoaHinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ibtnXoaHinh.FlatAppearance.BorderSize = 0;
            this.ibtnXoaHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnXoaHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ibtnXoaHinh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibtnXoaHinh.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.ibtnXoaHinh.IconColor = System.Drawing.Color.White;
            this.ibtnXoaHinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoaHinh.IconSize = 28;
            this.ibtnXoaHinh.Location = new System.Drawing.Point(667, 175);
            this.ibtnXoaHinh.Name = "ibtnXoaHinh";
            this.ibtnXoaHinh.Size = new System.Drawing.Size(119, 38);
            this.ibtnXoaHinh.TabIndex = 99;
            this.ibtnXoaHinh.Text = "Xóa Hình";
            this.ibtnXoaHinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXoaHinh.UseVisualStyleBackColor = false;
            this.ibtnXoaHinh.Click += new System.EventHandler(this.ibtnXoaHinh_Click);
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1059, 788);
            this.Controls.Add(this.ibtnXoaHinh);
            this.Controls.Add(this.ibtnChonHinh);
            this.Controls.Add(this.ibtnDong);
            this.Controls.Add(this.ibtnDanhSach);
            this.Controls.Add(this.ibtnBoQua);
            this.Controls.Add(this.ibtnLuu);
            this.Controls.Add(this.ibtnSua);
            this.Controls.Add(this.ibtnXoa);
            this.Controls.Add(this.ibtnThem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numDonGiaNhap);
            this.Controls.Add(this.numDonGiaBan);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rtxtGhiChu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtxtHinh);
            this.Controls.Add(this.pboxHinhAnh);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Frm_SanPham";
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.Frm_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDonGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewDanhMucSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDonGiaNhap;
        private System.Windows.Forms.NumericUpDown numDonGiaBan;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtviewDanhMucSanPham;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtHinh;
        private System.Windows.Forms.PictureBox pboxHinhAnh;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibtnDong;
        private FontAwesome.Sharp.IconButton ibtnDanhSach;
        private FontAwesome.Sharp.IconButton ibtnBoQua;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private FontAwesome.Sharp.IconButton ibtnTimKiem;
        private FontAwesome.Sharp.IconButton ibtnChonHinh;
        private FontAwesome.Sharp.IconButton ibtnXoaHinh;
    }
}