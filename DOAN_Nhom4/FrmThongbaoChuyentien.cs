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
        public NguoiDung nguoiDung;
        public TaiKhoangNganHang tknh;
        public GiaoDichChuyenTien gdchuyentien;
        public FrmThongbaoChuyentien()
        {
            InitializeComponent();
        }

        public FrmThongbaoChuyentien(NguoiDung nguoiDung, GiaoDichChuyenTien gdchuyentien, TaiKhoangNganHang tknh)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.gdchuyentien = gdchuyentien;
            this.tknh = tknh;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmThongbaoChuyentien_Load(object sender, EventArgs e)
        {
            lblSotien.Text = gdchuyentien.SoTien.ToString() + " VNĐ";
            lblTime.Text = DateTime.Now.ToString();
            lblNguoinhan.Text = gdchuyentien.TenTK.ToString();
            lblSTK.Text = gdchuyentien.SoTk.ToString();
            lblNganhang.Text = gdchuyentien.NganHang.ToString();
            lblNoidung.Text = gdchuyentien.LoiNhan.ToString();
        }
        private void picBoxQuaylai_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung(nguoiDung, tknh);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }

        private void lblQuaylai_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung(nguoiDung, tknh);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }
    }
}
