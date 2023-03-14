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
    public partial class FrmBaomat : Form
    {
        public NguoiDung ngdung;
        public TaiKhoanNganHang tknh;
        public FrmBaomat()
        {
            InitializeComponent();
        }

        public FrmBaomat(NguoiDung ngdung, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            this.ngdung = ngdung;
            this.tknh = tknh;
        }

        private void pn_baomat_Paint(object sender, PaintEventArgs e)
        {
            txtTenDN.Text = tknh.TenDN;
            txtMatkhau.Text = tknh.MatKhau;
        }

        private void cb_hienthipass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienthipass.Checked)
            {
                txtMatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatkhau.UseSystemPasswordChar = true;
            }
        }
        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            FrmDoimatkhau frmdoimk = new FrmDoimatkhau(ngdung, tknh);
            this.Hide();
            frmdoimk.ShowDialog();
            this.Close();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            FrmDangnhap frmDangnhap = new FrmDangnhap();
            this.Hide();
            frmDangnhap.ShowDialog();
            this.Close();
        }

        private void pb_QuayLai_Click(object sender, EventArgs e)
        {
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan(ngdung, tknh);
            this.Hide();
            frmHienThiThongTinCaNhan.ShowDialog();
            this.Close();
        }
    }
}
