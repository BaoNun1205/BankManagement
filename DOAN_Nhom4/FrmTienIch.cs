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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh);
            this.Hide();
            frmtrangchu.ShowDialog();
            this.Close();
        }

        private void lblNapDienThoai_Click(object sender, EventArgs e)
        {

        }

        private void FrmTienIch_Load(object sender, EventArgs e)
        {
        }

        private void panelVayTien_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(kh, tknh, pnlNguoiDung);
            addForm(frmTienIchVay);
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
            FrmDangKyTinDung frmDangKyTinDung = new FrmDangKyTinDung(kh, tknh, pnlNguoiDung);
            addForm(frmDangKyTinDung);
        }

        private void lblTinDung_Click(object sender, EventArgs e)
        {
            panelTinDung_Click(sender, e);
        }

        private void ptbTinDung_Click(object sender, EventArgs e)
        {
            panelTinDung_Click(sender, e);
        }
    }
}
