using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    public class TietKiem
    {
        private int maTietKiem;
        private DateTime ngayDangky;
        private string tenTKTK;
        private int loaiSo;
        private decimal tienGoc;
        private int kiHan;
        private double laiSuat;
        private decimal tienLai;
        private decimal tongTien;

        public TietKiem() { }

        public TietKiem(int maTietKiem, DateTime ngayDangky, string tenTKTK, int loaiSo, decimal tienGoc, int kiHan, double laiSuat, decimal tienLai, decimal tongTien)
        {
            this.maTietKiem = maTietKiem;
            this.ngayDangky= ngayDangky;
            this.tenTKTK = tenTKTK;
            this.loaiSo = loaiSo;
            this.tienGoc = tienGoc;
            this.kiHan = kiHan;
            this.laiSuat = laiSuat;
            this.tienLai = tienLai;
            this.tongTien = tongTien;
        }

        public int MaTietKiem { get => maTietKiem; set => maTietKiem = value; }
        public DateTime NgayDangky { get => ngayDangky; set => ngayDangky = value; }
        public string TenTKTK { get => tenTKTK; set => tenTKTK = value; }
        public int LoaiSo { get => loaiSo; set => loaiSo = value; }
        public decimal TienGoc { get => tienGoc; set => tienGoc = value; }
        public int KiHan { get => kiHan; set => kiHan = value; }
        public double LaiSuat { get => laiSuat; set => laiSuat = value; }
        public decimal TienLai { get => tienLai; set => tienLai = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
    }
}
