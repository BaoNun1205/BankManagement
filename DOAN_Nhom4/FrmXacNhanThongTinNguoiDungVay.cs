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
        public ThongTinNguoiDungVay ttNgDung;
        public NguoiDung nguoiDung;
        ThongTinNguoiDungVayDAO ngDungVay = new ThongTinNguoiDungVayDAO();
        private Panel pnlNguoiDung;
        public TaiKhoanNganHang tknh;
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        QLThongTinVayDAO qlDAO = new QLThongTinVayDAO();
        public FrmXacNhanThongTinNguoiDungVay()
        {
            InitializeComponent();
        }

        public FrmXacNhanThongTinNguoiDungVay(NguoiDung nguoiDung, TaiKhoanNganHang tknh,ThongTinNguoiDungVay ttNgDung, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.ttNgDung = ttNgDung;
            this.pnlNguoiDung = pnlNguoiDung;
        }
        private void HienThi()
        {
            txt_DanhXung.Text = ttNgDung.DanhXung;
            txt_HoTen.Text = ttNgDung.HoTen;
            txt_CCCD.Text = ttNgDung.Cccd;
            txt_DiaChi.Text = ttNgDung.DiaChi;
            txt_SDT.Text = ttNgDung.Sdt;
            txt_Email.Text = ttNgDung.Email;
            txt_NgheNghiep.Text = ttNgDung.NgheNghiep;
            txt_ThuNhap.Text = ttNgDung.ThuNhap;
            txt_SPVay.Text = ttNgDung.SpVay;
            txt_SoTienVay.Text = ttNgDung.SoTienVay.ToString("N0");
            txt_ThoiGianVay.Text = ttNgDung.ThoiGianVay.ToString();
            txt_KhoanVay.Text = ttNgDung.LoaiKhoanVay;
            double lai;
            if (ttNgDung.SpVay == "NHU CAU NHA O")
            {
                lai = 9;
            }
            else if (ttNgDung.SpVay == "SAN XUAT KINH DOANH")
            {
                lai = 5;
            }
            else if (ttNgDung.SpVay == "MUA O TO")
            {
                lai = 7;
            }
            else if (ttNgDung.SpVay == "TIEU DUNG KHONG CO TAI SAN BAO DAM")
            {
                lai = 12;
            }
            else if (ttNgDung.SpVay == "TIEU DUNG DAM BAO BANG BAT DONG SAN")
            {
                lai = 8;
            }
            else
                lai = 7;
            ttNgDung.Lai = lai;
            txt_LaiSuat.Text = lai.ToString();
            double soTienVay = double.Parse(txt_SoTienVay.Text);
            double laithang = lai / 1200;
            double number = Math.Pow((1 + laithang), int.Parse(txt_ThoiGianVay.Text));
            double tmp = (soTienVay * laithang * number) / (number - 1);
            BigInteger tienhangthang = new BigInteger(tmp);
            BigInteger tongsotien = tienhangthang * int.Parse(txt_ThoiGianVay.Text);
            txt_TongSoTien.Text = tongsotien.ToString("N0");
            ttNgDung.SoTienHangThang = tienhangthang;
            txt_SoTienHangThang.Text = tienhangthang.ToString("N0");
            txt_ChiNhanhVay.Text = ttNgDung.ChiNhanhVay;
            txt_NgayVay.Text = ttNgDung.NgayVay.ToString();
            laithang *= 100;
            txt_TinhTien.Text = String.Format("{0} x ({1} x {2}% x (1 + {3}%)^{4}) / ((1 + {5}%)^{6} - 1) = {7}",
                txt_ThoiGianVay.Text, soTienVay.ToString("N0"), laithang.ToString("0.000"), laithang.ToString("0.000"), txt_ThoiGianVay.Text, laithang.ToString("0.000"), txt_ThoiGianVay.Text, tongsotien.ToString("N0"));
            ttNgDung.NgayDenHan = ttNgDung.NgayVay.AddMonths(1);
            ttNgDung.TongSoTienPhaiTra = tongsotien;
            ttNgDung.PhiTraCham = 0;
            tknh.SoDu += ttNgDung.SoTienVay;
            tknhDAO.SuaSoDu(tknh);           
        }

        private void XacNhanThongTinNguoiDungVay_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btn_XacNhanVay_Click(object sender, EventArgs e)
        {
            ngDungVay.Them(ttNgDung);
            qlDAO.Them(ttNgDung);
            GiaoDich gd = new GiaoDich("Dang ky khoan vay", "HHB", "","", "HHB", ttNgDung.HoTen, ttNgDung.SoTKVay, ttNgDung.SoTienVay, "Vay no");
            lsgdDAO.Them(gd);
            MessageBox.Show("Xác nhận thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmTienIch frmTienIch = new FrmTienIch(nguoiDung, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIch, pnlNguoiDung);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIchVay, pnlNguoiDung);
        }
    }
}
