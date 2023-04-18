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
            lblHienThiNgayDaoHan.Text = tttd.NgayDaoHan.ToString("dd/MM/yyyy");
            lblHienThiHanMuc.Text = tttd.HanMuc.ToString("N0");
            lblHienThiLaiSuat.Text = tttd.LaiSuat.ToString();
            lblHienThiSoTienDaSuDung.Text = tttd.SoTienDaSuDung.ToString("N0");
            if (tttdDAO.IsNgayDenHan(tttd))
            {
                CapNhatPhi();
            }
            lblHienThiPhiTraCham.Text = tttd.PhiTraCham.ToString("N0");
            lblHienThiPhiPhat.Text = tttd.PhiPhat.ToString("N0");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FrmXacNhanGIaoDichTinDung frmXacNhanGIaoDichTinDung = new FrmXacNhanGIaoDichTinDung(kh, tknh, pnlNguoiDung, tttd);
            DOAN_Nhom4.ClassAddForm.addForm(frmXacNhanGIaoDichTinDung, pnlNguoiDung);
        }

        public void CapNhatPhi()
        {
            tttd.PhiPhat = tttdDAO.PhiPhat(tttd);
            tttd.PhiTraCham = tttdDAO.PhiTraCham(tttd);
            tttdDAO.Update(tttd);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            FrmTienIchTinDung frmTienIchTinDung = new FrmTienIchTinDung(kh, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIchTinDung, pnlNguoiDung);
        }
    }
}
