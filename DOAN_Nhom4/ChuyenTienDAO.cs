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
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();

        public ChuyenTienDAO() { }

        public List<LichSuGiaoDich> LayDanhSachGiaoDich(string stkgui)
        {
            var danhSachGiaoDich = hhb.LichSuGiaoDiches
                        .Where(gd => gd.LoaiGd == "Chuyen Tien" && gd.SoTkgui == stkgui)
                        .GroupBy(gd => new { gd.NganHangNhan, gd.SoTknhan })
                        .Select(grp => grp.First())
                        .ToList();

            return danhSachGiaoDich;
        }

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
