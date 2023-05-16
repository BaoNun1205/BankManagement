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
    public partial class FrmXacNhanGiaoDichVayToanBo : Form
    {
        public NguoiDung nguoiDung;
        public ThongTinNguoiDungVay ttNgDung;
        public Panel pnlNguoiDung;
        public TaiKhoanNganHang tknh;
        ThongTinNguoiDungVayDAO ttNgDungDAO = new ThongTinNguoiDungVayDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        public FrmXacNhanGiaoDichVayToanBo()
        {
            InitializeComponent();
        }

        public FrmXacNhanGiaoDichVayToanBo(NguoiDung nguoiDung, TaiKhoanNganHang tknh, ThongTinNguoiDungVay ttNgDung, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.ttNgDung = ttNgDung;
            this.pnlNguoiDung = pnlNguoiDung;
        }
        private void FrmXacNhanGiaoDichVayToanBo_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIchVay, pnlNguoiDung);
        }
        private void HienThi()
        {
            lblHienThiTKNguon.Text = nguoiDung.SoTK;
            lblHienThiTKVay.Text = nguoiDung.SoTK;
            lblHienThiNoGoc.Text = ttNgDung.TongSoTienPhaiTra.ToString("N0");
            lblHienThiTraCham.Text = ttNgDung.PhiTraCham.ToString("N0");
            lblHienThiTong.Text = (ttNgDung.TongSoTienPhaiTra + ttNgDung.PhiTraCham).ToString("N0");
            txt_NgayGiaoDich.Value = DateTime.Now;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            tknh.SoDu -= (ttNgDung.TongSoTienPhaiTra + ttNgDung.PhiTraCham);
            tknhDAO.Sua(tknh);
            GiaoDich gd = new GiaoDich("Thanh toan toan bo khoan vay", "HHB", nguoiDung.tenTK, nguoiDung.SoTK, "HHB", "", "", ttNgDung.TongSoTienPhaiTra, "Thanh toan khoan vay");
            lsgdDAO.Them(gd);
            ttNgDungDAO.Xoa(ttNgDung);
            MessageBox.Show("Bạn đã thanh toán xong khoản vay", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmTienIchVay FrmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            Utility.addForm(FrmTienIchVay, pnlNguoiDung);
        }
    }
}
