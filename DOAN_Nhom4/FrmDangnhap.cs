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
    public partial class FrmDangnhap : Form
    {
        public FrmDangnhap()
        {
            InitializeComponent();
        }

        private void FrmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "username" && txtPass.Text == "pass")
            {
                new FrmNguoiDung().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user name or password you entered is incorrect, try again");
                txtUserName.Clear();
                txtPass.Clear();
                txtUserName.Focus();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNo);
            if(dg == DialogResult.Yes)
                Application.Exit();
        }

        private void lbl_Clear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPass.Clear();
            txtUserName.Focus();
        }
    }
}
