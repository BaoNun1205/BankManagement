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
        private static string tenTK;
        public FrmChuyentien()
        {
            InitializeComponent();
            pnlChuyentien.Parent = picBoxChuyentien;
            pnlChuyentien.BackColor = Color.Transparent;
        }
        DBConnection dBConnection = new DBConnection();
        private void FrmChuyentien_Load(object sender, EventArgs e)
        {
            KhachHang kh = LayKhachHang();
            lblSoDu.Text = kh.SoDu.ToString();
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
            if (lblTenTK.Text != "Khong ton tai" && int.Parse(lblSoDu.Text) > int.Parse(txtSoTien.Text))
            {
                ChuyenTien chuyenTien = new ChuyenTien(tenTK, txtSTK.Text, int.Parse(txtSoTien.Text), cbTenNH.Text , txtLoiNhan.Text);
                FrmXacnhanChuyentien frmxacnhan = new FrmXacnhanChuyentien();
                frmxacnhan.chuyenTien = chuyenTien;
                frmxacnhan.khChuyenTien = LayKhachHang();
                this.Hide();
                frmxacnhan.ShowDialog();
                this.Close();
            }
            else
            {
                if (lblTenTK.Text == "Khong ton tai")
                    MessageBox.Show("Tai khoang khong ton tai");
                else
                    MessageBox.Show("So Du cua ban khong du");
            }
        }

        private void txtSTK_TextChanged(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh = dBConnection.LayKhachHang("SoTK", txtSTK.Text);
            if (kh != null)
            {
                lblTenTK.Text = kh.TenTK.ToString();
                tenTK = kh.TenTK.ToString();
            }                   
            else
                lblTenTK.Text = "Khong ton tai";
        } 
    }
}
