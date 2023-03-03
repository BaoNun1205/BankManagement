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
    public partial class FrmChuyenTienNoi : Form
    {
        public FrmChuyenTienNoi()
        {
            InitializeComponent();
        }
        KhachHangDAO khachHangDAO = new KhachHangDAO();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            ChuyenTien chuyenTien = new ChuyenTien(txtStk.Text, txtSoTien.Text, txtLoiNhan.Text);
            KhachHang khachHang = new KhachHang(txtStk.Text);
            khachHangDAO.ThemTien(khachHang, chuyenTien);
        }
    }
}
