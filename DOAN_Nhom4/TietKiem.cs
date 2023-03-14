using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class TietKiem
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

        public bool ktSotien(int tiengoc, int sodu)
        {
            if (tiengoc >= 100000 && tiengoc % 100000 == 0) return true;
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
