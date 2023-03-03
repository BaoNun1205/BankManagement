using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DOAN_Nhom4
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        AdminDAO adminDAO = new AdminDAO();
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            gvQLKH.DataSource = adminDAO.HienThi();
            gvQLKH.RowHeadersVisible = false;
            gvQLKH.Columns[0].HeaderText = "Số tài khoản";
            gvQLKH.Columns[1].HeaderText = "Tên tài khoản";
            gvQLKH.Columns[2].HeaderText = "Tên đăng nhập";
            gvQLKH.Columns[3].HeaderText = "Password";
            gvQLKH.Columns[4].HeaderText = "Ngày sinh";
            gvQLKH.Columns[5].HeaderText = "Căn cước công dân";
            gvQLKH.Columns[6].HeaderText = "Số điện thoại";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin(txt_soTK.Text, txt_tenTK.Text,txt_tenDN.Text, txt_Password.Text, txt_NgaySinh.Text, txt_CCCD.Text, txt_SDT.Text);
            if (adminDAO.IsEmpty(ad) == false)
            {
                if (adminDAO.IsPhone(ad) == false)
                    MessageBox.Show("So dien thoai khong hop le");
                else
                {
                    adminDAO.Them(ad);
                    HienThi();
                    Refresh();                }
            }
            else
                MessageBox.Show("Chua nhap du thong tin");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin(txt_soTK.Text, txt_tenTK.Text, txt_tenDN.Text, txt_Password.Text, txt_NgaySinh.Text, txt_CCCD.Text, txt_SDT.Text);
            adminDAO.Xoa(ad);
            HienThi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin(txt_soTK.Text, txt_tenTK.Text, txt_tenDN.Text, txt_Password.Text, txt_NgaySinh.Text, txt_CCCD.Text, txt_SDT.Text);
            if (adminDAO.IsEmpty(ad) == false)
            {
                if (adminDAO.IsPhone(ad) == false)
                    MessageBox.Show("So dien thoai khong hop le");
                else
                {
                    adminDAO.Sua(ad);
                    HienThi();
                    Refresh();
                }
            }
            else
                MessageBox.Show("Chua nhap du thong tin");
        }
        private void Refresh()
        {
            txt_soTK.Text = "";
            txt_tenTK.Text = "";
            txt_tenDN.Text = "";
            txt_NgaySinh.Value = DateTime.Now;
            txt_Password.Text = "";
            txt_CCCD.Text = "";
            txt_SDT.Text = "";
        }
    }
}
