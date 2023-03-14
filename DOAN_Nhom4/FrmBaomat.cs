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
        public NguoiDung kh;
        public TaiKhoangNganHang tknh;
        public FrmBaomat()
        {
            InitializeComponent();
        }

        public FrmBaomat(NguoiDung kh, TaiKhoangNganHang tknh)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan(kh, tknh);
            this.Hide();
            frmHienThiThongTinCaNhan.ShowDialog();
            this.Close();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            FrmDoimatkhau frmdoimk = new FrmDoimatkhau(kh, tknh);
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
    }
}
