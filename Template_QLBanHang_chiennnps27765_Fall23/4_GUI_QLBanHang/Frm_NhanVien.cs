using _2_BUS_QLBanHang;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class Frm_NhanVien : Form
    {
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        public Frm_NhanVien()
        {
            InitializeComponent();
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            dtviewNhanVien.DataSource = bus_NhanVien.DanhSachNhanVien();

            dtviewNhanVien.Columns["Id"].HeaderText = "Số Thứ Tự";
            dtviewNhanVien.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dtviewNhanVien.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
            dtviewNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtviewNhanVien.Columns["VaiTro"].HeaderText = "Vai Trò";
            dtviewNhanVien.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            dtviewNhanVien.Columns["MatKhau"].Visible = false;

            txtEmail.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimKiem.Text = "Nhập tên nhân viên ...";
            txtTimKiem.ForeColor = Color.Gray;
            grbTinhTrang.Enabled = false;
            grbVaiTro.Enabled = false;

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        private void dtviewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dtviewNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtviewNhanVien.SelectedRows[0];
                if (row.Cells[0].Value.ToString() != string.Empty)
                {
                    txtEmail.Text = row.Cells[2].Value.ToString();
                    txtTenNhanVien.Text = row.Cells[3].Value.ToString();
                    txtDiaChi.Text = row.Cells[4].Value.ToString();
                    int vaitro;
                    string vaitroStr = row.Cells[5].Value.ToString();
                    if (!int.TryParse(vaitroStr, out vaitro))
                    {
                        vaitroStr = string.Empty;
                    }
                    int tinhtrang;
                    string tinhtrangStr = row.Cells[6].Value.ToString();
                    if (!int.TryParse(tinhtrangStr, out tinhtrang))
                    {
                        tinhtrangStr = string.Empty;
                    }
                    if (vaitro == 1)
                    {
                        rdoNhanVien.Checked = true;
                    }
                    else
                    {
                        rdoQuanTri.Checked = true;
                    }
                    if (tinhtrang == 1)
                    {
                        rdoHoatDong.Checked = true;
                    }
                    else
                    {
                        rdoNgungHoatDong.Checked = true;
                    }
                    txtEmail.Enabled = false;
                    txtTenNhanVien.Enabled = true;
                    txtDiaChi.Enabled = true;
                    grbVaiTro.Enabled = true;
                    grbTinhTrang.Enabled = true;
                    btnThem.Enabled = false;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                    btnBoQua.Enabled = true;
                }
                else
                {
                    ClearFields();
                    txtEmail.Enabled = true;
                    txtTenNhanVien.Enabled = true;
                    txtDiaChi.Enabled = true;
                    grbVaiTro.Enabled = true;
                    grbTinhTrang.Enabled = true;
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    btnLuu.Enabled = true;
                    btnBoQua.Enabled = true;
                }
            }

        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập tên nhân viên ...")
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
                txtTimKiem.Text = "Nhập tên nhân viên ...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void ButtonControl(Button btn)
        {
            DialogResult log = new DialogResult();
            if (btn.Name == "btnThem")
            {
                txtEmail.Enabled = true;
                txtTenNhanVien.Enabled = true;
                txtDiaChi.Enabled = true;
                grbVaiTro.Enabled = true;
                grbTinhTrang.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
                btnBoQua.Enabled = true;
            }
            else if (btn.Name == "btnSua" || btn.Name == "btnXoa")
            {
                txtEmail.Enabled = false;
                txtTenNhanVien.Enabled = false;
                txtDiaChi.Enabled = false;
                grbVaiTro.Enabled = false;
                grbTinhTrang.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
            }
            else if (btn.Name == "btnLuu")
            {
                txtEmail.Enabled = false;
                txtTenNhanVien.Enabled = false;
                txtDiaChi.Enabled = false;
                grbVaiTro.Enabled = false;
                grbTinhTrang.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
            }
            else if (btn.Name == "btnBoQua")
            {
                txtEmail.Enabled = false;
                txtTenNhanVien.Enabled = false;
                txtDiaChi.Enabled = false;
                grbVaiTro.Enabled = false;
                grbTinhTrang.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
            }
            else if (btn.Name == "btnDong")
            {
                log = MessageBox.Show("Bạn có muốn thoát ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (log != DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void LoadData()
        {
            dtviewNhanVien.DataSource = bus_NhanVien.DanhSachNhanVien();
        }

        private void ClearFields()
        {
            txtEmail.Text = string.Empty;
            txtTenNhanVien.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtTimKiem.Text = string.Empty;
            rdoNhanVien.Checked = false;
            rdoQuanTri.Checked = false;
            rdoHoatDong.Checked = false;
            rdoNgungHoatDong.Checked = false;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            this.ButtonControl(btnThem);
            ClearFields();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult log = MessageBox.Show("Bạn có muốn xóa nhân viên này ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                MessageBox.Show(bus_NhanVien.XoaNhanVien(txtEmail.Text.Trim()), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
                dtviewNhanVien.ClearSelection();
                ButtonControl(btnXoa);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string tennv = txtTenNhanVien.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            int vaitro = 1;
            int tinhtrang = 1;
            if (rdoQuanTri.Checked == true)
            {
                vaitro = 2;
            }
            if (rdoNgungHoatDong.Checked == true)
            {
                tinhtrang = 2;
            }
            DialogResult log = MessageBox.Show("Bạn có muốn cập nhật nhân viên này ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                MessageBox.Show(bus_NhanVien.CapNhatNhanVien(email, tennv, diachi, vaitro, tinhtrang), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
                dtviewNhanVien.ClearSelection();
                ButtonControl(btnSua);
            }
        }

        private async void btnLuu_Click_1(object sender, EventArgs e)
        {
            int vaitro = 1;
            int tinhtrang = 1;
            string email = txtEmail.Text.Trim();
            string emailTonTai = await bus_NhanVien.KiemTraEmailTonTai(email);
            string tennv = txtTenNhanVien.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string subject = "Tạo tài khoản thành công";
            string content = $"Id: {email} \nPassword: abc123";
            if (rdoQuanTri.Checked == true)
            {
                vaitro = 2;
            }
            if (rdoNgungHoatDong.Checked == true)
            {
                tinhtrang = 2;
            }
            if (txtEmail.Text != string.Empty && txtTenNhanVien.Text != string.Empty && txtDiaChi.Text != string.Empty)
            {
                if (emailTonTai != "Email hợp lệ")
                {
                    MessageBox.Show(emailTonTai, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (rdoNhanVien.Checked == false && rdoQuanTri.Checked == false)
                {
                    MessageBox.Show("Hãy chọn vai trò cho nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (rdoHoatDong.Checked == false && rdoNgungHoatDong.Checked == false)
                {
                    MessageBox.Show("Hãy chọn Tình trạng cho nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult log = MessageBox.Show("Bạn có muốn lưu nhân viên này ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (log != DialogResult.Yes)
                {
                    return;
                }
                bus_NhanVien.GuiMail(email, subject, content);
                MessageBox.Show(bus_NhanVien.ThemNhanVien(bus_NhanVien.TaoMaNhanVien(), email, tennv, diachi, vaitro, tinhtrang), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonControl(btnLuu);
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
        }

        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            ButtonControl(btnBoQua);
            ClearFields();
            dtviewNhanVien.ClearSelection();
        }

        private void btnDanhSach_Click_1(object sender, EventArgs e)
        {
            dtviewNhanVien.DataSource = bus_NhanVien.DanhSachNhanVien();
            dtviewNhanVien.Columns["MatKhau"].Visible = false;
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            dtviewNhanVien.DataSource = bus_NhanVien.TimKiemNhanVien(txtTimKiem.Text.Trim());
            txtTimKiem.Text = string.Empty;
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Nhập tên nhân viên ...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }
    }
}
