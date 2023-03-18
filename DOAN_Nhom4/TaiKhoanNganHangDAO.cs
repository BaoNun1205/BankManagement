using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class TaiKhoanNganHangDAO
    {
        DBConnection data = new DBConnection();
        public TaiKhoanNganHangDAO() { }

        public void Them(TaiKhoanNganHang tknh)
        {
            string sqlNH = string.Format("INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}')", tknh.TenNH, tknh.SoTK, tknh.TenDN, tknh.MatKhau, tknh.SoDu, tknh.NgayDangKy);
            data.xuLi(sqlNH);
        }

        public void Xoa(TaiKhoanNganHang tknh)
        {
            string sqlNH = string.Format("DELETE FROM TaiKhoanNganHang WHERE SoTK ='{0}'", tknh.SoTK);
            data.xuLi(sqlNH);
        }
        public void Sua(TaiKhoanNganHang tknh)
        {
            string sqlNH = string.Format("UPDATE TaiKhoanNganHang SET TenDN = '{0}', MatKhau = '{1}', SoDu = {2}, NgayDangKy = '{3}' WHERE SoTK = '{4}'", tknh.TenDN, tknh.MatKhau, tknh.SoDu,tknh.NgayDangKy, tknh.SoTK);
            data.xuLi(sqlNH);
        }
        public bool IsEmpty(TaiKhoanNganHang tknh)
        {
            if (tknh.SoTK != "" && tknh.MatKhau != "" && tknh.TenDN != "" && tknh.SoDu != 0)
                return false;
            return true;
        }

        public TaiKhoanNganHang LayTaiKhoanNganHang(string Cot, string giaTri)
        {
            TaiKhoanNganHang tknh = new TaiKhoanNganHang();
            string sql = string.Format("SELECT * FROM TaiKhoanNganHang WHERE {0} = '{1}'", Cot, giaTri);
            tknh = data.XuLi(sql);
            return tknh;
        }

        public void GuiTien(TaiKhoanNganHang tkGui, GiaoDichChuyenTien chuyenTien, TaiKhoanNganHang tkNhan)
        {
            TaiKhoanNganHang taiKhoanNhan = new TaiKhoanNganHang();
            taiKhoanNhan = LayTaiKhoanNganHang("SoTK", tkNhan.SoTK);
            BigInteger soTienNhan = chuyenTien.SoTien + taiKhoanNhan.SoDu;
            string sqlStrNhan = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienNhan, taiKhoanNhan.SoTK);
            data.xuLi(sqlStrNhan);

            TaiKhoanNganHang taiKhoanGui = new TaiKhoanNganHang();
            taiKhoanGui = LayTaiKhoanNganHang("SoTk", tkGui.SoTK);
            BigInteger soTienGui = taiKhoanGui.SoDu - chuyenTien.SoTien;
            string sqlStrGui = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienGui, taiKhoanGui.SoTK);
            data.xuLi(sqlStrGui);
        }
        public void NapTien(TaiKhoanNganHang tkNap, BigInteger SoTien)
        {
            TaiKhoanNganHang taiKhoanNhan = new TaiKhoanNganHang();
            taiKhoanNhan = LayTaiKhoanNganHang("SoTK", tkNap.SoTK);
            BigInteger tongSoDu = SoTien + taiKhoanNhan.SoDu;
            string sqlStrNap = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}'", tongSoDu, taiKhoanNhan.SoTK);
            data.xuLi(sqlStrNap);
        }
    }
}
