namespace GUI_QLBanHang
{
    partial class Frm_KhachHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtviewKhachHang = new System.Windows.Forms.DataGridView();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rtxtDiaChi = new System.Windows.Forms.RichTextBox();
            this.ibtnDong = new FontAwesome.Sharp.IconButton();
            this.ibtnDanhSach = new FontAwesome.Sharp.IconButton();
            this.ibtnBoQua = new FontAwesome.Sharp.IconButton();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.ibtnTimKiem = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewKhachHang)).BeginInit();
            this.grbGender.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Và Tên";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDienThoai.Location = new System.Drawing.Point(208, 139);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(268, 22);
            this.txtDienThoai.TabIndex = 5;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoVaTen.Location = new System.Drawing.Point(208, 207);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(268, 22);
            this.txtHoVaTen.TabIndex = 6;
            this.txtHoVaTen.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.ibtnTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.dtviewKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(108, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 303);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Khách Hàng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(256, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(232, 26);
            this.txtTimKiem.TabIndex = 15;
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // dtviewKhachHang
            // 
            this.dtviewKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtviewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtviewKhachHang.Location = new System.Drawing.Point(0, 96);
            this.dtviewKhachHang.MultiSelect = false;
            this.dtviewKhachHang.Name = "dtviewKhachHang";
            this.dtviewKhachHang.ReadOnly = true;
            this.dtviewKhachHang.RowHeadersWidth = 51;
            this.dtviewKhachHang.RowTemplate.Height = 24;
            this.dtviewKhachHang.Size = new System.Drawing.Size(812, 207);
            this.dtviewKhachHang.TabIndex = 13;
            this.dtviewKhachHang.SelectionChanged += new System.EventHandler(this.dtviewKhachHang_SelectionChanged);
            // 
            // grbGender
            // 
            this.grbGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbGender.Controls.Add(this.rdoNu);
            this.grbGender.Controls.Add(this.rdoNam);
            this.grbGender.Location = new System.Drawing.Point(550, 198);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(352, 52);
            this.grbGender.TabIndex = 17;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Giới Tính";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(233, 21);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(45, 20);
            this.rdoNu.TabIndex = 11;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(71, 21);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(57, 20);
            this.rdoNam.TabIndex = 10;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rtxtDiaChi
            // 
            this.rtxtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtDiaChi.Location = new System.Drawing.Point(634, 136);
            this.rtxtDiaChi.Name = "rtxtDiaChi";
            this.rtxtDiaChi.Size = new System.Drawing.Size(268, 56);
            this.rtxtDiaChi.TabIndex = 19;
            this.rtxtDiaChi.Text = "";
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
            this.ibtnDong.Location = new System.Drawing.Point(867, 654);
            this.ibtnDong.Name = "ibtnDong";
            this.ibtnDong.Size = new System.Drawing.Size(136, 50);
            this.ibtnDong.TabIndex = 40;
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
            this.ibtnDanhSach.Location = new System.Drawing.Point(725, 654);
            this.ibtnDanhSach.Name = "ibtnDanhSach";
            this.ibtnDanhSach.Size = new System.Drawing.Size(136, 50);
            this.ibtnDanhSach.TabIndex = 39;
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
            this.ibtnBoQua.Location = new System.Drawing.Point(586, 654);
            this.ibtnBoQua.Name = "ibtnBoQua";
            this.ibtnBoQua.Size = new System.Drawing.Size(133, 50);
            this.ibtnBoQua.TabIndex = 38;
            this.ibtnBoQua.Text = "Bỏ Qua";
            this.ibtnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnBoQua.UseVisualStyleBackColor = false;
            this.ibtnBoQua.Click += new System.EventHandler(this.iBoQua_Click);
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
            this.ibtnLuu.Location = new System.Drawing.Point(444, 654);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(136, 50);
            this.ibtnLuu.TabIndex = 37;
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
            this.ibtnSua.Location = new System.Drawing.Point(302, 654);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(136, 50);
            this.ibtnSua.TabIndex = 36;
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
            this.ibtnXoa.Location = new System.Drawing.Point(162, 654);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(136, 50);
            this.ibtnXoa.TabIndex = 35;
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
            this.ibtnThem.Location = new System.Drawing.Point(20, 654);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(136, 50);
            this.ibtnThem.TabIndex = 34;
            this.ibtnThem.Text = "Thêm";
            this.ibtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThem.UseVisualStyleBackColor = false;
            this.ibtnThem.Click += new System.EventHandler(this.ibtnThem_Click);
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
            this.ibtnTimKiem.Location = new System.Drawing.Point(494, 38);
            this.ibtnTimKiem.Name = "ibtnTimKiem";
            this.ibtnTimKiem.Size = new System.Drawing.Size(111, 35);
            this.ibtnTimKiem.TabIndex = 35;
            this.ibtnTimKiem.Text = "Tìm Kiếm";
            this.ibtnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTimKiem.UseVisualStyleBackColor = false;
            this.ibtnTimKiem.Click += new System.EventHandler(this.ibtnTimKiem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 100);
            this.panel2.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1015, 773);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ibtnDong);
            this.Controls.Add(this.ibtnDanhSach);
            this.Controls.Add(this.ibtnBoQua);
            this.Controls.Add(this.ibtnLuu);
            this.Controls.Add(this.ibtnSua);
            this.Controls.Add(this.ibtnXoa);
            this.Controls.Add(this.ibtnThem);
            this.Controls.Add(this.rtxtDiaChi);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Frm_KhachHang";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewKhachHang)).EndInit();
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dtviewKhachHang;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RichTextBox rtxtDiaChi;
        private FontAwesome.Sharp.IconButton ibtnDong;
        private FontAwesome.Sharp.IconButton ibtnDanhSach;
        private FontAwesome.Sharp.IconButton ibtnBoQua;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private FontAwesome.Sharp.IconButton ibtnTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}