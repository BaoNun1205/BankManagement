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
    public partial class FrmTienIchVay : Form
    {
        public FrmTienIchVay()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmVay frmVay = new FrmVay();
            frmVay.ShowDialog();
            frmVay = null;
            this.Show();
        }

        private void btn_XemKhoanVay_Click(object sender, EventArgs e)
        {

        }
    }
}
