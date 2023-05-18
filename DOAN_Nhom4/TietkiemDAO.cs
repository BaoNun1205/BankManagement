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
        DBConnection data = new DBConnection();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        public TietkiemDAO() { }

        public TietKiem LayThongTinSoTietKiem(string Cot, string giaTri)
        {
            TietKiem tktk = new TietKiem();
            string sql = string.Format("SELECT * FROM TaiKhoanTietKiem WHERE {0} = '{1}'", Cot, giaTri);
            tktk = data.LayThongTinSoTietKiem(sql);
            return tktk;
        }

        public List<string> LayCotTKTK(string tenCot, TaiKhoanNganHang tknh)
        {
            List<string> cot = new List<string>();
            string sql = string.Format("SELECT * FROM TaiKhoanTietKiem WHERE TenNH = '{0}' and SoTK = '{1}'", tknh.TenNH, tknh.SoTK);
            cot = data.LayCot(sql, tenCot);
            return cot;
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

        public void Them(TietKiem tkiem, TaiKhoanNganHang tknh)
        {      
            string sqlTkiem = string.Format("INSERT INTO TaiKhoanTietKiem(TenNH, SoTK, MaTietKiem, NgayDangKy, TenTKTK, LoaiSo, TienGoc, KiHan, LaiSuat, TienLai, TongTien) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", tknh.TenNH, tknh.SoTK, tkiem.MaTietKiem, tkiem.NgayDangky, tkiem.TenTKTK, tkiem.LoaiSo, tkiem.TienGoc, tkiem.KiHan, tkiem.LaiSuat, tkiem.TienLai, tkiem.TongTien);
            data.xuLi(sqlTkiem);
        }

        public void Rut(TietKiem tkiem)
        {
            string sqlTkiem = string.Format("DELETE FROM TaiKhoanTietKiem WHERE MaTietKiem ='{0}'", tkiem.MaTietKiem);
            data.xuLi(sqlTkiem);
        }

        public void Sua(TietKiem tkiem)
        {
            string sqlTkiem = string.Format("UPDATE TaiKhoanTietKiem SET NgayDangKy = '{0}', TienGoc = '{1}', TienLai = '{2}', TongTien = {3} WHERE MaTietKiem = '{4}'", tkiem.NgayDangky, tkiem.TienGoc, tkiem.TienLai, tkiem.TongTien, tkiem.MaTietKiem);
            data.xuLi(sqlTkiem);
        }


        public DateTime NgayToiHan(DateTime ngaydangky, int kihan)
        {
            TimeSpan timeToAdd = TimeSpan.FromDays(kihan*30);
            DateTime ngaytoihan = ngaydangky.Add(timeToAdd);
            return ngaytoihan;
        }

        public void KiemTraSoTietKiem(TaiKhoanNganHang tknh)
        {
            List<string> matks = new List<string>();
            List<TietKiem> tkiems = new List<TietKiem>();
            matks = LayCotTKTK("MaTietKiem", tknh);
            foreach (string matk in matks)
            {
                TietKiem tkiem = new TietKiem();
                tkiem = LayThongTinSoTietKiem("MaTietKiem", matk);
                tkiems.Add(tkiem);
            }
            
            foreach (TietKiem tk in tkiems)
            {
                if (NgayToiHan(tk.NgayDangky, tk.KiHan) <= DateTime.Now)
                {
                    if (tk.LoaiSo == 1)
                    {
                        tknh.SoDu = tknh.SoDu + tk.TongTien;
                        Rut(tk);
                        tknhDAO.SuaSoDu(tknh);
                    }
                    if (tk.LoaiSo == 2)
                    {
                        tknh.SoDu = tknh.SoDu + tk.TienLai;
                        tk.NgayDangky = DateTime.Now;
                        Sua(tk);
                        tknhDAO.SuaSoDu(tknh);
                    }
                    if (tk.LoaiSo == 3)
                    {
                        tk.TienGoc = tk.TongTien;
                        tk.NgayDangky = DateTime.Now;
                        tk.TienLai = TienLai(tk.TienGoc, tk.LaiSuat, tk.KiHan);
                        tk.TongTien = TongTien(tk.TienGoc, tk.TienLai);
                        Sua(tk);
                    }                        
                }
            }    
        }
    }
}
