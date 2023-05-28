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
    public partial class FrmAdminDichVu : Form
    {
        public FrmAdminDichVu()
        {
            InitializeComponent();
        }

        private void FrmAdminDichVu_Load(object sender, EventArgs e)
        {
            NapTien nt = new NapTien();
            Utility.addUserControl(nt, pnlDichvu);
        }

        private void btn_NapTien_Click(object sender, EventArgs e)
        {
            NapTien nt = new NapTien();
            Utility.addUserControl(nt, pnlDichvu);
        }

        private void btn_RutTien_Click(object sender, EventArgs e)
        {
            RutTien rt = new RutTien();
            Utility.addUserControl(rt, pnlDichvu);
        }

        private void btn_ChuyenTien_Click(object sender, EventArgs e)
        {
            ChuyenTien ct = new ChuyenTien();
            Utility.addUserControl(ct, pnlDichvu);
        }

        private void pb_QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdmin frmad = new FrmAdmin();    
            frmad.ShowDialog();
            this.Close();
        }

    }
}
