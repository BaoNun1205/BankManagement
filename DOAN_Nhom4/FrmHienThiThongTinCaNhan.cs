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
        private ThongTinTinDung tktd;
        private ThongTinTinDungDAO tktdDAO = new ThongTinTinDungDAO();
        private TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();

        public FrmHienThiThongTinCaNhan()
        {
            InitializeComponent();
        }

        Image[] images = new Image[]
        {
            Properties.Resources.hhb_visa_Flexi,
            Properties.Resources.hhb_visa_platinum_cashback,
            Properties.Resources.hhb_visa_infinite,
        };

        public FrmHienThiThongTinCaNhan(NguoiDung kh, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
        }
        private void FrmHienThiThongTinCaNhan_Load(object sender, EventArgs e)
        {
            ThongTinTinDung tttd = new ThongTinTinDung();
            tttd = tktdDAO.LayThongTinTinDung("CCCD", kh.Cccd);
            txtChutaikhoan.Text = kh.TenTK.ToString();
            lblSoTk.Text = kh.SoTK.ToString();
            lblSoTKTinDung.Text = tttd.SoTKTinDung.ToString();
            lblSoDuValue.Text = tknh.SoDu.ToString("N0") + " VNĐ";
            lblHanmuc.Text = tttd.HanMuc.ToString("N0") + "VNĐ";
            txtCCCD.Text = kh.Cccd.ToString();
            txtNgaysinh.Text = kh.NgaySinh.ToString("dd/MM/yyyy");
            txtSDT.Text = kh.Sdt.ToString();
            HienThiTheTinDung();
        }

        private void HienThiTheTinDung()
        {
            tktd = tktdDAO.LayThongTinTinDung("CCCD", kh.Cccd);
            if (tktd != null)
            {
                if (tktd.HanMuc >= 300000000)
                {
                    ptbTheTinDung.Image = images[2];
                }
                else if (tktd.HanMuc >= 80000000)
                {
                    ptbTheTinDung.Image = images[1];
                }
                else
                {
                    ptbTheTinDung.Image = images[0];
                }
            }

        }
    }
}
