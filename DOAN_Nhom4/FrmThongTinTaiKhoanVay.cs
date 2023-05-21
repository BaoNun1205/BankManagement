using DOAN_Nhom4.Entities;
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
        private KhachHang nguoiDung;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        private ThongTinNguoiDungVay ttNgDung;
        public FrmThongTinTaiKhoanVay()
        {
            InitializeComponent();
        }
        public FrmThongTinTaiKhoanVay(KhachHang nguoiDung, TaiKhoanNganHang tknh,ThongTinNguoiDungVay ttNgDung, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.pnlNguoiDung = pnlNguoiDung;
            this.nguoiDung = nguoiDung;
            this.ttNgDung = ttNgDung;
            this.tknh = tknh;
        }

        private void FrmThongTinTaiKhoanVay_Load(object sender, EventArgs e)
        {
            HienThi();
        }        
        
        private void pBQuaylai_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmtienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            Utility.addForm(frmtienIchVay, pnlNguoiDung);
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIchVay, pnlNguoiDung);
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            FrmXacNhanGiaoDichVay frmgdvay = new FrmXacNhanGiaoDichVay(nguoiDung, tknh, ttNgDung, pnlNguoiDung);
            Utility.addForm(frmgdvay, pnlNguoiDung);
        }

        private void btn_ThanhToanToanBo_Click(object sender, EventArgs e)
        {
            FrmXacNhanGiaoDichVayToanBo frmgdvaytoanbo = new FrmXacNhanGiaoDichVayToanBo(nguoiDung, tknh, ttNgDung, pnlNguoiDung);
            Utility.addForm(frmgdvaytoanbo, pnlNguoiDung);
        }

        private void HienThi()
        {
            txtNgayDenHan.Value = ttNgDung.NgayDenHan;
            txtDuNo.Text = ttNgDung.TongSoTienPhaiTra.ToString("N0");
            txtLaiSuat.Text = ttNgDung.Lai.ToString() + "%/năm";
            txtSoTienHangThang.Text = ttNgDung.SoTienHangThang.ToString("N0");
            if (ttNgDung.NgayDenHan.Year > DateTime.Now.Year) //chua qua han thanh toan, phi tra cham = 0
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
                        ttNgDung.PhiTraCham = 50000; //qua han thanh toan
                }
                else
                    ttNgDung.PhiTraCham = 50000; //qua han thanh toan
            }
            txtPhiTraCham.Text = ttNgDung.PhiTraCham.ToString("N0");
        }
    }
}
