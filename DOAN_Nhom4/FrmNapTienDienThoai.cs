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
    public partial class FrmNapTienDienThoai : Form
    {
        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        private ThongTinTinDungDAO tttdDAO = new ThongTinTinDungDAO();
        private ThongTinTinDung tttd = new ThongTinTinDung();
        private int menhGia = 0;
        private string Stk = "";
        private string loaiTaiKhoan = "";
        private LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        private SoDienThoaiDAO sdtDAO = new SoDienThoaiDAO();
        private TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        public FrmNapTienDienThoai()
        {
            InitializeComponent();
        }
        
        public FrmNapTienDienThoai(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void FrmNapTienDienThoai_Load(object sender, EventArgs e)
        {
            btnTKThe.Text = tknh.SoTK.ToString();
            tttd = tttdDAO.LayThongTinTinDung("CCCD", kh.Cccd);
            if (tttd != null)
            {
                btnTKTinDung.Text = tttd.SoTKTinDung.ToString();
            }
            else
            {
                btnTKTinDung.Text = "";
                btnTKTinDung.Enabled = false;
            }
        }

        private void btn10k_Click(object sender, EventArgs e)
        {
            TienMacDinh();
            btn10k.ForeColor = Color.White;
            btn10k.BackColor = Color.FromArgb(75,115,165);
            btn10k.BorderColor = Color.White;
            menhGia = 10000;
        }

        private void btn20k_Click(object sender, EventArgs e)
        {
            TienMacDinh();
            btn20k.ForeColor = Color.White;
            btn20k.BackColor = Color.FromArgb(75, 115, 165);
            btn20k.BorderColor = Color.White;
            menhGia = 20000;
        }

        private void btn30k_Click(object sender, EventArgs e)
        {
            TienMacDinh();
            btn30k.ForeColor = Color.White;
            btn30k.BackColor = Color.FromArgb(75, 115, 165);
            btn30k.BorderColor = Color.White;
            menhGia = 30000;
        }

        private void btn50k_Click(object sender, EventArgs e)
        {
            TienMacDinh();
            btn50k.ForeColor = Color.White;
            btn50k.BackColor = Color.FromArgb(75, 115, 165);
            btn50k.BorderColor = Color.White;
            menhGia = 50000;
        }

        private void btn100k_Click(object sender, EventArgs e)
        {
            TienMacDinh();
            btn100k.ForeColor = Color.White;
            btn100k.BackColor = Color.FromArgb(75, 115, 165);
            btn100k.BorderColor = Color.White;
            menhGia = 100000;
        }

        private void btn200k_Click(object sender, EventArgs e)
        {
            TienMacDinh();
            btn200k.ForeColor = Color.White;
            btn200k.BackColor = Color.FromArgb(75, 115, 165);
            btn200k.BorderColor = Color.White;
            menhGia = 200000;
        }

        private void btn300k_Click(object sender, EventArgs e)
        {
            TienMacDinh();
            btn300k.ForeColor = Color.White;
            btn300k.BackColor = Color.FromArgb(75, 115, 165);
            btn300k.BorderColor = Color.White;
            menhGia = 300000;
        }

        private void btn500k_Click(object sender, EventArgs e)
        {
            TienMacDinh();
            btn500k.ForeColor = Color.White;
            btn500k.BackColor = Color.FromArgb(75, 115, 165);
            btn500k.BorderColor = Color.White;
            menhGia = 500000;
        }

        public void TienMacDinh()
        {
            btn10k.ForeColor = Color.Black;
            btn10k.BackColor = Color.WhiteSmoke;
            btn10k.BorderColor = Color.Black;
            btn20k.ForeColor = Color.Black;
            btn20k.BackColor = Color.WhiteSmoke;
            btn20k.BorderColor = Color.Black;
            btn30k.ForeColor = Color.Black;
            btn30k.BackColor = Color.WhiteSmoke;
            btn30k.BorderColor = Color.Black;
            btn50k.ForeColor = Color.Black;
            btn50k.BackColor = Color.WhiteSmoke;
            btn50k.BorderColor = Color.Black;
            btn100k.ForeColor = Color.Black;
            btn100k.BackColor = Color.WhiteSmoke;
            btn100k.BorderColor = Color.Black;
            btn200k.ForeColor = Color.Black;
            btn200k.BackColor = Color.WhiteSmoke;
            btn200k.BorderColor = Color.Black;
            btn300k.ForeColor = Color.Black;
            btn300k.BackColor = Color.WhiteSmoke;
            btn300k.BorderColor = Color.Black;
            btn500k.ForeColor = Color.Black;
            btn500k.BackColor = Color.WhiteSmoke;
            btn500k.BorderColor = Color.Black;
        }

        private void btnTKTinDung_Click(object sender, EventArgs e)
        {
            btnTKThe.ForeColor = Color.Black;
            btnTKThe.BackColor = Color.WhiteSmoke;
            btnTKTinDung.ForeColor = Color.White;
            btnTKTinDung.BackColor = Color.FromArgb(75, 115, 165);
            Stk = btnTKTinDung.Text;
            loaiTaiKhoan = "Tai Khoan Tin Dung";
        }

        private void btnTKThe_Click(object sender, EventArgs e)
        {
            btnTKThe.ForeColor = Color.White;
            btnTKThe.BackColor = Color.FromArgb(75, 115, 165);
            btnTKTinDung.ForeColor = Color.Black;
            btnTKTinDung.BackColor = Color.WhiteSmoke;
            Stk = btnTKThe.Text;
            loaiTaiKhoan = "HHB";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (loaiTaiKhoan != "")
            {
                if (menhGia != 0)
                {
                    GiaoDich gd = new GiaoDich("Nap tien dien thoai", loaiTaiKhoan, kh.TenTK, Stk, "So Dien Thoai", "So Dien Thoai", txtSoDienThoai.Text, menhGia, " ");
                    if (loaiTaiKhoan == "HHB" && tknh.SoDu < gd.SoTien)
                    {
                        MessageBox.Show("Số dư của bạn không đủ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (gd.SoTKNhan == "")
                        {
                            gd.SoTKNhan = kh.Sdt;
                        }
                        lsgdDAO.Them(gd);
                        SoDienThoai sdt = sdtDAO.LaySoDienThoai("SDT", gd.SoTKNhan);
                        sdtDAO.ThanhToanVienThong(sdt, gd);
                        tknh = tknhDAO.LayTaiKhoanNganHang("SoTK", tknh.SoTK, "TenNH", tknh.TenNH);
                        FrmThongbaoChuyentien frmThongbaoChuyentien = new FrmThongbaoChuyentien(kh, gd, tknh, pnlNguoiDung);
                        this.Hide();
                        frmThongbaoChuyentien.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn mệnh giá nạp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn loại thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
