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
            string sqlNH = string.Format("UPDATE TaiKhoanNganHang SET TenDN = '{0}', MatKhau = '{1}', SoDu = {2} WHERE SoTK = '{3}'", tknh.TenDN, tknh.MatKhau, tknh.SoDu, tknh.SoTK);
            data.xuLi(sqlNH);
        }
        public void SuaSoDu(TaiKhoanNganHang tknh)
        {
            string sqlNH = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}'", tknh.SoDu, tknh.SoTK);
            data.xuLi(sqlNH);
        }
        public bool IsEmpty(TaiKhoanNganHang tknh)
        {
            if (tknh.SoTK != "" && tknh.MatKhau != "" && tknh.TenDN != "" && tknh.SoDu != 0)
                return false;
            return true;
        }

        public TaiKhoanNganHang LayTaiKhoanNganHang(string CotSoTK, string GTSoTK, string CotTenNH, string GTTenNH)
        {
            TaiKhoanNganHang tknh = new TaiKhoanNganHang();
            string sql = string.Format("SELECT * FROM TaiKhoanNganHang WHERE {0} = '{1}' AND {2} = '{3}'", CotSoTK, GTSoTK, CotTenNH, GTTenNH);
            tknh = data.XuLi(sql);
            return tknh;
        }

        public void ChuyenTien(TaiKhoanNganHang tkGui, GiaoDich gd, TaiKhoanNganHang tkNhan)
        {
            TaiKhoanNganHang taiKhoanNhan = LayTaiKhoanNganHang("SoTK", gd.SoTKNhan, "TenNH", gd.NganHangNhan);
            BigInteger soTienNhan = gd.SoTien + taiKhoanNhan.SoDu;
            string sqlStrNhan = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienNhan, taiKhoanNhan.SoTK);
            data.xuLi(sqlStrNhan);

            TaiKhoanNganHang taiKhoanGui = LayTaiKhoanNganHang("SoTk", gd.SoTKGui, "TenNH", gd.NganHangGui);
            BigInteger soTienGui = taiKhoanGui.SoDu - gd.SoTien;
            string sqlStrGui = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienGui, taiKhoanGui.SoTK);
            data.xuLi(sqlStrGui);
        }
        public void NapTien(TaiKhoanNganHang tkNap, GiaoDich gd)
        {
            BigInteger SoDu = gd.SoTien + tkNap.SoDu;
            string sqlStrNap = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}' AND TenNH = '{2}'", SoDu, tkNap.SoTK, tkNap.TenNH);
            data.xuLi(sqlStrNap);        
        }
        public void RutTien(TaiKhoanNganHang tkRut, GiaoDich gd)
        {
            BigInteger SoDu = tkRut.SoDu - gd.SoTien;
            string sqlStrRut = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}' AND TenNH = '{2}'", SoDu, tkRut.SoTK, tkRut.TenNH);
            data.xuLi(sqlStrRut);
        }
    }
}
