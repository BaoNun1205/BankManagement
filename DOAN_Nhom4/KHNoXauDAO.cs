using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class KHNoXauDAO
    {

        KHNoXau kh = new KHNoXau();
        DBConnection data = new DBConnection();
        public KHNoXauDAO() { }
        public void Them(KHNoXau kh)
        {
            string sql = string.Format("INSERT INTO KhachHangNoXau(SoTK, TenTK, CCCD, NgayNo, TenNH) Values('{0}', '{1}', '{2}', '{3}', '{4}')", kh.SoTK, kh.TenTK, kh.Cccd, kh.NgayNo, kh.TenNH);
            data.xuLi(sql);
        }
        public void Xoa(KHNoXau kh)
        {
            string sql = string.Format("DELETE FROM KhachHangNoXau WHERE SoTK = '{0}'", kh.SoTK);
            data.xuLi(sql);
        }
        public KHNoXau IsNull(TaiKhoanNganHang tknh)
        {
            string sql = string.Format("SELECT * FROM KhachHangNoXau WHERE SoTK = '{0}'", tknh.SoTk);
            return data.XuLiKHNoXau(sql);
        }
    }
}
