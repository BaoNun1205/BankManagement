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
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();

        public ChuyenTienDAO() { }

        public List<GiaoDich> LayDanhSachGiaoDich(string stkgui)
        {
            List<GiaoDich> gd = new List<GiaoDich>();
            string sql = string.Format("SELECT * FROM hr.LichSuGiaoDich WHERE LoaiGD = 'Chuyen Tien' and SoTKGui = '{0}'", stkgui);
            gd = data.LayDanhSachGiaoDich(sql);
            return gd;
        }
        public void ChuyenTien(TaiKhoanNganHang tkGui, GiaoDich gd, TaiKhoanNganHang tkNhan)
        {
            TaiKhoanNganHang taiKhoanNhan = tknhDAO.LayTaiKhoanNganHang("SoTK", gd.SoTKNhan, "TenNH", gd.NganHangNhan);
            decimal soTienNhan = gd.SoTien + taiKhoanNhan.SoDu;
            string sqlStrNhan = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}' AND TenNH = '{2}'", soTienNhan, taiKhoanNhan.SoTK, taiKhoanNhan.TenNH);
            data.xuLi(sqlStrNhan);

            TaiKhoanNganHang taiKhoanGui = tknhDAO.LayTaiKhoanNganHang("SoTk", gd.SoTKGui, "TenNH", gd.NganHangGui);
            decimal soTienGui = taiKhoanGui.SoDu - gd.SoTien;
            string sqlStrGui = string.Format("UPDATE TaiKhoanNganHang SET SoDu = {0} WHERE SoTK = '{1}' AND TenNH = '{2}'", soTienGui, taiKhoanGui.SoTK, taiKhoanGui.TenNH);
            data.xuLi(sqlStrGui);
        }
    }
}
