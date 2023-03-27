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
        public FrmTienIch()
        {
            InitializeComponent();
        }

        public FrmTienIch(NguoiDung kh, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
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
            lblTenTK.Text = kh.TenTK.ToString();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(kh, tknh);
            this.Hide();
            frmTienIchVay.ShowDialog();
            this.Close();
        }

        private void ptbVayTien_Click(object sender, EventArgs e)
        {
            panel5_Click(sender, e);
        }

        private void lblVayTien_Click(object sender, EventArgs e)
        {
            panel5_Click(sender, e);
        }
    }
}
