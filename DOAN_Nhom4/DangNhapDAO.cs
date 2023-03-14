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

        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        public bool XacNhanDangNhap(DangNhap dn)
        {
            TaiKhoanNganHang tknh = new TaiKhoanNganHang();
            tknh = tknhDAO.LayTaiKhoanNganHang("TenDN", dn.TenDN);
            if (tknh.TenDN == dn.TenDN && tknh.MatKhau == dn.MatKhau)
            {
                return true;
            }
            return false;
        }
    }
}
