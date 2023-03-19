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
        NguoiDungDAO ngdungDAO = new NguoiDungDAO();
        DBConnection db = new DBConnection();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        private void btn_RutTien_Click(object sender, EventArgs e)
        {
            TaiKhoanNganHang tkRut = new TaiKhoanNganHang();
            tkRut = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTK.Text);
            NguoiDung ngdungRut = new NguoiDung();
            ngdungRut = ngdungDAO.LayKhachHang("SoTK", txt_SoTK.Text);
            BigInteger SoTien = BigInteger.Parse(txt_SoTien.Text);
            if (tkRut != null)
            {
                if (txt_CCCD.Text == ngdungRut.Cccd)
                {
                    if (txt_SDT.Text == ngdungRut.Sdt && db.IsPhone(txt_SDT.Text))
                    {
                        if (SoTien > 0 && SoTien <= tkRut.SoDu)
                        {
                            tknhDAO.RutTien(tkRut, SoTien);
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
                        MessageBox.Show("Số điện thoại không đúng hoặc không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Số căn cước công dân không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Số tài khoản không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
