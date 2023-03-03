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
    public partial class FrmXacnhanChuyentien : Form
    {
        private string STK;
        private string SoTien;
        private string LoiNhan;
        public FrmXacnhanChuyentien(string stk, string soTien, string loiNhan)
        {
            InitializeComponent();
            pnlXacnhanChuyentien.Parent = picBoxXacnhanChuyentien;
            pnlXacnhanChuyentien.BackColor = Color.Transparent;
            this.txtMatkhau.PasswordChar = '*';
            STK = stk;
            SoTien = soTien;
            LoiNhan = loiNhan;
        }
        KhachHangDAO khachHangDAO = new KhachHangDAO();

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien();
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            ChuyenTien chuyenTien = new ChuyenTien(STK, SoTien, LoiNhan);
            KhachHang khachHang = new KhachHang(STK);
            khachHangDAO.ThemTien(khachHang, chuyenTien);
        }
    }
}
