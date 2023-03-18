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
        NguoiDungDAO khDAO = new NguoiDungDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        public FrmAdmin()
        {
            InitializeComponent();
        }
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            gvQLKH.DataSource = khDAO.HienThi();
            gvQLKH.RowHeadersVisible = false;
            gvQLKH.Columns[0].HeaderText = "Tên ngân hàng";
            gvQLKH.Columns[1].HeaderText = "Số tài khoản";
            gvQLKH.Columns[2].HeaderText = "Tên tài khoản";
            gvQLKH.Columns[3].HeaderText = "Tên đăng nhập";
            gvQLKH.Columns[4].HeaderText = "Mật khẩu";
            gvQLKH.Columns[5].HeaderText = "Số dư";
            gvQLKH.Columns[6].HeaderText = "Ngày sinh";
            gvQLKH.Columns[7].HeaderText = "Căn cước công dân";
            gvQLKH.Columns[8].HeaderText = "Email";
            gvQLKH.Columns[9].HeaderText = "Số điện thoại";
            gvQLKH.Columns[10].HeaderText = "Ngày đăng ký";
        }
        private void Refresh()
        {
            txt_SoTK.Text = "";
            txt_TenTK.Text = "";
            txt_TenDN.Text = "";
            txt_NgaySinh.Value = DateTime.Now;
            txt_NgayDangKyThe.Value = DateTime.Now;
            txt_MatKhau.Text = "";
            txt_CCCD.Text = "";
            txt_SDT.Text = "";
            txt_Email.Text = "";
            txt_SoDu.Text = "";
        }

        private void gvQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_SoTK.Text = gvQLKH.Rows[numrow].Cells[1].Value.ToString();
            txt_TenTK.Text = gvQLKH.Rows[numrow].Cells[2].Value.ToString();
            txt_TenDN.Text = gvQLKH.Rows[numrow].Cells[3].Value.ToString();
            txt_MatKhau.Text = gvQLKH.Rows[numrow].Cells[4].Value.ToString();
            txt_SoDu.Text = gvQLKH.Rows[numrow].Cells[5].Value.ToString();
            txt_NgaySinh.Text = gvQLKH.Rows[numrow].Cells[6].Value.ToString();
            txt_CCCD.Text = gvQLKH.Rows[numrow].Cells[7].Value.ToString();
            txt_Email.Text = gvQLKH.Rows[numrow].Cells[8].Value.ToString();
            txt_SDT.Text = gvQLKH.Rows[numrow].Cells[9].Value.ToString();
            txt_NgayDangKyThe.Text = gvQLKH.Rows[numrow].Cells[10].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            NguoiDung kh = new NguoiDung("HHB", txt_SoTK.Text, txt_TenTK.Text, txt_NgaySinh.Value, txt_CCCD.Text, txt_Email.Text, txt_SDT.Text);
            TaiKhoanNganHang tknh = new TaiKhoanNganHang("HHB", txt_SoTK.Text, txt_TenDN.Text, txt_MatKhau.Text, int.Parse(txt_SoDu.Text), txt_NgayDangKyThe.Value);
            if (!khDAO.IsEmpty(kh) && !tknhDAO.IsEmpty(tknh))
            {
                if (!khDAO.IsPhone(kh))
                    MessageBox.Show("So dien thoai khong hop le");
                else
                {
                    khDAO.Them(kh);
                    tknhDAO.Them(tknh);
                    HienThi();
                    Refresh();
                }
            }
            else
                MessageBox.Show("Chua nhap du thong tin");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            NguoiDung kh = new NguoiDung("HHB", txt_SoTK.Text, txt_TenTK.Text, txt_NgaySinh.Value, txt_CCCD.Text, txt_Email.Text, txt_SDT.Text);
            TaiKhoanNganHang tknh = new TaiKhoanNganHang("HHB", txt_SoTK.Text, txt_TenDN.Text, txt_MatKhau.Text, int.Parse(txt_SoDu.Text), txt_NgayDangKyThe.Value);
            khDAO.Xoa(kh);
            tknhDAO.Xoa(tknh);
            HienThi();
            Refresh();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            NguoiDung kh = new NguoiDung("HHB", txt_SoTK.Text, txt_TenTK.Text, txt_NgaySinh.Value, txt_CCCD.Text, txt_Email.Text, txt_SDT.Text);
            TaiKhoanNganHang tknh = new TaiKhoanNganHang("HHB", txt_SoTK.Text, txt_TenDN.Text, txt_MatKhau.Text, int.Parse(txt_SoDu.Text), txt_NgayDangKyThe.Value);
            if (!khDAO.IsEmpty(kh) && !tknhDAO.IsEmpty(tknh))
            {
                if (khDAO.IsPhone(kh) == false)
                    MessageBox.Show("So dien thoai khong hop le");
                else
                {
                    khDAO.Sua(kh);
                    tknhDAO.Sua(tknh);
                    HienThi();
                    Refresh();
                }
            }
            else
                MessageBox.Show("Chua nhap du thong tin");
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminDichVu frmaddv = new FrmAdminDichVu();
            frmaddv.ShowDialog();
            this.Close();
        }
    }
}
