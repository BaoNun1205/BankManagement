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
    public partial class FrmXacNhanGiaoDichVayToanBo : Form
    {
        public KhachHang nguoiDung;
        public KhachHangVay ttNgDung;
        public Panel pnlNguoiDung;
        public TaiKhoanNganHang tknh;
        ThongTinNguoiDungVayDAO ttNgDungDAO = new ThongTinNguoiDungVayDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        public FrmXacNhanGiaoDichVayToanBo()
        {
            InitializeComponent();
        }

        public FrmXacNhanGiaoDichVayToanBo(KhachHang nguoiDung, TaiKhoanNganHang tknh, KhachHangVay ttNgDung, Panel pnlNguoiDung)
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

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIchVay, pnlNguoiDung);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (tknh.SoDu >= (ttNgDung.TongSoTienPhaiTra + ttNgDung.PhiTraCham))
            {
                tknh.SoDu -= (ttNgDung.TongSoTienPhaiTra + ttNgDung.PhiTraCham);
                tknhDAO.Sua(tknh);
                LichSuGiaoDich gd = new LichSuGiaoDich()
                {
                    LoaiGd = "Thanh Toan Khoan Vay",
                    NganHangGui = "HHB",
                    TenTkgui = nguoiDung.TenKh,
                    SoTkgui = nguoiDung.SoTk,
                    NganHangNhan = "HHB",
                    TenTknhan = "",
                    SoTknhan = "",
                    ThoiGian = DateTime.Now,
                    SoTien = ttNgDung.TongSoTienPhaiTra,
                    LoiNhan = "Thanh toan khoan vay"
                };
                lsgdDAO.Them(gd);
                ttNgDungDAO.Xoa(ttNgDung);
                MessageBox.Show("Bạn đã thanh toán xong khoản vay", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmTienIchVay FrmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
                Utility.addForm(FrmTienIchVay, pnlNguoiDung);
            }
            else
                MessageBox.Show("Số dư không đủ để thực hiện", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void HienThi()
        {
            lblHienThiTKNguon.Text = nguoiDung.SoTk;
            lblHienThiTKVay.Text = nguoiDung.SoTk;
            lblHienThiNoGoc.Text = ttNgDung.TongSoTienPhaiTra.Value.ToString("N0");
            lblHienThiTraCham.Text = ttNgDung.PhiTraCham.Value.ToString("N0");
            lblHienThiTong.Text = (ttNgDung.TongSoTienPhaiTra + ttNgDung.PhiTraCham).Value.ToString("N0");
            txtNgayGiaoDich.Value = DateTime.Now;
        }
    }
}
