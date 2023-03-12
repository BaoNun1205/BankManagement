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
    public partial class FrmDangky : Form
    {
        NguoiDungDAO khachHangDAO = new NguoiDungDAO();
        public FrmDangky()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmDangnhap frmdangnhap = new FrmDangnhap();
            this.Hide();
            frmdangnhap.ShowDialog();
            this.Close();
        }
        /*private void btnXacnhan_Click(object sender, EventArgs e)
        {
            NguoiDung kh = new NguoiDung(txtSoTK.Text, txtTenTK.Text, txtTenDN.Text, txtMatkhau.Text, timeNgaySinh.Value, txtCCCD.Text, txtSDT.Text, 100000);
            khachHangDAO.Them(kh);
            FrmDangnhap frmdangnhap = new FrmDangnhap();
            this.Hide();
            frmdangnhap.ShowDialog();
            this.Close();
        }*/
    }
}
