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
    public partial class FrmThongTinTaiKhoanVay : Form
    {
        private NguoiDung nguoiDung;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        private ThongTinNguoiDungVay ttNgDung;
        public FrmThongTinTaiKhoanVay()
        {
            InitializeComponent();
        }
        public FrmThongTinTaiKhoanVay(NguoiDung nguoiDung, TaiKhoanNganHang tknh,ThongTinNguoiDungVay ttNgDung, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.pnlNguoiDung = pnlNguoiDung;
            this.nguoiDung = nguoiDung;
            this.ttNgDung = ttNgDung;
            this.tknh = tknh;
        }


        private void FrmThongTinTaiKhoanVay_Load(object sender, EventArgs e)
        {
            txt_NgayDenHan.Value = ttNgDung.NgayDenHan;
            txt_DuNo.Text = ttNgDung.TongSoTienPhaiTra.ToString("N0");
            txt_LaiSuat.Text = ttNgDung.Lai.ToString() + "%/năm";
            txt_SoTienHangThang.Text = ttNgDung.SoTienHangThang.ToString("N0");
            if (ttNgDung.NgayDenHan.Year > DateTime.Now.Year)
            {
                ttNgDung.PhiTraCham = 0;
            }
            else
            {
                if (ttNgDung.NgayDenHan.Month > DateTime.Now.Month)
                {
                    ttNgDung.PhiTraCham = 0;
                }
                else if (ttNgDung.NgayDenHan.Month == DateTime.Now.Month)
                {
                    if (ttNgDung.NgayDenHan.Date >= DateTime.Now.Date)
                    {
                        ttNgDung.PhiTraCham = 0;
                    }
                    else
                        ttNgDung.PhiTraCham = 50000;
                }
                else
                    ttNgDung.PhiTraCham = 50000;
            }
            txt_PhiTraCham.Text = ttNgDung.PhiTraCham.ToString("N0");
        }
        
        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIchVay, pnlNguoiDung);
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            FrmXacNhanGiaoDichVay frmgdvay = new FrmXacNhanGiaoDichVay(nguoiDung,tknh, ttNgDung, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmgdvay, pnlNguoiDung);
        }
    }
}
