using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_DAL_QLBanHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_QLBanHang;
using _3_DTO_QLBanHang;

namespace _1_DAL_QLBanHang.Tests
{
    [TestClass()]
    public class DAL_NhanVienTests
    {
        [TestMethod()]
        public void Login_01001()
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
            string email = "";
            string matkhau = "abc123";
            byte[] matkhaumd5 = bus_NhanVien.Encryption(matkhau);
            bool result = dal_NhanVien.NhanVienDangNhap(email, matkhaumd5);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void Login_01002()
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
            string email = "chienprivate@gmail.com";
            string matkhau = "";
            byte[] matkhaumd5 = bus_NhanVien.Encryption(matkhau);
            bool result = dal_NhanVien.NhanVienDangNhap(email, matkhaumd5);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void Login_01003()
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
            string email = "";
            string matkhau = "";
            byte[] matkhaumd5 = bus_NhanVien.Encryption(matkhau);
            bool result = dal_NhanVien.NhanVienDangNhap(email, matkhaumd5);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void Login_01004()
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
            string email = "chienprivate@gmail.com";
            string matkhau = "abc123";
            byte[] matkhaumd5 = bus_NhanVien.Encryption(matkhau);
            bool result = dal_NhanVien.NhanVienDangNhap(email, matkhaumd5);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ThemNhanVien_02001()
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            string manv = "NVTEST";
            string email = "";
            string tennv = "Tiến Đạt";
            string diachi = "TP. Hồ Chí Minh";
            int vaitro = 2;
            int tinhtrang = 1;
            string thongbao = dal_NhanVien.ThemNhanVien(manv, email, tennv, diachi, vaitro, tinhtrang);
            bool result;
            if ( thongbao != "Thêm nhân viên thành công")
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ThemNhanVien_02002()
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            string manv = "NVTEST";
            string email = "chienprivate@gmail.com";
            string tennv = "";
            string diachi = "TP. Hồ Chí Minh";
            int vaitro = 2;
            int tinhtrang = 1;
            string thongbao = dal_NhanVien.ThemNhanVien(manv, email, tennv, diachi, vaitro, tinhtrang);
            bool result;
            if (thongbao != "Thêm nhân viên thành công")
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ThemNhanVien_02003()
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            string manv = "NVTEST";
            string email = "chienprivate@gmail.com";
            string tennv = "Tiến Đạt";
            string diachi = "";
            int vaitro = 2;
            int tinhtrang = 1;
            string thongbao = dal_NhanVien.ThemNhanVien(manv, email, tennv, diachi, vaitro, tinhtrang);
            bool result;
            if (thongbao != "Thêm nhân viên thành công")
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ThemNhanVien_02004()
        {
            DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
            string manv = "NVTEST";
            string email = "anhlahd@gmail.com";
            string tennv = "Tiến Đạt";
            string diachi = "TP. Hồ Chí Minh";
            int vaitro = 2;
            int tinhtrang = 1;
            string thongbao = dal_NhanVien.ThemNhanVien(manv, email, tennv, diachi, vaitro, tinhtrang);
            bool result;
            if (thongbao != "Thêm nhân viên thành công")
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}