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
        DBConnection dBConnection = new DBConnection();
        public FrmDangnhap()
        {
            InitializeComponent();
        }
        DangNhapDAO dnDAO = new DangNhapDAO();
        private void FrmDangnhap_Load(object sender, EventArgs e)
        {
            this.txtPass.PasswordChar = '*';
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
            NguoiDung nguoiDung = new NguoiDung();
            /*if (dnDAO.XacNhanDangNhap(dn))
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    MessageBox.Show("Login successful!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                nguoiDung = dBConnection.LayKhachHang("TenDN", dn.TenDN);
                FrmNguoidung frmnguoidung = new FrmNguoidung(nguoiDung);
                this.Hide();
                frmnguoidung.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("The user name or password you entered is incorrect, try again");
                txtUserName.Clear();
                txtPass.Clear();
                txtUserName.Focus();
            }*/
        }
        private void btnDangky_Click(object sender, EventArgs e)
        {
            FrmDangky frmdangky = new FrmDangky();
            this.Hide();
            frmdangky.ShowDialog();
            this.Close();
        }
    }
}
