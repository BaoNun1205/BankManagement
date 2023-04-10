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
        public void Them(ThongTinTinDung tttd)
        {
            string sql = string.Format("INSERT INTO TaiKhoanTinDung(SoTKTinDung, HoTen, CCCD, DiaChi, SDT, Email, NgheNghiep, ThuNhap, LoaiThe, NgayDaoHan, HanMuc, LaiSuat, SoTienDaSuDung, NgayMoThe, PhiTraCham, PhiThuongNien) " +
                                        "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10}, '{11}', {12}, '{13}', {14}, {15})",
                                        tttd.SoTKTinDung, tttd.HoTen, tttd.Cccd, tttd.DiaChi, tttd.Sdt, tttd.Email, tttd.NgheNghiep, tttd.ThuNhap,
                                        tttd.LoaiThe, tttd.NgayDaoHan, tttd.HanMuc, tttd.LaiSuat, tttd.SoTienDaSuDung, tttd.NgayMoThe, tttd.PhiTraCham, tttd.PhiThuongNien);
            data.xuLi(sql);
        }
        public void Update(ThongTinTinDung tttd)
        {
            string sql = string.Format("UPDATE TaiKhoangTinDung SET NgayDaoHan = '{0}', SoTienDaSuDung = {1} Where SoTkTinDung = '{2}'", tttd.NgayDaoHan, tttd.SoTienDaSuDung, tttd.SoTKTinDung);
            data.xuLi(sql);
        }
        public void Xoa(ThongTinTinDung tttd)
        {
            string sql = string.Format("DELETE FROM TaiKhoanTinDung WHERE SoTKVay = '{0}'", tttd.SoTKTinDung);
            data.xuLi(sql);
        }
        public ThongTinTinDung LayThongTinTinDung(string cot, string giaTri)
        {
            ThongTinTinDung ttTinDung = new ThongTinTinDung();
            string sql = string.Format("SELECT * FROM TaiKhoanTinDung WHERE {0} = '{1}'", cot, giaTri);
            ttTinDung = data.XuLiNgDungTinDung(sql);
            return ttTinDung;
        }

        public BigInteger LaiSuat(ThongTinTinDung tttd)
        {
            decimal tienLaiSuat = (decimal)tttd.LaiSuat / 100 / 12;
            decimal tienDaSuDung = (decimal)tttd.SoTienDaSuDung;
            return (BigInteger)(tienDaSuDung * tienLaiSuat);
        }

        public bool IsNgayDenHan(ThongTinTinDung tttd)
        {
            if (DateTime.Now > tttd.NgayDaoHan)
            {
                return true;
            }
            return false;
        }

        public BigInteger PhiTraCham(ThongTinTinDung tttd)
        {
            decimal tienPhat = (decimal)0.04;
            decimal tienDaSuDung = (decimal)tttd.SoTienDaSuDung;
            return (BigInteger)(tienDaSuDung * tienPhat);
        }
    }
}
