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
        public GiaoDichChuyenTien gdchuyentien;
        public NguoiDung nguoiDung;
        NguoiDungDAO ngdungDAO = new NguoiDungDAO();
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

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            NguoiDung nguoiGui = nguoiDung;
            if (txtMatkhau.Text == nguoiGui.MatKhau)
            {
                NguoiDung nguoiNhan = new NguoiDung(gdchuyentien.STKNgnhan);
                ngdungDAO.GuiTien(nguoiGui, gdchuyentien, nguoiNhan);
                FrmThongbaoChuyentien frmThongbaoChuyentien = new FrmThongbaoChuyentien(nguoiDung, gdchuyentien);
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
