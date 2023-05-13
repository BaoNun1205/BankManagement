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
            NguoiDung ngDung = new NguoiDung();
            TaiKhoanNganHang tk = new TaiKhoanNganHang();
            ngDung = ndDAO.LayKhachHang("SoTK", txt_SoTK.Text);
            tk = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTK.Text);
            if (ngDung != null)
            {
                txt_TenTK.Text = ngDung.TenTK.ToString();
                txt_CCCD.Text = ngDung.Cccd.ToString();
                txt_SDT.Text = ngDung.Sdt.ToString();
                lblSoDu.Text = tk.SoDu.ToString();
            }
            else
            {
                txt_TenTK.Text = "";
                txt_CCCD.Text = "";
                txt_SDT.Text = "";
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
            tkRut = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTK.Text);
            NguoiDung ndRut = new NguoiDung();
            ndRut = ndDAO.LayKhachHang("SoTK", txt_SoTK.Text);
            GiaoDich gd = new GiaoDich("Rut Tien", tkRut.TenNH, ndRut.TenTK, tkRut.SoTK, "Tien Mat", "", "", BigInteger.Parse(txt_SoTien.Text), "Rut tien ra khoi tai khoan");
            if (tkRut != null)
            {
                if (gd.SoTien > 0 && gd.SoTien <= tkRut.SoDu)
                {
                    tknhDAO.RutTien(tkRut, gd);
                    lsgdDAO.Them(gd);
                    txt_SoTK.Text = "";
                    txt_SoTien.Text = "";
                    txt_CCCD.Text = "";
                    txt_SDT.Text = "";
                    MessageBox.Show("Rút tiền thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Số tiền không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Số tài khoản không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
