using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class ThongKeDAO
    {
        DBConnection data = new DBConnection();
        public ThongKeDAO() { }

        public LineSeries ThongKeTienGui(string from, string to, string nganHang, string soTK)
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
            return data.ThongKeTien(sqlStr);
        }
    }
}
