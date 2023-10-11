using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DTO_QLBanHang
{
    public class Hang
    {
        #region Fields
        private string _MaHang;
        private string _Tenhang;
        private int _SoLuong;
        private float _DonGiaBan;
        private float _DonGiaNhap;
        private string _HinhAnh;
        private string _GhiChu;
        private string _MaNV;
        #endregion

        #region Properties
        public string MaHang {  get { return _MaHang; } set { _MaHang = value; } }
        public string TenHang {  get { return _Tenhang; } set { _Tenhang = value; } }
        public int SoLuong { get {  return _SoLuong; } set { _SoLuong = value; } }
        public float DonGiaBan { get {  return _DonGiaBan; } set { _DonGiaBan = value; } }
        public float DonGiaNhap { get { return _DonGiaNhap;} set { _DonGiaNhap = value;} }
        public string HinhAnh { get {  return _HinhAnh; } set { _HinhAnh = value; } }
        public string GhiChu { get {  return _GhiChu; } set { _GhiChu = value; } }
        public string MaNV { get { return _MaNV; } set { _MaNV = value; } }
        #endregion

        #region Constructors
        public Hang()
        {

        }

        public Hang(string maHang, string tenHang, int soLuong, float donGiaBan, float donGiaNhap, string hinhAnh, string maNV)
        {
            MaHang = maHang;
            TenHang = tenHang;
            SoLuong = soLuong;
            DonGiaBan = donGiaBan;
            DonGiaNhap = donGiaNhap;
            HinhAnh = hinhAnh;
            MaNV = maNV;
        }
        #endregion
    }
}
