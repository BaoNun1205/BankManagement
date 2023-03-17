using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class LichSuGiaoDichDAO
    {
        DBConnection data = new DBConnection();
        public LichSuGiaoDichDAO() { }

        public void Them(GiaoDichChuyenTien gdct)
        {
            string sqlGD = string.Format("INSERT INTO hr.LichSuGiaoDich(TenTKGui, SoTKGui, TenTKNhan, SoTKNhan, ThoiGian, SoTien, NganHangGui, NganHangNhan, LoiNhan) OUTPUT INSERTED.MaGD VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}')", gdct.TenTKGui, gdct.SoTKGui, gdct.TenTKNhan, gdct.SoTKNhan, DateTime.Now, gdct.SoTien, "HHB", gdct.NganHang, gdct.LoiNhan);
            data.xuLi(sqlGD);
        }

        public DataTable LichSuGiaoDichNhanNguoiDung(NguoiDung kh, int x)
        {
            string sqlStr = String.Format("SELECT MaGD, ThoiGian, NganHangGui, SoTKGui, SoTien, LoiNhan FROM hr.LichSuGiaoDich WHERE SoTKNhan = '{0}' AND ThoiGian >= DATEADD(day, -{1}, GETDATE())", kh.SoTK, x);
            return data.LayDanhSach(sqlStr);
        }

        public DataTable LichSuGiaoDichGuiNguoiDung(NguoiDung kh, int x)
        {
            string sqlStr = String.Format("SELECT MaGD, ThoiGian, NganHangNhan, SoTKNhan, SoTien, LoiNhan FROM hr.LichSuGiaoDich WHERE SoTKGui = '{0}' AND ThoiGian >= DATEADD(day, -{1}, GETDATE())", kh.SoTK, x);
            return data.LayDanhSach(sqlStr);
        }
    }
}
