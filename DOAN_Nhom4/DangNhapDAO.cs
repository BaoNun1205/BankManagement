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

        TaiKhoangNganHangDAO tknhDAO = new TaiKhoangNganHangDAO();
        public bool XacNhanDangNhap(DangNhap dn)
        {
            TaiKhoangNganHang tknh = new TaiKhoangNganHang();
            tknh = tknhDAO.LayTaiKhoanNganHang("TenDN", dn.TenDN);
            if (tknh.TenDN == dn.TenDN && tknh.MatKhau == dn.Pass)
            {
                return true;
            }
            return false;
        }
    }
}
