using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DTO_QLBanHang
{
    public class KhachHang
    {
        #region Fields
        private string _DienThoai;
        private string _TenKhacHang;
        private string _DiaChi;
        private string _Phai;
        private string _MaNV;
        #endregion

        #region Properties
        public string DienThoai {  get { return _DienThoai;} set { _DienThoai = value;} }
        public string TenKhacHang { get {  return _TenKhacHang;} set {  _TenKhacHang = value;} }
        public string DiaChi { get { return _DiaChi; } set { _DiaChi = value;} }
        public string Phai { get { return _Phai; } set { _Phai = value;} }
        public string MaNV { get { return _MaNV; } set { _MaNV = value;} }
        #endregion

        #region Constructors
        public KhachHang()
        {

        }

        public KhachHang(string dienThoai, string tenKhacHang, string diaChi, string phai, string maNV)
        {
            DienThoai = dienThoai;
            TenKhacHang = tenKhacHang;
            DiaChi = diaChi;
            Phai = phai;
            MaNV = maNV;
        }
        #endregion
    }
}
