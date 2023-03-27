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
    public partial class FrmTienIch : Form
    {
        private NguoiDung kh;
        public FrmTienIch()
        {
            InitializeComponent();
        }

        public FrmTienIch(NguoiDung kh)
        {
            InitializeComponent();
            this.kh = kh;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblNapDienThoai_Click(object sender, EventArgs e)
        {

        }

        private void FrmTienIch_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = kh.TenTK.ToString();
        }
    }
}
