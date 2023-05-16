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
            txtChutaikhoan.Text = kh.TenTK.ToString();
            lblSoTkValue.Text = kh.SoTK.ToString();
            lblSoDuValue.Text = tknh.SoDu.ToString("N0") + " VNĐ";
            txtCCCD.Text = kh.Cccd.ToString();
            txtNgaysinh.Text = kh.NgaySinh.ToString("MM/dd/yyyy");
            txtSDT.Text = kh.Sdt.ToString();
            HienThiTheTinDung();
        }

        private void HienThiTheTinDung()
        {
            tktd = tktdDAO.LayThongTinTinDung("SoTKTinDung", tknh.SoTK);
            if (tktd != null)
            {
                if (tktd.LoaiThe == "HHB Visa Flexi")
                {
                    ptbTheTinDung.Image = images[0];
                }
                if (tktd.LoaiThe == "HHB Visa Platinum Cashback")
                {
                    ptbTheTinDung.Image = images[1];
                }
                if (tktd.LoaiThe == "HHB Visa Infinite")
                {
                    ptbTheTinDung.Image = images[2];
                }
            }

        }
    }
}
