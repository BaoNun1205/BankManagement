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
    public partial class FrmHienThiThongTinCaNhan : Form
    {
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        public FrmHienThiThongTinCaNhan()
        {
            InitializeComponent();
        }

        public FrmHienThiThongTinCaNhan(NguoiDung kh, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
        }
        private void FrmHienThiThongTinCaNhan_Load(object sender, EventArgs e)
        {
            lblChuTKValue.Text = kh.TenTK.ToString();
            lblSoTkValue.Text = kh.SoTK.ToString();
            lblSoDuValue.Text = tknh.SoDu.ToString() + " VNĐ";
            lblCccdValue.Text = kh.Cccd.ToString();
            lblNgaySinhValue.Text = kh.NgaySinh.ToString("dd/MM/yyyy");
            lblSdtValue.Text = kh.Sdt.ToString();
        }

        private void btnChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(kh, tknh);
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void btnTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh);
            this.Hide();
            frmtietkiem.ShowDialog();
            this.Close();
        }

        private void btnTienich_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh);
            this.Hide();
            frmtrangchu.ShowDialog();
            this.Close();
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
