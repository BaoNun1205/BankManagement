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
            int selectedIndex = cb_LoaiThe.SelectedIndex;
            if (selectedIndex >= 0)
            {
                ptbTheTinDung.Image = images[selectedIndex];
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
    }
}
