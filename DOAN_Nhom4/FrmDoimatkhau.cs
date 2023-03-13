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
        public NguoiDung ngdung;
        public TaiKhoangNganHang tknh;
        NguoiDungDAO ngdungDAO = new NguoiDungDAO();
        TaiKhoangNganHangDAO tknhDAO = new TaiKhoangNganHangDAO();
        public FrmDoimatkhau()
        {
            InitializeComponent();
        }

        public FrmDoimatkhau(NguoiDung ngdung, TaiKhoangNganHang tknh)
        {
            InitializeComponent();
            this.ngdung = ngdung;
            this.tknh = tknh;
        }
        private void picBoxQuaylai_Click(object sender, EventArgs e)
        {
            FrmBaomat frmbaomat = new FrmBaomat(ngdung, tknh);
            this.Hide();
            frmbaomat.ShowDialog();
            this.Close();
        }
        private void txt_MatKhauCu_Enter(object sender, EventArgs e)
        {
           if (txt_MatKhauCu.ForeColor != Color.Black)
           {
               txt_MatKhauCu.Text = "";
               txt_MatKhauCu.ForeColor = Color.Black;
           }               
        }

        private void txt_MatKhauCu_Leave(object sender, EventArgs e)
        {
            if (txt_MatKhauCu.Text == "")
            {
                txt_MatKhauCu.Text = "Mật khẩu cũ";
                txt_MatKhauCu.ForeColor = Color.Gray;
            }
        }

        private void txt_MatKhauMoi_Enter(object sender, EventArgs e)
        {
            if (txt_MatKhauMoi.ForeColor != Color.Black)
            {
                txt_MatKhauMoi.Text = "";
                txt_MatKhauMoi.ForeColor = Color.Black;
            }
        }

        private void txt_MatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (txt_MatKhauMoi.Text == "")
            {
                txt_MatKhauMoi.Text = "Mật khẩu cũ";
                txt_MatKhauMoi.ForeColor = Color.Gray;
            }
        }

        private void txt_XacNhanMatKhau_Enter(object sender, EventArgs e)
        {
            if (txt_XacNhanMatKhau.ForeColor != Color.Black)
            {
                txt_XacNhanMatKhau.Text = "";
                txt_XacNhanMatKhau.ForeColor = Color.Black;
            }
        }

        private void txt_XacNhanMatKhau_Leave(object sender, EventArgs e)
        {
            if (txt_XacNhanMatKhau.Text == "")
            {
                txt_XacNhanMatKhau.Text = "Mật khẩu cũ";
                txt_XacNhanMatKhau.ForeColor = Color.Gray;
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
                FrmDangnhap frmdangnhap = new FrmDangnhap();
                this.Hide();
                frmdangnhap.ShowDialog();
                this.Close();
            }    
        }
    }
}
