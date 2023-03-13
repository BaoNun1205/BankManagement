using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            string sqlNH = string.Format("INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu) VALUES ('{0}', '{1}', '{2}', '{3}', {4})", tknh.TenNH, tknh.SoTK, tknh.TenDN, tknh.MatKhau, tknh.SoDu);
            data.xuLi(sqlNH);
        }

        public void Xoa(TaiKhoangNganHang tknh)
        {
            string sqlNH = string.Format("DELETE FROM TaiKhoanNganHang WHERE SoTK ='{0}'", tknh.SoTK);
            data.xuLi(sqlNH);
        }
        public void Sua(TaiKhoangNganHang tknh)
        {
            string sqlNH = string.Format("UPDATE TaiKhoanNganHang SET TenDN = '{0}', MatKhau = '{1}', SoDu = {2} WHERE SoTK = '{3}'", tknh.TenDN, tknh.MatKhau, tknh.SoDu, tknh.SoTK);
            data.xuLi(sqlNH);
        }
        public bool IsEmpty(TaiKhoangNganHang tknh)
        {
            if (tknh.SoTK != "" && tknh.MatKhau != "" && tknh.TenDN != "" && tknh.SoDu != 0)
                return false;
            return true;
        }

        public TaiKhoangNganHang LayTaiKhoanNganHang(string Cot, string giaTri)
        {
            TaiKhoangNganHang tknh = new TaiKhoangNganHang();
            string sql = string.Format("SELECT * FROM TaiKhoanNganHang WHERE {0} = '{1}'", Cot, giaTri);
            tknh = data.XuLi(sql);
            return tknh;
        }

        public void GuiTien(TaiKhoangNganHang tkGui, GiaoDichChuyenTien chuyenTien, TaiKhoangNganHang tkNhan)
        {
            TaiKhoangNganHang taiKhoanNhan = new TaiKhoangNganHang();
            taiKhoanNhan = LayTaiKhoanNganHang("SoTK", tkNhan.SoTK);
            BigInteger soTienNhan = chuyenTien.SoTien + taiKhoanNhan.SoDu;
            string sqlStrNhan = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienNhan, taiKhoanNhan.SoTK);
            data.xuLi(sqlStrNhan);

            TaiKhoangNganHang taiKhoanGui = new TaiKhoangNganHang();
            taiKhoanGui = LayTaiKhoanNganHang("SoTk", tkGui.SoTK);
            BigInteger soTienGui = taiKhoanGui.SoDu - chuyenTien.SoTien;
            string sqlStrGui = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienGui, taiKhoanGui.SoTK);
            data.xuLi(sqlStrGui);
        }
    }
}
