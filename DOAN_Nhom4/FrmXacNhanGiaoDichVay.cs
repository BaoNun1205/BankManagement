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
    public partial class FrmXacNhanGiaoDichVay : Form
    {
        public NguoiDung nguoiDung;
        public ThongTinNguoiDungVay ttNgDung;
        public Panel pnlNguoiDung;
        public TaiKhoanNganHang tknh;
        ThongTinNguoiDungVayDAO ttNgDungDAO = new ThongTinNguoiDungVayDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        public FrmXacNhanGiaoDichVay()
        {
            InitializeComponent();
        }
        public FrmXacNhanGiaoDichVay(NguoiDung nguoiDung, TaiKhoanNganHang tknh, ThongTinNguoiDungVay ttNgDung, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.ttNgDung = ttNgDung;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void FrmXacNhanGiaoDichVay_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIchVay, pnlNguoiDung);
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            decimal sotienlai = decimal.Parse(lblHienThiLai.Text, NumberStyles.AllowThousands);
            ttNgDung.NgayDenHan = ttNgDung.NgayDenHan.AddMonths(1);
            ttNgDung.TongSoTienPhaiTra -= (ttNgDung.SoTienHangThang + ttNgDung.PhiTraCham);
            ttNgDung.ThoiGianVay -= 1;
            ttNgDung.SoTienVay = ttNgDung.SoTienVay - (ttNgDung.SoTienHangThang - sotienlai);
            ttNgDung.PhiTraCham = 0;
            tknh.SoDu -= (ttNgDung.SoTienHangThang + ttNgDung.PhiTraCham);
            if (ttNgDung.ThoiGianVay != 0)
            {
                if (tknh.SoDu >= (ttNgDung.SoTienHangThang + ttNgDung.PhiTraCham))
                {
                    ttNgDungDAO.Sua(ttNgDung);
                    tknhDAO.Sua(tknh);
                    GiaoDich gd = new GiaoDich("Thanh Toan Khoan Vay", "HHB", nguoiDung.tenTK, nguoiDung.SoTK, "HHB", "", "", ttNgDung.SoTienHangThang, "Thanh toan khoan vay");
                    lsgdDAO.Them(gd);
                    MessageBox.Show("Hoàn tất thanh toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmThongTinTaiKhoanVay frmThongTinTaiKhoanVay = new FrmThongTinTaiKhoanVay(nguoiDung, tknh, ttNgDung, pnlNguoiDung);
                    Utility.addForm(frmThongTinTaiKhoanVay, pnlNguoiDung);
                }
                else
                {
                    tknh.SoDu += (ttNgDung.SoTienHangThang + ttNgDung.PhiTraCham);
                    MessageBox.Show("Số dư không đủ để thanh toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                tknhDAO.Sua(tknh);
                GiaoDich gd = new GiaoDich("Thanh Toan Khoan Vay", "HHB", nguoiDung.tenTK, nguoiDung.SoTK, "HHB", "", "", ttNgDung.SoTienHangThang, "Thanh toan khoan vay");
                lsgdDAO.Them(gd);
                ttNgDungDAO.Xoa(ttNgDung);
                MessageBox.Show("Bạn đã thanh toán xong khoản vay", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmTienIchVay FrmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
                Utility.addForm(FrmTienIchVay, pnlNguoiDung);
            }         
        }

        private void HienThi()
        {
            lblHienThiTKNguon.Text = nguoiDung.SoTK;
            lblHienThiTKVay.Text = nguoiDung.SoTK;
            decimal tmp = ttNgDung.SoTienVay / ttNgDung.ThoiGianVay;
            lblHienThiNoGoc.Text = tmp.ToString("N0");
            lblHienThiLai.Text = (ttNgDung.SoTienHangThang - tmp).ToString("N0");
            lblHienThiTraCham.Text = ttNgDung.PhiTraCham.ToString("N0");
            lblHienThiTong.Text = (ttNgDung.SoTienHangThang + ttNgDung.PhiTraCham).ToString("N0");
            txtNgayGiaoDich.Value = DateTime.Now;
        }
    }
}
