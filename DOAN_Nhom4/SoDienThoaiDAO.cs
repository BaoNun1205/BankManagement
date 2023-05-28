using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class SoDienThoaiDAO
    {
        NganHangHhbContext hhb = new NganHangHhbContext();
        DBConnection data = new DBConnection();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        ThongTinTinDungDAO tttdDAO = new ThongTinTinDungDAO();

        public SoDienThoaiDAO() { }

        public void CapNhat(SoDienThoai dt)
        {
            SoDienThoai? sdt = hhb.SoDienThoais.Where(sdt => sdt.Sdt == dt.Sdt).FirstOrDefault();
            if (sdt != null)
            {
                sdt.SoDu = dt.SoDu;
                hhb.SaveChanges();
            }    
        }

        public void ThanhToanVienThong(SoDienThoai sdt, LichSuGiaoDich gd)
        {
            if (gd.NganHangGui == "Tai Khoan Tin Dung")
            {
                TaiKhoanTinDung? tttd = tttdDAO.LayThongTinTinDungBangStk(gd.SoTkgui);
                if (tttd != null)
                {
                    tttdDAO.ThanhToanPhi(tttd, gd);
                    tttdDAO.Sua(tttd);
                    NapTienDienThoai(sdt, gd);
                }    
            }
            else
            {
                TaiKhoanNganHang? tknh = new TaiKhoanNganHang();
                tknh = tknhDAO.LayTaiKhoanNganHang(gd.SoTkgui, gd.NganHangGui);
                if (tknh!= null)
                {
                    tknhDAO.RutTien(tknh, gd);
                    NapTienDienThoai(sdt, gd);
                }
            }
        }

        public void NapTienDienThoai(SoDienThoai sdt, LichSuGiaoDich gd)
        {
            sdt.SoDu = sdt.SoDu + gd.SoTien ?? 0;
            CapNhat(sdt);
        }

        public SoDienThoai? LaySoDienThoai(string? giaTri)
        {
            return hhb.SoDienThoais.Where(sdt => sdt.Sdt == giaTri).FirstOrDefault();
        }
    }
}
