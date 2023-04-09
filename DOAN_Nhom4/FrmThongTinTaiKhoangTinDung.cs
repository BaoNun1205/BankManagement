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
    public partial class FrmThongTinTaiKhoangTinDung : Form
    {
        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        private  ThongTinTinDung tttd;
        private ThongTinTinDungDAO tttdDAO = new ThongTinTinDungDAO();
        public FrmThongTinTaiKhoangTinDung()
        {
            InitializeComponent();
        }

        public FrmThongTinTaiKhoangTinDung(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoiDung, ThongTinTinDung tttd)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
            this.tttd = tttd;
        }

        private void FrmThongTinTaiKhoangTinDung_Load(object sender, EventArgs e)
        {
            lblHienThiSoTK.Text = tttd.SoTKTinDung.ToString();
            lblHienThiLoaiThe.Text = tttd.LoaiThe.ToString();
            lblHienThiNgayDaoHan.Text = tttd.NgayDaoHan.ToString();
            lblHienThiHanMuc.Text = tttd.HanMuc.ToString();
            lblHienThiLaiSuat.Text = tttd.LaiSuat.ToString();
            lblHienThiSoTienDaSuDung.Text = tttd.SoTienDaSuDung.ToString();
            lblHienThiLaiSuat.Text = tttd.LaiSuat.ToString();
            if (!tttdDAO.IsNgayDenHan(tttd.NgayDaoHan))
            {
                lblHienThiPhiTraCham.Text = tttdDAO.PhiTraCham(BigInteger.Parse(lblHienThiSoTienDaSuDung.Text), float.Parse(lblHienThiLaiSuat.Text)).ToString();
            }
            else
            {
                lblHienThiPhiTraCham.Text = "0";
            }
            lblHienThiPhiThuongNien.Text = "0";
        }
    }
}
