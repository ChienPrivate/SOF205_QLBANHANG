using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class Frm_Main : Form
    {
        #region Fields
        private int boderSize = 2;
        private string Email;
        private int Role;
        private Frm_NhanVienDangNhap frm_DangNhap;
        private _2_BUS_QLBanHang.BUS_NhanVien bus_NhanVien;

        public string email { get { return Email; } private set { Email = value; } }
        #endregion

        #region Constructor
        public Frm_Main()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(boderSize); // đồ dày của viền ngoài form
            this.BackColor = Color.FromArgb(98, 102, 244); // màu nền của form
            bus_NhanVien = new _2_BUS_QLBanHang.BUS_NhanVien();
        }
        #endregion

        // Drag form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // ghi đè phương thức WndProc
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            /*if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }*/
            base.WndProc(ref m);
        }

        private void Frm_Main_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Minimized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != boderSize)
                    {
                        this.Padding = new Padding(boderSize);
                    }
                    break;
            }
        }

        private void ibtnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ibtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ibtnClosed_Click(object sender, EventArgs e)
        {
            DialogResult log = MessageBox.Show("bạn có muốn thoát ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ibtnNhanVien_Click(object sender, EventArgs e)
        {
            if (panelDesktop.Controls.Count == 0 || !(panelDesktop.Controls[0] is Frm_NhanVien))
            {
                Frm_NhanVien frm = new Frm_NhanVien();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                panelDesktop.Controls.Clear();

                panelDesktop.Controls.Add(frm);
                frm.Show();
            }
        }

        private void tbtnSanPham_Click(object sender, EventArgs e)
        {
            if (panelDesktop.Controls.Count == 0 || !(panelDesktop.Controls[0] is Frm_SanPham))
            {
                Frm_SanPham frm = new Frm_SanPham(Email);
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                panelDesktop.Controls.Clear();

                panelDesktop.Controls.Add(frm);
                frm.Show();
            }
        }

        private void ibtnKhachHang_Click(object sender, EventArgs e)
        {
            if (panelDesktop.Controls.Count == 0 || !(panelDesktop.Controls[0] is Frm_KhachHang))
            {
                Frm_KhachHang frm = new Frm_KhachHang(Email);
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                panelDesktop.Controls.Clear();

                panelDesktop.Controls.Add(frm);
                frm.Show();
            }
        }

        private void ibtnHuongDan_Click(object sender, EventArgs e)
        {
            string projectStartUpPath = AppDomain.CurrentDomain.BaseDirectory;
            string destinationFilePath = Path.Combine(projectStartUpPath, "Huong_Dan.pdf");
            if (File.Exists(destinationFilePath))
            {
                Process.Start(destinationFilePath);
            }
            else
            {
                MessageBox.Show("Tệp PDF này không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ibtnThongKe_Click(object sender, EventArgs e)
        {
            if (panelDesktop.Controls.Count == 0 || !(panelDesktop.Controls[0] is Frm_ThongKe))
            {
                Frm_ThongKe frm = new Frm_ThongKe();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                panelDesktop.Controls.Clear();

                panelDesktop.Controls.Add(frm);
                frm.Show();
            }
        }

        private void ibtnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                panelUserInfo.Visible = false;
                pboxLogo.Visible = false;
                ibtnMenu.Dock = DockStyle.Top;
                panelDesktop.Dock = DockStyle.Fill;

                foreach (Button menuBtn in panelMenu.Controls.OfType<Button>())
                {
                    menuBtn.Text = "";
                    menuBtn.ImageAlign = ContentAlignment.MiddleCenter;
                    menuBtn.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                pboxLogo.Visible = true;
                ibtnMenu.Dock = DockStyle.None;
                panelDesktop.Dock = DockStyle.Fill;


                foreach (Button menuBtn in panelMenu.Controls.OfType<Button>())
                {
                    menuBtn.Text = "    " + menuBtn.Tag.ToString();
                    menuBtn.ImageAlign = ContentAlignment.MiddleLeft;
                    menuBtn.Padding = new Padding(10, 0, 0, 0);
                }
            }
            /*if (this.panelMenu.Width > 200)
            {
                targetMenuWidth = 100;
            }
            else
            {
                targetMenuWidth = 282;
            }

            // Tạo một Timer để thực hiện hiệu ứng
            Timer timer = new Timer();
            timer.Interval = animationSpeed;
            timer.Tick += (sender, e) =>    
            {
                // Tính toán sự thay đổi kích thước cho mỗi bước
                int step = (targetMenuWidth - panelMenu.Width) / 10; // Chia cho 10 bước

                // Nếu chưa đạt được kích thước mục tiêu, thay đổi kích thước và thực hiện các thay đổi liên quan
                if (panelMenu.Width != targetMenuWidth)
                {
                    panelMenu.Width += step;

                    // Đặt các yếu tố liên quan
                    if (panelMenu.Width <= 100)
                    {
                        pboxLogo.Visible = false;
                        ibtnMenu.Dock = DockStyle.Top;
                        foreach (Button menuBtn in panelMenu.Controls.OfType<Button>())
                        {
                            menuBtn.Text = "";
                            menuBtn.ImageAlign = ContentAlignment.MiddleCenter;
                            menuBtn.Padding = new Padding(0);
                        }
                    }
                    else
                    {
                        pboxLogo.Visible = true;
                        ibtnMenu.Dock = DockStyle.None;
                        foreach (Button menuBtn in panelMenu.Controls.OfType<Button>())
                        {
                            menuBtn.Text = "    " + menuBtn.Tag.ToString();
                            menuBtn.ImageAlign = ContentAlignment.MiddleLeft;
                            menuBtn.Padding = new Padding(10, 0, 0, 0);
                        }
                    }
                }
                else
                {
                    // Đạt được kích thước mục tiêu, dừng Timer
                    timer.Stop();
                    timer.Dispose();
                }
            };

            // Bắt đầu Timer
            timer.Start();*/
        }

        private void ibtnDangNhap_Click(object sender, EventArgs e)
        {
            if (panelDesktop.Controls.Count == 0 || !(panelDesktop.Controls[0] is Frm_NhanVienDangNhap))
            {
                frm_DangNhap = new Frm_NhanVienDangNhap(this);
                frm_DangNhap.DangNhap += (email) =>
                {
                    Email = email;
                    frm_DangNhap.Close();
                };
                frm_DangNhap.TopLevel = false;
                frm_DangNhap.FormBorderStyle = FormBorderStyle.None;
                frm_DangNhap.Dock = DockStyle.Fill;

                panelDesktop.Controls.Clear();

                panelDesktop.Controls.Add(frm_DangNhap);
                frm_DangNhap.Show();
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            ibtnDangNhap.Enabled = true;
            ibtnNhanVien.Enabled = false;
            tbtnSanPham.Enabled = false;
            ibtnKhachHang.Enabled = false;
            ibtnThongKe.Enabled = false;
            ibtnTaiKhoan.Enabled = false;
            ibtnDangXuat.Visible = false;
        }

        private void ibtnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (panelDesktop.Controls.Count == 0 || !(panelDesktop.Controls[0] is Frm_TaiKhoan))
            {
                Frm_TaiKhoan frm = new Frm_TaiKhoan(Email);
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                panelDesktop.Controls.Clear();

                panelDesktop.Controls.Add(frm);
                frm.Show();
            }
        }

        public void UpdateUI(string email)
        {
            Email = email;
            Role = bus_NhanVien.VaiTroNhanVien(Email);
            if (!string.IsNullOrEmpty(Email))
            {
                labelEmail.Text = Email;
                panelUserInfo.Visible = true;
                ibtnDangNhap.Enabled = false;
                tbtnSanPham.Enabled = true;
                ibtnKhachHang.Enabled = true;
                ibtnTaiKhoan.Enabled = true;
                ibtnDangXuat.Visible = true;
                if (Role > 1)
                {
                    ibtnNhanVien.Enabled = true;
                    ibtnThongKe.Enabled = true;
                }
            }
            else
            {
                panelDesktop.Controls.Clear();
                panelUserInfo.Visible = false;
                ibtnDangNhap.Enabled = true;
                ibtnNhanVien.Enabled = false;
                tbtnSanPham.Enabled = false;
                ibtnKhachHang.Enabled = false;
                ibtnThongKe.Enabled = false;
                ibtnTaiKhoan.Enabled = false;
                ibtnDangXuat.Visible = false;
            }
        }

        private void ibtnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult log = MessageBox.Show("Bạn có muốn đăng xuất ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                Email = null;
                UpdateUI(Email);
            }
        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
