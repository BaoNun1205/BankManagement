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

        DBConnection data = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public DataTable HienThi()
        {
            string sqlStr = string.Format("SELECT *FROM KhachHang");
            return data.LayDanhSach(sqlStr);
        }
        public void Them(NguoiDung kh)
        {
            string sqlStr = string.Format("INSERT INTO KhachHang(SoTK , TenTK, TenDN, MatKhau, NgaySinh, CCCD, SDT, SoDU) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})", kh.SoTK, kh.TenTK, kh.TenDN, kh.Pass, kh.NgaySinh, kh.Cccd, kh.Sdt, kh.SoDu);
            data.xuLi(sqlStr); 
        }

        public void Xoa(NguoiDung kh)
        {
            string sqlStr = string.Format("DELETE FROM KhachHang WHERE SoTK ='{0}'", kh.SoTK);
            data.xuLi(sqlStr);
        }
        public void Sua(NguoiDung kh)
        {
            string sqlStr = string.Format("UPDATE KhachHang SET TenTK = '{0}' , TenDN = '{1}', MatKhau = '{2}', NgaySinh = '{3}', CCCD = '{4}', SDT = '{5}', SoDu = {6} WHERE SoTK ='{7}'", kh.TenTK, kh.TenDN, kh.Pass, kh.NgaySinh, kh.Cccd, kh.Sdt, kh.SoDu, kh.SoTK);
            data.xuLi(sqlStr);
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
                if (reader.HasRows)
                {
                    reader.Read();
                    khachHang.SoTK = reader.GetString(0);
                    khachHang.TenTK = reader.GetString(1);
                    khachHang.TenDN = reader.GetString(2);
                    khachHang.Pass = reader.GetString(3);
                    khachHang.NgaySinh = reader.GetDateTime(4);
                    khachHang.Cccd = reader.GetString(5);
                    khachHang.Sdt = reader.GetString(6);
                    khachHang.SoDu = reader.GetInt64(7);
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
        public void GuiTien(NguoiDung ngGui, GiaoDichChuyenTien gdchuyentien, NguoiDung ngNhan)
        {
            NguoiDung khachHangNhan = new NguoiDung();
            khachHangNhan = LayKhachHang("SoTK", ngNhan.SoTK);
            BigInteger soTienNhan = gdchuyentien.SotienGiaodich + khachHangNhan.SoDu;
            string sqlStrNhan = string.Format("UPDATE KhachHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienNhan, khachHangNhan.SoTK);
            data.xuLi(sqlStrNhan);

            NguoiDung khachHangGui = new NguoiDung();
            khachHangGui = LayKhachHang("SoTk", ngGui.SoTK);
            BigInteger soTienGui = khachHangGui.SoDu - gdchuyentien.SotienGiaodich;
            string sqlStrGui = string.Format("UPDATE KhachHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienGui, khachHangGui.SoTK);
            data.xuLi(sqlStrGui);
            ngGui.SoDu = ngGui.SoDu - gdchuyentien.SotienGiaodich;

        }
        public bool IsEmpty(NguoiDung ad)
        {
            if (ad.SoTK != "" && ad.TenTK != "" && ad.Pass != "" && ad.TenDN != "" && ad.Cccd != "" && ad.Sdt != "")
                return false;
            return true;
        }
        public bool IsPhone(NguoiDung ad)
        {
            return data.IsPhone(ad.Sdt);
        }
    }
}
