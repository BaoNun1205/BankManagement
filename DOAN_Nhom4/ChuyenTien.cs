using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class ChuyenTien
    {
        private string soTk;
        private BigInteger soTien;
        private string loiNhan;

        public string SoTk { get => soTk; set => soTk = value; }
        public BigInteger SoTien { get => soTien; set => soTien = value; }
        public string LoiNhan { get => loiNhan; set => loiNhan = value; }

        public ChuyenTien() { }

        public ChuyenTien(string soTk, BigInteger soTien, string loiNhan)
        {
            this.soTk = soTk;
            this.soTien = soTien;
            this.loiNhan = loiNhan;
        }
    }
}
