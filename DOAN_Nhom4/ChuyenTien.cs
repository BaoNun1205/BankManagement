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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DOAN_Nhom4
{
    public partial class ChuyenTien : UserControl
    {
        public ChuyenTien()
        {
            InitializeComponent();
        }
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        NguoiDungDAO ndDAO = new NguoiDungDAO();
        DBConnection db = new DBConnection();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        private void btn_ChuyenTien_Click(object sender, EventArgs e)
        {
            TaiKhoanNganHang tkGui = new TaiKhoanNganHang();
            tkGui = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTKChuyen.Text);
            NguoiDung ndGui = new NguoiDung();
            ndGui = ndDAO.LayKhachHang("SoTK", txt_SoTKChuyen.Text);
            TaiKhoanNganHang tkNhan = new TaiKhoanNganHang();
            tkNhan = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTKNhan.Text);
            NguoiDung ndNhan = new NguoiDung();
            ndNhan = ndDAO.LayKhachHang("SoTK", txt_SoTKNhan.Text);
            GiaoDich gd = new GiaoDich("Chuyen Tien", tkGui.TenNH, ndGui.TenTK, tkGui.SoTK, tkNhan.TenNH, ndNhan.TenTK, tkNhan.SoTK, BigInteger.Parse(txt_SoTien.Text), "Chuyen tien");      
            if (tkGui != null)
            {
                if (tkNhan != null)
                {
                    if (txt_CCCD.Text == ndGui.Cccd)
                    {
                        if (txt_SDT.Text == ndGui.Sdt && db.IsPhone(txt_SDT.Text))
                        {
                            if (gd.SoTien > 0 && gd.SoTien <= tkGui.SoDu)
                            {
                                tknhDAO.ChuyenTien(tkGui, gd, tkNhan);
                                lsgdDAO.Them(gd);
                                txt_SoTKNhan.Text = "";
                                txt_SoTKChuyen.Text = "";
                                cb_TenNH.SelectedIndex = 0;
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

        private void ChuyenTien_Load(object sender, EventArgs e)
        {
            string[] items = { "HHB", "ACB", "Agribank", "BIDV", "Đông Á Bank", "Eximbank",
                "HDBank",  "MBBank", "OCB", "Sacombank", "SHB", "TPBank", "Vietcombank",
                "Vietinbank", "VietCapital Bank"};
            cb_TenNH.Items.AddRange(items);
        }

        public void HienThiThongTinNguoiChuyen()
        {
            NguoiDung ngDung = new NguoiDung();
            TaiKhoanNganHang tk = new TaiKhoanNganHang();
            ngDung = ndDAO.LayKhachHang("SoTK", txt_SoTKChuyen.Text);           
            tk = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTKChuyen.Text);
            if (ngDung != null)
            {
                txt_SoTKChuyen.Text = ngDung.SoTK.ToString();
                txt_TenTKChuyen.Text = ngDung.TenTK.ToString();
                txt_CCCD.Text = ngDung.Cccd.ToString();
                txt_SDT.Text = ngDung.Sdt.ToString();
                lblSoDu.Text = tk.SoDu.ToString();
            }
            else
            {
                txt_SoTKChuyen.Text = "";
                txt_CCCD.Text = "";
                txt_SDT.Text = "";
                lblSoDu.Text = "-";
            }
        }

        public void HienThiThongTinNguoiNhan()
        {
            NguoiDung ngDung = new NguoiDung();
            ngDung = ndDAO.LayKhachHang("SoTK", txt_SoTKNhan.Text, "TenNH", cb_TenNH.Text);

            if (ngDung != null)
            {
                txt_TenTKNhan.Text = ngDung.TenTK.ToString();
            }
            else
            {
                txt_TenTKNhan.Text = "";
            }
        }

        private void txt_SoTKChuyen_TextChanged(object sender, EventArgs e)
        {
            HienThiThongTinNguoiChuyen();
        }

        private void txt_SoTKNhan_TextChanged(object sender, EventArgs e)
        {
            HienThiThongTinNguoiNhan();
        }
    }
}
