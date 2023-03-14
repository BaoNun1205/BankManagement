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
    public partial class FrmTietkiem : Form
    {
        public NguoiDung ngdung;
        public FrmTietkiem()
        {
            InitializeComponent();
        }

        public FrmTietkiem(NguoiDung ngdung)
        {
            InitializeComponent();
            this.ngdung = ngdung;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void picBoxQuaylai_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung(ngdung);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }
    }
}
