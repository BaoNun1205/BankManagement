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
        private Panel pnlNguoiDung;
        public FrmBaomat()
        {
            InitializeComponent();
        }

        public FrmBaomat(NguoiDung ngdung, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.ngdung = ngdung;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
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
            FrmDoimatkhau frmDoiMatKhau = new FrmDoimatkhau(ngdung, tknh, pnlNguoiDung);
            DOAN_Nhom4.Utility.addForm(frmDoiMatKhau, pnlNguoiDung);
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            FrmDangnhap frmDangnhap = new FrmDangnhap();
            Application.OpenForms["frmBaoMat"].Hide();
            Application.OpenForms["frmNguoiDung"].Hide();
            frmDangnhap.ShowDialog();
            Application.OpenForms["frmBaoMat"].Close();
            Application.OpenForms["frmNguoiDung"].Close();
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {
            txtMatkhau.UseSystemPasswordChar = true;
        }
    }
}
