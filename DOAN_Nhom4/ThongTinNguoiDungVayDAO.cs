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
        NganHangHhbContext hhb = new NganHangHhbContext();
        DBConnection data = new DBConnection();
        public ThongTinNguoiDungVayDAO() { }

        public void Them(KhachHangVay ttNgDung)
        {
            hhb.KhachHangVays.Add(ttNgDung);
            hhb.SaveChanges();
        }
        public void Sua(KhachHangVay ttNgDung)
        {
            KhachHangVay? tmp = hhb.KhachHangVays.Where(tmp => tmp.SoTkvay == ttNgDung.SoTkvay).FirstOrDefault();
            if (tmp != null)
            {
                tmp.SoTkvay = ttNgDung.SoTkvay;
                tmp.HoTen = ttNgDung.HoTen;
                tmp.Cccd = ttNgDung.Cccd;
                tmp.DiaChi = ttNgDung.DiaChi;
                tmp.Sdt = ttNgDung.Sdt;
                tmp.Email = ttNgDung.Email;
                tmp.NgheNghiep = ttNgDung.NgheNghiep;
                tmp.ThuNhap = ttNgDung.ThuNhap;
                tmp.Spvay = ttNgDung.Spvay;
                tmp.SoTienVay = ttNgDung.SoTienVay;
                tmp.ThoiGianVay = ttNgDung.ThoiGianVay;
                tmp.TaiSanTheChap = ttNgDung.TaiSanTheChap;
                tmp.GiaTriTaiSan = ttNgDung.GiaTriTaiSan;
                tmp.ChiNhanhVay = ttNgDung.ChiNhanhVay;
                tmp.NgayVay = ttNgDung.NgayVay;
                tmp.LaiSuat = ttNgDung.LaiSuat;
                tmp.SoTienHangThang = ttNgDung.SoTienHangThang;
                tmp.NgayDenHan = ttNgDung.NgayDenHan;
                tmp.TongSoTienPhaiTra = ttNgDung.TongSoTienPhaiTra;
                tmp.PhiTraCham = ttNgDung.PhiTraCham;
                hhb.SaveChanges();
            }    
        }
        public void Xoa(KhachHangVay ttNgDung)
        {
            KhachHangVay? tmp = hhb.KhachHangVays.Where(tmp => tmp.SoTkvay == ttNgDung.SoTkvay).FirstOrDefault();
            if (tmp != null)
            {
                hhb.Remove(tmp);
                hhb.SaveChanges();
            }
        }
        public KhachHangVay? TKValid(KhachHang ngdung)
        {
            return hhb.KhachHangVays.Where(tmp => tmp.SoTkvay == ngdung.SoTk).FirstOrDefault();
        }     
        public Decimal TienHangThang(KhachHangVay ttNgDung)
        {
            double soTienVay = double.Parse((ttNgDung.SoTienVay ?? 0).ToString());
            double laithang = double.Parse(ttNgDung.LaiSuat ?? "0") / 1200;
            double number = Math.Pow((1 + laithang), int.Parse((ttNgDung.ThoiGianVay ?? 0).ToString()));
            double tmp = (soTienVay * laithang * number) / (number - 1);
            decimal tienhangthang = new decimal(tmp);
            return tienhangthang;
        }
        public string TinhTien(KhachHangVay ttNgDung)
        {
            double laithang = double.Parse(ttNgDung.LaiSuat ?? "0") / 12;
            decimal tongsotien = TienHangThang(ttNgDung) * (ttNgDung.ThoiGianVay ?? 0);
            string kq = String.Format("{0} x ({1} x {2}% x (1 + {3}%)^{4}) / ((1 + {5}%)^{6} - 1) = {7}",
                ttNgDung.ThoiGianVay.ToString(), ttNgDung.SoTienVay.ToString(), laithang.ToString("0.000"), laithang.ToString("0.000"), ttNgDung.ThoiGianVay.ToString(), laithang.ToString("0.000"), ttNgDung.ThoiGianVay.ToString(), tongsotien.ToString("N0"));
            return kq;
        }
        public Decimal TongSoTien(KhachHangVay ttNgDung)
        {
            return TienHangThang(ttNgDung) * (ttNgDung.ThoiGianVay ?? 0);
        }
        public void CapNhatNgDungVay(KhachHangVay ttNgDung)
        {
            ttNgDung.SoTienHangThang = TienHangThang(ttNgDung);
            if (ttNgDung.NgayVay.HasValue)
            {
                ttNgDung.NgayDenHan = ttNgDung.NgayVay.Value.AddMonths(1);
            }
            ttNgDung.TongSoTienPhaiTra = TongSoTien(ttNgDung);
            ttNgDung.PhiTraCham = 0;
        }
        public void CapNhatTaiKhoanNganHang(TaiKhoanNganHang tknh, TaiKhoanNganHangDAO tknhDAO, KhachHangVay ttNgDung)
        {
            tknh.SoDu += ttNgDung.SoTienVay;
            tknhDAO.Sua(tknh);
        }
    }
}
