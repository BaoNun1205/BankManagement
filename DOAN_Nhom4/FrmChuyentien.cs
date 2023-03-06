using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmChuyentien : Form
    {
        public KhachHang khNguoiDung { get; set; }
        public FrmChuyentien()
        {
            InitializeComponent();
            pnlChuyentien.Parent = picBoxChuyentien;
            pnlChuyentien.BackColor = Color.Transparent;
        }
        private KhachHang LayKhachHang()
        {
            KhachHang kh = new KhachHang(khNguoiDung.SoTK, khNguoiDung.TenTK, khNguoiDung.TenDN, khNguoiDung.Pass, khNguoiDung.NgaySinh, khNguoiDung.Cccd, khNguoiDung.Sdt, khNguoiDung.SoDu);
            return khNguoiDung;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung();
            frmnguoidung.khDangNhap = LayKhachHang();
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            ChuyenTien chuyenTien = new ChuyenTien(txtSTK.Text, int.Parse(txtSoTien.Text), txtLoiNhan.Text);
            FrmXacnhanChuyentien frmxacnhan = new FrmXacnhanChuyentien();
            frmxacnhan.chuyenTien = chuyenTien;
            frmxacnhan.khChuyenTien = LayKhachHang();
            this.Hide();
            frmxacnhan.ShowDialog();
            this.Close();
        }

        private void txtSTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlChuyentien_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
