using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class KHNoXau
    {
        private string soTK;
        private string tenTK;
        private string cccd;
        private DateTime ngayNo;
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
        public string Cccd
        {
            get { return cccd; }
            set { cccd = value; }
        }
        public DateTime NgayNo
        {
            get { return ngayNo; }
            set
            {
                ngayNo = value;
            }
        }
        public KHNoXau() { }
        public KHNoXau(string soTK, string tenTK, string cccd, DateTime ngayNo)
        {
            SoTK = soTK;
            TenTK = tenTK;
            Cccd = cccd;
            NgayNo = ngayNo;
        }
    }
}
