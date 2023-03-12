using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class TaiKhoangNganHangDAO
    {
        DBConnection data = new DBConnection();
        public TaiKhoangNganHangDAO() { }

        public void GuiTien(TaiKhoangNganHang tkGui, ChuyenTien chuyenTien, TaiKhoangNganHang tkNhan)
        {
            TaiKhoangNganHang taiKhoangNhan = new TaiKhoangNganHang();
            taiKhoangNhan = data.LayKhachHang("SoTK", tkNhan.SoTK);
            BigInteger soTienNhan = chuyenTien.SoTien + taiKhoangNhan.SoDu;
            string sqlStrNhan = string.Format("UPDATE KhachHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienNhan, taiKhoangNhan.SoTK);
            data.xuLi(sqlStrNhan);

            NguoiDung khachHangGui = new NguoiDung();
            khachHangGui = data.LayKhachHang("SoTk", khGui.SoTK);
            BigInteger soTienGui = khachHangGui.SoDu - chuyenTien.SoTien;
            string sqlStrGui = string.Format("UPDATE KhachHang SET SoDu = {0} WHERE SoTK = '{1}'", soTienGui, khachHangGui.SoTK);
            data.xuLi(sqlStrGui);
        }
    }
}
