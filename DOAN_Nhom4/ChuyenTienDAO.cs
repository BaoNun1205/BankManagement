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

        public List<string> LayThongTinSTKNhan(string stkgui)
        {
            List<string> cot = new List<string>();
            string sql = string.Format("select distinct SoTKNhan from hr.LichSuGiaoDich where LoaiGD = 'Chuyen Tien' and SoTKGui = '{0}'", stkgui);
            cot = data.LayCot(sql, "SoTKNhan");
            return cot;
        }
    }
}
