using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class Admin
    {
        private string soTK;
        private string tenTK;
        private string tenDN;
        private string pass;
        private string ngaySinh;
        private string cccd;
        private string sdt;
        public string SoTK
        {
            get { return soTK; }
            set { soTK = value; }
        }
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string TenDN
        {
            get { return tenDN; }
            set
            {
                tenDN = value;
            }
        }
        public string NgaySinh
        {
            get { return ngaySinh; }
            set
            {
                ngaySinh = value;
            }
        }
        public string Cccd
        {
            get { return cccd; }
            set
            {
                cccd = value;
            }
        }
        public string Sdt
        {
            get { return sdt; }
            set
            {
                sdt = value;
            }
        }
        public Admin() { }
        public Admin(string soTK, string tenTK, string tenDN, string pass, string ngaySinh, string cccd, string sdt)
        {
            this.soTK = soTK;
            this.tenTK = tenTK;
            this.tenDN = tenDN;
            this.pass = pass;
            this.ngaySinh = ngaySinh;
            this.cccd = cccd;
            this.sdt = sdt;
        }
    }
}
