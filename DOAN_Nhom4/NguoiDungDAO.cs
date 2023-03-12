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
            string sqlStr = string.Format("SELECT KhachHang.TenNH, KhachHang.SoTK, KhachHang.TenKH, TaiKhoanNganHang.TenDN, TaiKhoanNganHang.MatKhau, TaiKhoanNganHang.SoDu, KhachHang.NgaySinh, KhachHang.CCCD, KhachHang.Email, KhachHang.SDT "
                                        + "FROM KhachHang "
                                        + "JOIN TaiKhoanNganHang ON KhachHang.TenNH = TaiKhoanNganHang.TenNH AND KhachHang.SoTK = TaiKhoanNganHang.SoTK");
            return data.LayDanhSach(sqlStr);
        }
        public void Them(NguoiDung kh, TaiKhoangNganHang tknh)
        {
            string sqlKH = string.Format("INSERT INTO KhachHang(TenNH, SoTK , TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", kh.TenNH, kh.SoTK, kh.TenTK, kh.NgaySinh, kh.Cccd, kh.Email, kh.Sdt);
            string sqlNH = string.Format("INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu) VALUES ('{0}', '{1}', '{2}', '{3}', {4})", tknh.TenNH, tknh.SoTK1, tknh.TenDN, tknh.MatKhau, tknh.SoDu);
            data.xuLi(sqlKH, sqlNH); 
        }
        
        public void Xoa(NguoiDung kh, TaiKhoangNganHang tknh)
        {
            string sqlKH = string.Format("DELETE FROM KhachHang WHERE SoTK ='{0}'", kh.SoTK);
            string sqlNH = string.Format("DELETE FROM TaiKhoanNganHang WHERE SoTK ='{0}'", tknh.SoTK1);
            data.xuLi(sqlKH, sqlNH);
        }
        public void Sua(NguoiDung kh, TaiKhoangNganHang tknh)
        {
            string sqlKH = string.Format("UPDATE KhachHang SET TenTK = '{0}', NgaySinh = '{1}', CCCD = '{2}', Email = '{3}', SDT = '{4}' WHERE SoTK ='{5}'", kh.TenTK, kh.NgaySinh, kh.Cccd, kh.Email, kh.Sdt, kh.SoTK);
            string sqlNH = string.Format("UPDATE TaiKhoanNganHang SET TenDN = '{0}', MatKhau = '{1}', SoDu = {2} WHERE SoTK = '{3}'", tknh.TenDN, tknh.MatKhau, tknh.SoDu, tknh.SoTK1);
            data.xuLi(sqlKH, sqlNH);
        }
        
        public bool IsEmpty(NguoiDung kh, TaiKhoangNganHang tknh)
        {
            if (kh.SoTK != "" && kh.TenTK != "" && tknh.MatKhau != "" && tknh.TenDN != "" && kh.Cccd != "" && kh.Sdt != "" && tknh != null && kh.Email != "")
                return false;
            return true;
        }
        public bool IsPhone(NguoiDung kh)
        {
            return data.IsPhone(kh.Sdt);
        }
        
    }
}
