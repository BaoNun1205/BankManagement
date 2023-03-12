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
    public partial class FrmDoimatkhau : Form
    {
        public NguoiDung ngdung;
        public FrmDoimatkhau()
        {
            InitializeComponent();
        }

        public FrmDoimatkhau(NguoiDung ngdung)
        {
            InitializeComponent();
            this.ngdung = ngdung;
        }
        private void picBoxQuaylai_Click(object sender, EventArgs e)
        {
            FrmBaomat frmbaomat = new FrmBaomat(ngdung);
            this.Hide();
            frmbaomat.ShowDialog();
            this.Close();
        }
    }
}
