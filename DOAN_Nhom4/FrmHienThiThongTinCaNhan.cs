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
        public KhachHang khNguoiDung { get; set; }
        public FrmHienThiThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void FrmHienThiThongTinCaNhan_Load(object sender, EventArgs e)
        {
            lblChuTKValue.Text = khNguoiDung.TenTK.ToString();
            lblSoTkValue.Text = khNguoiDung.SoTK.ToString();
            lblSoDuValue.Text = khNguoiDung.SoDu.ToString();
            lblCccdValue.Text = khNguoiDung.Cccd.ToString();
            lblNgaySinhValue.Text = khNguoiDung.NgaySinh.ToString();
            lblSdtValue.Text = khNguoiDung.Sdt.ToString();
        }
    }
}
