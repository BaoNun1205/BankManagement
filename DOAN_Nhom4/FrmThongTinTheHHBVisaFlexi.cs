using DOAN_Nhom4.Entities;
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
    public partial class FrmThongTinTheHHBVisaFlexi : Form
    {
        private KhachHang kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        public FrmThongTinTheHHBVisaFlexi()
        {
            InitializeComponent();
        }

        public FrmThongTinTheHHBVisaFlexi(KhachHang kh, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void pbQuayLai_Click(object sender, EventArgs e)
        {
            FrmDangKyTinDung frmDangKyTinDung = new FrmDangKyTinDung(kh, tknh, pnlNguoiDung);
            addForm(frmDangKyTinDung);
        }

        private void pbChuyenTrang_Click(object sender, EventArgs e)
        {
            FrmThongTinTheHHBVisaPlatinumCashBack frmThongTinTheHHBVisaPlatinumCashBack = new FrmThongTinTheHHBVisaPlatinumCashBack(kh, tknh, pnlNguoiDung);
            addForm(frmThongTinTheHHBVisaPlatinumCashBack);
        }

        private void addForm(Form form)
        {
            pnlNguoiDung.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlNguoiDung.Controls.Add(form);
            pnlNguoiDung.Tag = form;
            form.Show();
        }
    }
}
