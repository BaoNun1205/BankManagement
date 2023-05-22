using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class ChuyenTienDAO
    {
        NganHangHhbContext hhb = new NganHangHhbContext();
        DBConnection data = new DBConnection();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();

        public ChuyenTienDAO() { }

        public List<LichSuGiaoDich> LayDanhSachGiaoDich(string stkgui)
        {
            List<LichSuGiaoDich> gd = new List<LichSuGiaoDich>();
            string sql = string.Format("SELECT * FROM hr.LichSuGiaoDich WHERE LoaiGD = 'Chuyen Tien' and SoTKGui = '{0}'", stkgui);
            gd = data.LayDanhSachGiaoDich(sql);
            return gd;
        }

        /*public List<GiaoDich> LayDanhSachGiaoDich(string stkgui)
        {
            var danhSachGiaoDich = from giaoDich in hhb.LichSuGiaoDiches
                                   where giaoDich.LoaiGd == "Chuyen Tien" && giaoDich.SoTkgui == stkgui
                                   select giaoDich;

            return danhSachGiaoDich.ToList();
        }*/

        public void ChuyenTien(TaiKhoanNganHang tkGui, LichSuGiaoDich gd, TaiKhoanNganHang tkNhan)
        {
            TaiKhoanNganHang? taiKhoanGui = tknhDAO.LayTaiKhoanNganHang(gd.SoTkgui, gd.NganHangGui);
            decimal soTienGui = ((taiKhoanGui?.SoDu - gd.SoTien) ?? 0);
            TaiKhoanNganHang? tknhg = hhb.TaiKhoanNganHangs.Where(tknhg => tknhg.TenNh == tkGui.TenNh && tknhg.SoTk == tkGui.SoTk).SingleOrDefault();
            if (tknhg != null)
            {
                tknhg.SoDu = soTienGui;
                hhb.SaveChanges();
            }

            TaiKhoanNganHang? taiKhoanNhan = tknhDAO.LayTaiKhoanNganHang(gd.SoTknhan, gd.NganHangNhan);
            decimal soTienNhan = ((taiKhoanNhan?.SoDu + gd.SoTien) ?? 0);
            TaiKhoanNganHang? tknhn = hhb.TaiKhoanNganHangs.Where(tknhn => tknhn.TenNh == tkNhan.TenNh && tknhn.SoTk == tkNhan.SoTk).SingleOrDefault();
            if (tknhn != null)
            {
                tknhn.SoDu = soTienNhan;
                hhb.SaveChanges();
            }
        }
    }
}
