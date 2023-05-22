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
    public partial class FrmXacnhanChuyentien : Form
    {
        private LichSuGiaoDich gd;
        private KhachHang kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoidung;
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        ChuyenTienDAO chuyentienDAO = new ChuyenTienDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        public FrmXacnhanChuyentien()
        {
            InitializeComponent();
            this.txtMatkhau.PasswordChar = '*';
        }

        public FrmXacnhanChuyentien(KhachHang kh, TaiKhoanNganHang tknh, LichSuGiaoDich gd, Panel pnlNguoidung)
        {
            InitializeComponent();
            this.txtMatkhau.PasswordChar = '*';
            this.kh = kh;
            this.tknh = tknh;
            this.gd = gd;
            this.pnlNguoidung = pnlNguoidung;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(kh, tknh, pnlNguoidung);
            Utility.addForm(frmchuyentien, pnlNguoidung);
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.Text == tknh.MatKhau)
            {               
                TaiKhoanNganHang? tknhNhan = tknhDAO.LayTaiKhoanNganHang(gd.SoTknhan, gd.NganHangNhan);
                if (tknhNhan != null) chuyentienDAO.ChuyenTien(tknh, gd, tknhNhan);
                lsgdDAO.Them(gd);
                TaiKhoanNganHang? tknhGui = tknhDAO.LayTaiKhoanNganHang(gd.SoTkgui, gd.NganHangGui);
                if (tknhGui != null) tknh = tknhGui;
                FrmThongbaoChuyentien frmThongbaoChuyentien = new FrmThongbaoChuyentien(kh, gd, tknh, pnlNguoidung);
                this.Hide();
                frmThongbaoChuyentien.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Sai mat khau");
                txtMatkhau.Text = "";
            }
        }
    }
}
