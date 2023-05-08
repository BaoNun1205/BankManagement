using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmDangKyTinDung : Form
    {
        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        ThongTinTinDungDAO tttdDAO = new ThongTinTinDungDAO();
        Image[] images = new Image[]
        {
            Properties.Resources.hhb_visa_Flexi,
            Properties.Resources.hhb_visa_platinum_cashback,
            Properties.Resources.hhb_visa_infinite,
        };
        public FrmDangKyTinDung()
        {
            InitializeComponent();
        }

        public FrmDangKyTinDung(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void cb_LoaiThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] hanMuc = {"10.000.000 - 80.000.000 VND", "80.000.000 VND - ... VND ", "300.000.000 VND - ... VND "};
            int selectedIndex = cb_LoaiThe.SelectedIndex;
            if (selectedIndex >= 0)
            {
                ptbTheTinDung.Image = images[selectedIndex];
                lblThongTinTIen.Text = hanMuc[selectedIndex];
            }
            else
            {
                ptbTheTinDung.Image = null;
            }
        }

        private void lbllLoaiThe_Click(object sender, EventArgs e)
        {
            FrmThongTinTheHHBVisaFlexi frmThongTinTheHHBVisaFlexi = new FrmThongTinTheHHBVisaFlexi(kh, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmThongTinTheHHBVisaFlexi, pnlNguoiDung);
        }

        private void ptbQuayLai_Click(object sender, EventArgs e)
        {
            FrmTienIchTinDung frmTienIchTinDung = new FrmTienIchTinDung(kh, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIchTinDung, pnlNguoiDung);
        }

        private void FrmDangKyTinDung_Load(object sender, EventArgs e)
        {
            txt_HoTen.Text = kh.tenTK;
            txt_CCCD.Text = kh.cccd;
            txt_SDT.Text = kh.Sdt;
            txt_Email.Text = kh.Email;
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            double lai = laiSuat();
            ThongTinTinDung ttTinDung = new ThongTinTinDung(txtSoTaiKhoang.Text, txt_HoTen.Text, txt_CCCD.Text, txt_DiaChi.Text, txt_SDT.Text, txt_Email.Text, cb_NgheNghiep.Text, cb_ThuNhap.Text,
                                                            cb_LoaiThe.Text, dtpNgayMoThe.Value.AddMonths(1), dtpNgayMoThe.Value.AddMonths(1).Subtract(new TimeSpan(15, 0, 0, 0)), int.Parse(txtHanMuc.Text), lai, 0, 0, dtpNgayMoThe.Value, 0, 0);
            tttdDAO.Them(ttTinDung);
        }

        private double laiSuat()
        {
            int giaTri = cb_LoaiThe.SelectedIndex;
            if (giaTri == 1)
            {
                return 18;
            }
            else if (giaTri == 2)
            {
                return 16.5;
            }
            else
            {
                return 16.5;
            }
        }
    }
}
