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
    public partial class FrmLichSuGiaoDich : Form
    {
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        public GiaoDichChuyenTien gd;
        public FrmLichSuGiaoDich()
        {
            InitializeComponent();
        }

        public FrmLichSuGiaoDich(NguoiDung kh, GiaoDichChuyenTien gd, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            this.kh = kh;
            this.gd = gd;
            this.tknh = tknh;
        }

        private void picBoxQuaylai_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh, gd);
            this.Hide();
            frmtrangchu.ShowDialog();
            this.Close();
        }
    }
}
