using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    public class ThongTinNguoiDungVay
    {
        private string tenNH;
        private string loaiKhoanVay;
        private string soTKVay;
        private string danhXung;
        private string hoTen;
        private string cccd;
        private string diaChi;
        private string sdt;
        private string email;
        private string ngheNghiep;
        private string thuNhap;
        private string spVay;
        private decimal soTienVay;
        private int thoiGianVay;
        private string taiSan;
        private decimal giaTriTaiSan;
        private string chiNhanhVay;
        private DateTime ngayVay;
        private double lai;
        private decimal soTienHangThang;
        private DateTime ngayDenHan;
        private decimal tongSoTienPhaiTra;
        private decimal phiTraCham;
        
        public string TenNH { get =>  tenNH;  set => tenNH = value;  }
        public string LoaiKhoanVay { get => loaiKhoanVay; set => loaiKhoanVay = value; }
        public string SoTKVay { get => soTKVay; set => soTKVay = value; }
        public string DanhXung { get => danhXung; set => danhXung = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string ThuNhap { get => thuNhap; set => thuNhap = value; }
        public string SpVay { get => spVay; set => spVay = value; }
        public decimal SoTienVay { get => soTienVay; set => soTienVay = value; }
        public int ThoiGianVay { get => thoiGianVay; set => thoiGianVay = value; }
        public string TaiSan { get => taiSan; set => taiSan = value; }
        public decimal GiaTriTaiSan { get => giaTriTaiSan; set => giaTriTaiSan = value; }
        public string ChiNhanhVay { get => chiNhanhVay; set => chiNhanhVay = value; }
        public DateTime NgayVay { get => ngayVay; set => ngayVay = value; }
        public double Lai { get => lai; set => lai = value; }
        public decimal SoTienHangThang { get => soTienHangThang; set => soTienHangThang = value; }
        public DateTime NgayDenHan { get => ngayDenHan; set => ngayDenHan = value; }
        public decimal TongSoTienPhaiTra { get => tongSoTienPhaiTra; set => tongSoTienPhaiTra = value; }
        public decimal PhiTraCham { get => phiTraCham; set => phiTraCham = value; }

        public ThongTinNguoiDungVay() { }
        public ThongTinNguoiDungVay(string tenNH, string loaiKhoanVay, string soTKVay, string danhXung, string hoTen, string cccd, string diaChi, string sdt, string email, string ngheNghiep, string thuNhap, string spVay, decimal soTienVay, int thoiGianVay,string taiSan, decimal giaTriTaiSan, string chiNhanhVay, DateTime ngayVay)
        {
            this.tenNH = tenNH;
            this.loaiKhoanVay = loaiKhoanVay;
            this.soTKVay = soTKVay;
            this.danhXung = danhXung;
            this.hoTen = hoTen;
            this.cccd = cccd;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.email = email;
            this.ngheNghiep = ngheNghiep;
            this.thuNhap = thuNhap;
            this.spVay = spVay;
            this.soTienVay = soTienVay;
            this.thoiGianVay = thoiGianVay;
            this.taiSan = taiSan;
            this.giaTriTaiSan = giaTriTaiSan;
            this.chiNhanhVay = chiNhanhVay;
            this.ngayVay = ngayVay;
        }
    }
}
