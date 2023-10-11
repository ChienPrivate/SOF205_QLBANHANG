using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLBanHang
{
    public class DAL_Hang : DatabaseConnect
    {
        public string MaNhanVien(string email)
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
                result = Convert.ToString(cmd.ExecuteScalar());
            }
            _Conn.Close();
            return result;
        }

        public string ThemSanPham(_3_DTO_QLBanHang.Hang sanpham)
        {
            int result;
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            try
            {
                if (sanpham.MaHang != "" && sanpham.TenHang != "" && sanpham.SoLuong != 0 && sanpham.DonGiaBan != 0 && sanpham.DonGiaNhap != 0)
                {
                    using (SqlCommand cmd = new SqlCommand("[ThemSanPham]", _Conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@mahang", sanpham.MaHang);
                        cmd.Parameters.AddWithValue("@tenhang", sanpham.TenHang);
                        cmd.Parameters.AddWithValue("@soluong", sanpham.SoLuong);
                        cmd.Parameters.AddWithValue("@dgb", sanpham.DonGiaBan);
                        cmd.Parameters.AddWithValue("@dgn", sanpham.DonGiaNhap);
                        cmd.Parameters.AddWithValue("@hinhanh", sanpham.HinhAnh);
                        cmd.Parameters.AddWithValue("@ghichu", sanpham.GhiChu);
                        cmd.Parameters.AddWithValue("@manv", sanpham.MaNV);

                        result = cmd.ExecuteNonQuery();
                        _Conn.Close();
                        if (result > 0)
                        {
                            return "Thêm sản phẩm thành công";
                        }
                        else
                        {
                            return "Thêm sản phẩm không thành công";
                        }
                    }
                }
                else
                {
                    return "Thêm sản phẩm thất bại";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int SoLuongSanPham()
        {
            string querry = " SELECT COUNT(*) FROM tblHang ";
            int soluong;
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(querry, _Conn))
            {
                soluong = Convert.ToInt32(cmd.ExecuteScalar());
            }
            _Conn.Close();
            return soluong;
        }

        public List<int> TachChuoiMaSanPham()
        {
            string querry = " SELECT CAST( SUBSTRING( MaHang, 3, LEN(MaHang)) AS INT) AS Code " +
                            " FROM tblHang ";
            List<int> manvInt = new List<int>();
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(querry, _Conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        manvInt.Add(Convert.ToInt32(reader["Code"]));
                    }
                }
            }
            _Conn.Close();
            return manvInt;
        }

        public DataTable DanhMucSanPham()
        {
            string querry = " SELECT * FROM tblHang ";
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

        public string XoaSanPham(string masp)
        {
            try
            {
                int result;
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand("[XoaSanPham]", _Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@masp", masp);
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return "Xóa sản phẩm thành công";
                    }
                    else
                    {
                        return "Xóa sản phẩm không thành công";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CapNhatSanPham(_3_DTO_QLBanHang.Hang sanpham)
        {
            try
            {
                int result;
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand("[CapNhatSanPham]", _Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@mahang", sanpham.MaHang);
                    cmd.Parameters.AddWithValue("@tenhang", sanpham.TenHang);
                    cmd.Parameters.AddWithValue("@soluong", sanpham.SoLuong);
                    cmd.Parameters.AddWithValue("@dgb", sanpham.DonGiaBan);
                    cmd.Parameters.AddWithValue("@dgn", sanpham.DonGiaNhap);
                    cmd.Parameters.AddWithValue("@hinhanh", sanpham.HinhAnh);
                    cmd.Parameters.AddWithValue("@ghichu", sanpham.GhiChu);
                    cmd.Parameters.AddWithValue("@manv", sanpham.MaNV);

                    result = cmd.ExecuteNonQuery();
                    _Conn.Close();
                    if (result > 0)
                    {
                        return "Cập nhật sản phẩm thành công";
                    }
                    else
                    {
                        return "Cập nhật sản phẩm không thành công";
                    }
                }
            }
            catch (Exception ex)
            {
                _Conn.Close();
                return ex.Message;
            }
        }

        public DataTable TimKiemSanPham(string tensp)
        {
            DataTable dt = new DataTable();
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand("[TimKiemSanPham]", _Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tensp", tensp);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            _Conn.Close();
            return dt;
        }
    }
}
