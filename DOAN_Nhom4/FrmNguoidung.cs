using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmNguoidung : Form
    {
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        public ThongTinNguoiDungVay ttNgDung;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FrmNguoidung()
        {
            InitializeComponent();
        }

        public FrmNguoidung(NguoiDung kh, TaiKhoanNganHang tknh)
        {
            InitializeComponent();         
            this.kh = kh;
            this.tknh = tknh;
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh, pnlNguoidung);
            DOAN_Nhom4.ClassAddForm.addForm(frmtrangchu, pnlNguoidung);
        }

        private void FrmNguoidung_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = kh.TenTK.ToString();
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan(kh, tknh);
            DOAN_Nhom4.ClassAddForm.addForm(frmHienThiThongTinCaNhan, pnlNguoidung);
        }

        private void btnChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(kh, tknh, pnlNguoidung);
            DOAN_Nhom4.ClassAddForm.addForm(frmchuyentien, pnlNguoidung);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh, pnlNguoidung);
            DOAN_Nhom4.ClassAddForm.addForm(frmtrangchu, pnlNguoidung);
        }

        private void btnTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh, pnlNguoidung);
            DOAN_Nhom4.ClassAddForm.addForm(frmtietkiem, pnlNguoidung);
        }

        private void btnTienich_Click(object sender, EventArgs e)
        {
            FrmTienIch frmTienIch = new FrmTienIch(kh, tknh, pnlNguoidung);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIch, pnlNguoidung);
        }

        private void pBThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ptbMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCaidat_Click(object sender, EventArgs e)
        {
            FrmBaomat frmBaomat = new FrmBaomat(kh, tknh, pnlNguoidung);
            DOAN_Nhom4.ClassAddForm.addForm(frmBaomat, pnlNguoidung);
        }
    }
}
