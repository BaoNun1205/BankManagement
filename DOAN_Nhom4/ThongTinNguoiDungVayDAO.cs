using DOAN_Nhom4.Entities;
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
    internal class ThongTinNguoiDungVayDAO
    {
        DBConnection data = new DBConnection();
        public ThongTinNguoiDungVayDAO() { }

        public void Them(ThongTinNguoiDungVay ttNgDung)
        {
            string sql = string.Format("INSERT INTO KhachHangVay(TenNH, LoaiKhoanVay, SoTKVay, DanhXung, HoTen, CCCD, DiaChi, SDT, Email, NgheNghiep, ThuNhap, SPVay, SoTienVay, ThoiGianVay,TaiSanTheChap, GiaTriTaiSan, ChiNhanhVay, NgayVay, LaiSuat, SoTienHangThang, NgayDenHan, TongSoTienPhaiTra, PhiTraCham) VALUES('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', {12}, {13}, '{14}', {15}, '{16}', '{17}', '{18}', {19}, '{20}', {21}, {22})", ttNgDung.TenNH,ttNgDung.LoaiKhoanVay, ttNgDung.SoTKVay,ttNgDung.DanhXung, ttNgDung.HoTen, ttNgDung.Cccd, ttNgDung.DiaChi, ttNgDung.Sdt, ttNgDung.Email,ttNgDung.NgheNghiep, ttNgDung.ThuNhap, ttNgDung.SpVay,ttNgDung.SoTienVay, ttNgDung.ThoiGianVay,ttNgDung.TaiSan, ttNgDung.GiaTriTaiSan, ttNgDung.ChiNhanhVay, ttNgDung.NgayVay, ttNgDung.Lai.ToString(), ttNgDung.SoTienHangThang, ttNgDung.NgayDenHan, ttNgDung.TongSoTienPhaiTra, ttNgDung.PhiTraCham);
            data.xuLi(sql);
        }
        public void Sua(ThongTinNguoiDungVay ttNgDung)
        {
            string sql = string.Format("UPDATE KhachHangVay SET TongSoTienPhaiTra = {0}, ThoiGianVay = {1}, SoTienVay = {2}, PhiTraCham = {3}, NgayDenHan = '{4}' WHERE SoTKVay = '{5}'", ttNgDung.TongSoTienPhaiTra, ttNgDung.ThoiGianVay, ttNgDung.SoTienVay, ttNgDung.PhiTraCham, ttNgDung.NgayDenHan, ttNgDung.SoTKVay);
            data.xuLi(sql);
        }
        public void Xoa(ThongTinNguoiDungVay ttNgDung)
        {
            string sql = string.Format("DELETE FROM KhachHangVay WHERE SoTKVay = '{0}'", ttNgDung.SoTKVay);
            data.xuLi(sql);
        }
        public ThongTinNguoiDungVay TKValid(string SoTKVay)
        {
            ThongTinNguoiDungVay ttNgDung = new ThongTinNguoiDungVay();
            string sql = string.Format("SELECT * FROM KhachHangVay WHERE SoTKVay = '{0}'", SoTKVay);
            ttNgDung = data.XuLiNgDungVay(sql);
            return ttNgDung;
        }
        public DataTable HienThi()
        {
            string sql = string.Format("SELECT LoaiKhoanVay, SoTKVay, DanhXung, HoTen, CCCD, DiaChi, SDT, Email, NgheNghiep, ThuNhap, SPVay, SoTienVay, ThoiGianVay, ChiNhanhVay, NgayVay, LaiSuat, TongSoTienPhaiTra FROM KhachHangVay");
            return data.LayDanhSach(sql);
        }        
        public Decimal TienHangThang(ThongTinNguoiDungVay ttNgDung)
        {
            double soTienVay = double.Parse(ttNgDung.SoTienVay.ToString());
            double laithang = ttNgDung.Lai / 1200;
            double number = Math.Pow((1 + laithang), int.Parse(ttNgDung.ThoiGianVay.ToString()));
            double tmp = (soTienVay * laithang * number) / (number - 1);
            decimal tienhangthang = new decimal(tmp);
            return tienhangthang;
        }
        public string TinhTien(ThongTinNguoiDungVay ttNgDung)
        {
            double laithang = ttNgDung.Lai / 12;
            decimal tongsotien = TienHangThang(ttNgDung) * ttNgDung.ThoiGianVay;
            string kq = String.Format("{0} x ({1} x {2}% x (1 + {3}%)^{4}) / ((1 + {5}%)^{6} - 1) = {7}",
                ttNgDung.ThoiGianVay.ToString(), ttNgDung.SoTienVay.ToString("N0"), laithang.ToString("0.000"), laithang.ToString("0.000"), ttNgDung.ThoiGianVay.ToString(), laithang.ToString("0.000"), ttNgDung.ThoiGianVay.ToString(), tongsotien.ToString("N0"));
            return kq;
        }
        public Decimal TongSoTien(ThongTinNguoiDungVay ttNgDung)
        {
            return TienHangThang(ttNgDung) * ttNgDung.ThoiGianVay;
        }
        public void CapNhatNgDungVay(ThongTinNguoiDungVay ttNgDung)
        {
            ttNgDung.SoTienHangThang = TienHangThang(ttNgDung);
            ttNgDung.NgayDenHan = ttNgDung.NgayVay.AddMonths(1);
            ttNgDung.TongSoTienPhaiTra = TongSoTien(ttNgDung);
            ttNgDung.PhiTraCham = 0;
        }
        public void CapNhatTaiKhoanNganHang(TaiKhoanNganHang tknh, TaiKhoanNganHangDAO tknhDAO, ThongTinNguoiDungVay ttNgDung)
        {
            tknh.SoDu += ttNgDung.SoTienVay;
            tknhDAO.Sua(tknh);
        }
    }
}
