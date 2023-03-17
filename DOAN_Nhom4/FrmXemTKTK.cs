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
    public partial class FrmXemTKTK : Form
    {
        TietkiemDAO tietkiemDAO = new TietkiemDAO();
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        public FrmXemTKTK()
        {
            InitializeComponent();
        }

        public FrmXemTKTK(NguoiDung kh, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            HienThi();
        }
        private void FrmXemTKTK_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        public void HienThi()
        {
            gvTKTK.DataSource = tietkiemDAO.LayDanhSachTKTK();
        }

        private void picBoxQuaylai_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh);
            Hide();
            frmtietkiem.ShowDialog();
            Close();
        }

        private void pnlTietkiem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
