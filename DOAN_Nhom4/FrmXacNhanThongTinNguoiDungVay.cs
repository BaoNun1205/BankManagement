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
    public partial class FrmXacNhanThongTinNguoiDungVay : Form
    {
        public ThongTinNguoiDungVay ttNgDung;
        public NguoiDung nguoiDung;
        ThongTinNguoiDungVayDAO ngDungVay = new ThongTinNguoiDungVayDAO();
        private Panel pnlNguoiDung;
        public TaiKhoanNganHang tknh;
        public FrmXacNhanThongTinNguoiDungVay()
        {
            InitializeComponent();
        }

        public FrmXacNhanThongTinNguoiDungVay(NguoiDung nguoiDung, TaiKhoanNganHang tknh,ThongTinNguoiDungVay ttNgDung, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.ttNgDung = ttNgDung;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void XacNhanThongTinNguoiDungVay_Load(object sender, EventArgs e)
        {
            txt_DanhXung.Text = ttNgDung.DanhXung;
            txt_HoTen.Text = ttNgDung.HoTen;
            txt_CCCD.Text = ttNgDung.Cccd;
            txt_DiaChi.Text = ttNgDung.DiaChi;
            txt_SDT.Text = ttNgDung.Sdt;
            txt_Email.Text = ttNgDung.Email;
            txt_NgheNghiep.Text = ttNgDung.NgheNghiep;
            txt_ThuNhap.Text = ttNgDung.ThuNhap;
            txt_SPVay.Text = ttNgDung.SpVay;
            txt_SoTienVay.Text = ttNgDung.SoTienVay.ToString("N0");
            txt_ThoiGianVay.Text = ttNgDung.ThoiGianVay.ToString();
            double lai;
            if (ttNgDung.SpVay == "Sản phẩm cho vay nhu cầu nhà ở")
            {
                lai = 7.9;
            }
            else if (ttNgDung.SpVay == "Sản phẩm cho vay sản xuất kinh doanh")
            {
                lai = 5;
            }
            else if (ttNgDung.SpVay == "Sản phẩm cho vay mua oto")
            {
                lai = 7.3;
            }
            else if (ttNgDung.SpVay == "Sản phẩm cho vay tiêu dùng không có tài sản đảm bảo")
            {
                lai = 11.9;
            }
            else if (ttNgDung.SpVay == "Sản phẩm cho vay tiêu dùng đảm bảo bằng bất động sản")
            {
                lai = 7.5;
            }
            else
                lai = 7.3;
            txt_LaiSuat.Text = lai.ToString();
            double soTienVay = double.Parse(txt_SoTienVay.Text);
            double tmp =  (soTienVay + (soTienVay * lai / 100));
            BigInteger tongsotien = new BigInteger(tmp);
            txt_TongSoTien.Text = tongsotien.ToString("N0");
            BigInteger tienhangthang = tongsotien / int.Parse(txt_ThoiGianVay.Text);
            txt_SoTienHangThang.Text = tienhangthang.ToString("N0");
            txt_ChiNhanhVay.Text = ttNgDung.ChiNhanhVay;
            txt_NgayVay.Text = ttNgDung.NgayVay.ToString();
            txt_TinhTien.Text = String.Format("{0} + ({1} x {2}) = {3}", soTienVay.ToString(), soTienVay.ToString(), (lai/100).ToString(), tongsotien.ToString());
        }

        private void btn_XacNhanVay_Click(object sender, EventArgs e)
        {
            ngDungVay.Them(ttNgDung);
            MessageBox.Show("Xác nhận thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmTienIch frmTienIch = new FrmTienIch(nguoiDung, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIch, pnlNguoiDung);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIchVay, pnlNguoiDung);
        }
    }
}
