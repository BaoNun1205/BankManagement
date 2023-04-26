using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class ChuyenTienDAO
    {
        DBConnection data = new DBConnection();

        public ChuyenTienDAO() { }

        public NguoiDung LayThongTinKhachHang(string Cot, string giaTri)
        {
            NguoiDung ngDung = new NguoiDung();
            string sql = string.Format("SELECT * FROM KhachHang WHERE {0} = '{1}'", Cot, giaTri);
            ngDung = data.LayThongTinKhachHang(sql);
            return ngDung;
        }

        public List<string> LayThongTinSTKNhan()
        {
            List<string> cot = new List<string>();
            string sql = string.Format("select distinct TenTKNhan from hr.LichSuGiaoDich where LoaiGD = 'Chuyen Tien'");
            cot = data.LayCot(sql, "TenTKNhan");
            return cot;
        }
    }
}
