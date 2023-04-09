using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class ThongTinTinDungDAO
    {
        DBConnection data = new DBConnection();
        public ThongTinTinDungDAO () { }
        public void Them(ThongTinTinDung ttTinDung)
        {
            string sql = string.Format("INSERT INTO TaiKhoanTinDung(SoTKTinDung, HoTen, CCCD, DiaChi, SDT, Email, NgheNghiep, ThuNhap, LoaiThe, NgayDaoHan, HanMuc, LaiSuat, SoTienDaSuDung, NgayMoThe, PhiTraCham, PhiThuongNien) " +
                                        "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10}, '{11}', {12}, '{13}', {14}, {15})",
                                        ttTinDung.SoTKTinDung, ttTinDung.HoTen, ttTinDung.Cccd, ttTinDung.DiaChi, ttTinDung.Sdt, ttTinDung.Email, ttTinDung.NgheNghiep, ttTinDung.ThuNhap,
                                        ttTinDung.LoaiThe, ttTinDung.NgayDaoHan, ttTinDung.HanMuc, ttTinDung.LaiSuat, ttTinDung.SoTienDaSuDung, ttTinDung.NgayMoThe, ttTinDung.PhiTraCham, ttTinDung.PhiThuongNien);
            data.xuLi(sql);
        }
        public void Update(ThongTinTinDung ttTinDung)
        {
            string sql = string.Format("UPDATE TaiKhoangTinDung SET NgayDaoHan = '{0}', SoTienDaSuDung = {1} Where SoTkTinDung = '{2}'", ttTinDung.NgayDaoHan, ttTinDung.SoTienDaSuDung, ttTinDung.SoTKTinDung);
            data.xuLi(sql);
        }
        public void Xoa(ThongTinTinDung ttTinDung)
        {
            string sql = string.Format("DELETE FROM TaiKhoanTinDung WHERE SoTKVay = '{0}'", ttTinDung.SoTKTinDung);
            data.xuLi(sql);
        }
        public ThongTinTinDung LayThongTinTinDung(string cot, string giaTri)
        {
            ThongTinTinDung ttTinDung = new ThongTinTinDung();
            string sql = string.Format("SELECT * FROM TaiKhoanTinDung WHERE {0} = '{1}'", cot, giaTri);
            ttTinDung = data.XuLiNgDungTinDung(sql);
            return ttTinDung;
        }

        public BigInteger PhiTraCham(BigInteger soTienDaSuDung, float laiSuat)
        {
            decimal laiSuatThang = (decimal)laiSuat;
            decimal tienLaiSuat = laiSuatThang / 100 / 12;
            BigInteger soTien = BigInteger.Multiply((BigInteger)tienLaiSuat, soTienDaSuDung);
            return soTien;
        }

        public bool IsNgayDenHan(DateTime ngayDenHan)
        {
            if (DateTime.Now > ngayDenHan)
            {
                return false;
            }
            return true;
        }
    }
}
