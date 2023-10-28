using _2_BUS_QLBanHang;
using System;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class Frm_TaiKhoan : Form
    {
        private BUS_NhanVien bus_NhanVien;
        private Frm_NhanVienDangNhap frm_DangNhap;
        private string Email;

        public Frm_TaiKhoan(string email)
        {
            InitializeComponent();
            bus_NhanVien = new BUS_NhanVien();
            Email = email;
        }

        private void Frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            int vaitro = bus_NhanVien.VaiTroNhanVien(Email);
            int tinhtrang = bus_NhanVien.TinhTrangNhanVien(Email);
            labelId.Text = bus_NhanVien.MaNhanVien(Email);
            labelHoTen.Text = bus_NhanVien.TenNhanVien(Email);
            labelEmail.Text = Email;
            if (vaitro != 2)
            {
                labelVaiTro.Text = "Nhân Viên";
            }
            else
            {
                labelVaiTro.Text = "Quản Trị";
            }
            if (tinhtrang != 2)
            {
                labelTrangThai.Text = "Hoạt động";
            }
            else
            {
                labelTrangThai.Text = "Ngưng Hoạt động";
            }
            panelDoiMatKhau.Visible = false;
        }

        private void ibtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            panelDoiMatKhau.Visible = true;
            panelThongTinTaiKhoan.Visible = false;
        }

        private void ibtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnXacNhan_Click(object sender, EventArgs e)
        {
            string matkhaucu = txtMatKhauCu.Text.Trim();
            string matkhaumoi = txtMatKhauMoi.Text.Trim();
            string xacnhanmatkhau = txtXacNhanMatKhau.Text.Trim();
            bool result;
            if (matkhaucu == string.Empty || matkhaumoi == string.Empty || xacnhanmatkhau == string.Empty)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin trước khi xác nhận", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (matkhaumoi != xacnhanmatkhau)
            {
                MessageBox.Show(" mật khẩu mới và xác nhận lại mật khẩu không giống nhau ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult log = MessageBox.Show("Xác nhận đổi mật khẩu", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                result = bus_NhanVien.DoiMatKhau(Email, matkhaucu, matkhaumoi);
                if (result)
                {
                    MessageBox.Show("đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhauCu.Text = string.Empty;
                    txtMatKhauMoi.Text = string.Empty;
                    txtXacNhanMatKhau.Text = string.Empty;
                    panelDoiMatKhau.Visible = false;
                    panelThongTinTaiKhoan.Visible = true;
                }
                else
                {
                    MessageBox.Show("đổi mật khẩu thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhauCu.Text = string.Empty;
                    txtMatKhauMoi.Text = string.Empty;
                    txtXacNhanMatKhau.Text = string.Empty;
                }
            }
        }

        private void ibtnHuy_Click(object sender, EventArgs e)
        {
            panelDoiMatKhau.Visible = false;
            panelThongTinTaiKhoan.Visible = true;
        }


    }
}
