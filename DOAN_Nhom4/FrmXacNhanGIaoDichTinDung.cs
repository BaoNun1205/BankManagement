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
        private TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        private LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
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
            lblHienThiPhiTraCham.Text = tttd.PhiTraCham.ToString();
            lblHienThiPhiPhat.Text = tttd.PhiPhat.ToString();
            lblHienThiTongSoTien.Text = (tttd.PhiTraCham + tttd.PhiPhat + tttd.SoTienDaSuDung).ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (tknh.SoDu >= Int64.Parse(lblHienThiTongSoTien.Text))
            {
                GiaoDich gd = new GiaoDich("Tin Dung", tknh.TenNH, kh.TenTK, tknh.SoTK, "TinDung", tttd.HoTen, tttd.SoTKTinDung, Int64.Parse(lblHienThiTongSoTien.Text), "Thanh toan tien tinh dung");
                tknhDAO.RutTien(tknh, gd);
                tttdDAO.CapNhatTinDungHangThang(tttd);
                tttdDAO.Update(tttd);
                tknh = tknhDAO.LayTaiKhoanNganHang("TenNH", gd.NganHangGui, "SoTK", gd.SoTKGui);
                lsgdDAO.Them(gd);
                FrmThongbaoChuyentien frmThongbaoChuyentien = new FrmThongbaoChuyentien(kh, gd, tknh, pnlNguoiDung);
                frmThongbaoChuyentien.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Số dư của bạn không đủ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            lblNgaySaoKe frmThongTinTaiKhoangTinDung = new lblNgaySaoKe(kh, tknh, pnlNguoiDung, tttd);
            ClassAddForm.addForm(frmThongTinTaiKhoangTinDung, pnlNguoiDung);
        }
    }
}
