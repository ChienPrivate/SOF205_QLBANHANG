using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_QLBanHang;

namespace GUI_QLBanHang
{
    
    public partial class Frm_KhachHang : Form
    {
        private BUS_KhachHang bus_KhachHang;
        private string Email;
        private string MaNV;

        public Frm_KhachHang(string email)
        {
            InitializeComponent();
            bus_KhachHang = new BUS_KhachHang();
            Email = email;
            MaNV = bus_KhachHang.MaNhanVien(Email);
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadData();

            dtviewKhachHang.Columns["DienThoai"].HeaderText = "Số Điện Thoại";
            dtviewKhachHang.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
            dtviewKhachHang.Columns["TenKhachHang"].Width = 120;
            dtviewKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtviewKhachHang.Columns["Phai"].HeaderText = "Phái";
            dtviewKhachHang.Columns["MaNV"].HeaderText = "Mã Nhân Viên";

            txtDienThoai.Enabled = false;
            txtHoVaTen.Enabled = false;
            rtxtDiaChi.Enabled = false;
            grbGender.Enabled = false;
            txtTimKiem.Text = "Nhập tên khách hàng ...";
            txtTimKiem.ForeColor = Color.Gray;

            ibtnThem.Enabled = true;
            ibtnXoa.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnLuu.Enabled = false;
            ibtnBoQua.Enabled = false;
        }

        private void dtviewKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dtviewKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtviewKhachHang.SelectedRows[0];
                if (row.Cells[0].Value.ToString() != string.Empty)
                {
                    txtDienThoai.Text = row.Cells[0].Value.ToString();
                    txtHoVaTen.Text = row.Cells[1].Value.ToString();
                    rtxtDiaChi.Text = row.Cells[2].Value.ToString();
                    string phai = row.Cells[3].Value.ToString();
                    if (phai.ToLower() == "nữ")
                    {
                        rdoNu.Checked = true;
                    }
                    else if (phai.ToLower() == "nam")
                    {
                        rdoNam.Checked = true;
                    }

                    txtDienThoai.Enabled = false;
                    txtHoVaTen.Enabled = true;
                    rtxtDiaChi.Enabled = true;
                    grbGender.Enabled = true;

                    ibtnThem.Enabled = false;
                    ibtnXoa.Enabled = true;
                    ibtnSua.Enabled = true;
                    ibtnLuu.Enabled = false;
                    ibtnBoQua.Enabled = true;
                }
                else
                {
                    ClearFields();

                    txtDienThoai.Enabled = true;
                    txtHoVaTen.Enabled = true;
                    rtxtDiaChi.Enabled = true;
                    grbGender.Enabled = true;

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
            if (txtTimKiem.Text == "Nhập tên khách hàng ...")
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
                txtTimKiem.Text = "Nhập tên khách hàng ...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }

            string cunrrent = txtDienThoai.Text;
            if (cunrrent.Length > 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonControl(Button btn)
        {
            DialogResult log = new DialogResult();
            if (btn.Name == "ibtnThem")
            {
                txtDienThoai.Enabled = true;
                txtHoVaTen.Enabled = true;
                rtxtDiaChi.Enabled = true;
                grbGender.Enabled = true;

                ibtnThem.Enabled = false;
                ibtnXoa.Enabled = false;
                ibtnSua.Enabled = false;
                ibtnLuu.Enabled = true;
                ibtnBoQua.Enabled = true;
            }
            else if (btn.Name == "ibtnSua" || btn.Name == "ibtnXoa")
            {
                txtDienThoai.Enabled = false;
                txtHoVaTen.Enabled = false;
                rtxtDiaChi.Enabled = false;
                grbGender.Enabled = false;

                ibtnThem.Enabled = true;
                ibtnXoa.Enabled = false;
                ibtnSua.Enabled = false;
                ibtnLuu.Enabled = false;
                ibtnBoQua.Enabled = false;
            }
            else if (btn.Name == "ibtnLuu")
            {
                txtDienThoai.Enabled = false;
                txtHoVaTen.Enabled = false;
                rtxtDiaChi.Enabled = false;
                grbGender.Enabled = false;

                ibtnThem.Enabled = true;
                ibtnXoa.Enabled = false;
                ibtnSua.Enabled = false;
                ibtnLuu.Enabled = false;
                ibtnBoQua.Enabled = false;
            }
            else if (btn.Name == "ibtnBoQua")
            {
                txtDienThoai.Enabled = false;
                txtHoVaTen.Enabled = false;
                rtxtDiaChi.Enabled = false;
                grbGender.Enabled = false;

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

        private void ClearFields()
        {
            txtDienThoai.Text = string.Empty;
            txtHoVaTen.Text = string.Empty;
            rtxtDiaChi.Text = string.Empty;
            rdoNu.Checked = false;
            rdoNam.Checked = false;
            dtviewKhachHang.ClearSelection();
        }

        private void LoadData()
        {
            dtviewKhachHang.DataSource = bus_KhachHang.DanhSachKhachHang();
        }

        private void ibtnThem_Click(object sender, EventArgs e)
        {
            ButtonControl(ibtnThem);
            ClearFields();
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult log = MessageBox.Show("Bạn có muốn xóa khách hàng này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                string dienthoai = txtDienThoai.Text.Trim();
                string result = bus_KhachHang.XoaNhanVien(dienthoai);
                MessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
                ButtonControl(ibtnXoa);
            }
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            string phai = null;
            if (rdoNu.Checked == true)
            {
                phai = "Nữ";
            }
            else if (rdoNam.Checked == true)
            {
                phai = "Nam";
            }
            _3_DTO_QLBanHang.KhachHang khach = new _3_DTO_QLBanHang.KhachHang
            {
                DienThoai = txtDienThoai.Text.Trim(),
                TenKhacHang = txtHoVaTen.Text.Trim(),
                DiaChi = rtxtDiaChi.Text.Trim(),
                Phai = phai,
                MaNV = this.MaNV
            };
            DialogResult log = MessageBox.Show("Bạn có muốn cập nhật khách hàng này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                string result = bus_KhachHang.CapNhatKhachHang(khach);
                MessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
                ButtonControl(ibtnSua);
            }
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            if (txtDienThoai.Text == string.Empty)
            {
                MessageBox.Show("hãy nhập số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtHoVaTen.Text == string.Empty)
            {
                MessageBox.Show("hãy nhập tên khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (rtxtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("hãy nhập địa chỉ khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string phai = null;
            if (rdoNu.Checked == true)
            {
                phai = "Nữ";
            }
            else if (rdoNam.Checked == true)
            {
                phai = "Nam";
            }
            else if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Hãy chọn giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _3_DTO_QLBanHang.KhachHang khach = new _3_DTO_QLBanHang.KhachHang
            {
                DienThoai = txtDienThoai.Text.Trim(),
                TenKhacHang = txtHoVaTen.Text.Trim(),
                DiaChi = rtxtDiaChi.Text.Trim(),
                Phai = phai,
                MaNV = this.MaNV
            };
            DialogResult log = MessageBox.Show("Bạn có muốn lưu khách hàng này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                string result = bus_KhachHang.ThemKhachHang(khach);
                MessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
                ButtonControl(ibtnLuu);
            }
        }

        private void iBoQua_Click(object sender, EventArgs e)
        {
            ButtonControl(ibtnBoQua);
            ClearFields();
        }

        private void ibtnDanhSach_Click(object sender, EventArgs e)
        {
            dtviewKhachHang.DataSource = bus_KhachHang.DanhSachKhachHang();
            ButtonControl(ibtnBoQua);
        }

        private void ibtnDong_Click(object sender, EventArgs e)
        {
            ButtonControl(ibtnDong);
        }

        private void ibtnTimKiem_Click(object sender, EventArgs e)
        {
            dtviewKhachHang.DataSource = bus_KhachHang.TimKiemKhachHang(txtTimKiem.Text.Trim());
            txtTimKiem.Text = string.Empty;
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Nhập tên khách hàng ...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }
    }
}
