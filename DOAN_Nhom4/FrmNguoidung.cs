using DOAN_Nhom4.Entities;
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
        public KhachHang kh;
        public TaiKhoanNganHang tknh;
        public KhachHangVay ttNgDung;
        private TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FrmNguoidung()
        {
            InitializeComponent();
        }

        public FrmNguoidung(KhachHang kh, TaiKhoanNganHang tknh)
        {
            InitializeComponent();         
            this.kh = kh;
            this.tknh = tknh;
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh, pnlNguoidung);
            Utility.addForm(frmtrangchu, pnlNguoidung);
        }

        private void FrmNguoidung_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = kh.TenKh.ToString();
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan(kh, tknh);
            Utility.addForm(frmHienThiThongTinCaNhan, pnlNguoidung);
        }

        private void btnChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(kh, tknh, pnlNguoidung);
            Utility.addForm(frmchuyentien, pnlNguoidung);
        }

        private void pbTrangChu_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh, pnlNguoidung);
            Utility.addForm(frmtrangchu, pnlNguoidung);
        }

        private void btnTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh, pnlNguoidung);
            Utility.addForm(frmtietkiem, pnlNguoidung);
        }

        private void btnTienich_Click(object sender, EventArgs e)
        {
            FrmTienIch frmTienIch = new FrmTienIch(kh, tknh, pnlNguoidung);
            Utility.addForm(frmTienIch, pnlNguoidung);
        }

        private void pbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBaomat_Click(object sender, EventArgs e)
        {
            FrmBaomat frmBaomat = new FrmBaomat(kh, tknh, pnlNguoidung);
            Utility.addForm(frmBaomat, pnlNguoidung);
            pnlLuachonCD.Visible = false;
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult luachon = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (luachon == DialogResult.Yes)
            {
                FrmDangnhap frmDangnhap = new FrmDangnhap();
                this.Hide();
                frmDangnhap.ShowDialog();
                this.Close();
            }
            else pnlLuachonCD.Visible = false;
        }

        private void btnCaidat_Click(object sender, EventArgs e)
        {
            if (pnlLuachonCD.Visible == true) pnlLuachonCD.Visible = false;
            else pnlLuachonCD.Visible = true;
        }

        private void btnLsgd_Click(object sender, EventArgs e)
        {
            FrmLichSuGiaoDich frmLichSuGiaoDich = new FrmLichSuGiaoDich(kh, pnlNguoidung);
            Utility.addForm(frmLichSuGiaoDich, pnlNguoidung);
        }

        private void pnlTrendau_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
