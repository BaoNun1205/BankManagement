using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace DOAN_Nhom4
{
    public partial class NapTien : UserControl
    {
        public NapTien()
        {
            InitializeComponent();
        }
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        NguoiDungDAO ngdungDAO = new NguoiDungDAO();
        DBConnection db = new DBConnection();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        private void btn_NapTien_Click(object sender, EventArgs e)
        {
            TaiKhoanNganHang tkNap = new TaiKhoanNganHang();
            tkNap = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTK.Text);
            NguoiDung ngdungNap = new NguoiDung();
            ngdungNap = ngdungDAO.LayKhachHang("SoTK", txt_SoTK.Text);
            BigInteger SoTien = BigInteger.Parse(txt_SoTien.Text);
            if (tkNap != null)
            {
                if (txt_CCCD.Text == ngdungNap.Cccd)
                {
                    if (txt_SDT.Text == ngdungNap.Sdt && db.IsPhone(txt_SDT.Text))
                    {
                        if (SoTien > 0)
                        {
                            tknhDAO.NapTien(tkNap, SoTien);
                            txt_SoTK.Text = "";
                            txt_SoTien.Text = "";
                            txt_CCCD.Text = "";
                            txt_SDT.Text = "";
                            MessageBox.Show("Nạp tiền thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
