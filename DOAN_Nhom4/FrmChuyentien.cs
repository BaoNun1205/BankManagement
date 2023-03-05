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
    public partial class FrmChuyentien : Form
    {
        public FrmChuyentien()
        {
            InitializeComponent();
            pnlChuyentien.Parent = picBoxChuyentien;
            pnlChuyentien.BackColor = Color.Transparent;

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung();
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            string stk = txtSTK.Text;
            string soTien = txtSoTien.Text;
            string loiNhan = txtLoiNhan.Text;
            FrmXacnhanChuyentien frmxacnhan = new FrmXacnhanChuyentien(stk, soTien, loiNhan);
            this.Hide();
            frmxacnhan.ShowDialog();
            this.Close();
        }

        private void txtSTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
