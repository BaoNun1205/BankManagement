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
    public partial class FrmBaoMat : Form
    {
        public FrmBaoMat()
        {
            InitializeComponent();
            ChangeLabel(lbl_tenDN, pb_baomat);
            ChangeLabel(lbl_matKhau, pb_baomat);
            ChangeCheckbox(cb_hienthipass, pb_baomat);
        }

        private void FrmBaoMat_Load(object sender, EventArgs e)
        {
            
        }
        public void ChangeLabel(Label x, PictureBox y)
        {
            var a = this.PointToScreen(x.Location);
            a = y.PointToClient(a);
            x.Parent = y;
            x.Location = a;
            x.BackColor = Color.Transparent;
        }
        public void ChangeCheckbox(CheckBox x, PictureBox y)
        {
            var a = this.PointToScreen(x.Location);
            a = y.PointToClient(a);
            x.Parent = y;
            x.Location = a;
            x.BackColor = Color.Transparent;
        }
    }
}
