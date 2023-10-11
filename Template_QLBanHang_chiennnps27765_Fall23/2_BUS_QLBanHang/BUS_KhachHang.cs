using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLBanHang;

namespace _2_BUS_QLBanHang
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang dal_KhachHang = new DAL_KhachHang();

        public string MaNhanVien(string email)
        {
            return dal_KhachHang.MaNhanVien(email);
        }

        public string ThemKhachHang(_3_DTO_QLBanHang.KhachHang khach)
        {
            return dal_KhachHang.ThemKhachHang(khach);
        }

        public DataTable DanhSachKhachHang()
        {
            return dal_KhachHang.DanhSachKhachHang();
        }

        public string XoaNhanVien(string email)
        {
            return dal_KhachHang.XoaKhachHang(email);
        }

        public string CapNhatKhachHang(_3_DTO_QLBanHang.KhachHang khach)
        {
            return dal_KhachHang.CapNhatKhachHang(khach);
        }

        public DataTable TimKiemKhachHang(string tenkhachhang)
        {
            return dal_KhachHang.TimKiemKhachHang(tenkhachhang);
        }
    }
}
