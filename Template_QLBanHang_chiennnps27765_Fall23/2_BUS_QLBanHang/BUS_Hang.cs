using _1_DAL_QLBanHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLBanHang
{
    public class BUS_Hang
    {
        private DAL_Hang dal_Hang = new DAL_Hang();

        public string MaNhanVien(string email)
        {
            return dal_Hang.MaNhanVien(email);
        }

        public string ThemSanPham(_3_DTO_QLBanHang.Hang sanpham)
        {
            return dal_Hang.ThemSanPham(sanpham);
        }

        public string TaoMaSanPham()
        {
            if (dal_Hang.SoLuongSanPham() > 0)
            {
                List<int> maspInt = dal_Hang.TachChuoiMaSanPham();
                int maspMax = maspInt.Max() + 1;
                if (maspMax < 10)
                {
                    return "SP" + "000" + maspMax;
                }
                else if (maspMax < 100)
                {
                    return "SP" + "00" + maspMax;
                }
                else if (maspMax < 1000)
                {
                    return "SP" + "0" + maspMax;
                }
                else
                {
                    return "SP" + maspMax;
                }
            }
            return "SP0001";
        }

        public DataTable DanhMucSanPham()
        {
            return dal_Hang.DanhMucSanPham();
        }

        public string XoaSanPham(string masp)
        {
            return dal_Hang.XoaSanPham(masp);
        }

        public string CapNhatSanPham(_3_DTO_QLBanHang.Hang sanpham)
        {
            return dal_Hang.CapNhatSanPham(sanpham);
        }

        public DataTable TimKiemSanPham(string tensp)
        {
            return dal_Hang.TimKiemSanPham(tensp);
        }
    }
}
