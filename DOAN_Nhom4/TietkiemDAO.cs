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
        public TietkiemDAO() { }

        public TietKiem LayHangTKTK(string Cot, string giaTri)
        {
            TietKiem tktk = new TietKiem();
            string sql = string.Format("SELECT * FROM TaiKhoanTietKiem WHERE {0} = '{1}'", Cot, giaTri);
            tktk = data.LayHangTKTK(sql);
            return tktk;
        }

        public List<string> LayCotTKTK(string tenCot)
        {
            List<string> cot = new List<string>();
            string sql = string.Format("SELECT TenTKTK FROM TaiKhoanTietKiem");
            cot = data.LayCot(sql, tenCot);
            return cot;
        }
        public bool ktSotien(BigInteger tienGoc, BigInteger soDu)
        {
            if (tienGoc <= soDu && tienGoc >= 100000 && tienGoc % 100000 == 0) return true;
            else return false;
        }
        public BigInteger TienLai(BigInteger tienGoc, double laiSuat, int thoigian)
        {
            return (BigInteger)((decimal)tienGoc * (decimal)laiSuat * thoigian / 12);
        }

        public BigInteger TongTien(BigInteger tienGoc, BigInteger tienLai)
        {
            return tienGoc + tienLai;
        }

        public DataTable LayDanhSachTKTK()
        {
            string sqlStr = string.Format("SELECT *FROM TaiKhoanTietKiem");
            return data.LayDanhSach(sqlStr);
        }
        public void Them(TietKiem tkiem)
        {
            string sqlTkiem = string.Format("INSERT INTO TaiKhoanTietKiem(ID, NgayDangKy, TenTKTK, TienGoc, KiHan, LaiSuat, TienLai, TongTien) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", tkiem.Id, tkiem.NgayDangky, tkiem.TenTKTK, tkiem.TienGoc, tkiem.KiHan, tkiem.LaiSuat, tkiem.TienLai, tkiem.TongTien);
            data.xuLi(sqlTkiem);
        }

        public void Rut(TietKiem tkiem)
        {
            string sqlTkiem = string.Format("DELETE FROM TaiKhoanTietKiem WHERE ID ='{0}'", tkiem.Id);
            data.xuLi(sqlTkiem);
        }

        public DateTime NgayToiHan(DateTime ngaydangky, int kihan)
        {
            TimeSpan timeToAdd = TimeSpan.FromDays(kihan*30);
            DateTime ngaytoihan = ngaydangky.Add(timeToAdd);
            return ngaytoihan;
        }
    }
}
