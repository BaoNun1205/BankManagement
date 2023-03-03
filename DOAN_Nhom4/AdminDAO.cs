using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class AdminDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection data = new DBConnection();
        public DataTable HienThi()
        {
            string sqlStr = string.Format("SELECT *FROM KhachHang");
            return data.LayDanhSach(sqlStr, conn);
        }
        public void Them(Admin ad)
        {
            string sqlStr = string.Format("INSERT INTO KhachHang(SoTK , TenTK, TenDN, MatKhau, NgaySinh, CCCD, SDT) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", ad.SoTK, ad.TenTK, ad.TenDN, ad.Pass, ad.NgaySinh, ad.Cccd, ad.Sdt);
            data.xuLi(sqlStr, conn);
        }

        public void Xoa(Admin ad)
        {
            string sqlStr = string.Format("DELETE FROM KhachHang WHERE SoTK ='{0}'", ad.SoTK);
            data.xuLi(sqlStr, conn);
        }
        public void Sua(Admin ad)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET TenTK = '{0}' , TenDN = '{1}', MatKhau = '{2}', NgaySinh = '{3}', CCCD = '{4}', SDT = '{5}' WHERE SoTK ='{6}'", ad.TenTK, ad.TenDN, ad.Pass, ad.NgaySinh, ad.Cccd, ad.Sdt, ad.SoTK);
            data.xuLi(sqlStr, conn);
        }
        public bool IsEmpty(Admin ad)
        {
            if (ad.SoTK != "" && ad.TenTK != "" && ad.Pass != "" && ad.TenDN != "" && ad.Cccd != "" && ad.Sdt != "")
                return false;
            return true;
        }
        public bool IsPhone(Admin ad)
        {
            return data.IsPhone(ad.Sdt);
        }
    }
}
