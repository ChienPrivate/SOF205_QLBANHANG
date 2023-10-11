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
    public class DAL_HangTests
    {
        [TestMethod()]
        public void ThemSanPham_04001()
        {
            DAL_Hang dal_Hang = new DAL_Hang();
            Hang hang = new Hang
            {
                MaHang = "SPTEST",
                TenHang = "",
                SoLuong = 10,
                DonGiaNhap = 100000,
                DonGiaBan = 190000,
                HinhAnh = "D:\\SOF205_DAM_K4\\Exercise\\PS27765_NguyenNgocChien_Assignment\\Template_QLBanHang_chiennnps27765_Fall23\\4_GUI_QLBanHang\\images\\Xe_Vision.png",
                GhiChu = "Điện thoại Iphone 15 hàng chính hãnh, bảo hành 24 tháng",
                MaNV = "NVTEST"
            };
            string thongbao = dal_Hang.ThemSanPham(hang);
            bool result = true;
            if (thongbao != "Thêm sản phẩm thành công")
            {
                result = false;
            }
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ThemSanPham_04002()
        {
            DAL_Hang dal_Hang = new DAL_Hang();
            Hang hang = new Hang
            {
                MaHang = "SPTEST",
                TenHang = "Iphone15",
                SoLuong = 0,
                DonGiaNhap = 100000,
                DonGiaBan = 190000,
                HinhAnh = "D:\\SOF205_DAM_K4\\Exercise\\PS27765_NguyenNgocChien_Assignment\\Template_QLBanHang_chiennnps27765_Fall23\\4_GUI_QLBanHang\\images\\Xe_Vision.png",
                GhiChu = "Điện thoại Iphone 15 hàng chính hãnh, bảo hành 24 tháng",
                MaNV = "NVTEST"
            };
            string thongbao = dal_Hang.ThemSanPham(hang);
            bool result = true;
            if (thongbao != "Thêm sản phẩm thành công")
            {
                result = false;
            }
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ThemSanPham_04003()
        {
            DAL_Hang dal_Hang = new DAL_Hang();
            Hang hang = new Hang
            {
                MaHang = "SPTEST",
                TenHang = "Iphone15",
                SoLuong = 10,
                DonGiaNhap = 0,
                DonGiaBan = 190000,
                HinhAnh = "D:\\SOF205_DAM_K4\\Exercise\\PS27765_NguyenNgocChien_Assignment\\Template_QLBanHang_chiennnps27765_Fall23\\4_GUI_QLBanHang\\images\\Xe_Vision.png",
                GhiChu = "Điện thoại Iphone 15 hàng chính hãnh, bảo hành 24 tháng",
                MaNV = "NVTEST"
            };
            string thongbao = dal_Hang.ThemSanPham(hang);
            bool result = true;
            if (thongbao != "Thêm sản phẩm thành công")
            {
                result = false;
            }
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ThemSanPham_04004()
        {
            DAL_Hang dal_Hang = new DAL_Hang();
            Hang hang = new Hang
            {
                MaHang = "SPTEST",
                TenHang = "Iphone15",
                SoLuong = 10,
                DonGiaNhap = 100000,
                DonGiaBan = 0,
                HinhAnh = "D:\\SOF205_DAM_K4\\Exercise\\PS27765_NguyenNgocChien_Assignment\\Template_QLBanHang_chiennnps27765_Fall23\\4_GUI_QLBanHang\\images\\Xe_Vision.png",
                GhiChu = "Điện thoại Iphone 15 hàng chính hãnh, bảo hành 24 tháng",
                MaNV = "NVTEST"
            };
            string thongbao = dal_Hang.ThemSanPham(hang);
            bool result = true;
            if (thongbao != "Thêm sản phẩm thành công")
            {
                result = false;
            }
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ThemSanPham_04005()
        {
            DAL_Hang dal_Hang = new DAL_Hang();
            Hang hang = new Hang
            {
                MaHang = "SPTEST",
                TenHang = "Iphone15",
                SoLuong = 10,
                DonGiaNhap = 100000,
                DonGiaBan = 190000,
                HinhAnh = "D:\\SOF205_DAM_K4\\Exercise\\PS27765_NguyenNgocChien_Assignment\\Template_QLBanHang_chiennnps27765_Fall23\\4_GUI_QLBanHang\\images\\Xe_Vision.png",
                GhiChu = "Điện thoại Iphone 15 hàng chính hãnh, bảo hành 24 tháng",
                MaNV = "NVTEST"
            };
            string thongbao = dal_Hang.ThemSanPham(hang);
            bool result = true;
            if (thongbao != "Thêm sản phẩm thành công")
            {
                result = false;
            }
            Assert.IsTrue(result);
        }
    }
}