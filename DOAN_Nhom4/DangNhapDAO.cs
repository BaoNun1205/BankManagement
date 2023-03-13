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

        NguoiDungDAO nguoiDungDAO = new NguoiDungDAO();
        public bool XacNhanDangNhap(DangNhap dn)
        {
            NguoiDung khachHang = new NguoiDung();
            khachHang = nguoiDungDAO.LayKhachHang("TenDN", dn.TenDN);
            if (khachHang.TenDN == dn.TenDN && khachHang.MatKhau == dn.MatKhau)
            {
                return true;
            }
            return false;
        }
    }
}
