using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLBanHang
{
    public class DAL_KhachHang : DatabaseConnect
    {
        public string MaNhanVien(string email)
        {
            try
            {
                string querry = " SELECT MaNV FROM tblNhanVien WHERE Email = @email ";
                string result;
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand(querry, _Conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    result = cmd.ExecuteScalar().ToString();
                }
                _Conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ThemKhachHang(_3_DTO_QLBanHang.KhachHang khach)
        {
            try
            {
                string result;
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                if (khach.DienThoai != "" && khach.TenKhacHang != "" && khach.DiaChi != "" && khach.Phai != "")
                {
                    using (SqlCommand cmd = new SqlCommand("[ThemKhachHang]", _Conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@dienthoai", khach.DienThoai);
                        cmd.Parameters.AddWithValue("@tenkhachhang", khach.TenKhacHang);
                        cmd.Parameters.AddWithValue("@diachi", khach.DiaChi);
                        cmd.Parameters.AddWithValue("@phai", khach.Phai);
                        cmd.Parameters.AddWithValue("@manv", khach.MaNV);
                        result = cmd.ExecuteScalar().ToString();

                    }
                    _Conn.Close();
                    return result;
                }
                else
                {
                    return "Thêm khách hàng thất bại";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable DanhSachKhachHang()
        {
            try
            {
                string querry = " SELECT * FROM tblKhachHang ";
                DataTable dt = new DataTable();
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand(querry, _Conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                _Conn.Close();
                return dt;
            }
            catch
            {
                return new DataTable();
            }
        }

        public string XoaKhachHang(string dienthoai)
        {
            try
            {
                string result;
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand("[XoaKhachHang]", _Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dienthoai", dienthoai);
                    result = cmd.ExecuteScalar().ToString();
                }
                _Conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CapNhatKhachHang(_3_DTO_QLBanHang.KhachHang khach)
        {
            try
            {
                string result;
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand("[CapNhatKhachHang]", _Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dienthoai", khach.DienThoai);
                    cmd.Parameters.AddWithValue("@tenkhachhang", khach.TenKhacHang);
                    cmd.Parameters.AddWithValue("@diachi", khach.DiaChi);
                    cmd.Parameters.AddWithValue("@phai", khach.Phai);
                    cmd.Parameters.AddWithValue("@manv", khach.MaNV);

                    result = cmd.ExecuteScalar().ToString();
                }
                _Conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable TimKiemKhachHang(string tenkhachhang)
        {
            try
            {
                DataTable dt = new DataTable();
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand("[TimKiemKhachHang]", _Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tenkhachhang", tenkhachhang);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                return dt;
            }
            catch
            {
                return new DataTable();
            }
        }
    }
}
