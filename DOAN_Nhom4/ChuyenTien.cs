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


        private void ChuyenTien_Load(object sender, EventArgs e)
        {

        }

        public void HienThiThongTinNguoiChuyen()
        {
            NguoiDung ngDung = new NguoiDung();
            TaiKhoanNganHang tk = new TaiKhoanNganHang();
            ngDung = ndDAO.LayKhachHang("SoTK", txt_SoTKChuyen.Text, "TenNH", "HHB");           
            tk = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTKChuyen.Text, "TenNH", "HHB");
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
                txt_TenTKChuyen.Text = "Khong ton tai";
                txt_CCCD.Text = "";
                txt_SDT.Text = "";
                lblSoDu.Text = "-";
            }
        }

        public void HienThiThongTinNguoiNhan()
        {
            NguoiDung ngDungNhan = new NguoiDung();
            NguoiDung ngDungChuyen = new NguoiDung();
            ngDungNhan = ndDAO.LayKhachHang("SoTK", txt_SoTKNhan.Text, "TenNH", cb_TenNH.Text);
            ngDungChuyen = ndDAO.LayKhachHang("SoTK", txt_SoTKChuyen.Text, "TenNH", "HHB");
            if (ngDungNhan != null)
            {
                if(ngDungNhan.TenNH == ngDungChuyen.TenNH && ngDungNhan.SoTK == ngDungChuyen.SoTK)
                {
                    txt_TenTKNhan.Text = "Khong duoc chuyen cho chinh minh";
                }
                else
                    txt_TenTKNhan.Text = ngDungNhan.TenTK.ToString();
            }
            else
            {
                txt_TenTKNhan.Text = "Khong ton tai";
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

        private void btn_ChuyenTien_Click(object sender, EventArgs e)
        {
            TaiKhoanNganHang tkGui = new TaiKhoanNganHang();
            tkGui = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTKChuyen.Text, "TenNH", "HHB");
            NguoiDung ndGui = new NguoiDung();
            ndGui = ndDAO.LayKhachHang("SoTK", txt_SoTKChuyen.Text, "TenNH", "HHB");
            TaiKhoanNganHang tkNhan = new TaiKhoanNganHang();
            tkNhan = tknhDAO.LayTaiKhoanNganHang("SoTK", txt_SoTKNhan.Text, "TenNH", cb_TenNH.Text);
            NguoiDung ndNhan = new NguoiDung();
            ndNhan = ndDAO.LayKhachHang("SoTK", txt_SoTKNhan.Text, "TenNH", cb_TenNH.Text);
            GiaoDich gd = new GiaoDich("Chuyen Tien", tkGui.TenNH, ndGui.TenTK, tkGui.SoTK, tkNhan.TenNH, ndNhan.TenTK, tkNhan.SoTK, BigInteger.Parse(txt_SoTien.Text), "Chuyen tien");
            if (tkGui != null)
            {
                if (tkNhan != null)
                {
                    if (tkGui.TenNH != tkNhan.TenNH|| tkGui.TenNH == tkNhan.TenNH && tkGui.SoTK != tkNhan.SoTK)
                    {
                        if (gd.SoTien > 0 && gd.SoTien <= tkGui.SoDu)
                        {
                            tknhDAO.ChuyenTien(tkGui, gd, tkNhan);
                            lsgdDAO.Them(gd);
                            txt_SoTKNhan.Text = "";
                            txt_SoTKChuyen.Text = "";
                            cb_TenNH.Text = "HHB";
                            txt_SoTien.Text = "";
                            txt_CCCD.Text = "";
                            txt_SDT.Text = "";
                            MessageBox.Show("Chuyển tiền thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Số tiền không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Khong the thuc hien giao dich. Kiem tra lai !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }      
            }
            else
                MessageBox.Show("Số tài khoản chuyển không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            txt_SoTKChuyen.Text = "";
            txt_SoTien.Text = "";
            txt_CCCD.Text = "";
            txt_SDT.Text = "";
            txt_TenTKNhan.Text = "";
            txt_TenTKChuyen.Text = "";
            txt_TenTKNhan.Text = "";
            cb_TenNH.Text = "HHB";
            lblSoDu.Text = "-";
        }
    }
}
