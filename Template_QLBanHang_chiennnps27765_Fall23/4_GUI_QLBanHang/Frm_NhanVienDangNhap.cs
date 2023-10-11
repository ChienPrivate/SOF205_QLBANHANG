using _2_BUS_QLBanHang;
using System;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class Frm_NhanVienDangNhap : Form
    {
        private BUS_NhanVien bus_QLBanHang;
        private Frm_Main frm_Main;
        public event Action<string> DangNhap;
        public Frm_NhanVienDangNhap(Frm_Main frm_Main)
        {
            InitializeComponent();
            bus_QLBanHang = new BUS_NhanVien();
            this.frm_Main = frm_Main;
        }

        private void tbtnDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            if (txtEmail.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Hãy điền vào tài khoản và mật khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbGhiNho.Checked)
            {
                Properties.Settings.Default.Email = email;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Reset();
            }
            if (bus_QLBanHang.NhanVienDangNhap(txtEmail.Text, txtPassword.Text))
            {
                int vaitro = bus_QLBanHang.VaiTroNhanVien(email);
                int tinhtrang = bus_QLBanHang.TinhTrangNhanVien(email);
                if (tinhtrang != 1)
                {
                    this.Show();
                    MessageBox.Show("Nhân viên đã không còn hoạt động", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DangNhap?.Invoke(email);
                frm_Main.UpdateUI(email);
                /*this.Hide();*/
                /*if (vaitro == 1)
                {
                    frm_Khach.Show();
                    frm_SanPham.Show();
                }
                else
                {
                    frm_NhanVien.Show();
                }*/
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ibtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult log = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private async void llbleQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string notExist = "Email Chưa được đăng ký";
            string email = txtEmail.Text.Trim();
            string checkemail = await bus_QLBanHang.KiemTraEmailTonTai(email);
            string matkhaumoi = bus_QLBanHang.TaoMatKhau(email);
            string subject = "Bạn đã sử dụng tính năng quên mật khẩu";
            string content = "Mật khẩu mới: " + matkhaumoi;
            string thongbao;
            if (bus_QLBanHang.NhanVienQuenMatKhau(email, matkhaumoi) == notExist)
            {
                MessageBox.Show(notExist, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkemail != "Email hợp lệ")
            {
                MessageBox.Show(checkemail, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                thongbao = bus_QLBanHang.GuiMail(email, subject, content);
                MessageBox.Show(thongbao, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_NhanVienDangNhap_Load(object sender, EventArgs e)
        {
            txtEmail.Text = Properties.Settings.Default.Email;
            txtPassword.Text = Properties.Settings.Default.Password;
            if (Properties.Settings.Default.Email != "")
            {
                cbGhiNho.Checked = true;
            }
        }
    }
}
