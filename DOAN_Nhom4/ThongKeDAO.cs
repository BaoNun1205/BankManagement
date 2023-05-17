using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class ThongKeDAO
    {
        DBConnection data = new DBConnection();
        public ThongKeDAO() { }

        public DataTable ThongKeTienGui(string from, string to, string nganHang, string soTK)
        {
            string sqlStr = string.Format("SELECT COALESCE(SUM(ls.SoTien), 0) AS TongTien, d.ThoiGian " +
                                           "FROM ( " +
                                           "SELECT DATEADD(DAY, number, '{0}') AS ThoiGian " +
                                           "FROM master..spt_values " +
                                           "WHERE type = 'P' AND number BETWEEN 0 AND DATEDIFF(DAY, '{0}', '{1}') " +
                                           ") d LEFT JOIN hr.LichSuGiaoDich ls " +
                                           "ON d.ThoiGian = CONVERT(date, ls.ThoiGian, 103) AND ls.NganHangGui = '{2}' AND ls.SoTKGui = '{3}'" +
                                           "WHERE d.ThoiGian BETWEEN '{0}' AND '{1}' " +
                                           "GROUP BY d.ThoiGian",from, to, nganHang, soTK);
            return data.LayDanhSach(sqlStr);
        }

        public DataTable ThongKeTienNhan(string from, string to, string nganHang, string soTK)
        {
            string sqlStr = string.Format("SELECT COALESCE(SUM(ls.SoTien), 0) AS TongTien, d.ThoiGian " +
                                           "FROM ( " +
                                           "SELECT DATEADD(DAY, number, '{0}') AS ThoiGian " +
                                           "FROM master..spt_values " +
                                           "WHERE type = 'P' AND number BETWEEN 0 AND DATEDIFF(DAY, '{0}', '{1}') " +
                                           ") d LEFT JOIN hr.LichSuGiaoDich ls " +
                                           "ON d.ThoiGian = CONVERT(date, ls.ThoiGian, 103) AND ls.NganHangNhan = '{2}' AND ls.SoTKNhan = '{3}'" +
                                           "WHERE d.ThoiGian BETWEEN '{0}' AND '{1}' " +
                                           "GROUP BY d.ThoiGian", from, to, nganHang, soTK);
            return data.LayDanhSach(sqlStr);
        }

        public DataTable ThongKeTienTong(string from, string to, string nganHang, string soTK)
        {
            string sqlStr = string.Format("SELECT COALESCE(SUM(ls.SoTien), 0) AS TongTien, d.ThoiGian " +
                                           "FROM ( " +
                                           "SELECT DATEADD(DAY, number, '{0}') AS ThoiGian " +
                                           "FROM master..spt_values " +
                                           "WHERE type = 'P' AND number BETWEEN 0 AND DATEDIFF(DAY, '{0}', '{1}') " +
                                           ") d LEFT JOIN hr.LichSuGiaoDich ls " +
                                           "ON d.ThoiGian = CONVERT(date, ls.ThoiGian, 103) AND ((ls.NganHangNhan = '{2}' AND ls.SoTKNhan = '{3}') OR (ls.NganHangGui = '{2}' AND ls.SoTKGui = '{3}'))" +
                                           "WHERE d.ThoiGian BETWEEN '{0}' AND '{1}' " +
                                           "GROUP BY d.ThoiGian", from, to, nganHang, soTK);
            return data.LayDanhSach(sqlStr);
        }

        public DataTable ThongKeGiaoDichChuyenTien(string from, string to)
        {
            string sqlStr = string.Format("SELECT COALESCE(SUM(ls.SoTien), 0) AS TongTien, d.ThoiGian " +
                                           "FROM ( " +
                                           "SELECT DATEADD(DAY, number, '{0}') AS ThoiGian " +
                                           "FROM master..spt_values " +
                                           "WHERE type = 'P' AND number BETWEEN 0 AND DATEDIFF(DAY, '{0}', '{1}') " +
                                           ") d LEFT JOIN hr.LichSuGiaoDich ls " +
                                           "ON d.ThoiGian = CONVERT(date, ls.ThoiGian, 103) AND ls.LoaiGD = '{2}'" +
                                           "WHERE d.ThoiGian BETWEEN '{0}' AND '{1}' " +
                                           "GROUP BY d.ThoiGian", from, to, "Chuyen Tien");
            return data.LayDanhSach(sqlStr);
        }

        public DataTable ThongKeGiaoDichVienThong(string from, string to)
        {
            string sqlStr = string.Format("SELECT COALESCE(SUM(ls.SoTien), 0) AS TongTien, d.ThoiGian " +
                                           "FROM ( " +
                                           "SELECT DATEADD(DAY, number, '{0}') AS ThoiGian " +
                                           "FROM master..spt_values " +
                                           "WHERE type = 'P' AND number BETWEEN 0 AND DATEDIFF(DAY, '{0}', '{1}') " +
                                           ") d LEFT JOIN hr.LichSuGiaoDich ls " +
                                           "ON d.ThoiGian = CONVERT(date, ls.ThoiGian, 103) AND ls.LoaiGD = '{2}'" +
                                           "WHERE d.ThoiGian BETWEEN '{0}' AND '{1}' " +
                                           "GROUP BY d.ThoiGian", from, to, "Nap Tien Dien Thoai");
            return data.LayDanhSach(sqlStr);
        }

        public DataTable ThongKeGiaoDichTinDung(string from, string to)
        {
            string sqlStr = string.Format("SELECT COALESCE(SUM(ls.SoTien), 0) AS TongTien, d.ThoiGian " +
                                           "FROM ( " +
                                           "SELECT DATEADD(DAY, number, '{0}') AS ThoiGian " +
                                           "FROM master..spt_values " +
                                           "WHERE type = 'P' AND number BETWEEN 0 AND DATEDIFF(DAY, '{0}', '{1}') " +
                                           ") d LEFT JOIN hr.LichSuGiaoDich ls " +
                                           "ON d.ThoiGian = CONVERT(date, ls.ThoiGian, 103) AND ls.LoaiGD = '{2}'" +
                                           "WHERE d.ThoiGian BETWEEN '{0}' AND '{1}' " +
                                           "GROUP BY d.ThoiGian", from, to, "Tin Dung");
            return data.LayDanhSach(sqlStr);
        }

        public DataTable ThongKeGiaoDichTietKiem(string from, string to)
        {
            string sqlStr = string.Format("SELECT COALESCE(SUM(ls.SoTien), 0) AS TongTien, d.ThoiGian " +
                                           "FROM ( " +
                                           "SELECT DATEADD(DAY, number, '{0}') AS ThoiGian " +
                                           "FROM master..spt_values " +
                                           "WHERE type = 'P' AND number BETWEEN 0 AND DATEDIFF(DAY, '{0}', '{1}') " +
                                           ") d LEFT JOIN hr.LichSuGiaoDich ls " +
                                           "ON d.ThoiGian = CONVERT(date, ls.ThoiGian, 103) AND (ls.LoaiGD = '{2}' OR ls.LoaiGD = '{3}')" +
                                           "WHERE d.ThoiGian BETWEEN '{0}' AND '{1}' " +
                                           "GROUP BY d.ThoiGian", from, to, "Gui Tiet Kiem", "Rut Tiet Kiem");
            return data.LayDanhSach(sqlStr);
        }

        public DataTable ThongKeGiaoDichVayTien(string from, string to)
        {
            string sqlStr = string.Format("SELECT COALESCE(SUM(ls.SoTien), 0) AS TongTien, d.ThoiGian " +
                                           "FROM ( " +
                                           "SELECT DATEADD(DAY, number, '{0}') AS ThoiGian " +
                                           "FROM master..spt_values " +
                                           "WHERE type = 'P' AND number BETWEEN 0 AND DATEDIFF(DAY, '{0}', '{1}') " +
                                           ") d LEFT JOIN hr.LichSuGiaoDich ls " +
                                           "ON d.ThoiGian = CONVERT(date, ls.ThoiGian, 103) AND (ls.LoaiGD = '{2}' OR ls.LoaiGD = '{3}')" +
                                           "WHERE d.ThoiGian BETWEEN '{0}' AND '{1}' " +
                                           "GROUP BY d.ThoiGian", from, to, "Vay Tien", "Thanh Toan Khoan Vay");
            return data.LayDanhSach(sqlStr);
        }

        public int DemSoLuongTaiKhoang()
        {
            int soLuongTaiKhoan = 0;
            string sql = string.Format("SELECT COUNT(SoTK) " +
                                       "FROM TaiKhoanNganHang");
            DataTable dt = data.LayDanhSach(sql);
            if (dt.Rows.Count > 0)
            {
                object firstValue = dt.Rows[0][0];
                soLuongTaiKhoan = (int)firstValue;
            }
            return soLuongTaiKhoan;
        }

        public int DemSoLuongTinDung()
        {
            int soLuongTaiKhoan = 0;
            string sql = string.Format("SELECT COUNT(SoTKTinDung) " +
                                       "FROM TaiKhoanTinDung");
            DataTable dt = data.LayDanhSach(sql);
            if (dt.Rows.Count > 0)
            {
                object firstValue = dt.Rows[0][0];
                soLuongTaiKhoan = (int)firstValue;
            }
            return soLuongTaiKhoan;
        }

        public int DemSoLuongSoTietKiem()
        {
            int soLuongTaiKhoan = 0;
            string sql = string.Format("SELECT COUNT(MaTietKiem) " +
                                       "FROM TaiKhoanTietKiem");
            DataTable dt = data.LayDanhSach(sql);
            if (dt.Rows.Count > 0)
            {
                object firstValue = dt.Rows[0][0];
                soLuongTaiKhoan = (int)firstValue;
            }
            return soLuongTaiKhoan;
        }

        public int DemSoLuongVay()
        {
            int soLuongTaiKhoan = 0;
            string sql = string.Format("SELECT COUNT(SoTKVay) " +
                                       "FROM KhachHangVay");
            DataTable dt = data.LayDanhSach(sql);
            if (dt.Rows.Count > 0)
            {
                object firstValue = dt.Rows[0][0];
                soLuongTaiKhoan = (int)firstValue;
            }
            return soLuongTaiKhoan;
        }

        public int DemSoLuongNoXau()
        {
            int soLuongTaiKhoan = 0;
            string sql = string.Format("SELECT COUNT(SoTK) " +
                                       "FROM KhachHangNoXau");
            DataTable dt = data.LayDanhSach(sql);
            if (dt.Rows.Count > 0)
            {
                object firstValue = dt.Rows[0][0];
                soLuongTaiKhoan = (int)firstValue;
            }
            return soLuongTaiKhoan;
        }
    }
}
