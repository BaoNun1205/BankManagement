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
        NguoiDungDAO khDAO = new NguoiDungDAO();
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            gvQLKH.DataSource = khDAO.HienThi();
            gvQLKH.RowHeadersVisible = false;
            gvQLKH.Columns[0].HeaderText = "Số tài khoản";
            gvQLKH.Columns[1].HeaderText = "Tên tài khoản";
            gvQLKH.Columns[2].HeaderText = "Tên đăng nhập";
            gvQLKH.Columns[3].HeaderText = "Mật khẩu";
            gvQLKH.Columns[4].HeaderText = "Ngày sinh";
            gvQLKH.Columns[5].HeaderText = "Căn cước công dân";
            gvQLKH.Columns[6].HeaderText = "Số điện thoại";
            gvQLKH.Columns[7].HeaderText = "Số dư";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NguoiDung kh = new NguoiDung(txt_soTK.Text, txt_tenTK.Text, txt_tenDN.Text, txt_Password.Text, txt_NgaySinh.Value, txt_CCCD.Text, txt_SDT.Text, int.Parse(txt_SoDu.Text));
            if (khDAO.IsEmpty(kh) == false)
            {
                if (khDAO.IsPhone(kh) == false)
                    MessageBox.Show("So dien thoai khong hop le");
                else
                {
                    khDAO.Them(kh);
                    HienThi();
                    Refresh();                }
            }
            else
                MessageBox.Show("Chua nhap du thong tin");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            NguoiDung kh = new NguoiDung(txt_soTK.Text, txt_tenTK.Text, txt_tenDN.Text, txt_Password.Text, txt_NgaySinh.Value, txt_CCCD.Text, txt_SDT.Text, int.Parse(txt_SoDu.Text));
            khDAO.Xoa(kh);
            HienThi();
            Refresh();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            NguoiDung kh = new NguoiDung(txt_soTK.Text, txt_tenTK.Text, txt_tenDN.Text, txt_Password.Text, txt_NgaySinh.Value, txt_CCCD.Text, txt_SDT.Text, int.Parse(txt_SoDu.Text));
            if (khDAO.IsEmpty(kh) == false)
            {
                if (khDAO.IsPhone(kh) == false)
                    MessageBox.Show("So dien thoai khong hop le");
                else
                {
                    khDAO.Sua(kh);
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
            txt_SoDu.Text = "";
        }

        private void gvQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_soTK.Text = gvQLKH.Rows[numrow].Cells[0].Value.ToString();
            txt_tenTK.Text = gvQLKH.Rows[numrow].Cells[1].Value.ToString();
            txt_tenDN.Text = gvQLKH.Rows[numrow].Cells[2].Value.ToString();
            txt_Password.Text = gvQLKH.Rows[numrow].Cells[3].Value.ToString();
            txt_NgaySinh.Text = gvQLKH.Rows[numrow].Cells[4].Value.ToString();
            txt_CCCD.Text = gvQLKH.Rows[numrow].Cells[5].Value.ToString();
            txt_SDT.Text = gvQLKH.Rows[numrow].Cells[6].Value.ToString();
            txt_SoDu.Text = gvQLKH.Rows[numrow].Cells[7].Value.ToString();
        }

        private void gvQLKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gvQLKH.Rows[e.RowIndex];
            txt_soTK.Text = Convert.ToString(row.Cells[0].Value);
            txt_tenTK.Text = Convert.ToString(row.Cells[1].Value);
            txt_tenDN.Text = Convert.ToString(row.Cells[2].Value);
            txt_Password.Text = Convert.ToString(row.Cells[3].Value);
            txt_NgaySinh.Text = Convert.ToString(row.Cells[4].Value);
            txt_CCCD.Text = Convert.ToString(row.Cells[5].Value);
            txt_SDT.Text = Convert.ToString(row.Cells[6].Value);
        }
    }
}
