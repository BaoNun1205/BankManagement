using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    public class GiaoDichChuyenTien
    {
        private string tenTKGui;
        private string soTKGui;
        private string tenTKNhan;
        private string soTKNhan;
        private BigInteger soTien;
        private string nganHang;
        private string loiNhan;

        public string TenTKGui { get => tenTKGui; set => tenTKGui = value; }
        public string SoTKGui { get => soTKGui; set => soTKGui = value; }
        public string TenTKNhan { get => tenTKNhan; set => tenTKNhan = value; }
        public string SoTKNhan { get => soTKNhan; set => soTKNhan = value; }
        public BigInteger SoTien { get => soTien; set => soTien = value; }
        public string NganHang { get => nganHang; set => nganHang = value; }
        public string LoiNhan { get => loiNhan; set => loiNhan = value; }

        public GiaoDichChuyenTien() { }

        public GiaoDichChuyenTien(string tenTKGui, string soTKGui, string tenTKNhan, string soTKNhan, BigInteger soTien, string nganHang, string loiNhan)
        {
            this.tenTKGui = tenTKGui;
            this.soTKGui = soTKGui;
            this.tenTKNhan = tenTKNhan;
            this.soTKNhan = soTKNhan;
            this.soTien = soTien;
            this.nganHang = nganHang;
            this.loiNhan = loiNhan;
        }
    }
}
