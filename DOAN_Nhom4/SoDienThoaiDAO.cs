using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class SoDienThoaiDAO
    {
        DBConnection data = new DBConnection();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        ThongTinTinDungDAO tttdDAO = new ThongTinTinDungDAO();

        public SoDienThoaiDAO() { }

        public void CapNhat(SoDienThoai sdt)
        {
            string sql = string.Format("UPDATE SoDienThoai Set SoDu = {0} Where SDT = '{1}'", sdt.SoDu, sdt.Sdt);
            data.XuLi(sql);
        }

        public void ThanhToanVienThong(SoDienThoai sdt, GiaoDich gd)
        {
            if (gd.NganHangGui == "Tai Khoan Tin Dung")
            {
                ThongTinTinDung tttd = tttdDAO.LayThongTinTinDung("SoTKTinDung", gd.SoTKGui);
                tttdDAO.ThanhToanPhi(tttd, gd);
                tttdDAO.Update(tttd);
                NapTienDienThoai(sdt, gd);
            }
            else
            {
                TaiKhoanNganHang tknh = tknhDAO.LayTaiKhoanNganHang("TenNH", gd.NganHangGui, "SoTK", gd.SoTKGui);
                tknhDAO.RutTien(tknh, gd);
                NapTienDienThoai(sdt, gd);
            }
        }

        public void NapTienDienThoai(SoDienThoai sdt, GiaoDich gd)
        {
            sdt.SoDu = sdt.SoDu + gd.SoTien;
            CapNhat(sdt);
        }

        public SoDienThoai LaySoDienThoai(string Cot, string giaTri)
        {
            SoDienThoai sdt = new SoDienThoai();
            string sql = string.Format("SELECT * FROM SoDienThoai WHERE {0} = '{1}'", Cot, giaTri);
            sdt = data.XuLiSoDienThoai(sql);
            return sdt;
        }
    }
}
