using System;
using System.Data.SqlClient;
using System.IO;

namespace _1_DAL_QLBanHang
{
    public class DatabaseConnect
    {
        // Kết nối dành cho localDb
        /*private static string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string mdfFilePath = Path.Combine(directoryPath, "QLBanHang.mdf");
        private static string connection = $@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename = {mdfFilePath} ;Initial Catalog=QLBanHang;Integrated Security=True";
        protected SqlConnection _Conn = new SqlConnection(connection);*/

        // Kết nối đến Azure Sql
        private const string azureConnection = @"Server=tcp:chienprivate.database.windows.net,1433;Initial Catalog=QuanLyBanHang;Persist Security Info=False;User ID=chienprivate@gmail.com@chienprivate;Password=Chienprivate@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        protected SqlConnection _Conn = new SqlConnection(azureConnection);
    }
}
