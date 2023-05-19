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
        private ThongTinTinDung tttd;
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
            HienThiTheNganHang();
            HienThiTheTinDung();
        }

        private void HienThiTheNganHang()
        {
            txtChutaikhoan.Text = kh.TenTK.ToString();
            lblSoTk.Text = kh.SoTK.ToString();
            lblSoDuValue.Text = tknh.SoDu.ToString("N0") + " VNĐ";
            txtCCCD.Text = kh.Cccd.ToString();
            txtNgaysinh.Text = kh.NgaySinh.ToString("dd/MM/yyyy");
            txtSDT.Text = kh.Sdt.ToString();
        }

        private void HienThiTheTinDung()
        {
            tttd = tktdDAO.LayThongTinTinDung("CCCD", kh.Cccd);
            if (tttd != null)
            {
                // Hien thi thong tin cua the tin dung
                lblSoTKTinDung.Text = tttd.SoTKTinDung.ToString();
                lblHanmuc.Text = tttd.HanMuc.ToString("N0") + "VNĐ";
                
                //kiem tra dieu kien han muc cua the de in ra loai the phu hop
                if (tttd.HanMuc >= 300000000)
                {
                    ptbTheTinDung.Image = images[2];
                }
                else if (tttd.HanMuc >= 80000000)
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
