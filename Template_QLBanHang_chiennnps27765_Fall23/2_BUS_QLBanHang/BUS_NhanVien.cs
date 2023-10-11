using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_QLBanHang;
using _3_DTO_QLBanHang;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace _2_BUS_QLBanHang
{
    public class BUS_NhanVien
    {
        private DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
        private const string apiKey = "c9edb9285c810b4fae2b8829e8586f4976b45e55";

        public bool NhanVienDangNhap(string email, string password)
        {
            return dal_NhanVien.NhanVienDangNhap(email, Encryption(password));
        }

        public string NhanVienQuenMatKhau(string email, string matkhaumoi)
        {
            return dal_NhanVien.NhanVienQuenMatKhau(email, matkhaumoi);
        }

        public bool DoiMatKhau(string email, string matkhaucu, string matkhaumoi)
        {
            return dal_NhanVien.DoiMatKhau(email, matkhaucu, matkhaumoi);
        }

        public string TaoMatKhau(string email)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            var radom = new Random();
            var matKhauMoi = new string(Enumerable.Repeat(chars, 8).Select(s => s[radom.Next(s.Length)]).ToArray());
            return matKhauMoi;
        }

        public byte[] Encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            return hashBytes;
        }

        public DataTable DanhSachNhanVien()
        {
            return dal_NhanVien.DanhSachNhanVien();
        }

        public int VaiTroNhanVien(string email)
        {
            return dal_NhanVien.VaiTroNhanVien(email);
        }

        public int TinhTrangNhanVien(string email)
        {
            return dal_NhanVien.TinhTrangNhanVien(email);
        }

        public string MaNhanVien(string email)
        {
            return dal_NhanVien.MaNhanVien(email);
        }

        public string TenNhanVien(string email)
        {
            return dal_NhanVien.TenNhanVien(email);
        }

        public string ThemNhanVien(string manv, string email, string tennv, string diachi, int vaitro, int tinhtrang)
        {
            return dal_NhanVien.ThemNhanVien(manv, email, tennv, diachi, vaitro, tinhtrang);
        }

        public string TaoMaNhanVien()
        {
            if (dal_NhanVien.SoLuongNhanVien() > 0)
            {
                List<int> Code = dal_NhanVien.SubStringMaNhanVien();
                int maxCode = Code.Max() + 1;
                if (maxCode < 10)
                {
                    return "NV" + "000" + maxCode;
                }
                else if (maxCode < 100)
                {
                    return "NV" + "00" + maxCode;
                }
                else if (maxCode < 1000)
                {
                    return "NV" + "0" + maxCode;
                }
                else
                {
                    return "NV" + maxCode;
                }
            }
            return "NV0001";
        }

        public string XoaNhanVien(string email)
        {
            return dal_NhanVien.XoaNhanVien(email);
        }

        public string CapNhatNhanVien(string email, string tennv, string diachi, int vaitro, int tinhtrang)
        {
            return dal_NhanVien.CapNhatNhanVien(email, tennv, diachi, vaitro, tinhtrang);
        }

        public DataTable TimKiemNhanVien(string tennv)
        {
            return dal_NhanVien.TimKiemNhanVien(tennv);
        }

        public string GuiMail(string to, string subject ,string content)
        {
            string from = "chienprivate@gmail.com";
            string pass = "rxth acjd gzqz vtao";
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(from);
            msg.To.Add(to);
            msg.Subject = subject;
            msg.Body = content;

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.EnableSsl = true;
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(from, pass);
            try
            {
                client.Send(msg);
                return "gửi mail thành công";
            }
            catch (Exception ex)
            {
                return "Gửi mail thất bại \n" + ex.Message;
            }
        }

        public async Task<string> KiemTraEmailTonTai(string email)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = $"https://api.hunter.io/v2/email-verifier?email={email}&api_key={apiKey}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        // phân tích JSON response
                        var data = JObject.Parse(jsonResponse);
                        string status = data["data"]["result"].ToString();

                        if (status.Equals("deliverable", StringComparison.OrdinalIgnoreCase))
                        {
                            return "Email hợp lệ";
                        }
                        else if (status.Equals("undeliverable", StringComparison.OrdinalIgnoreCase))
                        {
                            return "Không thể gửi mail cho địa chỉ email này\n hãy kiểm tra lại địa chỉ email";
                        }
                        else
                        {
                            return "Trạng thái email không xác định \n hãy kiểm tra lại email";
                        }
                    }
                    else
                    {
                        return "Địa chỉ email không hợp lệ";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
