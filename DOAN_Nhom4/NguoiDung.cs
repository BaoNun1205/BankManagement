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
        public string soTK;
        public string tenTK;
        public DateTime ngaySinh;
        public string cccd;
        public string sdt;

        public string SoTK { get => soTK; set => soTK = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public NguoiDung() { }
        public NguoiDung(string soTK, string tenTK, string tenDN, string pass, DateTime ngaySinh, string cccd, string sdt, BigInteger soDu)
        {
            this.soTK = soTK;
            this.tenTK = tenTK;
            this.ngaySinh = ngaySinh;
            this.cccd = cccd;
            this.sdt = sdt;
        }

        public NguoiDung(string soTK)
        {
            this.soTK = soTK;
            this.TenTK = "";
            this.NgaySinh = DateTime.Now;
            this.cccd = "";
            this.sdt = "";
        }
    }
}
