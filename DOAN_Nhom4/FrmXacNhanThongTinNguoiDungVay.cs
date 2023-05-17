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
        private void XuLi()
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
            Dictionary<string, double> laiDictionary = new Dictionary<string, double>
            {
                { "NHU CAU NHA O", 9 },
                { "SAN XUAT KINH DOANH", 5 },
                { "MUA O TO", 7 },
                { "TIEU DUNG KHONG CO TAI SAN BAO DAM", 12 },
                { "TIEU DUNG DAM BAO BANG BAT DONG SAN", 8 }
            };
            double lai;
            if (laiDictionary.ContainsKey(ttNgDung.SpVay))
            {
                lai = laiDictionary[ttNgDung.SpVay];
            }
            else
            {
                lai = 7;
            }
            //chua biet lam sao cho gon
            ttNgDung.Lai = lai;
            txt_LaiSuat.Text = lai.ToString();
            double soTienVay = double.Parse(ttNgDung.SoTienVay.ToString());
            double laithang = lai / 1200;
            double number = Math.Pow((1 + laithang), int.Parse(ttNgDung.ThoiGianVay.ToString()));
            double tmp = (soTienVay * laithang * number) / (number - 1);
            BigInteger tienhangthang = new BigInteger(tmp);
            BigInteger tongsotien = tienhangthang * int.Parse(ttNgDung.ThoiGianVay.ToString());
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
            XuLi();
        }

        private void btn_XacNhanVay_Click(object sender, EventArgs e)
        {
            ngDungVay.Them(ttNgDung);
            GiaoDich gd = new GiaoDich("Dang ky khoan vay", "HHB", "","", "HHB", ttNgDung.HoTen, ttNgDung.SoTKVay, ttNgDung.SoTienVay, "Vay no");
            lsgdDAO.Them(gd);
            MessageBox.Show("Xác nhận thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmTienIch frmTienIch = new FrmTienIch(nguoiDung, tknh, pnlNguoiDung);
            DOAN_Nhom4.Utility.addForm(frmTienIch, pnlNguoiDung);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            DOAN_Nhom4.Utility.addForm(frmTienIchVay, pnlNguoiDung);
        }
    }
}
