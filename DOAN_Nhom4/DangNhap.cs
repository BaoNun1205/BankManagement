using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class DangNhap
    {
        private string tenDN;
        private string matKhau;

        public string TenDN { get => tenDN; set => tenDN = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

        public DangNhap() { }

        public DangNhap(string tenDN, string pass)
        {
            this.tenDN = tenDN;
            this.matKhau = pass;
        }
    }
}
