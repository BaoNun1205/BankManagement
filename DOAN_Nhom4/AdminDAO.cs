using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class AdminDAO
    {
        DBConnection data = new DBConnection();
        public NguoiDung LayKhachHang(string Cot, string giaTri)
        {
            NguoiDung khachHang = new NguoiDung();
            string sql = string.Format("SELECT * FROM KhachHang WHERE {0} = '{1}'", Cot, giaTri);
            khachHang = data.Xuli(sql);
            return khachHang;
        }
    }
}
