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
    public partial class FrmXacNhanGiaoDichVay : Form
    {
        public NguoiDung nguoiDung;
        public ThongTinNguoiDungVay ttNgDung;
        public Panel pnlNguoiDung;
        public TaiKhoanNganHang tknh;
        ThongTinNguoiDungVayDAO ttNgDungDAO = new ThongTinNguoiDungVayDAO();
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

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIchVay, pnlNguoiDung);
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            ttNgDung.NgayDenHan.AddMonths(1);
            ttNgDung.TongSoTienPhaiTra -= (ttNgDung.SoTienHangThang + ttNgDung.PhiTraCham);
            ttNgDung.ThoiGianVay -= 1;
            ttNgDung.SoTienHangThang = ttNgDung.TongSoTienPhaiTra / ttNgDung.ThoiGianVay;
            ttNgDung.PhiTraCham = 0;
            if (ttNgDung.ThoiGianVay != 0)
            {
                ttNgDungDAO.Update(ttNgDung);
                MessageBox.Show("Hoàn tất thanh toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ttNgDungDAO.Xoa(ttNgDung);
                MessageBox.Show("Bạn đã thanh toán xong khoản vay", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FrmThongTinTaiKhoanVay frmThongTinTaiKhoanVay = new FrmThongTinTaiKhoanVay(nguoiDung, tknh, ttNgDung, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmThongTinTaiKhoanVay, pnlNguoiDung);
        }

        private void FrmXacNhanGiaoDichVay_Load(object sender, EventArgs e)
        {
            txt_TKNguon.Text = nguoiDung.SoTK;
            txt_TKVay.Text = nguoiDung.SoTK;
            txt_SoTienGoc.Text = (ttNgDung.SoTienVay / ttNgDung.ThoiGianVay).ToString();
            txt_SoTienLai.Text = (ttNgDung.SoTienVay * ttNgDung.Lai).ToString();
            txt_PhiTraCham.Text = ttNgDung.PhiTraCham.ToString();
            txt_TongSoTien.Text = (ttNgDung.SoTienHangThang + ttNgDung.PhiTraCham).ToString();
            txt_NgayGiaoDich.Value = DateTime.Now;
        }
    }
}
