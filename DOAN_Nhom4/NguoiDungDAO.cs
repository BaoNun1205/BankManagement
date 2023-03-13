using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class NguoiDungDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection data = new DBConnection();
        public DataTable HienThi()
        {
            string sqlStr = string.Format("SELECT KhachHang.TenNH, KhachHang.SoTK, KhachHang.TenKH, TaiKhoanNganHang.TenDN, TaiKhoanNganHang.MatKhau, TaiKhoanNganHang.SoDu, KhachHang.NgaySinh, KhachHang.CCCD, KhachHang.Email, KhachHang.SDT "
                                        + "FROM KhachHang "
                                        + "JOIN TaiKhoanNganHang ON KhachHang.TenNH = TaiKhoanNganHang.TenNH AND KhachHang.SoTK = TaiKhoanNganHang.SoTK");
            return data.LayDanhSach(sqlStr);
        }
        public void Them(NguoiDung kh)
        {
            string sqlKH = string.Format("INSERT INTO KhachHang(TenNH, SoTK , TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", kh.TenNH, kh.SoTK, kh.TenTK, kh.NgaySinh, kh.Cccd, kh.Email, kh.Sdt);
            data.xuLi(sqlKH); 
        }
        
        public void Xoa(NguoiDung kh)
        {
            string sqlKH = string.Format("DELETE FROM KhachHang WHERE SoTK ='{0}'", kh.SoTK);
            data.xuLi(sqlKH);
        }
        public void Sua(NguoiDung kh)
        {
            string sqlKH = string.Format("UPDATE KhachHang SET TenTK = '{0}', NgaySinh = '{1}', CCCD = '{2}', Email = '{3}', SDT = '{4}' WHERE SoTK ='{5}'", kh.TenTK, kh.NgaySinh, kh.Cccd, kh.Email, kh.Sdt, kh.SoTK);
            data.xuLi(sqlKH);
        }

        public NguoiDung LayKhachHang(string Cot, string giaTri)
        {
            NguoiDung khachHang = new NguoiDung();
            try
            {
                conn.Open();
                string sql = string.Format("SELECT * FROM KhachHang WHERE {0} = @Giatri", Cot);
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@Giatri", giaTri);

                SqlDataReader reader = command.ExecuteReader();
                /*if (reader.HasRows)
                {
                    reader.Read();
                    khachHang.SoTK = reader.GetString(0);
                    khachHang.TenTK = reader.GetString(1);
                    khachHang.TenDN = reader.GetString(2);
                    khachHang.Pass = reader.GetString(3);
                    khachHang.NgaySinh = reader.GetDateTime(4);
                    khachHang.Cccd = reader.GetString(5);
                    khachHang.Sdt = reader.GetString(6);
                }
                else
                    return null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return khachHang;
        }

        public bool IsEmpty(NguoiDung kh)
        {
            if (kh.SoTK != "" && kh.TenTK != "" && kh.Cccd != "" && kh.Sdt != ""  && kh.Email != "")
                return false;
            return true;
        }
        public bool IsPhone(NguoiDung kh)
        {
            return data.IsPhone(kh.Sdt);
        }
        
    }
}
