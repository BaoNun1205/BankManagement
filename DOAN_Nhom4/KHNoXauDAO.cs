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
        NganHangHhbContext hhb = new NganHangHhbContext();
        DBConnection data = new DBConnection();
        public KHNoXauDAO() { }
        public void Them(KhachHangNoXau kh)
        {
            hhb.KhachHangNoXaus.Add(kh);
            hhb.SaveChanges();
        }
        public void Xoa(KhachHangNoXau kh)
        {
            KhachHangNoXau tmp = hhb.KhachHangNoXaus.Where(tmp => tmp.SoTk == kh.SoTk).FirstOrDefault();
            hhb.Remove(tmp);
            hhb.SaveChanges();
        }
        public KhachHangNoXau IsNull(TaiKhoanNganHang tknh)
        {
            return hhb.KhachHangNoXaus.Where(tmp => tmp.SoTk == tknh.SoTk).FirstOrDefault();
        }
    }
}
