using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    public class ThongTinTinDung
    {
        private string soTKTinDung;
        private string hoTen;
        private string cccd;
        private string diaChi;
        private string sdt;
        private string email;
        private string ngheNghiep;
        private string thuNhap;
        private string loaiThe;
        private DateTime hanThanhToan;
        private DateTime ngaySaoKe;
        private decimal hanMuc;
        private double laiSuat;
        private decimal soTienDaSuDung;
        private decimal soTienSuDungSau;
        private DateTime ngayMoThe;
        private decimal phiTraCham;
        private decimal phiPhat;

        public string SoTKTinDung { get => soTKTinDung; set => soTKTinDung = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string ThuNhap { get => thuNhap; set => thuNhap = value; }
        public string LoaiThe { get => loaiThe; set => loaiThe = value; }
        public DateTime HanThanhToan { get => hanThanhToan; set => hanThanhToan = value; }
        public DateTime NgaySaoKe { get => ngaySaoKe; set => ngaySaoKe = value; }
        public decimal HanMuc { get => hanMuc; set => hanMuc = value; }
        public double LaiSuat { get => laiSuat; set => laiSuat = value; }
        public decimal SoTienDaSuDung { get => soTienDaSuDung; set => soTienDaSuDung = value; }
        public decimal SoTienSuDungSau { get => soTienSuDungSau; set => soTienSuDungSau = value; }
        public DateTime NgayMoThe { get => ngayMoThe; set => ngayMoThe = value; }
        public decimal PhiTraCham { get => phiTraCham; set => phiTraCham = value; }
        public decimal PhiPhat { get => phiPhat; set => phiPhat = value; }
        public ThongTinTinDung() { }

        public ThongTinTinDung(string soTKTinDung, string hoTen, string cccd, string diaChi, string sdt, string email, string ngheNghiep, string thuNhap, string loaiThe, 
                                DateTime hanThanhToan, DateTime ngaySaoKe, decimal hanMuc, double laiSuat, decimal soTienDaSuDung, decimal soTienSuDungSau, DateTime ngayMoThe, decimal phiTraCham, decimal phiPhat)
        {
            this.soTKTinDung = soTKTinDung;
            this.hoTen = hoTen;
            this.cccd = cccd;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.email = email;
            this.ngheNghiep = ngheNghiep;
            this.thuNhap = thuNhap;
            this.loaiThe = loaiThe;
            this.hanThanhToan = hanThanhToan;
            this.ngaySaoKe = ngaySaoKe;
            this.hanMuc = hanMuc;
            this.laiSuat = laiSuat;
            this.soTienDaSuDung = soTienDaSuDung;
            this.soTienSuDungSau = soTienSuDungSau;
            this.ngayMoThe = ngayMoThe;
            this.phiTraCham = phiTraCham;
            this.phiPhat = phiPhat;
        }

        
    }
}
