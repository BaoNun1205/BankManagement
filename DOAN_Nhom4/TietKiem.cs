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
        private int id;
        private string tenTKTK;
        private BigInteger tienGoc;
        private int kiHan;
        private double laiSuat;
        private BigInteger tienLai;
        private BigInteger tongTien;

        public TietKiem() { }

        public TietKiem(int id, string tenTKTK, BigInteger tienGoc, int kiHan, double laiSuat, BigInteger tienLai, BigInteger tongTien)
        {
            this.id = id;
            this.tenTKTK = tenTKTK;
            this.tienGoc = tienGoc;
            this.kiHan = kiHan;
            this.laiSuat = laiSuat;
            this.tienLai = tienLai;
            this.tongTien = tongTien;
        }

        public int Id { get => id; set => id = value; }
        public string TenTKTK { get => tenTKTK; set => tenTKTK = value; }
        public BigInteger TienGoc { get => tienGoc; set => tienGoc = value; }
        public int KiHan { get => kiHan; set => kiHan = value; }
        public double LaiSuat { get => laiSuat; set => laiSuat = value; }
        public BigInteger TienLai { get => tienLai; set => tienLai = value; }
        public BigInteger TongTien { get => tongTien; set => tongTien = value; }
        
    }
}
