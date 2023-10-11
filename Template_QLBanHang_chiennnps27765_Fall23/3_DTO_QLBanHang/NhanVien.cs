using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DTO_QLBanHang
{
    public class NhanVien
    {
        #region Fields
        private int _Id;
        private string _MaNV;
        private string _Email;
        private string _TenNV;
        private string _DiaChi;
        private int _VaiTro;
        private int _TinhTrang;
        private string _Matkhau;
        #endregion

        #region Properties
        public int Id { get { return _Id; } set { _Id = value; } }
        public string MaNV { get { return _MaNV; } set { _MaNV = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        public string TenNV { get { return _TenNV; } set { _TenNV = value; } }
        public string DiaChi { get {  return _DiaChi; } set { _DiaChi = value; } }
        public int VaiTro { get {  return _VaiTro; } set { _VaiTro = value; } }
        public int TinhTrang { get {  return _TinhTrang; } set { _TinhTrang = value; } }
        public string MatKhau { get { return _Matkhau; } set { _Matkhau = value; } }
        #endregion

        #region Constructors
        public NhanVien()
        {

        }

        public NhanVien(int id, string maNV, string email, string tenNV, string diaChi, int vaiTro, int tinhTrang, string matKhau) 
        {
            Id = id;
            MaNV = maNV;
            Email = email;
            TenNV = tenNV;
            DiaChi = diaChi;
            VaiTro = vaiTro;
            TinhTrang = tinhTrang;
            MatKhau = matKhau;
        }
        #endregion
    }
}
