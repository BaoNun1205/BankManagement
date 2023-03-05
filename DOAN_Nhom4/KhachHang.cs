using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DOAN_Nhom4
{
    public class KhachHang
    {
        public string soTK;
        public string tenTK;
        public string tenDN;
        public string pass;
        public DateTime ngaySinh;
        public string cccd;
        public string sdt;
        public BigInteger soDu;

        public string SoTK { get => soTK; set => soTK = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string TenDN { get => tenDN; set => tenDN = value; }
        public string Pass { get => pass; set => pass = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public BigInteger SoDu { get => soDu; set => soDu = value; }

        public KhachHang() { }
        public KhachHang(string soTK, string tenTK, string tenDN, string pass, DateTime ngaySinh, string cccd, string sdt, BigInteger soDu)
        {
            this.soTK = soTK;
            this.tenTK = tenTK;
            this.tenDN = tenDN;
            this.pass = pass;
            this.ngaySinh = ngaySinh;
            this.cccd = cccd;
            this.sdt = sdt;
            this.soDu = soDu;
        }

        public KhachHang(string soTK)
        {
            this.soTK = soTK;
            this.TenTK = "";
            this.TenDN = "";
            this.pass = "";
            this.NgaySinh = DateTime.Now;
            this.cccd = "";
            this.sdt = "";
            this.soDu = 0;
        }

        public KhachHang(string tenDN, string pass)
        {
            this.tenDN = tenDN;
            this.pass = pass;
        }
    }
}
