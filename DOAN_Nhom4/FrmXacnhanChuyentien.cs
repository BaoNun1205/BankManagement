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
    public partial class FrmXacnhanChuyentien : Form
    {
        public ChuyenTien chuyenTien { get; set; }
        public KhachHang khChuyenTien { get; set; }
        public FrmXacnhanChuyentien()
        {
            InitializeComponent();
            pnlXacnhanChuyentien.Parent = picBoxXacnhanChuyentien;
            pnlXacnhanChuyentien.BackColor = Color.Transparent;
            this.txtMatkhau.PasswordChar = '*';
        }
        KhachHangDAO khachHangDAO = new KhachHangDAO();

        private KhachHang LayKhachHang()
        {
            KhachHang kh = new KhachHang(khChuyenTien.SoTK, khChuyenTien.TenTK, khChuyenTien.TenDN, khChuyenTien.Pass, khChuyenTien.NgaySinh, khChuyenTien.Cccd, khChuyenTien.Sdt, khChuyenTien.SoDu);
            return kh;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien();
            frmchuyentien.khNguoiDung = LayKhachHang();
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            KhachHang khachHangGui = LayKhachHang();
            if (txtMatkhau.Text == khachHangGui.Pass)
            {
                ChuyenTien ct = new ChuyenTien(chuyenTien.SoTk, chuyenTien.SoTien, chuyenTien.LoiNhan);
                KhachHang khachHangNhan = new KhachHang(chuyenTien.SoTk);
                khachHangDAO.GuiTien(khachHangGui, ct, khachHangNhan);
                FrmThongbaoChuyentien frmThongbaoChuyentien = new FrmThongbaoChuyentien();
                frmThongbaoChuyentien.khXacNhanChuyenTien = LayKhachHang();
                this.Hide();
                frmThongbaoChuyentien.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai mat khau");
                txtMatkhau.Text = "";
            }
        }
    }
}
