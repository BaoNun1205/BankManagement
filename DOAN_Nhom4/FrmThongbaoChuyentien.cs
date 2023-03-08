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
        public ChuyenTien chuyenTien;
        public FrmThongbaoChuyentien()
        {
            InitializeComponent();
        }

        public FrmThongbaoChuyentien(NguoiDung nguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmThongbaoChuyentien_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            lblNguoinhan.Text = chuyenTien.TenTK.ToString();
            lblSTK.Text = chuyenTien.SoTk.ToString();
            lblNganhang.Text = chuyenTien.NganHang.ToString();
            lblNoidung.Text = chuyenTien.LoiNhan.ToString();
        }
        private void picBoxQuaylai_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung(nguoiDung);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }

        private void lblQuaylai_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung(nguoiDung);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }
    }
}
