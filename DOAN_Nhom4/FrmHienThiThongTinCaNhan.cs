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
        public TaiKhoangNganHang tknh;
        public FrmHienThiThongTinCaNhan()
        {
            InitializeComponent();
        }

        public FrmHienThiThongTinCaNhan(NguoiDung kh, TaiKhoangNganHang tknh)
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

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmnguoidung = new FrmTrangchu(kh, tknh);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }

        private void pb_quaylai_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmnguoidung = new FrmTrangchu(kh, tknh);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }

        private void btnBaomat_Click(object sender, EventArgs e)
        {
            FrmBaomat frmbaomat = new FrmBaomat(kh, tknh);
            this.Hide();
            frmbaomat.ShowDialog();
            this.Close();
        }
    }
}
