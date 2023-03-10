using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    public class GiaoDichChuyenTien
    {
        private string tenNgnhan;
        private string stkNgnhan;
        private BigInteger sotienGiaodich;
        private string tenNganhang;
        private string loiNhan;

        public string TenNgnhan { get => tenNgnhan; set => tenNgnhan = value; }
        public string STKNgnhan { get => stkNgnhan; set => stkNgnhan = value; }
        public BigInteger SotienGiaodich { get => sotienGiaodich; set => sotienGiaodich = value; }
        public string TenNganhang { get => tenNganhang; set => tenNganhang = value; }
        public string LoiNhan { get => loiNhan; set => loiNhan = value; }

        public GiaoDichChuyenTien() { }

        public GiaoDichChuyenTien(string tenTK, string soTk, BigInteger soTien, string nganHang, string loiNhan)
        {
            this.tenNgnhan = tenTK;
            this.stkNgnhan = soTk;
            this.sotienGiaodich = soTien;
            this.tenNganhang = nganHang;
            this.loiNhan = loiNhan;
        }
    }
}
