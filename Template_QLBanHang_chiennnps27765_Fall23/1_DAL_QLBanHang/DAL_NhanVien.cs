using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QLBanHang 
{
    public class DAL_NhanVien : DatabaseConnect
    {
        public bool NhanVienDangNhap(string email, byte[] password)
        {
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand("[DangNhap]", _Conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = email;
                cmd.Parameters.Add("@matkhau", SqlDbType.VarBinary, 64).Value = password;

                // Thêm một tham số đầu ra để nhận kết quả trả về
                SqlParameter returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteScalar();
                _Conn.Close();

                // Lấy giá trị trả về
                int result = (int)returnParameter.Value;
                if ( result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public string NhanVienQuenMatKhau(string email,string matKhauMoi)
        {
            try
            {
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand("[QuenMatKhau]",_Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@email",email));
                    cmd.Parameters.Add(new SqlParameter("@matkhaumoi",matKhauMoi));

                    SqlParameter outputParameter = new SqlParameter("@result", SqlDbType.NVarChar, 50);
                    outputParameter.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputParameter);

                    cmd.ExecuteScalar();
                    _Conn.Close();
                    return outputParameter.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message + ex.Source;
            }
        }

        public bool DoiMatKhau(string email, string matkhaucu, string matkhaumoi)
        {
            int result;
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand("[DoiMatKhau]", _Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@matkhaucu", matkhaucu);
                cmd.Parameters.AddWithValue("@matkhaumoi", matkhaumoi);

                result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string ThemNhanVien(string manv, string email, string tennv, string diachi, int vaitro, int tinhtrang)
        {
            try
            {
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                if (manv != "" && email != "" && tennv != "" && diachi != "" && vaitro > 0 && tinhtrang > 0)
                {
                    using (SqlCommand cmd = new SqlCommand("[ThemNhanVien]", _Conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@manv", manv);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@tennv", tennv);
                        cmd.Parameters.AddWithValue("@diachi", diachi);
                        cmd.Parameters.AddWithValue("@vaitro", vaitro);
                        cmd.Parameters.AddWithValue("@tinhtrang", tinhtrang);

                        string result = cmd.ExecuteScalar().ToString();
                        _Conn.Close();
                        return result;
                    }
                }
                else
                {
                    return "Thêm nhân viên Không thành công";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string XoaNhanVien(string email)
        {
            string result;
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand("[XoaNhanVien]", _Conn))
            {
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);

                result = cmd.ExecuteScalar().ToString();
            }
            _Conn.Close();
            return result;
        }

        public string CapNhatNhanVien(string email, string tennv, string diachi, int vaitro, int tinhtrang)
        {
            string result;
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand("[CapNhatNhanVien]", _Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@tennv", tennv);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@vaitro", vaitro);
                cmd.Parameters.AddWithValue("@tinhtrang", tinhtrang);
                
                result = cmd.ExecuteScalar().ToString();
            }
            _Conn.Close();
            return result;
        }

        public DataTable TimKiemNhanVien(string tennv)
        {
            DataTable dt = new DataTable();
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand("[TimKiemNhanVien]", _Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tennv", tennv);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            _Conn.Close();
            return dt;
        }

        public DataTable DanhSachNhanVien()
        {
            DataTable dt = new DataTable();
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand command = new SqlCommand("[DanhSachNhanVien]", _Conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            _Conn.Close();
            return dt;
        }

        public int VaiTroNhanVien(string email)
        {
            object result;
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            if (string.IsNullOrEmpty(email))
            {
                return 0;
            }
            using (SqlCommand cmd = new SqlCommand("[VaiTroNhanVien]", _Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                result = cmd.ExecuteScalar();
            }
            _Conn.Close();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public int TinhTrangNhanVien(string email)
        {
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand("[TinhTrangNhanVien]", _Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@email", email);
                int tinhtrang = (int)cmd.ExecuteScalar();
                _Conn.Close();
                return tinhtrang;
            }
        }

        public string MaNhanVien(string email)
        {
            string querry = " SELECT MaNV FROM tblNhanVien WHERE Email = @email";
            string result;
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using(SqlCommand cmd = new SqlCommand(querry, _Conn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                result = cmd.ExecuteScalar().ToString();
            }
            _Conn.Close();
            return result;
        }

        public string TenNhanVien(string email)
        {
            string querry = " SELECT TenNV FROM tblNhanVien WHERE Email = @email";
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

        public int SoLuongNhanVien()
        {
            string querry = " SELECT COUNT(*) FROM tblNhanVien ";
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open() ;
            }
            using (SqlCommand cmd = new SqlCommand(querry, _Conn))
            {
                int result = (int)cmd.ExecuteScalar();
                _Conn.Close();
                return result;
            }
        }

        public List<int> SubStringMaNhanVien()
        {
            string querry = " SELECT CAST(SUBSTRING(MaNV, 3, LEN(MaNV)) AS INT) AS Code  " +
                            " FROM tblNhanVien ";
            List<int> result = new List<int>();
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
                        result.Add(Convert.ToInt32(reader["Code"]));
                    }
                }
            }
            _Conn.Close();
            return result;
        }

        public bool TaoMatKhau(string email, string matKhauMoi)
        {
            return true;
        }

        public bool UpdateMatKhau(string email, string matKhauCu, string matKhauMoi)
        {
            return false;
        }
        
    }
}
