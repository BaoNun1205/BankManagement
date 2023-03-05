using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class DangNhap
    {
        private string tenDN;
        private string pass;

        public string TenDN { get => tenDN; set => tenDN = value; }
        public string Pass { get => pass; set => pass = value; }

        public DangNhap() { }

        public DangNhap(string tenDN, string pass)
        {
            this.tenDN = tenDN;
            this.pass = pass;
        }
    }
}
