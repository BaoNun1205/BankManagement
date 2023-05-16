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
        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        public FrmTienIch()
        {
            InitializeComponent();
        }

        public FrmTienIch(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh);
            this.Hide();
            frmtrangchu.ShowDialog();
            this.Close();
        }

        private void FrmTienIch_Load(object sender, EventArgs e)
        {
        }

        private void panelVayTien_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(kh, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIchVay, pnlNguoiDung);
        }

        private void ptbVayTien_Click(object sender, EventArgs e)
        {
            panelVayTien_Click(sender, e);
        }

        private void lblVayTien_Click(object sender, EventArgs e)
        {
            panelVayTien_Click(sender, e);
        }

        private void panelTinDung_Click(object sender, EventArgs e)
        {
            FrmTienIchTinDung frmTienIchTinDung = new FrmTienIchTinDung(kh, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIchTinDung, pnlNguoiDung);
        }

        private void lblTinDung_Click(object sender, EventArgs e)
        {
            panelTinDung_Click(sender, e);
        }

        private void ptbTinDung_Click(object sender, EventArgs e)
        {
            panelTinDung_Click(sender, e);
        }

        private void ptbTietkiem_Click(object sender, EventArgs e)
        {
            panelTietkiem_Click(sender, e);
        }

        private void panelTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh, pnlNguoiDung);
            Utility.addForm(frmtietkiem, pnlNguoiDung);
        }

        private void lblTietkiem_Click(object sender, EventArgs e)
        {
            panelTietkiem_Click(sender, e);
        }

        private void pnlNapTienDienThoai_Click(object sender, EventArgs e)
        {
            FrmNapTienDienThoai frmNapTienDienThoai = new FrmNapTienDienThoai(kh, tknh, pnlNguoiDung);
            Utility.addForm(frmNapTienDienThoai, pnlNguoiDung);
        }

        private void ptbNapTienDienThoai_Click(object sender, EventArgs e)
        {
            pnlNapTienDienThoai_Click(sender, e);
        }

        private void lblNapDienThoai_Click(object sender, EventArgs e)
        {
            pnlNapTienDienThoai_Click(sender, e);
        }
    }
}
