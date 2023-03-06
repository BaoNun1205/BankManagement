using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    public class ChuyenTien
    {
        private string tenTK;
        private string soTk;
        private BigInteger soTien;
        private string nganHang;
        private string loiNhan;

        public string TenTK { get => tenTK; set => tenTK = value; }
        public string SoTk { get => soTk; set => soTk = value; }
        public BigInteger SoTien { get => soTien; set => soTien = value; }
        public string NganHang { get => nganHang; set => nganHang = value; }
        public string LoiNhan { get => loiNhan; set => loiNhan = value; }

        public ChuyenTien() { }

        public ChuyenTien(string tenTK, string soTk, BigInteger soTien, string nganHang, string loiNhan)
        {
            this.tenTK = tenTK;
            this.soTk = soTk;
            this.soTien = soTien;
            this.nganHang = nganHang;
            this.loiNhan = loiNhan;
        }
    }
}
