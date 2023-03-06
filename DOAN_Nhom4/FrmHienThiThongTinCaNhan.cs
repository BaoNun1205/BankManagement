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
        public KhachHang khNguoiDung { get; set; }
        public FrmHienThiThongTinCaNhan()
        {
            InitializeComponent();
        }
        private KhachHang LayKhachHang()
        {
            KhachHang kh = new KhachHang(khNguoiDung.SoTK, khNguoiDung.TenTK, khNguoiDung.TenDN, khNguoiDung.Pass, khNguoiDung.NgaySinh, khNguoiDung.Cccd, khNguoiDung.Sdt, khNguoiDung.SoDu);
            return khNguoiDung;
        }
        private void FrmHienThiThongTinCaNhan_Load(object sender, EventArgs e)
        {
            lblChuTKValue.Text = khNguoiDung.TenTK.ToString();
            lblSoTkValue.Text = khNguoiDung.SoTK.ToString();
            lblSoDuValue.Text = khNguoiDung.SoDu.ToString();
            lblCccdValue.Text = khNguoiDung.Cccd.ToString();
            lblNgaySinhValue.Text = khNguoiDung.NgaySinh.ToString();
            lblSdtValue.Text = khNguoiDung.Sdt.ToString();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung();
            frmnguoidung.khDangNhap = LayKhachHang();
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }
    }
}
