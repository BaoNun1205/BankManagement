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
    public partial class FrmXacNhanGIaoDichTinDung : Form
    {
        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        private ThongTinTinDung tttd;
        private ThongTinTinDungDAO tttdDAO = new ThongTinTinDungDAO();
        public FrmXacNhanGIaoDichTinDung()
        {
            InitializeComponent();
        }

        public FrmXacNhanGIaoDichTinDung(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoiDung, ThongTinTinDung tttd)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
            this.tttd = tttd;
        }

        private void FrmXacNhanGIaoDichTinDung_Load(object sender, EventArgs e)
        {
            lblHienThiTKNguon.Text = tknh.SoTK;
            lblHienThiTKTinDung.Text = tttd.SoTKTinDung;
            lblHienThiTienDaSuDung.Text = tttd.SoTienDaSuDung.ToString();
            txt_NgayGiaoDich.Value = DateTime.Now;
            if (tttdDAO.IsNgayDenHan(tttd))
            {
                lblHienThiLai.Text = tttdDAO.LaiSuat(tttd).ToString();
                lblHienThiTraCham.Text = tttdDAO.PhiTraCham(tttd).ToString();
            }
            else
            {
                lblHienThiLai.Text = "0";
                lblHienThiTraCham.Text = "0";
            }
        }
    }
}
