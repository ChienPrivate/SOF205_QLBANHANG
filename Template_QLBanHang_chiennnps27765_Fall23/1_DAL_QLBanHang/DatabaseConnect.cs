using System;
using System.Data.SqlClient;
using System.IO;

namespace _1_DAL_QLBanHang
{
    public class DatabaseConnect
    {
        private static string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string mdfFilePath = Path.Combine(directoryPath, "QLBanHang.mdf");
        private static string connection = $@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename = {mdfFilePath} ;Initial Catalog=QLBanHang;Integrated Security=True";
        protected SqlConnection _Conn = new SqlConnection(connection);
    }
}
