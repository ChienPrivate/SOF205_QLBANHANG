using _2_BUS_QLBanHang;
using System;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class Frm_ThongKe : Form
    {
        //Fields
        private BUS_BangThongKe bus_Thongke;

        public Frm_ThongKe()
        {
            InitializeComponent();
            bus_Thongke = new BUS_BangThongKe();
        }

        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            labelTonKho.Text = bus_Thongke.TongTonKho().ToString();
            labelTongTienHang.Text = bus_Thongke.TongTienHang().ToString();
            labelSoLuongKhach.Text = bus_Thongke.SoLuongKhachHang().ToString();
            chartSanPham.DataSource = bus_Thongke.TonKho();
            chartSanPham.Series[0].XValueMember = "TenHang";
            chartSanPham.Series[0].YValueMembers = "SoLuong";
            chartSanPham.DataBind();
            chartTop5SanPham.DataSource = bus_Thongke.Top5SanPham();
            chartTop5SanPham.Series[0].XValueMember = "TenHang";
            chartTop5SanPham.Series[0].YValueMembers = "SoLuong";
            chartTop5SanPham.DataBind();
        }

        private void btnSPNK_Click(object sender, EventArgs e)
        {
            dtviewTonKho.DataSource = bus_Thongke.SanPhamNhapKho();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dtviewTonKho.DataSource = bus_Thongke.TonKho();
            dtviewTonKho.Columns["TenHang"].HeaderText = "Tên Hàng";
            dtviewTonKho.Columns["SoLuong"].HeaderText = "Số Lượng Hàng Tồn";
        }

        private void iconDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
