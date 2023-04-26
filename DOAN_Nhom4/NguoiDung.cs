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
        public string tenNH;
        public string soTK;
        public string tenTK;
        public DateTime ngaySinh;
        public string cccd;
        public string email;
        public string sdt;

        public string TenNH { get => tenNH; set => tenNH = value; }
        public string SoTK { get => soTK; set => soTK = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public NguoiDung() { }
        public NguoiDung(string tenNH, string soTK, string tenTK, DateTime ngaySinh, string cccd, string email, string sdt)
        {
            this.tenNH = tenNH;
            this.soTK = soTK;
            this.tenTK = tenTK;
            this.ngaySinh = ngaySinh;
            this.cccd = cccd;
            this.email = email;
            this.sdt = sdt;
        }

        public NguoiDung(string soTK)
        {
            this.tenNH = "";
            this.soTK = soTK;
            this.TenTK = "";
            this.NgaySinh = DateTime.Now;
            this.cccd = "";
            this.email = "";
            this.sdt = "";
        }

        public string ThongTinCoBan
        {
            get
            {
                return string.Format("{0} - {1} - {2}", TenNH, TenTK, SoTK);
            }
        }
    }
}
