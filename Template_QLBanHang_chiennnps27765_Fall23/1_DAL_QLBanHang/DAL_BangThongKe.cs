using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _1_DAL_QLBanHang
{
    public class DAL_BangThongKe : DatabaseConnect
    {
        public int TongTonKho()
        {
            try
            {
                int result;
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand("[TongTonKho]", _Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = int.Parse(cmd.ExecuteScalar().ToString());
                }
                _Conn.Close();
                return result;
            }
            catch
            {
                return 0;
            }
        }

        public double TongTienHang()
        {
            try
            {
                double result;
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand("[TongTienHang]", _Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = double.Parse(cmd.ExecuteScalar().ToString());
                }
                _Conn.Close();
                return result;
            }
            catch
            {
                return 0;
            }
        }

        public int SoLuongKhachHang()
        {
            try
            {
                int result;
                if (_Conn.State != ConnectionState.Open)
                {
                    _Conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand("[SoLuongKhachHang]", _Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = int.Parse(cmd.ExecuteScalar().ToString());
                }
                _Conn.Close();
                return result;
            }
            catch
            {
                return 0;
            }
        }

        public DataTable SanPhamNhapKho()
        {
            DataTable result = new DataTable();
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand("[SanPhamNhapKho]", _Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    result.Load(reader);
                }
            }
            _Conn.Close();
            return result;
        }

        public DataTable TonKho()
        {
            DataTable result = new DataTable();
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand("[Tonkho]", _Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    result.Load(reader);
                }
            }
            _Conn.Close();
            return result;
        }

        public DataTable Top5SanPham()
        {
            DataTable result = new DataTable();
            if (_Conn.State != ConnectionState.Open)
            {
                _Conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand("[Top5SanPham]", _Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    result.Load(reader);
                }
            }
            _Conn.Close();
            return result;

        }
    }
}
