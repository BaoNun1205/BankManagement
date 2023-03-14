using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    public class TietKiem
    {
        private int tienGoc;
        private int kiHan;
        private double laiSuat;

        public TietKiem() { }
        public TietKiem(int tienGoc, int kiHan, double laiSuat)
        {
            this.tienGoc = tienGoc;
            this.kiHan = kiHan;
            this.laiSuat = laiSuat;
        }

        public int TienGoc { get => tienGoc; set => tienGoc = value; }
        public int KiHan { get => kiHan; set => kiHan = value; }
        public double LaiSuat { get => laiSuat; set => laiSuat = value; }
    }
}
