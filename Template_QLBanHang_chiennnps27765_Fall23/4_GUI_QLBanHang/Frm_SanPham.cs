using _2_BUS_QLBanHang;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class Frm_SanPham : Form
    {
        private string Email;
        private string MaNV;
        private BUS_Hang bus_Hang;
        private Image placeholder;
        public Frm_SanPham(string email)
        {
            InitializeComponent();
            bus_Hang = new BUS_Hang();
            Email = email;
            MaNV = bus_Hang.MaNhanVien(Email);
            placeholder = pboxHinhAnh.Image;
        }

        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            dtviewDanhMucSanPham.DataSource = bus_Hang.DanhMucSanPham();
            if (dtviewDanhMucSanPham.DataSource != null)
            {
                dtviewDanhMucSanPham.Columns["MaHang"].HeaderText = "Mã Hàng";
                dtviewDanhMucSanPham.Columns["TenHang"].HeaderText = "Tên Hàng";
                dtviewDanhMucSanPham.Columns["SoLuong"].HeaderText = "Số Lượng";
                dtviewDanhMucSanPham.Columns["DonGiaBan"].HeaderText = "Đơn Giá Bán";
                dtviewDanhMucSanPham.Columns["DonGiaNhap"].HeaderText = "Đơn Giá Nhập";
                dtviewDanhMucSanPham.Columns["HinhAnh"].HeaderText = "Hình Ảnh";
                dtviewDanhMucSanPham.Columns["GhiChu"].HeaderText = "Ghi Chú";
                dtviewDanhMucSanPham.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            }

            labelEmail.Text = Email;
            labelEmail.Visible = false;
            txtMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            numSoLuong.Enabled = false;
            numSoLuong.Maximum = decimal.MaxValue;
            numDonGiaBan.Enabled = false;
            numDonGiaBan.Maximum = decimal.MaxValue;
            numDonGiaNhap.Enabled = false;
            numDonGiaNhap.Maximum = decimal.MaxValue;
            rtxtHinh.Enabled = false;
            rtxtGhiChu.Enabled = false;
            txtTimKiem.Text = "Nhập tên sản phẩm ...";
            txtTimKiem.ForeColor = Color.Gray;

            ibtnChonHinh.Enabled = false;
            ibtnXoaHinh.Enabled = false;
            ibtnThem.Enabled = true;
            ibtnXoa.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnLuu.Enabled = false;
            ibtnBoQua.Enabled = false;

        }

        private void pboxHinhAnh_Paint(object sender, PaintEventArgs e)
        {
            /*GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(-25, -25, pboxHinhAnh.Width + 50 , pboxHinhAnh.Height + 50);
            Region rg = new Region(gp);
            pboxHinhAnh.Region = rg;*/
            ControlPaint.DrawBorder(e.Graphics, pboxHinhAnh.ClientRectangle, Color.Black, ButtonBorderStyle.Dashed);
        }

        private void dtviewDanhMucSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dtviewDanhMucSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtviewDanhMucSanPham.SelectedRows[0];
                if (row.Cells[0].Value.ToString() != string.Empty)
                {
                    string mahang = row.Cells[0].Value.ToString();
                    string tenhang = row.Cells[1].Value.ToString();
                    int soluong = int.Parse(row.Cells[2].Value.ToString());
                    float dgn;
                    float dgb;
                    string dgbStr = row.Cells[3].Value.ToString();
                    string dgnStr = row.Cells[4].Value.ToString();
                    string hinh = row.Cells[5].Value.ToString();
                    string ghichu = row.Cells[6].Value.ToString();


                    txtMaHang.Text = mahang;
                    txtTenHang.Text = tenhang;
                    numSoLuong.Text = soluong.ToString();
                    numDonGiaBan.Text = dgbStr;
                    numDonGiaNhap.Text = dgnStr;
                    rtxtHinh.Text = hinh;
                    rtxtGhiChu.Text = ghichu;
                    if (!File.Exists(hinh) && rtxtHinh.Text != string.Empty)
                    {
                        MessageBox.Show("Hình sản phẩm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pboxHinhAnh.Image = placeholder;
                    }
                    else if (hinh == string.Empty)
                    {
                        pboxHinhAnh.Image = placeholder;
                    }
                    else
                    {
                        pboxHinhAnh.Image = Image.FromFile(hinh);
                    }

                    // điều khiển các control
                    txtTenHang.Enabled = true;
                    numSoLuong.Enabled = true;
                    numDonGiaBan.Enabled = true;
                    numDonGiaNhap.Enabled = true;
                    rtxtHinh.Enabled = true;
                    rtxtGhiChu.Enabled = true;

                    ibtnChonHinh.Enabled = true;
                    ibtnXoaHinh.Enabled = true;
                    ibtnThem.Enabled = false;
                    ibtnXoa.Enabled = true;
                    ibtnSua.Enabled = true;
                    ibtnLuu.Enabled = false;
                    ibtnBoQua.Enabled = true;

                }
                else
                {
                    ClearFields();
                    txtTenHang.Enabled = true;
                    numSoLuong.Enabled = true;
                    numDonGiaBan.Enabled = true;
                    numDonGiaNhap.Enabled = true;
                    rtxtHinh.Enabled = true;
                    rtxtGhiChu.Enabled = true;

                    ibtnChonHinh.Enabled = true;
                    ibtnXoaHinh.Enabled = true;
                    ibtnThem.Enabled = false;
                    ibtnXoa.Enabled = false;
                    ibtnSua.Enabled = false;
                    ibtnLuu.Enabled = true;
                    ibtnBoQua.Enabled = true;
                }
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập tên sản phẩm ...")
            {
                txtTimKiem.Text = string.Empty;
                txtTimKiem.ForeColor = Color.Black;
                txtTimKiem.Select(0, 0);
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Nhập tên sản phẩm...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void numSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void numDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void ButtonControl(Button btn)
        {
            DialogResult log = new DialogResult();
            if (btn.Name == "ibtnThem")
            {
                txtTenHang.Enabled = true;
                numSoLuong.Enabled = true;
                numDonGiaBan.Enabled = true;
                numDonGiaNhap.Enabled = true;
                rtxtHinh.Enabled = true;
                rtxtGhiChu.Enabled = true;
                ibtnChonHinh.Enabled = true;
                ibtnXoaHinh.Enabled = true;
                ibtnThem.Enabled = false;
                ibtnXoa.Enabled = false;
                ibtnSua.Enabled = false;
                ibtnLuu.Enabled = true;
                ibtnBoQua.Enabled = true;
            }
            else if (btn.Name == "ibtnSua" || btn.Name == "ibtnXoa")
            {
                txtTenHang.Enabled = false;
                numSoLuong.Enabled = false;
                numDonGiaBan.Enabled = false;
                numDonGiaNhap.Enabled = false;
                rtxtHinh.Enabled = false;
                rtxtGhiChu.Enabled = false;
                ibtnChonHinh.Enabled = false;
                ibtnXoaHinh.Enabled = false;
                ibtnThem.Enabled = true;
                ibtnXoa.Enabled = false;
                ibtnSua.Enabled = false;
                ibtnLuu.Enabled = false;
                ibtnBoQua.Enabled = false;
            }
            else if (btn.Name == "ibtnLuu")
            {
                txtTenHang.Enabled = false;
                numSoLuong.Enabled = false;
                numDonGiaBan.Enabled = false;
                numDonGiaNhap.Enabled = false;
                rtxtHinh.Enabled = false;
                rtxtGhiChu.Enabled = false;
                ibtnChonHinh.Enabled = false;
                ibtnXoaHinh.Enabled = false;
                ibtnThem.Enabled = true;
                ibtnXoa.Enabled = false;
                ibtnSua.Enabled = false;
                ibtnLuu.Enabled = false;
                ibtnBoQua.Enabled = false;
            }
            else if (btn.Name == "ibtnBoQua")
            {
                txtTenHang.Enabled = false;
                numSoLuong.Enabled = false;
                numDonGiaBan.Enabled = false;
                numDonGiaNhap.Enabled = false;
                rtxtHinh.Enabled = false;
                rtxtGhiChu.Enabled = false;
                ibtnChonHinh.Enabled = false;
                ibtnXoaHinh.Enabled = false;
                ibtnThem.Enabled = true;
                ibtnXoa.Enabled = false;
                ibtnSua.Enabled = false;
                ibtnLuu.Enabled = false;
                ibtnBoQua.Enabled = false;
            }
            else if (btn.Name == "ibtnDong")
            {
                this.Close();
            }
        }

        private void LoadData()
        {
            dtviewDanhMucSanPham.DataSource = bus_Hang.DanhMucSanPham();
        }

        private void ClearFields()
        {
            txtMaHang.Text = string.Empty;
            txtTenHang.Text = string.Empty;
            numSoLuong.Text = string.Empty;
            numDonGiaBan.Text = string.Empty;
            numDonGiaNhap.Text = string.Empty;
            rtxtHinh.Text = string.Empty;
            rtxtGhiChu.Text = string.Empty;
            pboxHinhAnh.Image = placeholder;
            dtviewDanhMucSanPham.ClearSelection();
        }

        private void ibtnThem_Click(object sender, EventArgs e)
        {
            ButtonControl(ibtnThem);
            ClearFields();
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult log = MessageBox.Show("Bạn có muốn xóa sản phẩm này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                string masp = txtMaHang.Text.Trim();
                if (File.Exists(rtxtHinh.Text))
                {
                    pboxHinhAnh.Image.Dispose();
                    File.Delete(rtxtHinh.Text);
                    pboxHinhAnh.Image = placeholder;
                }
                MessageBox.Show(bus_Hang.XoaSanPham(masp), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonControl(ibtnXoa);
                ClearFields();
                LoadData();
            }
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            DialogResult log = MessageBox.Show("Bạn có muốn cập nhật nhân viên này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                _3_DTO_QLBanHang.Hang sanpham = new _3_DTO_QLBanHang.Hang
                {
                    MaHang = txtMaHang.Text.Trim(),
                    TenHang = txtTenHang.Text.Trim(),
                    SoLuong = int.Parse(numSoLuong.Value.ToString()),
                    DonGiaBan = float.Parse(numDonGiaBan.Value.ToString()),
                    DonGiaNhap = float.Parse(numDonGiaNhap.Value.ToString()),
                    HinhAnh = rtxtHinh.Text.Trim(),
                    GhiChu = rtxtGhiChu.Text.Trim(),
                    MaNV = bus_Hang.MaNhanVien(Email)
                };
                MessageBox.Show(bus_Hang.CapNhatSanPham(sanpham), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonControl(ibtnSua);
                ClearFields();
                LoadData();
            }
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenHang.Text == string.Empty)
            {
                MessageBox.Show("hãy nhập tên sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (numSoLuong.Value == 0)
            {
                MessageBox.Show("hãy nhập số lượng cho sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (numDonGiaBan.Value == 0)
            {
                MessageBox.Show("hãy nhập đơn giá bán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (numDonGiaNhap.Value == 0)
            {
                MessageBox.Show("hãy nhập đơn giá nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult log = MessageBox.Show("Bạn có muốn lưu sản phẩm này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                _3_DTO_QLBanHang.Hang sanpham = new _3_DTO_QLBanHang.Hang
                {
                    MaHang = bus_Hang.TaoMaSanPham(),
                    TenHang = txtTenHang.Text.Trim(),
                    SoLuong = int.Parse(numSoLuong.Text.Trim()),
                    DonGiaBan = float.Parse(numDonGiaBan.Text.Trim()),
                    DonGiaNhap = float.Parse(numDonGiaNhap.Text.Trim()),
                    HinhAnh = rtxtHinh.Text.Trim(),
                    GhiChu = rtxtGhiChu.Text.Trim(),
                    MaNV = bus_Hang.MaNhanVien(Email)
                };
                string thongbao = bus_Hang.ThemSanPham(sanpham);
                MessageBox.Show(thongbao, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonControl(ibtnLuu);
                ClearFields();
                LoadData();
            }
        }

        private void ibtnBoQua_Click(object sender, EventArgs e)
        {
            ClearFields();
            ButtonControl(ibtnBoQua);
        }

        private void ibtnDanhSach_Click(object sender, EventArgs e)
        {
            dtviewDanhMucSanPham.DataSource = bus_Hang.DanhMucSanPham();
        }

        private void ibtnDong_Click(object sender, EventArgs e)
        {
            ButtonControl(ibtnDong);
        }

        private void ibtnTimKiem_Click(object sender, EventArgs e)
        {
            dtviewDanhMucSanPham.DataSource = bus_Hang.TimKiemSanPham(txtTimKiem.Text.Trim());
            txtTimKiem.Text = string.Empty;
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Nhập tên sản phẩm ...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void ibtnChonHinh_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog open = new OpenFileDialog())
                {
                    open.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg|GIF (*.gif)|*.gif|PNG (*.png)|*.png|All Files (*.*)|*.*";
                    open.FilterIndex = 4;

                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = open.FileName;
                        string projectFolderPath = Application.StartupPath;
                        string imagesFolderPath = Path.Combine(projectFolderPath, "images");
                        string destinationFilePath = Path.Combine(imagesFolderPath, Path.GetFileName(selectedFilePath));

                        if (!Directory.Exists(imagesFolderPath))
                        {
                            Directory.CreateDirectory(imagesFolderPath);
                        }

                        File.Copy(selectedFilePath, destinationFilePath, true);
                        pboxHinhAnh.Image = Image.FromFile(destinationFilePath);
                        rtxtHinh.Text = destinationFilePath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ibtnXoaHinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (pboxHinhAnh.Image != placeholder)
                {
                    string destinationPath = rtxtHinh.Text.Trim();
                    rtxtHinh.Text = string.Empty;
                    if (File.Exists(destinationPath))
                    {
                        pboxHinhAnh.Image.Dispose();
                        File.Delete(destinationPath);
                        pboxHinhAnh.Image = placeholder;
                    }
                }
                else
                {
                    rtxtHinh.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("hiện tại không thể xóa hình này,hãy thử lại sau","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
