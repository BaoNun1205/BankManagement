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
        public GiaoDich gd;
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        public FrmXacnhanChuyentien()
        {
            InitializeComponent();
            pnlXacnhanChuyentien.Parent = picBoxXacnhanChuyentien;
            pnlXacnhanChuyentien.BackColor = Color.Transparent;
            this.txtMatkhau.PasswordChar = '*';
        }

        public FrmXacnhanChuyentien(NguoiDung kh, TaiKhoanNganHang tknh, GiaoDich gd)
        {
            InitializeComponent();
            pnlXacnhanChuyentien.Parent = picBoxXacnhanChuyentien;
            pnlXacnhanChuyentien.BackColor = Color.Transparent;
            this.txtMatkhau.PasswordChar = '*';
            this.kh = kh;
            this.tknh = tknh;
            this.gd = gd;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(kh, tknh);
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.Text == tknh.MatKhau)
            {
                TaiKhoanNganHang tknhNhan = new TaiKhoanNganHang(gd.SoTKNhan);
                tknhDAO.ChuyenTien(tknh, gd, tknhNhan);
                lsgdDAO.Them(gd);
                tknh = tknhDAO.LayTaiKhoanNganHang("SoTK", tknh.SoTK);
                FrmThongbaoChuyentien frmThongbaoChuyentien = new FrmThongbaoChuyentien(kh, gd, tknh);
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
