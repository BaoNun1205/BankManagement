using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class KhachHang
    {
        private string soTK;
        private string tenTK;
        private string tenDN;
        private string pass;
        private string ngaySinh;
        private string cccd;
        private string sdt;
        private string soDu;

        public string SoTK { get => soTK; set => soTK = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string TenDN { get => tenDN; set => tenDN = value; }
        public string Pass { get => pass; set => pass = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string SoDu { get => soDu; set => soDu = value; }

        public KhachHang() { }
        public KhachHang(string soTK, string tenTK, string tenDN, string pass, string ngaySinh, string cccd, string sdt, string soDu)
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
            this.NgaySinh = "";
            this.cccd = "";
            this.sdt = "";
            this.soDu = "";
        }
    }
}
