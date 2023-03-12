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

            NguoiDung khachHangGui = new NguoiDung();
            khachHangGui = data.LayKhachHang("SoTk", khGui.SoTK);
            BigInteger soTienGui = khachHangGui.SoDu - chuyenTien.SoTien;
            string sqlStrGui = string.Format("UPDATE KhachHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienGui, khachHangGui.SoTK);
            data.xuLi(sqlStrGui);
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
