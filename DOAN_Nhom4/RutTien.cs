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
    public partial class RutTien : UserControl
    {
        public RutTien()
        {
            InitializeComponent();
        }
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        NguoiDungDAO ndDAO = new NguoiDungDAO();
        DBConnection db = new DBConnection();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();

        public void HienThiThongTin()
        {
            KhachHang ngDung = new KhachHang();
            TaiKhoanNganHang tk = new TaiKhoanNganHang();
            ngDung = ndDAO.LayKhachHang(txtSoTK.Text, "HHB");
            tk = tknhDAO.LayTaiKhoanNganHang(txtSoTK.Text, "HHB");
            if (ngDung != null)
            {
                txtTenTK.Text = ngDung.TenKh.ToString();
                txtCCCD.Text = ngDung.Cccd.ToString();
                txtSDT.Text = ngDung.Sdt.ToString();
                lblSoDu.Text = tk.SoDu.Value.ToString("N0") + " VNĐ";
            }
            else
            {
                txtTenTK.Text = "Khong ton tai";
                txtCCCD.Text = "";
                txtSDT.Text = "";
                lblSoDu.Text = "-";
            }
        }

        private void txt_SoTK_TextChanged(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void btn_RutTien_Click(object sender, EventArgs e)
        {
            TaiKhoanNganHang tkRut = new TaiKhoanNganHang();
            tkRut = tknhDAO.LayTaiKhoanNganHang(txtSoTK.Text, "HHB");
            KhachHang ndRut = new KhachHang();
            ndRut = ndDAO.LayKhachHang(txtSoTK.Text, "HHB");
            LichSuGiaoDich gd = new LichSuGiaoDich()
            {
                LoaiGd = "Rut Tien",
                NganHangGui = tkRut.TenNh,
                TenTkgui = ndRut.TenKh,
                SoTkgui = tkRut.SoTk,
                NganHangNhan = "Tien Mat",
                TenTknhan = "",
                SoTknhan = "",
                SoTien = decimal.Parse(txtSoTien.Text),
                LoiNhan = "Rut tien ra khoi tai khoan"
            };
            if (tkRut != null)
            {
                if (gd.SoTien >= 100000 && gd.SoTien <= tkRut.SoDu)
                {
                    tknhDAO.RutTien(tkRut, gd);
                    lsgdDAO.Them(gd);
                    txtSoTK.Text = "";
                    txtSoTien.Text = "";
                    txtCCCD.Text = "";
                    txtSDT.Text = "";
                    MessageBox.Show("Rút tiền thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Số tiền không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Số tài khoản không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            txtSoTK.Text = "";
            txtSoTien.Text = "";
            txtCCCD.Text = "";
            txtSDT.Text = "";
            txtTenTK.Text = "";
            lblSoDu.Text = "-";
        }
    }
}
