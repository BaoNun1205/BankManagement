using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class ThongTinNguoiDungVayDAO
    {
        DBConnection data = new DBConnection();
        public ThongTinNguoiDungVayDAO() { }

        public void Them(ThongTinNguoiDungVay ttNgDung)
        {
            string sql = string.Format("INSERT INTO KhachHangVay(SoTKVay, DanhXung, HoTen, CCCD, DiaChi, SDT, Email, NgheNghiep, ThuNhap, SPVay, SoTienVay, ThoiGianVay, ChiNhanhVay, NgayVay) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10}, {11}, '{12}', '{13}')", ttNgDung.SoTKVay, ttNgDung.DanhXung, ttNgDung.HoTen, ttNgDung.Cccd, ttNgDung.DiaChi, ttNgDung.Sdt, ttNgDung.Email, ttNgDung.NgheNghiep, ttNgDung.ThuNhap, ttNgDung.SpVay,ttNgDung.SoTienVay, ttNgDung.ThoiGianVay, ttNgDung.ChiNhanhVay, ttNgDung.NgayVay);
            data.xuLi(sql);
        }
        public ThongTinNguoiDungVay TKValid(string SoTKVay)
        {
            ThongTinNguoiDungVay ttNgDung = new ThongTinNguoiDungVay();
            string sql = string.Format("SELECT * FROM KhachHangVay WHERE SoTKVay = '{0}'", SoTKVay);
            ttNgDung = data.XuLiNgDungVay(sql);
            return ttNgDung;
        }
    }
}
