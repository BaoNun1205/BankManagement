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
        NguoiDungDAO khachHangDAO = new NguoiDungDAO();
        public FrmXacnhanChuyentien()
        {
            InitializeComponent();
            pnlXacnhanChuyentien.Parent = picBoxXacnhanChuyentien;
            pnlXacnhanChuyentien.BackColor = Color.Transparent;
            this.txtMatkhau.PasswordChar = '*';
        }

        public FrmXacnhanChuyentien(NguoiDung nguoiDung)
        {
            InitializeComponent();
            pnlXacnhanChuyentien.Parent = picBoxXacnhanChuyentien;
            pnlXacnhanChuyentien.BackColor = Color.Transparent;
            this.txtMatkhau.PasswordChar = '*';
            this.nguoiDung = nguoiDung;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(nguoiDung);
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        /*private void btnXacnhan_Click(object sender, EventArgs e)
        {
            NguoiDung nguoiGui = nguoiDung;
            if (txtMatkhau.Text == nguoiGui.Pass)
            {
                NguoiDung khachHangNhan = new NguoiDung(chuyenTien.SoTk);
                khachHangDAO.GuiTien(nguoiGui, chuyenTien, khachHangNhan);
                FrmThongbaoChuyentien frmThongbaoChuyentien = new FrmThongbaoChuyentien(nguoiDung);
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
        }*/
    }
}
