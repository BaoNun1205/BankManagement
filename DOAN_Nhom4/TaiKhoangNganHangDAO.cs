using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class TaiKhoangNganHangDAO
    {
        DBConnection data = new DBConnection();
        public TaiKhoangNganHangDAO() { }

        public void Them(TaiKhoangNganHang tknh)
        {
            string sqlNH = string.Format("INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu) VALUES ('{0}', '{1}', '{2}', '{3}', {4})", tknh.TenNH, tknh.SoTK1, tknh.TenDN, tknh.MatKhau, tknh.SoDu);
            data.xuLi(sqlNH);
        }

        public void Xoa(TaiKhoangNganHang tknh)
        {
            string sqlNH = string.Format("DELETE FROM TaiKhoanNganHang WHERE SoTK ='{0}'", tknh.SoTK1);
            data.xuLi(sqlNH);
        }
        public void Sua(TaiKhoangNganHang tknh)
        {
            string sqlNH = string.Format("UPDATE TaiKhoanNganHang SET TenDN = '{0}', MatKhau = '{1}', SoDu = {2} WHERE SoTK = '{3}'", tknh.TenDN, tknh.MatKhau, tknh.SoDu, tknh.SoTK1);
            data.xuLi(sqlNH);
        }
        public bool IsEmpty(TaiKhoangNganHang tknh)
        {
            if (tknh.SoTK1 != "" && tknh.MatKhau != "" && tknh.TenDN != "" && tknh.SoDu != 0)
                return false;
            return true;
        }

        /*public void GuiTien(TaiKhoangNganHang tkGui, ChuyenTien chuyenTien, TaiKhoangNganHang tkNhan)
        {
            TaiKhoangNganHang taiKhoangNhan = new TaiKhoangNganHang();
            taiKhoangNhan = data.LayKhachHang("SoTK", tkNhan.SoTK);
            BigInteger soTienNhan = chuyenTien.SoTien + taiKhoangNhan.SoDu;
            string sqlStrNhan = string.Format("UPDATE KhachHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienNhan, taiKhoangNhan.SoTK);
            data.xuLi(sqlStrNhan);

            NguoiDung khachHangGui = new NguoiDung();
            khachHangGui = data.LayKhachHang("SoTk", khGui.SoTK);
            BigInteger soTienGui = khachHangGui.SoDu - chuyenTien.SoTien;
            string sqlStrGui = string.Format("UPDATE KhachHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienGui, khachHangGui.SoTK);
            data.xuLi(sqlStrGui);
        }*/
    }
}
