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
    public partial class ChuyenTien : UserControl
    {
        public ChuyenTien()
        {
            InitializeComponent();
        }
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        NguoiDungDAO ngdungDAO = new NguoiDungDAO();
        DBConnection db = new DBConnection();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        private void btn_ChuyenTien_Click(object sender, EventArgs e)
        {
            TaiKhoanNganHang tkChuyen = new TaiKhoanNganHang();
            tkChuyen = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTKChuyen.Text);
            NguoiDung ngdungChuyen = new NguoiDung();
            ngdungChuyen = ngdungDAO.LayKhachHang("SoTK", txt_SoTKChuyen.Text);
            TaiKhoanNganHang tkNhan = new TaiKhoanNganHang();
            tkNhan = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTKNhan.Text);
            NguoiDung ngdungNhan = new NguoiDung();
            ngdungNhan = ngdungDAO.LayKhachHang("SoTK", txt_SoTKNhan.Text);
            BigInteger SoTien = BigInteger.Parse(txt_SoTien.Text);
            if (tkChuyen != null)
            {
                if ((txt_TenNH.Text != "HHB" && tkNhan == null) || tkNhan != null)
                {
                    if (txt_CCCD.Text == ngdungChuyen.Cccd)
                    {
                        if (txt_SDT.Text == ngdungChuyen.Sdt && db.IsPhone(txt_SDT.Text))
                        {
                            if (SoTien > 0 && SoTien <= tkChuyen.SoDu)
                            {
                                tknhDAO.ChuyenTien(tkChuyen, SoTien, tkNhan);
                                txt_SoTKNhan.Text = "";
                                txt_SoTKChuyen.Text = "";
                                txt_TenNH.Text = "";
                                txt_SoTien.Text = "";
                                txt_CCCD.Text = "";
                                txt_SDT.Text = "";
                                MessageBox.Show("Chuyển tiền thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Số tài khoản nhận không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Số tài khoản chuyển không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
