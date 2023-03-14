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
        public GiaoDichChuyenTien gdChuyenTien;
        public NguoiDung kh;
        public TaiKhoangNganHang tknh;
        TaiKhoangNganHangDAO tknhDAO = new TaiKhoangNganHangDAO();
        public FrmXacnhanChuyentien()
        {
            InitializeComponent();
            pnlXacnhanChuyentien.Parent = picBoxXacnhanChuyentien;
            pnlXacnhanChuyentien.BackColor = Color.Transparent;
            this.txtMatkhau.PasswordChar = '*';
        }

        public FrmXacnhanChuyentien(NguoiDung kh, TaiKhoangNganHang tknh)
        {
            InitializeComponent();
            pnlXacnhanChuyentien.Parent = picBoxXacnhanChuyentien;
            pnlXacnhanChuyentien.BackColor = Color.Transparent;
            this.txtMatkhau.PasswordChar = '*';
            this.kh = kh;
            this.tknh = tknh;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(kh, tknh);
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.Text == tknh.MatKhau)
            {
                TaiKhoangNganHang tknhNhan = new TaiKhoangNganHang(gdChuyenTien.SoTk);
                tknhDAO.GuiTien(tknh, gdChuyenTien, tknhNhan);
                tknh = tknhDAO.LayTaiKhoanNganHang("SoTK", tknh.SoTK);
                FrmThongbaoChuyentien frmThongbaoChuyentien = new FrmThongbaoChuyentien(kh, gdChuyenTien, tknh);
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
