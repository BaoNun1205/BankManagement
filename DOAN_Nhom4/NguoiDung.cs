using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DOAN_Nhom4
{
    public class NguoiDung
    {
        private string soTK;
        private string tenTK;
        private string tenDN;
        private string matKhau;
        private DateTime ngaySinh;
        private string cccd;
        private string sdt;
        private BigInteger soDu;

        public string SoTK { get => soTK; set => soTK = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string TenDN { get => tenDN; set => tenDN = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public BigInteger SoDu { get => soDu; set => soDu = value; }

        public NguoiDung() { }
        public NguoiDung(string soTK, string tenTK, string tenDN, string matKhau, DateTime ngaySinh, string cccd, string sdt, BigInteger soDu)
        {
            this.soTK = soTK;
            this.tenTK = tenTK;
            this.tenDN = tenDN;
            this.matKhau = matKhau;
            this.ngaySinh = ngaySinh;
            this.cccd = cccd;
            this.sdt = sdt;
            this.soDu = soDu;
        }

        public NguoiDung(string soTK)
        {
            this.soTK = soTK;
            this.TenTK = "";
            this.TenDN = "";
            this.matKhau = "";
            this.NgaySinh = DateTime.Now;
            this.cccd = "";
            this.sdt = "";
            this.soDu = 0;
        }

        public NguoiDung(string tenDN, string pass)
        {
            this.tenDN = tenDN;
            this.matKhau = pass;
        }
    }
}
