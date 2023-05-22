﻿using DOAN_Nhom4.Entities;
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

        public List<object> HienThi()
        {
            var result = from ls in hhb.LichSuGiaoDiches
                         select new
                         {
                             MaGd = ls.MaGd,
                             LoaiGd = ls.LoaiGd,
                             NganHangGui = ls.NganHangGui,
                             SoTkgui = ls.SoTkgui,
                             NganHangNhan = ls.NganHangNhan,
                             SoTknhan = ls.SoTknhan,
                             SoTien = ls.SoTien,
                             LoiNhan = ls.LoiNhan,
                             ThoiGian = ls.ThoiGian
                         };
            return result.ToList<object>();
        }
        public void Them(LichSuGiaoDich gd)
        {
            hhb.LichSuGiaoDiches.Add(gd);
            hhb.SaveChanges();
        }

        public DataTable LichSuGiaoDichNhanNguoiDung(KhachHang kh, int x)
        {
            DateTime fromDate = DateTime.Now.AddDays(-x);

            var danhSachGiaoDich = hhb.LichSuGiaoDiches
                .Where(gd => gd.SoTknhan == kh.SoTk && gd.ThoiGian >= fromDate)
                .Select(gd => new { gd.MaGd, gd.LoaiGd, gd.ThoiGian, gd.NganHangGui, gd.SoTkgui, gd.SoTien, gd.LoiNhan })
                .ToList();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaGD");
            dataTable.Columns.Add("LoaiGD");
            dataTable.Columns.Add("ThoiGian");
            dataTable.Columns.Add("NganHangGui");
            dataTable.Columns.Add("SoTKGui");
            dataTable.Columns.Add("SoTien");
            dataTable.Columns.Add("LoiNhan");

            foreach (var giaoDich in danhSachGiaoDich)
            {
                dataTable.Rows.Add(giaoDich.MaGd, giaoDich.LoaiGd, giaoDich.ThoiGian, giaoDich.NganHangGui, giaoDich.SoTkgui, giaoDich.SoTien, giaoDich.LoiNhan);
            }

            return dataTable;
        }

        public DataTable LichSuGiaoDichGuiNguoiDung(KhachHang kh, int x)
        {
            DateTime fromDate = DateTime.Now.AddDays(-x);

            var danhSachGiaoDich = hhb.LichSuGiaoDiches
                .Where(gd => gd.SoTkgui == kh.SoTk && gd.ThoiGian >= fromDate)
                .Select(gd => new { gd.MaGd, gd.LoaiGd, gd.ThoiGian, gd.NganHangNhan, gd.SoTknhan, gd.SoTien, gd.LoiNhan })
                .ToList();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaGD");
            dataTable.Columns.Add("LoaiGD");
            dataTable.Columns.Add("ThoiGian");
            dataTable.Columns.Add("NganHangNhan");
            dataTable.Columns.Add("SoTKNhan");
            dataTable.Columns.Add("SoTien");
            dataTable.Columns.Add("LoiNhan");

            foreach (var giaoDich in danhSachGiaoDich)
            {
                dataTable.Rows.Add(giaoDich.MaGd, giaoDich.LoaiGd, giaoDich.ThoiGian, giaoDich.NganHangNhan, giaoDich.SoTknhan, giaoDich.SoTien, giaoDich.LoiNhan);
            }

            return dataTable;
        }

        public void XuatExcel()
        {
            string sql = string.Format("SELECT * FROM hr.LichSuGiaoDich");
            data.XuatExcel(sql);
        }
    }
}
