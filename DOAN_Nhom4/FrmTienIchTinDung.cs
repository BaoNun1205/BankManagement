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
    public partial class FrmTienIchTinDung : Form
    {
        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        private ThongTinTinDung tttd;
        private ThongTinTinDungDAO tttdDAO = new ThongTinTinDungDAO();
        public FrmTienIchTinDung()
        {
            InitializeComponent();
        }

        public FrmTienIchTinDung(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void lblThongTin_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            FrmDangKyTinDung frmDangKyTinDung = new FrmDangKyTinDung(kh, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmDangKyTinDung, pnlNguoiDung);
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            tttd = tttdDAO.LayThongTinTinDung("CCCD", kh.Cccd);
            if (tttdDAO != null)
            {
                lblNgaySaoKe frmThongTinTaiKhoangTinDung = new lblNgaySaoKe(kh, tknh, pnlNguoiDung, tttd);
                DOAN_Nhom4.ClassAddForm.addForm(frmThongTinTaiKhoangTinDung, pnlNguoiDung);
            }
            else
                MessageBox.Show("Bạn không có khoản vay nào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
