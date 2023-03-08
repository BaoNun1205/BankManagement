using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class DangNhapDAO
    {
        public DangNhapDAO() { }

        DBConnection db = new DBConnection();
        public bool XacNhanDangNhap(DangNhap dn)
        {
            NguoiDung khachHang = new NguoiDung();
            khachHang = db.LayKhachHang("TenDN", dn.TenDN);
            if (khachHang.TenDN == dn.TenDN && khachHang.Pass == dn.Pass)
            {
                return true;
            }
            return false;
        }
    }
}
