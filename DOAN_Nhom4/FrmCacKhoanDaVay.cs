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
    public partial class FrmCacKhoanDaVay : Form
    {
        QLThongTinVayDAO qlDAO = new QLThongTinVayDAO();
        public FrmCacKhoanDaVay()
        {
            InitializeComponent();
        }

        private void FrmCacKhoanDaVay_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            gv_TungVay.DataSource = qlDAO.HienThi();
            gv_TungVay.RowHeadersVisible = false;
            gv_TungVay.Columns[0].HeaderText = "Số thứ tự";
            gv_TungVay.Columns[1].HeaderText = "Danh xưng";
            gv_TungVay.Columns[2].HeaderText = "Họ Tên";
            gv_TungVay.Columns[3].HeaderText = "CCCD";
            gv_TungVay.Columns[4].HeaderText = "Địa chỉ";
            gv_TungVay.Columns[5].HeaderText = "SDT";
            gv_TungVay.Columns[6].HeaderText = "Email";
            gv_TungVay.Columns[7].HeaderText = "Nghề nghiệp";
            gv_TungVay.Columns[8].HeaderText = "Thu nhập";
            gv_TungVay.Columns[9].HeaderText = "Sản phẩm vay";
            gv_TungVay.Columns[10].HeaderText = "Số tiền vay";
            gv_TungVay.Columns[11].HeaderText = "Thời gian vay";
            gv_TungVay.Columns[12].HeaderText = "Chi nhánh vay";
            gv_TungVay.Columns[13].HeaderText = "Ngày vay";
            gv_TungVay.Columns[14].HeaderText = "Lãi suất";
            gv_TungVay.Columns[15].HeaderText = "Số tiền phải trả";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDungVay ttNgDung = new ThongTinNguoiDungVay();
            ttNgDung.SoTKVay = txt_SoTKVay.Text;
            qlDAO.Xoa(ttNgDung);
            Refresh();
            MessageBox.Show("Đã xóa khoản vay!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FrmQLTKVay frmqltkvay = new FrmQLTKVay();
            this.Hide();
            frmqltkvay.ShowDialog();
            this.Close();
        }
        private void Refresh()
        {
            txt_SoTKVay.Text = "";
        }

        private void gv_TungVay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_SoTKVay.Text = gv_TungVay.Rows[numrow].Cells[0].Value.ToString();
        }
    }
}
