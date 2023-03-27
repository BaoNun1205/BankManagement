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
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
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

        private void gvTKTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gvTKTK.CurrentRow.Index;
            lblID.Text = gvTKTK.Rows[i].Cells[0].Value.ToString();
            lblTenTKTK.Text = gvTKTK.Rows[i].Cells[1].Value.ToString();
            txtTiengoc.Text = gvTKTK.Rows[i].Cells[2].Value.ToString();
            txtKihan.Text = gvTKTK.Rows[i].Cells[3].Value.ToString();
            lblLaisuat.Text = gvTKTK.Rows[i].Cells[4].Value.ToString();
            lblTienlai.Text = gvTKTK.Rows[i].Cells[5].Value.ToString();
            lblTongtien.Text = gvTKTK.Rows[i].Cells[6].Value.ToString();
        }

        private void btnRuttien_Click(object sender, EventArgs e)
        {
            TietKiem tkiem = new TietKiem(int.Parse(lblID.Text), lblTenTKTK.Text, int.Parse(txtTiengoc.Text), int.Parse(txtKihan.Text), double.Parse(lblLaisuat.Text), double.Parse(lblTienlai.Text), double.Parse(lblTongtien.Text));
            tknh.SoDu = tknh.SoDu + tkiem.TienGoc;
            tknhDAO.Sua(tknh);
            tietkiemDAO.Xoa(tkiem);
            MessageBox.Show("Rút tiền trong tài khoản tiết kiệm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
        }
    }
}
