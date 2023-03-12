using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class TaiKhoangNganHang
    {
        private string tenNH;
        private string soTK;
        private string tenDN;
        private string matKhau;
        private BigInteger soDu;

        public string TenNH { get => tenNH; set => tenNH = value; }
        public string SoTK1 { get => soTK; set => soTK = value; }
        public string TenDN { get => tenDN; set => tenDN = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public BigInteger SoDu { get => soDu; set => soDu = value; }

        public TaiKhoangNganHang() { }
        public TaiKhoangNganHang(string tenNH, string soTK, string tenDN, string matKhau, BigInteger soDu)
        {
            this.tenNH = tenNH;
            this.soTK = soTK;
            this.tenDN= tenDN;
            this.matKhau = matKhau;
            this.soDu = soDu;
        }
    }
}
