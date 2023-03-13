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
        public ChuyenTien chuyenTien;
        public NguoiDung nguoiDung;
        public TaiKhoangNganHang tknh;
        TaiKhoangNganHangDAO tknhDAO = new TaiKhoangNganHangDAO();
        public FrmXacnhanChuyentien()
        {
            InitializeComponent();
            pnlXacnhanChuyentien.Parent = picBoxXacnhanChuyentien;
            pnlXacnhanChuyentien.BackColor = Color.Transparent;
            this.txtMatkhau.PasswordChar = '*';
        }

        public FrmXacnhanChuyentien(NguoiDung nguoiDung, TaiKhoangNganHang tknh)
        {
            InitializeComponent();
            pnlXacnhanChuyentien.Parent = picBoxXacnhanChuyentien;
            pnlXacnhanChuyentien.BackColor = Color.Transparent;
            this.txtMatkhau.PasswordChar = '*';
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(nguoiDung, tknh);
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {   
            if (txtMatkhau.Text == tknh.MatKhau)
            {
                TaiKhoangNganHang tknhNhan = new TaiKhoangNganHang(chuyenTien.SoTk);
                tknhDAO.GuiTien(tknh, chuyenTien, tknhNhan);
                tknh = tknhDAO.LayTaiKhoanNganHang("SoTK", tknh.SoTK);
                FrmThongbaoChuyentien frmThongbaoChuyentien = new FrmThongbaoChuyentien(nguoiDung, tknh);
                frmThongbaoChuyentien.chuyenTien = chuyenTien;
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
