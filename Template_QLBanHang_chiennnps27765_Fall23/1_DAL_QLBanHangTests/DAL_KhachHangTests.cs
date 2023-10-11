using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_DAL_QLBanHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_DTO_QLBanHang;

namespace _1_DAL_QLBanHang.Tests
{
    [TestClass()]
    public class DAL_KhachHangTests
    {
        [TestMethod()]
        public void ThemKhachHang_03001()
        {
            DAL_KhachHang dal_KhachHang = new DAL_KhachHang();
            KhachHang kh = new KhachHang
            {
                DienThoai = "",
                TenKhacHang = "Nguyễn Ngọc Chiến",
                DiaChi = "TP. Hồ Chí Minh",
                Phai = "Nam",
                MaNV = "NVTEST",
            };
            string thongbao = dal_KhachHang.ThemKhachHang(kh);
            bool result = false;
            if (thongbao == "Thêm khách hàng thành công")
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ThemKhachHang_03002()
        {
            DAL_KhachHang dal_KhachHang = new DAL_KhachHang();
            KhachHang kh = new KhachHang
            {
                DienThoai = "0937806350",
                TenKhacHang = "",
                DiaChi = "TP. Hồ Chí Minh",
                Phai = "Nam",
                MaNV = "NVTEST",
            };
            string thongbao = dal_KhachHang.ThemKhachHang(kh);
            bool result = false;
            if (thongbao == "Thêm khách hàng thành công")
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ThemKhachHang_03003()
        {
            DAL_KhachHang dal_KhachHang = new DAL_KhachHang();
            KhachHang kh = new KhachHang
            {
                DienThoai = "0937806350",
                TenKhacHang = "Nguyễn Ngọc Chiến",
                DiaChi = "",
                Phai = "Nam",
                MaNV = "NVTEST",
            };
            string thongbao = dal_KhachHang.ThemKhachHang(kh);
            bool result = false;
            if (thongbao == "Thêm khách hàng thành công")
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ThemKhachHang_03004()
        {
            DAL_KhachHang dal_KhachHang = new DAL_KhachHang();
            KhachHang kh = new KhachHang
            {
                DienThoai = "0937806350",
                TenKhacHang = "Nguyễn Ngọc Chiến",
                DiaChi = "TP. Hồ Chí Minh",
                Phai = "Nam",
                MaNV = "NVTEST",
            };
            string thongbao = dal_KhachHang.ThemKhachHang(kh);
            bool result = false;
            if (thongbao == "Thêm khách hàng thành công")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
