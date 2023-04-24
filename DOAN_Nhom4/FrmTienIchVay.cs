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
    public partial class FrmTienIchVay : Form
    {
        private NguoiDung nguoiDung;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        ThongTinNguoiDungVayDAO ttNgDungDAO = new ThongTinNguoiDungVayDAO();
        public FrmTienIchVay()
        {
            InitializeComponent();
        }
        public FrmTienIchVay(NguoiDung nguoiDung, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            FrmVay frmVay = new FrmVay(nguoiDung, tknh,pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmVay, pnlNguoiDung);
        }

        private void btn_XemKhoanVay_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDungVay ttNgDung = ttNgDungDAO.TKValid(nguoiDung.SoTK);           
            if (ttNgDung != null)
            {
                FrmThongTinTaiKhoanVay frmThongTinTaiKhoanVay = new FrmThongTinTaiKhoanVay(nguoiDung, tknh, ttNgDung, pnlNguoiDung);
                DOAN_Nhom4.ClassAddForm.addForm(frmThongTinTaiKhoanVay, pnlNguoiDung);
            }
            else
                MessageBox.Show("Bạn không có khoản vay nào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
