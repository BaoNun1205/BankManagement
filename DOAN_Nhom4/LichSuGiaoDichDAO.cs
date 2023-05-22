using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    internal class LichSuGiaoDichDAO
    {
        NganHangHhbContext hhb = new NganHangHhbContext();
        DBConnection data = new DBConnection();
        public LichSuGiaoDichDAO() { }

        public DataTable HienThi()
        {
            string sql = string.Format("SELECT MaGD, LoaiGD, NganHangGui, SoTKGui, NganHangNhan, SoTKNhan, SoTien, ThoiGian " +
                                       "FROM hr.LichSuGiaoDich");
            return data.LayDanhSach(sql);
        }
        public void Them(LichSuGiaoDich gd)
        {
            hhb.LichSuGiaoDiches.Add(gd);
            hhb.SaveChanges();
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
