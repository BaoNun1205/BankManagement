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

        public List<GiaoDich> LayDanhSachGiaoDich(string stkgui)
        {
            List<GiaoDich> gd = new List<GiaoDich>();
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

        public void ChuyenTien(TaiKhoanNganHang tkGui, GiaoDich gd, TaiKhoanNganHang tkNhan)
        {
            TaiKhoanNganHang taiKhoanNhan = tknhDAO.LayTaiKhoanNganHang(gd.SoTKNhan, gd.NganHangNhan);
            decimal soTienNhan = (decimal)(gd.SoTien + taiKhoanNhan.SoDu);
            TaiKhoanNganHang tknhn = hhb.TaiKhoanNganHangs.Where(tknhn => tknhn.TenNh == tkNhan.TenNh && tknhn.SoTk == tkNhan.SoTk).SingleOrDefault();
            tknhn.SoDu = soTienNhan;
            hhb.SaveChanges();

            TaiKhoanNganHang taiKhoanGui = tknhDAO.LayTaiKhoanNganHang(gd.SoTKGui, gd.NganHangGui);
            decimal soTienGui = (decimal)(taiKhoanGui.SoDu - gd.SoTien);
            TaiKhoanNganHang tknhg = hhb.TaiKhoanNganHangs.Where(tknhg => tknhn.TenNh == tkNhan.TenNh && tknhg.SoTk == tkNhan.SoTk).SingleOrDefault();
            tknhg.SoDu = soTienNhan;
            hhb.SaveChanges();
        }
    }
}
