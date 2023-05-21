using DOAN_Nhom4.Entities;
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
            tknh = tknhDAO.LayTaiKhoanNganHangBangTenDn(dn.TenDN, "HHB");
            if (tknh != null && tknh.TenDn == dn.TenDN && tknh.MatKhau == dn.MatKhau)
            {
                return true;
            }
            return false;
        }
    }
}
