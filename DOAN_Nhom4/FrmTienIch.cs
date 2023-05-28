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
    public partial class FrmTienIch : Form
    {
        private KhachHang kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        public FrmTienIch()
        {
            InitializeComponent();
        }

        public FrmTienIch(KhachHang kh, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void pbTrangChu_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu();
            this.Hide();
            frmtrangchu.ShowDialog();
            this.Close();
        }

        private void pnlVayTien_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(kh, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIchVay, pnlNguoiDung);
        }

        private void pbVayTien_Click(object sender, EventArgs e)
        {
            pnlVayTien_Click(sender, e);
        }

        private void lblVayTien_Click(object sender, EventArgs e)
        {
            pnlVayTien_Click(sender, e);
        }

        private void pnlTinDung_Click(object sender, EventArgs e)
        {
            FrmTienIchTinDung frmTienIchTinDung = new FrmTienIchTinDung(kh, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIchTinDung, pnlNguoiDung);
        }

        private void lblTinDung_Click(object sender, EventArgs e)
        {
            pnlTinDung_Click(sender, e);
        }

        private void pbTinDung_Click(object sender, EventArgs e)
        {
            pnlTinDung_Click(sender, e);
        }

        private void pbTietkiem_Click(object sender, EventArgs e)
        {
            pnlTietkiem_Click(sender, e);
        }

        private void pnlTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh, pnlNguoiDung);
            Utility.addForm(frmtietkiem, pnlNguoiDung);
        }

        private void lblTietkiem_Click(object sender, EventArgs e)
        {
            pnlTietkiem_Click(sender, e);
        }

        private void pnlNapTienDienThoai_Click(object sender, EventArgs e)
        {
            FrmNapTienDienThoai frmNapTienDienThoai = new FrmNapTienDienThoai(kh, tknh, pnlNguoiDung);
            Utility.addForm(frmNapTienDienThoai, pnlNguoiDung);
        }

        private void pbNapTienDienThoai_Click(object sender, EventArgs e)
        {
            pnlNapTienDienThoai_Click(sender, e);
        }

        private void lblNapDienThoai_Click(object sender, EventArgs e)
        {
            pnlNapTienDienThoai_Click(sender, e);
        }
    }
}
