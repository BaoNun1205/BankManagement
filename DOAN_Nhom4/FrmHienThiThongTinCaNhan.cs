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
        public NguoiDung nguoiDung;
        public FrmHienThiThongTinCaNhan()
        {
            InitializeComponent();
        }

        public FrmHienThiThongTinCaNhan(NguoiDung nguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
        }
        private void FrmHienThiThongTinCaNhan_Load(object sender, EventArgs e)
        {
            lblChuTKValue.Text = nguoiDung.TenTK.ToString();
            lblSoTkValue.Text = nguoiDung.SoTK.ToString();
            lblSoDuValue.Text = nguoiDung.SoDu.ToString() + " VNĐ";
            lblCccdValue.Text = nguoiDung.Cccd.ToString();
            lblNgaySinhValue.Text = nguoiDung.NgaySinh.ToString("dd/MM/yyyy");
            lblSdtValue.Text = nguoiDung.Sdt.ToString();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung(nguoiDung);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }

        private void pb_quaylai_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung(nguoiDung);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }

        private void btnBaomat_Click(object sender, EventArgs e)
        {
            FrmBaomat frmbaomat = new FrmBaomat(nguoiDung);
            this.Hide();
            frmbaomat.ShowDialog();
            this.Close();
        }
    }
}
