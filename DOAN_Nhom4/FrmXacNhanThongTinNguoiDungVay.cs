using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmXacNhanThongTinNguoiDungVay : Form
    {
        public KhachHangVay ttNgDung;
        public KhachHang nguoiDung;
        ThongTinNguoiDungVayDAO ngDungVay = new ThongTinNguoiDungVayDAO();
        private Panel pnlNguoiDung;
        public TaiKhoanNganHang tknh;
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        public FrmXacNhanThongTinNguoiDungVay()
        {
            InitializeComponent();
        }

        public FrmXacNhanThongTinNguoiDungVay(KhachHang nguoiDung, TaiKhoanNganHang tknh, KhachHangVay ttNgDung, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.ttNgDung = ttNgDung;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void XacNhanThongTinNguoiDungVay_Load(object sender, EventArgs e)
        {
            XuLi();
        }

        private void btn_XacNhanVay_Click(object sender, EventArgs e)
        {
            ngDungVay.Them(ttNgDung);
            LichSuGiaoDich gd = new LichSuGiaoDich()
            {
                LoaiGd = "Vay Tien",
                NganHangGui = "HHB",
                SoTkgui = "",
                TenTkgui = "",
                NganHangNhan = "HHB",
                TenTknhan = ttNgDung.HoTen,
                SoTknhan = ttNgDung.SoTkvay,
                ThoiGian = DateTime.Now,
                SoTien = ttNgDung.SoTienVay,
                LoiNhan = "Vay no"
            };
            lsgdDAO.Them(gd);
            MessageBox.Show("Xác nhận thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmTienIch frmTienIch = new FrmTienIch(nguoiDung, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIch, pnlNguoiDung);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIchVay, pnlNguoiDung);
        }     
        
        private void XuLi()
        {
            Dictionary<string, double> laiDictionary = new Dictionary<string, double>
            {
                { "NHU CAU NHA O", 9 },
                { "SAN XUAT KINH DOANH", 5 },
                { "MUA O TO", 7 },
                { "TIEU DUNG KHONG CO TAI SAN DAM BAO", 12 },
                { "TIEU DUNG DAM BAO BANG BAT DONG SAN", 8 },
                { "CHO VAY KHAC", 7 }
            };
            double lai = laiDictionary[ttNgDung.Spvay];
            txtDanhXung.Text = ttNgDung.DanhXung;
            txtHoTen.Text = ttNgDung.HoTen;
            txtCCCD.Text = ttNgDung.Cccd;
            txtDiaChi.Text = ttNgDung.DiaChi;
            txtSDT.Text = ttNgDung.Sdt;
            txtEmail.Text = ttNgDung.Email;
            txtNgheNghiep.Text = ttNgDung.NgheNghiep;
            txtThuNhap.Text = ttNgDung.ThuNhap;
            txtSPVay.Text = ttNgDung.Spvay;
            txtSoTienVay.Text = ttNgDung.SoTienVay.Value.ToString("N0") + " VNĐ";
            txtThoiGianVay.Text = ttNgDung.ThoiGianVay.ToString();
            txtKhoanVay.Text = ttNgDung.LoaiKhoanVay;
            txtLaiSuat.Text = lai.ToString();
            ttNgDung.LaiSuat = lai.ToString();
            decimal tienhangthang = ngDungVay.TienHangThang(ttNgDung);
            decimal tongsotien = ngDungVay.TongSoTien(ttNgDung);
            txtTongSoTien.Text = tongsotien.ToString("N0") + " VNĐ";
            txtSoTienHangThang.Text = tienhangthang.ToString("N0") + " VNĐ";
            txtChiNhanhVay.Text = ttNgDung.ChiNhanhVay;
            txtNgayVay.Text = ttNgDung.NgayVay.ToString();
            txtTinhTien.Text = ngDungVay.TinhTien(ttNgDung);
            ngDungVay.CapNhatNgDungVay(ttNgDung);
            ngDungVay.CapNhatTaiKhoanNganHang(tknh, tknhDAO, ttNgDung);          
        }
    }
}
