using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmThongTinNguoiDungTinDung : Form
    {
        private KhachHang kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        private TaiKhoanTinDung tttd;
        private ThongTinTinDungDAO tttdDAO = new ThongTinTinDungDAO();
        public FrmThongTinNguoiDungTinDung()
        {
            InitializeComponent();
        }

        public FrmThongTinNguoiDungTinDung(KhachHang kh, TaiKhoanNganHang tknh, Panel pnlNguoiDung, TaiKhoanTinDung tttd)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
            this.tttd = tttd;
        }

        private void FrmThongTinTaiKhoangTinDung_Load(object sender, EventArgs e)
        {
            lblHienThiSoTK.Text = tttd.SoTktinDung.ToString();
            lblHienThiLoaiThe.Text = tttd.LoaiThe.ToString();
            lblHienThiHanThanhToan.Text = tttd.HanThanhToan.Value.ToString("dd/MM/yyyy");
            lblHienThiNgaySaoKe.Text = tttd.NgaySaoKe.Value.ToString("dd/MM/yyyy");
            lblHienThiHanMuc.Text = tttd.HanMuc.Value.ToString("N0");
            lblHienThiLaiSuat.Text = tttd.LaiSuat.ToString() + '%';
            lblHienThiSoTienDaSuDung.Text = tttd.SoTienDaSuDung.Value.ToString("N0");
            lblHienThiSoTienSuDungSau.Text = tttd.SoTienSuDungSau.Value.ToString("N0");
            if (tttdDAO.IsNgayDenHan(tttd))
            {
                CapNhatPhi();
            }
            lblHienThiPhiTraCham.Text = tttd.PhiTraCham.Value.ToString("N0");
            lblHienThiPhiPhat.Text = tttd.PhiPhat.Value.ToString("N0");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (DateTime.Now > tttd.NgaySaoKe)
            {
                FrmXacNhanGIaoDichTinDung frmXacNhanGIaoDichTinDung = new FrmXacNhanGIaoDichTinDung(kh, tknh, pnlNguoiDung, tttd);
                Utility.addForm(frmXacNhanGIaoDichTinDung, pnlNguoiDung);
            }
            else
            {
                MessageBox.Show("Chưa đến ngày sao kê!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            FrmTienIchTinDung frmTienIchTinDung = new FrmTienIchTinDung(kh, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIchTinDung, pnlNguoiDung);
        }

        public void CapNhatPhi()
        {
            tttd.PhiPhat = tttdDAO.PhiPhat(tttd);
            tttd.PhiTraCham = tttdDAO.PhiTraCham(tttd);
            tttdDAO.Sua(tttd);
        }
    }
}
