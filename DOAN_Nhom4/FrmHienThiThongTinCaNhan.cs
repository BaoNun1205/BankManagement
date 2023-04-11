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
    public partial class FrmHienThiThongTinCaNhan : Form
    {
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        private TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        public FrmHienThiThongTinCaNhan()
        {
            InitializeComponent();
        }

        public FrmHienThiThongTinCaNhan(NguoiDung kh, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
        }
        private void FrmHienThiThongTinCaNhan_Load(object sender, EventArgs e)
        {
            lblChuTKValue.Text = kh.TenTK.ToString();
            lblSoTkValue.Text = kh.SoTK.ToString();
            lblSoDuValue.Text = tknh.SoDu.ToString("N0") + " VNĐ";
            lblCccdValue.Text = kh.Cccd.ToString();
            lblNgaySinhValue.Text = kh.NgaySinh.ToString("MM/dd/yyyy");
            lblSdtValue.Text = kh.Sdt.ToString();
        }
    }
}
