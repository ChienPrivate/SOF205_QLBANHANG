using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLBanHang;

namespace _2_BUS_QLBanHang
{
    public class BUS_BangThongKe
    {
        private DAL_BangThongKe dal_ThongKe = new DAL_BangThongKe();
        public int TongTonKho()
        {
            return dal_ThongKe.TongTonKho();
        }

        public double TongTienHang()
        {
            return dal_ThongKe.TongTienHang();
        }

        public int SoLuongKhachHang()
        {
            return dal_ThongKe.SoLuongKhachHang();
        }

        public DataTable SanPhamNhapKho()
        {
            return dal_ThongKe.SanPhamNhapKho();
        }

        public DataTable TonKho()
        {
            return dal_ThongKe.TonKho();
        }

        public DataTable Top5SanPham()
        {
            return dal_ThongKe.Top5SanPham();
        }
    }
}
