using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    public class GiaoDich
    {
        private string loaiGD;
        private string nganHangGui;
        private string tenTKGui;
        private string soTKGui;
        private string nganHangNhan;
        private string tenTKNhan;
        private string soTKNhan;
        private decimal soTien;
        private string loiNhan;

        public string LoaiGD { get => loaiGD; set => loaiGD = value; }
        public string NganHangGui { get => nganHangGui; set => nganHangGui = value; }
        public string TenTKGui { get => tenTKGui; set => tenTKGui = value; }
        public string SoTKGui { get => soTKGui; set => soTKGui = value; }
        public string NganHangNhan { get => nganHangNhan; set => nganHangNhan = value; }
        public string TenTKNhan { get => tenTKNhan; set => tenTKNhan = value; }
        public string SoTKNhan { get => soTKNhan; set => soTKNhan = value; }
        public decimal SoTien { get => soTien; set => soTien = value; }
        public string LoiNhan { get => loiNhan; set => loiNhan = value; }

        public GiaoDich() { }

        public GiaoDich(string loaiGD, string nganHangGui, string tenTKGui, string soTKGui, string nganHangNhan, string tenTKNhan, string soTKNhan, decimal soTien, string loiNhan)
        {
            this.loaiGD = loaiGD;
            this.nganHangGui = nganHangGui;
            this.tenTKGui = tenTKGui;
            this.soTKGui = soTKGui;
            this.nganHangNhan = nganHangNhan;
            this.tenTKNhan = tenTKNhan;
            this.soTKNhan = soTKNhan;
            this.soTien = soTien;
            this.loiNhan = loiNhan;
        }

        public string ThongTinCoBan
        {
            get
            {
                return string.Format("{0} - {1} - {2}", NganHangNhan, TenTKNhan, SoTKNhan);
            }
        }
    }
}
