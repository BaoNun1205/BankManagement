using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmDangnhap : Form
    {
        NguoiDungDAO khDAO = new NguoiDungDAO();
        DangNhapDAO dnDAO = new DangNhapDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();

        Dictionary<string, string> credentials = new Dictionary<string, string>()
        {
            { "admin", "1" }
        };
        public FrmDangnhap()
        {
            InitializeComponent();
        }
        private void FrmDangnhap_Load(object sender, EventArgs e)
        {
            this.txtPass.PasswordChar = '*';
        }

        private void lblXoa_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPass.Clear();
            txtUserName.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap(txtUserName.Text, txtPass.Text);
            TaiKhoanNganHang tknh = new TaiKhoanNganHang();
            KhachHang nguoiDung = new KhachHang();
            if (rdb_Admin.Checked == true) //dang nhap voi tu cach admin
            {
                if (credentials.ContainsKey(txtUserName.Text) && credentials[txtUserName.Text] == txtPass.Text)
                {
                    FrmAdmin frmad = new FrmAdmin();
                    this.Hide();
                    frmad.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUserName.Clear();
                    txtPass.Clear();
                    txtUserName.Focus();
                }
            }
            else if (rdb_NguoiDung.Checked == true) //dang nhap voi tu cach nguoi dung
            {
                if (dnDAO.XacNhanDangNhap(dn))
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        tknh = tknhDAO.LayTaiKhoanNganHang("TenDN", dn.TenDN, "TenNH", "HHB");
                        nguoiDung = khDAO.LayKhachHang(tknh.SoTK, "HHB");
                        FrmNguoidung frmnguoidung = new FrmNguoidung(nguoiDung, tknh);
                        this.Hide();
                        frmnguoidung.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUserName.Clear();
                    txtPass.Clear();
                    txtUserName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn loại đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            FrmDangky frmdangky = new FrmDangky();
            this.Hide();
            frmdangky.ShowDialog();
            this.Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

            txtPass.UseSystemPasswordChar = false;
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_showpass.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }
}
