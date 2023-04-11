using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmQuanLyVayAdmin : Form
    {
        ThongTinNguoiDungVayDAO ttNgDungDAO = new ThongTinNguoiDungVayDAO();
        public FrmQuanLyVayAdmin()
        {
            InitializeComponent();
        }

        private void FrmQuanLyVayAdmin_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            gv_Vay.DataSource = ttNgDungDAO.HienThi();
            gv_Vay.RowHeadersVisible = false;
            gv_Vay.Columns[0].HeaderText = "Số tài khoản";
            gv_Vay.Columns[1].HeaderText = "Danh xưng";
            gv_Vay.Columns[2].HeaderText = "Họ Tên";
            gv_Vay.Columns[3].HeaderText = "CCCD";
            gv_Vay.Columns[4].HeaderText = "Địa chỉ";
            gv_Vay.Columns[5].HeaderText = "SDT";
            gv_Vay.Columns[6].HeaderText = "Email";
            gv_Vay.Columns[7].HeaderText = "Nghề nghiệp";
            gv_Vay.Columns[8].HeaderText = "Thu nhập";
            gv_Vay.Columns[9].HeaderText = "Sản phẩm vay";
            gv_Vay.Columns[10].HeaderText = "Số tiền vay";
            gv_Vay.Columns[11].HeaderText = "Thời gian vay";
            gv_Vay.Columns[12].HeaderText = "Chi nhánh vay";
            gv_Vay.Columns[13].HeaderText = "Ngày vay";
            gv_Vay.Columns[14].HeaderText = "Lãi suất";
            gv_Vay.Columns[15].HeaderText = "Số tiền phải trả";
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FrmAdmin frmadm = new FrmAdmin();
            this.Hide();
            frmadm.ShowDialog();
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDungVay ttNgDung = ttNgDungDAO.TKValid(txt_SoTKVay.Text);
            ttNgDungDAO.Xoa(ttNgDung);
            MessageBox.Show("Đã xóa khoản vay!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
        }

        private void gv_Vay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_SoTKVay.Text = gv_Vay.Rows[numrow].Cells[0].Value.ToString();
        }
    }
}
