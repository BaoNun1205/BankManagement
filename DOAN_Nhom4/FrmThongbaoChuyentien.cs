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
        public KhachHang khXacNhanChuyenTien { get; set; }
        public ChuyenTien chuyenTien { get; set; }
        public FrmThongbaoChuyentien()
        {
            InitializeComponent();
        }
        private KhachHang LayKhachHang()
        {
            KhachHang khNguoiDung = new KhachHang(khXacNhanChuyenTien.SoTK, khXacNhanChuyenTien.TenTK, khXacNhanChuyenTien.TenDN, khXacNhanChuyenTien.Pass, khXacNhanChuyenTien.NgaySinh, khXacNhanChuyenTien.Cccd, khXacNhanChuyenTien.Sdt, khXacNhanChuyenTien.SoDu);
            return khNguoiDung;
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
            FrmNguoidung frmnguoidung = new FrmNguoidung();
            frmnguoidung.khDangNhap = LayKhachHang();
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }

        private void lblQuaylai_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung();
            frmnguoidung.khDangNhap = LayKhachHang();
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }
    }
}
