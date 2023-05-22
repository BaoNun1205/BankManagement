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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DOAN_Nhom4
{
    public partial class FrmTietkiem : Form
    {
        private KhachHang kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoidung;
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        TietkiemDAO tkiemDAO = new TietkiemDAO();

        private Random rand;
        int maTietKiem;
        private int loaiSo;
        private decimal tienGoc;
        private int kiHan;
        private double laiSuat;
        private decimal tienLai;
        private decimal tongTien;

        public FrmTietkiem()
        {
            InitializeComponent();
        }

        public FrmTietkiem(KhachHang kh, TaiKhoanNganHang tknh, Panel pnlNguoidung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoidung = pnlNguoidung;
        }

        private void FrmTietkiem_Load(object sender, EventArgs e)
        {
            tkiemDAO.KiemTraSoTietKiem(tknh);
            rand = new Random();
            maTietKiem = rand.Next(100000, 999999);
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                TaiKhoanTietKiem tkiem = new TaiKhoanTietKiem
                {
                    TenNh = tknh.TenNh,
                    SoTk = tknh.SoTk,
                    MaTietKiem = maTietKiem,
                    NgayDangKy = DateTime.Now,
                    TenTktk = txtTenTKTK.Text,
                    LoaiSo = loaiSo,
                    TienGoc = tienGoc,
                    KiHan = kiHan,
                    LaiSuat = (float)laiSuat,
                    TienLai = tienLai,
                    TongTien = tongTien
                };

                LichSuGiaoDich gd = new LichSuGiaoDich()
                {
                    LoaiGd = "Gui Tiet Kiem",
                    NganHangGui = kh.TenNh,
                    TenTkgui = kh.TenKh,                   
                    SoTkgui = kh.SoTk,                    
                    NganHangNhan = "HHB",
                    TenTknhan = tkiem.TenTktk,
                    SoTknhan = tkiem.MaTietKiem.ToString(),
                    ThoiGian = DateTime.Now,
                    SoTien = tkiem.TienGoc,
                    LoiNhan = "Gui tien tiet kiem"
                };

                tknh.SoDu = tknh.SoDu - tkiem.TienGoc;
                tknhDAO.Sua(tknh);
                tkiemDAO.Them(tkiem);
                lsgdDAO.Them(gd);
                MessageBox.Show("Tạo tài khoản tiết kiệm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh, pnlNguoidung);
                Utility.addForm(frmtietkiem, pnlNguoidung);
            }
            else MessageBox.Show("Vui lòng điền đầy đủ các thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblTKTK_Click(object sender, EventArgs e)
        {
            FrmXemTKTK frmxemtktk = new FrmXemTKTK(kh, tknh, pnlNguoidung);
            Utility.addForm(frmxemtktk, pnlNguoidung);
        }

        private void btn1thang_Click(object sender, EventArgs e)
        {
            kiHan = 1;
            lblLaisuat.Text = "6%";
            laiSuat = 0.06;
            HienThiThongTin();
            HienThiMacDinh();
            btn1thang.ForeColor = Color.White;
            btn1thang.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btn3thang_Click(object sender, EventArgs e)
        {
            kiHan = 3;
            lblLaisuat.Text = "6%";
            laiSuat = 0.06;
            HienThiThongTin();
            HienThiMacDinh();
            btn3thang.ForeColor = Color.White;
            btn3thang.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btn6thang_Click(object sender, EventArgs e)
        {
            kiHan = 6;
            lblLaisuat.Text = "8%";
            laiSuat = 0.08;
            HienThiThongTin();
            HienThiMacDinh();
            btn6thang.ForeColor = Color.White;
            btn6thang.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btn12thang_Click(object sender, EventArgs e)
        {
            kiHan = 12;
            lblLaisuat.Text = "8.6%";
            laiSuat = 0.086;
            HienThiThongTin();
            HienThiMacDinh();
            btn12thang.ForeColor = Color.White;
            btn12thang.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btn18thang_Click(object sender, EventArgs e)
        {
            kiHan = 18;
            lblLaisuat.Text = "9%";
            laiSuat = 0.09;
            HienThiThongTin();
            HienThiMacDinh();
            btn18thang.ForeColor = Color.White;
            btn18thang.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void cbLoaiSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiSTK.SelectedItem != null)
            {
                if (cbLoaiSTK.SelectedIndex == 0) loaiSo = 1;
                if (cbLoaiSTK.SelectedIndex == 1) loaiSo = 2;
                if (cbLoaiSTK.SelectedIndex == 2) loaiSo = 3;
            }
        }

        private void txtSotien_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSotien.Text))
            {
                txtSotien.Text = "";
            }
        }

        private void txtSotien_Leave(object sender, EventArgs e)
        {
            if (txtSotien.Text == "")
            {
                txtSotien.Text = "Bạn muốn gửi bao nhiêu?";
            }    
        }

        private void HienThiThongTin()
        {
            BigInteger kt;
            if (BigInteger.TryParse(txtSotien.Text, out kt) && tkiemDAO.ktSotien(decimal.Parse(txtSotien.Text), tknh.SoDu ?? 0))
            {
                tienGoc = decimal.Parse(txtSotien.Text);
                tienLai = tkiemDAO.TienLai(tienGoc, laiSuat, kiHan);
                lblTongtienlai.Text = tienLai.ToString("0");
                tongTien = tkiemDAO.TongTien(tienGoc, tienLai);
                lblTongtien.Text = tongTien.ToString("0");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại số tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSotien.Text = "Bạn muốn gửi bao nhiêu?";
            } 
                
        }

        private bool KiemTraThongTin()
        {
            if (txtTenTKTK.Text == "" || cbLoaiSTK.Text == "")
            { return false; }
            else { return true; }
        }

        private void HienThiMacDinh()
        {
            btn18thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn18thang.BackColor = Color.White;
            btn3thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn3thang.BackColor = Color.White;
            btn6thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn6thang.BackColor = Color.White;
            btn12thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn12thang.BackColor = Color.White;
            btn1thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn1thang.BackColor = Color.White;
        }

        
    }
}
