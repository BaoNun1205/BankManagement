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
    public partial class FrmThongbaoChuyentien : Form
    {
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        public GiaoDichChuyenTien gd;
        public FrmThongbaoChuyentien()
        {
            InitializeComponent();
        }

        public FrmThongbaoChuyentien(NguoiDung kh, GiaoDichChuyenTien gd, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            this.kh = kh;
            this.gd = gd;
            this.tknh = tknh;
        }
        private void FrmThongbaoChuyentien_Load(object sender, EventArgs e)
        {
            lblSotien.Text = gd.SoTien.ToString() + " VNĐ";
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblNguoinhan.Text = gd.TenTKNhan.ToString();
            lblSTK.Text = gd.SoTKNhan.ToString();
            lblNganhang.Text = gd.NganHang.ToString();
            lblNoidung.Text = gd.LoiNhan.ToString();
        }
        private void picBoxQuaylai_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh, gd);
            this.Hide();
            frmtrangchu.ShowDialog();
            this.Close();
        }

        private void lblQuaylai_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh, gd);
            this.Hide();
            frmtrangchu.ShowDialog();
            this.Close();
        }
    }
}
