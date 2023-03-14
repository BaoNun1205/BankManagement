using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    public class TaiKhoanNganHang
    {
        private string tenNH;
        private string soTK;
        private string tenDN;
        private string matKhau;
        private BigInteger soDu;

        public string TenNH { get => tenNH; set => tenNH = value; }
        public string SoTK { get => soTK; set => soTK = value; }
        public string TenDN { get => tenDN; set => tenDN = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public BigInteger SoDu { get => soDu; set => soDu = value; }

        public TaiKhoanNganHang() { }
        public TaiKhoanNganHang(string tenNH, string soTK, string tenDN, string matKhau, BigInteger soDu)
        {
            this.tenNH = tenNH;
            this.soTK = soTK;
            this.tenDN = tenDN;
            this.matKhau = matKhau;
            this.soDu = soDu;
        }
        public TaiKhoanNganHang(String soTK)
        {
            this.soTK = soTK;
        }
    }
}
