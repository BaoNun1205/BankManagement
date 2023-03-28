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
    public partial class FrmTienIchVay : Form
    {
        private NguoiDung nguoiDung;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
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

        private void addForm(Form form)
        {
            pnlNguoiDung.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlNguoiDung.Controls.Add(form);
            pnlNguoiDung.Tag = form;
            form.Show();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            FrmVay frmVay = new FrmVay(nguoiDung, tknh,pnlNguoiDung);
            addForm(frmVay);
        }

        private void btn_XemKhoanVay_Click(object sender, EventArgs e)
        {

        }
    }
}
