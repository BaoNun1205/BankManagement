using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
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
            string sql = string.Format("INSERT INTO hr.KhachHangTungVay(DanhXung, HoTen, CCCD, DiaChi, SDT, Email, NgheNghiep, ThuNhap, SPVay, SoTienVay, ThoiGianVay, ChiNhanhVay, NgayVay, LaiSuat, SoTienHangThang, NgayDenHan, TongSoTienPhaiTra, PhiTraCham) OUTPUT INSERTED.SoTKVay VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, {10}, '{11}', '{12}', '{13}', {14}, '{15}', {16}, {17})", ttNgDung.DanhXung, ttNgDung.HoTen, ttNgDung.Cccd, ttNgDung.DiaChi, ttNgDung.Sdt, ttNgDung.Email, ttNgDung.NgheNghiep, ttNgDung.ThuNhap, ttNgDung.SpVay, ttNgDung.SoTienVay, ttNgDung.ThoiGianVay, ttNgDung.ChiNhanhVay, ttNgDung.NgayVay, ttNgDung.Lai.ToString(), ttNgDung.SoTienHangThang, ttNgDung.NgayDenHan, ttNgDung.TongSoTienPhaiTra, ttNgDung.PhiTraCham);
            data.xuLi(sql);
        }
        public void Xoa(int x)
        {
            string sql = string.Format("DELETE FROM hr.KhachHangTungVay WHERE SoTKVay = {0}", x);
            data.xuLi(sql);
        }
        public DataTable HienThi()
        {
            string sql = string.Format("SELECT SoTKVay, DanhXung, HoTen, CCCD, DiaChi, SDT, Email, NgheNghiep, ThuNhap, SPVay, SoTienVay, ThoiGianVay, ChiNhanhVay, NgayVay, LaiSuat, TongSoTienPhaiTra FROM hr.KhachHangTungVay");
            return data.LayDanhSach(sql);
        }
        public ThongTinNguoiDungVay TKValid(int SoTKVay)
        {
            ThongTinNguoiDungVay ttNgDung = new ThongTinNguoiDungVay();
            string sql = string.Format("SELECT * FROM hr.KhachHangTungVay WHERE SoTKVay = {0}", SoTKVay);
            ttNgDung = data.XuLiNgDungVay(sql);
            return ttNgDung;
        }
    }
}
