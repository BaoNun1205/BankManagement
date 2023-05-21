using DOAN_Nhom4.Entities;
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

        public DataTable HienThi()
        {
            string sql = string.Format("SELECT MaGD, LoaiGD, NganHangGui, SoTKGui, NganHangNhan, SoTKNhan, SoTien, ThoiGian " +
                                       "FROM hr.LichSuGiaoDich");
            return data.LayDanhSach(sql);
        }
        public void Them(GiaoDich gd)
        {
            string sqlGD = string.Format("INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian, SoTien, LoiNhan) OUTPUT INSERTED.MaGD VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, '{9}')",gd.LoaiGD, gd.NganHangGui, gd.TenTKGui, gd.SoTKGui, gd.NganHangNhan, gd.TenTKNhan, gd.SoTKNhan, DateTime.Now, gd.SoTien, gd.LoiNhan);
            data.xuLi(sqlGD);
        }

        public DataTable LichSuGiaoDichNhanNguoiDung(KhachHang kh, int x)
        {
            string sqlStr = string.Format("SELECT MaGD, LoaiGD, ThoiGian, NganHangGui, SoTKGui, SoTien, LoiNhan FROM hr.LichSuGiaoDich WHERE SoTKNhan = '{0}' AND ThoiGian >= DATEADD(day, -{1}, GETDATE())", kh.SoTk, x);
            return data.LayDanhSach(sqlStr);
        }

        public DataTable LichSuGiaoDichGuiNguoiDung(KhachHang kh, int x)
        {
            string sqlStr = string.Format("SELECT MaGD, LoaiGD, ThoiGian, NganHangNhan, SoTKNhan, SoTien, LoiNhan FROM hr.LichSuGiaoDich WHERE SoTKGui = '{0}' AND ThoiGian >= DATEADD(day, -{1}, GETDATE())", kh.SoTk, x);
            return data.LayDanhSach(sqlStr);
        }

        public void XuatExcel()
        {
            string sql = string.Format("SELECT * FROM hr.LichSuGiaoDich");
            data.XuatExcel(sql);
        }
    }
}
