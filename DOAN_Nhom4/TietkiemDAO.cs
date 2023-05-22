using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class TietkiemDAO
    {
        NganHangHhbContext hhb = new NganHangHhbContext();
        DBConnection data = new DBConnection();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        public TietkiemDAO() { }

        public TaiKhoanTietKiem? LayThongTinSoTietKiem(string tenNH, string soTK, int maTietKiem)
        {
            return hhb.TaiKhoanTietKiems.Where(tkiem => tkiem.TenNh == tenNH && tkiem.SoTk == soTK && tkiem.MaTietKiem == maTietKiem).SingleOrDefault();
        }

        public bool ktSotien(decimal tienGoc, decimal soDu)
        {
            if (tienGoc <= soDu && tienGoc >= 100000 && tienGoc % 100000 == 0) return true;
            else return false;
        }
        public decimal TienLai(decimal tienGoc, double laiSuat, int thoigian)
        {
            return tienGoc * (decimal)laiSuat * thoigian / 12;
        }

        public decimal TongTien(decimal tienGoc, decimal tienLai)
        {
            return tienGoc + tienLai;
        }

        public void Them(TaiKhoanTietKiem tkiem)
        {      
            hhb.Add(tkiem);
            hhb.SaveChanges();
        }

        public void Rut(TaiKhoanTietKiem tkiem)
        {
            hhb.Remove(tkiem);
            hhb.SaveChanges();  
        }

        public void Sua(TaiKhoanTietKiem tkiem)
        {
            TaiKhoanTietKiem? t = hhb.TaiKhoanTietKiems.Where(tkiem => tkiem.TenNh == tkiem.TenNh && tkiem.SoTk == tkiem.SoTk
                                                                && tkiem.MaTietKiem == tkiem.MaTietKiem).SingleOrDefault();
            if (t != null)
            {
                tkiem.TenNh = t.TenNh;
                tkiem.SoTk = t.SoTk;
                tkiem.MaTietKiem = t.MaTietKiem;
                tkiem.NgayDangKy = t.NgayDangKy;
                tkiem.TenTktk = t.TenTktk;
                tkiem.LoaiSo = t.LoaiSo;
                tkiem.TienGoc = t.TienGoc;
                tkiem.KiHan = t.KiHan;
                tkiem.LaiSuat = t.LaiSuat;
                tkiem.TienLai = t.TienLai;
                tkiem.TongTien = t.TongTien;
                hhb.SaveChanges();
            }
        }

        public DataTable DanhSachTietKiem(TaiKhoanNganHang tknh)
        {
            string sqlStr = string.Format("SELECT MaTietKiem, NgayDangKy, TenTKTK, LoaiSo, TienGoc, KiHan, LaiSuat, TienLai, TongTien FROM TaiKhoanTietKiem WHERE TenNH = '{0}' and SoTK = '{1}'", tknh.TenNh, tknh.SoTk);
            return data.LayDanhSach(sqlStr);
        }

        public DateTime NgayToiHan(DateTime ngaydangky, int? kihan)
        {
            int kiHan = kihan ?? 0;
            TimeSpan timeToAdd = TimeSpan.FromDays(kiHan*30);
            DateTime ngaytoihan = ngaydangky.Add(timeToAdd);
            return ngaytoihan;
        }

        public void KiemTraSoTietKiem(TaiKhoanNganHang tknh)
        {
            List<int> matks = new List<int>();
            List<TaiKhoanTietKiem> tkiems = new List<TaiKhoanTietKiem>();
            tkiems = hhb.TaiKhoanTietKiems.Select(t => new TaiKhoanTietKiem
            {
                TenNh = t.TenNh,
                SoTk = t.SoTk,
                MaTietKiem = t.MaTietKiem,
                NgayDangKy = t.NgayDangKy,
                TenTktk = t.TenTktk,
                LoaiSo = t.LoaiSo,
                TienGoc = t.TienGoc,
                KiHan = t.KiHan,
                LaiSuat = t.LaiSuat,
                TienLai= t.TienLai,
                TongTien = t.TongTien
            }).ToList();
            
            foreach (TaiKhoanTietKiem tkiem in tkiems)
            {
                if (NgayToiHan(tkiem.NgayDangKy, tkiem.KiHan) <= DateTime.Now)
                {
                    if (tkiem.LoaiSo == 1)
                    {
                        tknh.SoDu = tknh.SoDu + tkiem.TongTien;
                        Rut(tkiem);
                        tknhDAO.Sua(tknh);
                    }
                    if (tkiem.LoaiSo == 2)
                    {
                        tknh.SoDu = tknh.SoDu + tkiem.TienLai;
                        tkiem.NgayDangKy = DateTime.Now;
                        Sua(tkiem);
                        tknhDAO.Sua(tknh);
                    }
                    if (tkiem.LoaiSo == 3)
                    {
                        tkiem.TienGoc = tkiem.TongTien;
                        tkiem.NgayDangKy = DateTime.Now;
                        tkiem.TienLai = TienLai(tkiem.TienGoc ?? 0, tkiem.LaiSuat ?? 0, tkiem.KiHan ?? 0);
                        tkiem.TongTien = TongTien(tkiem.TienGoc ?? 0, tkiem.TienLai ?? 0);
                        Sua(tkiem);
                    }                        
                }
            }    
        }
    }
}
