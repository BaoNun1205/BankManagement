using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class QLThongTinVayDAO
    {
        DBConnection data = new DBConnection();
        public QLThongTinVayDAO() { }

        public void Them(ThongTinNguoiDungVay ttNgDung)
        {
            string sql = string.Format("INSERT INTO QuanLyKhachHangVay(SoTT, DanhXung, HoTen, CCCD, DiaChi, SDT, Email, NgheNghiep, ThuNhap, SPVay, SoTienVay, ThoiGianVay, ChiNhanhVay, NgayVay, LaiSuat, SoTienHangThang, NgayDenHan, TongSoTienPhaiTra, PhiTraCham) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10}, {11}, '{12}', '{13}', '{14}', {15}, '{16}', {17}, {18})", ttNgDung.SoTKVay, ttNgDung.DanhXung, ttNgDung.HoTen, ttNgDung.Cccd, ttNgDung.DiaChi, ttNgDung.Sdt, ttNgDung.Email, ttNgDung.NgheNghiep, ttNgDung.ThuNhap, ttNgDung.SpVay, ttNgDung.SoTienVay, ttNgDung.ThoiGianVay, ttNgDung.ChiNhanhVay, ttNgDung.NgayVay, ttNgDung.Lai.ToString(), ttNgDung.SoTienHangThang, ttNgDung.NgayDenHan, ttNgDung.TongSoTienPhaiTra, ttNgDung.PhiTraCham);
            data.xuLi(sql);
        }
        public void Xoa(ThongTinNguoiDungVay ttNgDung)
        {
            string sql = string.Format("DELETE FROM QuanLyKhachHangVay WHERE SoTKVay = '{0}'", ttNgDung.SoTKVay);
            data.xuLi(sql);
        }
    }
}
