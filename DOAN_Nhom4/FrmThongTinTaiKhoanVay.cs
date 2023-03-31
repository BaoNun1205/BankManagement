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
    public partial class FrmThongTinTaiKhoanVay : Form
    {
        public NguoiDung nguoiDung;
        ThongTinNguoiDungVayDAO ttNgVayDAO = new ThongTinNguoiDungVayDAO();
        private Panel pnlNguoiDung;
        public FrmThongTinTaiKhoanVay()
        {
            InitializeComponent();
        }
        public FrmThongTinTaiKhoanVay(NguoiDung nguoiDung, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.pnlNguoiDung = pnlNguoiDung;
            this.nguoiDung = nguoiDung;
        }

        private void FrmThongTinTaiKhoanVay_Load(object sender, EventArgs e)
        {
            ThongTinNguoiDungVay ttNgVay = ttNgVayDAO.TKValid(nguoiDung.SoTK);
            txt_NgayDenHan.Value = ttNgVay.NgayDenHan;
            txt_DuNo.Text = ttNgVay.TongSoTienPhaiTra.ToString();
            txt_LaiSuat.Text = ttNgVay.Lai.ToString();
            txt_SoTienHangThang.Text = ttNgVay.SoTienHangThang.ToString();
            if(txt_NgayDenHan.Value.Month > DateTime.Now.Month)
            {
                txt_PhiTraCham.Text = "0";
            }
            else if(txt_NgayDenHan.Value.Month == DateTime.Now.Month)
            {
                if(txt_NgayDenHan.Value.Date >= DateTime.Now.Date)
                {
                    txt_PhiTraCham.Text = "0";
                }
                else
                    txt_PhiTraCham.Text = "50000";
            }
            else
                txt_PhiTraCham.Text = "50000";
        }
    }
}
