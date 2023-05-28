using DOAN_Nhom4.Entities;
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
        NganHangHhbContext hhb = new NganHangHhbContext();
        public ThongTinTinDungDAO () { }
        public void Them(TaiKhoanTinDung tttd)
        {
            hhb.TaiKhoanTinDungs.Add(tttd);
            hhb.SaveChanges();
        }
        public void Sua(TaiKhoanTinDung tttd)
        {
            TaiKhoanTinDung? tktd = hhb.TaiKhoanTinDungs.Where(tktd => tktd.SoTktinDung == tttd.SoTktinDung).FirstOrDefault();
            if (tktd != null)
            {
                tktd.SoTktinDung = tttd.SoTktinDung;
                tktd.HoTen = tttd.HoTen;
                tktd.Cccd = tttd.Cccd;
                tktd.DiaChi = tttd.DiaChi;
                tktd.Sdt = tttd.Sdt;
                tktd.Email = tttd.Email;
                tktd.NgheNghiep = tttd.NgheNghiep;
                tktd.ThuNhap = tttd.ThuNhap;
                tktd.LoaiThe = tttd.LoaiThe;
                tktd.HanThanhToan = tttd.HanThanhToan;
                tktd.NgaySaoKe = tttd.NgaySaoKe;
                tktd.HanMuc = tttd.HanMuc;
                tktd.LaiSuat = tttd.LaiSuat;
                tktd.SoTienDaSuDung = tttd.SoTienDaSuDung;
                tktd.SoTienSuDungSau = tttd.SoTienSuDungSau;
                tktd.NgayMoThe = tttd.NgayMoThe;
                tktd.PhiTraCham = tttd.PhiTraCham;
                tktd.PhiPhat = tttd.PhiPhat;
                hhb.SaveChanges();
            }            
        }
        public void Xoa(TaiKhoanTinDung tttd)
        {
            TaiKhoanTinDung? tktd = hhb.TaiKhoanTinDungs.Where(tktd => tktd.SoTktinDung == tttd.SoTktinDung).FirstOrDefault();
            if (tktd != null)
            {
                hhb.Remove(tktd);
                hhb.SaveChanges();
            }              
        }
        public TaiKhoanTinDung? LayThongTinTinDungBangCccd(string? giaTri)
        {
            return hhb.TaiKhoanTinDungs.Where(tktd => tktd.Cccd == giaTri).FirstOrDefault();
        }
        public TaiKhoanTinDung? LayThongTinTinDungBangStk(string? giaTri)
        {
            return hhb.TaiKhoanTinDungs.Where(tktd => tktd.SoTktinDung == giaTri).FirstOrDefault();
        }

        public decimal PhiTraCham(TaiKhoanTinDung tttd)
        {
            decimal tienLaiSuat = decimal.Parse(tttd.LaiSuat ?? "0") / 100 / 12;
            decimal tienDaSuDung = (tttd.SoTienDaSuDung ?? 0);
            return tienDaSuDung * tienLaiSuat;
        }

        public bool IsNgayDenHan(TaiKhoanTinDung tttd)
        {
            if (DateTime.Now > tttd.HanThanhToan)
            {
                return true;
            }
            return false;
        }

        public decimal PhiPhat(TaiKhoanTinDung tttd)
        {
            decimal tienPhat = (decimal)0.04;
            decimal tienDaSuDung = (tttd.SoTienDaSuDung ?? 0);
            return tienDaSuDung * tienPhat;
        }

        public void CapNhatTinDungHangThang(TaiKhoanTinDung tttd)
        {
            if (tttd.HanThanhToan.HasValue)
            {
                tttd.HanThanhToan = tttd.HanThanhToan.Value.AddMonths(1);
                tttd.NgaySaoKe = tttd.HanThanhToan.Value.Subtract(new TimeSpan(15, 0, 0, 0));
            }
            tttd.SoTienDaSuDung = tttd.SoTienSuDungSau;
            tttd.SoTienSuDungSau = 0;
            tttd.PhiTraCham = 0;
            tttd.PhiPhat = 0;
        }

        public void ThanhToanPhiTruocNgaySaoKe(TaiKhoanTinDung tttd, LichSuGiaoDich gd)
        {
            tttd.SoTienDaSuDung = tttd.SoTienDaSuDung + gd.SoTien;
            Sua(tttd);
        }
        public void ThanhToanPhiSauNgaySaoKe(TaiKhoanTinDung tttd, LichSuGiaoDich gd)
        {
            tttd.SoTienSuDungSau = tttd.SoTienSuDungSau + gd.SoTien;
            Sua(tttd);
        }

        public void ThanhToanPhi(TaiKhoanTinDung tttd, LichSuGiaoDich gd)
        {
            if (DateTime.Now > tttd.NgaySaoKe)
            {
                ThanhToanPhiSauNgaySaoKe(tttd, gd);
            }
            else
            {
                ThanhToanPhiTruocNgaySaoKe(tttd, gd);
            }
        }
    }
}
