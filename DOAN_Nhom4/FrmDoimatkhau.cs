using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DOAN_Nhom4
{
    public partial class FrmDoimatkhau : Form
    {
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        public Panel pnlNguoiDung;
        NguoiDungDAO ngdungDAO = new NguoiDungDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        public FrmDoimatkhau()
        {
            InitializeComponent();
        }

        public FrmDoimatkhau(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }
        private void picBoxQuaylai_Click(object sender, EventArgs e)
        {
            FrmBaomat frmBaoMat = new FrmBaomat(kh, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmBaoMat, pnlNguoiDung);
        }

        private void txt_XacNhanMatKhau_Enter(object sender, EventArgs e)
        {
            if (txt_XacNhanMatKhau.ForeColor != Color.Black)
            {
                txt_XacNhanMatKhau.Text = "";
                txt_XacNhanMatKhau.ForeColor = Color.Black;
            }
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_MatKhauCu.Text != tknh.MatKhau)
            {
                MessageBox.Show("Mật khẩu chưa chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_MatKhauMoi.Text == txt_MatKhauCu.Text)
            {
                MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
            else if (txt_XacNhanMatKhau.Text != txt_MatKhauMoi.Text) 
            {
                MessageBox.Show("Xác nhận mật khẩu chưa chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tknh.MatKhau = txt_MatKhauMoi.Text;
                tknhDAO.Sua(tknh);
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FrmDangnhap frmDangnhap = new FrmDangnhap();
                Application.OpenForms["frmBaoMat"].Hide();
                Application.OpenForms["frmNguoiDung"].Hide();
                frmDangnhap.ShowDialog();
                Application.OpenForms["frmBaoMat"].Close();
                Application.OpenForms["frmNguoiDung"].Close();
            }    
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_MatKhauCu_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_MatKhauCu.ForeColor != Color.Black)
            {
                txt_MatKhauCu.Text = "";
                txt_MatKhauCu.ForeColor = Color.Black;
            }
            if (txt_MatKhauMoi.Text == "")
            {
                txt_MatKhauMoi.Text = "Mật khẩu mới";
                txt_MatKhauMoi.ForeColor = Color.Gray;
            }
            if (txt_XacNhanMatKhau.Text == "")
            {
                txt_XacNhanMatKhau.Text = "Xác nhận mật khẩu";
                txt_XacNhanMatKhau.ForeColor = Color.Gray;
            }
        }

        private void txt_MatKhauMoi_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_MatKhauMoi.ForeColor != Color.Black)
            {
                txt_MatKhauMoi.Text = "";
                txt_MatKhauMoi.ForeColor = Color.Black;
            }
            if (txt_MatKhauCu.Text == "")
            {
                txt_MatKhauCu.Text = "Mật khẩu cũ";
                txt_MatKhauCu.ForeColor = Color.Gray;
            }
            if (txt_XacNhanMatKhau.Text == "")
            {
                txt_XacNhanMatKhau.Text = "Xác nhận mật khẩu";
                txt_XacNhanMatKhau.ForeColor = Color.Gray;
            }
        }

        private void txt_XacNhanMatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_XacNhanMatKhau.ForeColor != Color.Black)
            {
                txt_XacNhanMatKhau.Text = "";
                txt_XacNhanMatKhau.ForeColor = Color.Black;
            }
            if (txt_MatKhauCu.Text == "")
            {
                txt_MatKhauCu.Text = "Mật khẩu cũ";
                txt_MatKhauCu.ForeColor = Color.Gray;
            }
            if (txt_MatKhauMoi.Text == "")
            {
                txt_MatKhauMoi.Text = "Mật khẩu mới";
                txt_MatKhauMoi.ForeColor = Color.Gray;
            }
        }
    }
}
