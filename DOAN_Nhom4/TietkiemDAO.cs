using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class TietkiemDAO
    {
        public TietkiemDAO() { }

        public bool ktSotien(int tiengoc, BigInteger sodu)
        {
            if (tiengoc <= sodu && tiengoc >= 100000 && tiengoc % 100000 == 0) return true;
            else return false;
        }
        public double TienLai(int tiengoc, double laisuat, int thoigian)
        {
            return tiengoc * laisuat * thoigian / 12;
        }

        public double TongTien(int tiengoc, double tienlai)
        {
            return tiengoc + tienlai;
        }
    }
}
