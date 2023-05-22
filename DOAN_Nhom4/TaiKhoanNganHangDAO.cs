using DOAN_Nhom4.Entities;
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
        NganHangHhbContext hhb = new NganHangHhbContext();
        DBConnection data = new DBConnection();
        public TaiKhoanNganHangDAO() { }

        public void Them(TaiKhoanNganHang tknh)
        {
            hhb.Add(tknh);
            hhb.SaveChanges();
        }

        public void Xoa(TaiKhoanNganHang tknh)
        {
            TaiKhoanNganHang? tk = hhb.TaiKhoanNganHangs.Where(tk => tk.TenNh == tknh.TenNh && tk.SoTk == tknh.SoTk).SingleOrDefault();
            if (tk != null)
            {
                hhb.Remove(tk);
                hhb.SaveChanges();
            }    
        }
        public void Sua(TaiKhoanNganHang tknh)
        {
            TaiKhoanNganHang? tk = hhb.TaiKhoanNganHangs.Where(tk => tk.TenNh == tknh.TenNh && tk.SoTk == tknh.SoTk).SingleOrDefault();
            if (tk != null)
            {
                tk.TenNh = tknh.TenNh;
                tk.SoTk = tknh.SoTk;
                tk.TenDn = tknh.TenDn;
                tk.MatKhau = tknh.MatKhau;
                tk.SoDu = tknh.SoDu;
                tk.NgayDangKy = tknh.NgayDangKy;
                hhb.SaveChanges();
            }          
        }

        public bool IsEmpty(TaiKhoanNganHang tknh)
        {
            if (tknh.SoTk != "" && tknh.MatKhau != "" && tknh.TenDn != "" && tknh.SoDu.ToString() != "")
                return false;
            return true;
        }

        public TaiKhoanNganHang? LayTaiKhoanNganHang(string? GTSoTK, string? GTTenNH)
        {
              return hhb.TaiKhoanNganHangs.Where(tknh => tknh.TenNh == GTTenNH && tknh.SoTk == GTSoTK).SingleOrDefault(); 
        }

        public TaiKhoanNganHang? LayTaiKhoanNganHangBangTenDn(string? GTTenDn, string? GTTenNH)
        {
            return hhb.TaiKhoanNganHangs.Where(tknh => tknh.TenNh == GTTenNH && tknh.TenDn == GTTenDn).SingleOrDefault();
        }

        public void NapTien(TaiKhoanNganHang tkNap, LichSuGiaoDich gd)
        {
            decimal SoDu = ((gd.SoTien + tkNap.SoDu) ?? 0);
            TaiKhoanNganHang? tknh = hhb.TaiKhoanNganHangs.Where(tknh => tknh.TenNh == tkNap.TenNh && tknh.SoTk == tkNap.SoTk).SingleOrDefault();
            if (tknh != null)
            {
                tknh.SoDu = SoDu;
                hhb.SaveChanges();
            }           
        }
        public void RutTien(TaiKhoanNganHang tkRut, LichSuGiaoDich gd)
        {
            decimal SoDu = ((tkRut.SoDu - gd.SoTien) ?? 0);
            TaiKhoanNganHang? tknh = hhb.TaiKhoanNganHangs.Where(tknh => tknh.TenNh == tkRut.TenNh && tknh.SoTk == tkRut.SoTk).SingleOrDefault();
            if (tknh != null)
            {
                tknh.SoDu = SoDu;
                hhb.SaveChanges();
            }
        }
    }
}
