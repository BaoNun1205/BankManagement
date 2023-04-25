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
    public partial class FrmQLTKVay : Form
    {
        public FrmQLTKVay()
        {
            InitializeComponent();
        }

        private void btn_KhoanDangVay_Click(object sender, EventArgs e)
        {
            FrmQuanLyVayAdmin frmql = new FrmQuanLyVayAdmin();
            this.Hide();
            frmql.ShowDialog();
            this.Close();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FrmAdmin fradm = new FrmAdmin();
            this.Hide();
            fradm.ShowDialog();
            this.Close();
        }

        private void btn_KhoanTungVay_Click(object sender, EventArgs e)
        {
            FrmCacKhoanDaVay frmkhoandavay = new FrmCacKhoanDaVay();
            this.Hide();
            frmkhoandavay.ShowDialog();
            this.Close();
        }
    }
}
