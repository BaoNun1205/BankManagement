using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class SoDienThoai
    {
        private string sdt;
        private BigInteger soDu;

        public string Sdt { get => sdt; set => sdt = value; }
        public BigInteger SoDu { get => soDu; set => soDu = value; }

        public SoDienThoai() { }

        public SoDienThoai(string sdt, BigInteger soDu)
        {
            this.sdt = sdt;
            this.soDu = soDu;
        }
    }
}
