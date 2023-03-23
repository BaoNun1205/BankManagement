using System;
using System.Collections.Generic;
using System.Data;
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

        public bool ktSotien(int tiengoc, BigInteger sodu)
        {
            if (tiengoc <= sodu && tiengoc >= 100000 && tiengoc % 100000 == 0) return true;
            else return false;
        }
        public double TienLai(int tiengoc, double laisuat, int thoigian)
        {
            return tiengoc * laisuat * thoigian / 12;
        }

        public double TongTien(int tiengoc, double tienlai)
        {
            return tiengoc + tienlai;
        }

        public DataTable LayDanhSachTKTK()
        {
            string sqlStr = string.Format("SELECT *FROM TaiKhoanTietKiem");
            return data.LayDanhSach(sqlStr);
        }
        public void Them(TietKiem tkiem)
        {
            string sqlTkiem = string.Format("INSERT INTO TaiKhoanTietKiem(ID, TenTKTK, TienGoc, KiHan, LaiSuat, TienLai, TongTien) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", tkiem.Id, tkiem.TenTKTK, tkiem.TienGoc, tkiem.KiHan, tkiem.LaiSuat, tkiem.TienLai, tkiem.TongTien);
            data.xuLi(sqlTkiem);
        }

        public void Xoa(TietKiem tkiem)
        {
            string sqlTkiem = string.Format("DELETE FROM TaiKhoanTietKiem WHERE ID ='{0}'", tkiem.Id);
            data.xuLi(sqlTkiem);
        }
    }
}
