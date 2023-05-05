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
        private Random rand;
        int maTietKiem;
        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoidung;
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        TietkiemDAO tkiemDAO = new TietkiemDAO();

        private string tenTKTK;
        private int loaiSo;
        private BigInteger tienGoc;
        private int kiHan;
        private double laiSuat;
        private BigInteger tienLai;
        private BigInteger tongTien;
        public FrmTietkiem()
        {
            InitializeComponent();
        }

        public FrmTietkiem(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoidung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoidung = pnlNguoidung;
        }

        public enum LoaiSoTietKiem
        {
            Loai1,
            Loai2,
            Loai3
        }

        private void FrmTietkiem_Load(object sender, EventArgs e)
        {
            tkiemDAO.KiemTraSoTietKiem(tknh);
            rand = new Random();
            maTietKiem = rand.Next(100000, 999999);
            foreach (LoaiSoTietKiem gt in Enum.GetValues(typeof(LoaiSoTietKiem)))
            {
                cbLoaiSTK.Items.Add(new KeyValuePair<LoaiSoTietKiem, string>(gt, gt.NoiDungLoaiSoTietKiem()));
            }
        }

        private void cbLoaiSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiSTK.SelectedItem != null)
            {
                KeyValuePair<LoaiSoTietKiem, string> selectedValue = (KeyValuePair<LoaiSoTietKiem, string>)cbLoaiSTK.SelectedItem;
                LoaiSoTietKiem loai = selectedValue.Key;
                string noidung = selectedValue.Value;

                if (loai == LoaiSoTietKiem.Loai1) loaiSo = 1;
                if (loai == LoaiSoTietKiem.Loai2) loaiSo = 2;
                if (loai == LoaiSoTietKiem.Loai3) loaiSo = 3;
            }
        }

        private void txtSotien_Enter(object sender, EventArgs e)
        {
            if (txtSotien.Text == "Bạn muốn gửi bao nhiêu?")
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
            if (BigInteger.TryParse(txtSotien.Text, out kt))
            {
                if (tkiemDAO.ktSotien(BigInteger.Parse(txtSotien.Text), tknh.SoDu) == true)
                {
                    tienGoc = BigInteger.Parse(txtSotien.Text);
                    tienLai = tkiemDAO.TienLai(tienGoc, laiSuat, kiHan);
                    lblTongtienlai.Text = tienLai.ToString();
                    tongTien = tkiemDAO.TongTien(tienGoc, tienLai);
                    lblTongtien.Text = tongTien.ToString();
                }
                else { MessageBox.Show("Vui lòng nhập lại số tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }          
        }

        private bool KiemTraThongTin()
        {
            if (txtTenTKTK.Text == "" || cbLoaiSTK.Text == "")
            { return false; }
            else { return true; }
        }
        private void btn1thang_Click(object sender, EventArgs e)
        {
            kiHan = 1;
            lblLaisuat.Text = "6%";
            laiSuat = 0.06;
            HienThiThongTin();

              btn1thang.ForeColor = Color.White;
              btn1thang.BackColor = Color.FromArgb(2, 69, 158);
              btn3thang.ForeColor = Color.FromArgb(2, 69, 158);
              btn3thang.BackColor = Color.White;
              btn6thang.ForeColor = Color.FromArgb(2, 69, 158);
              btn6thang.BackColor = Color.White;
              btn12thang.ForeColor = Color.FromArgb(2, 69, 158);
              btn12thang.BackColor = Color.White;
              btn18thang.ForeColor = Color.FromArgb(2, 69, 158);
              btn18thang.BackColor = Color.White;
        }

        private void btn3thang_Click(object sender, EventArgs e)
        {
            kiHan = 3;
            lblLaisuat.Text = "6%";
            laiSuat = 0.06;
            HienThiThongTin();

            btn3thang.ForeColor = Color.White;
            btn3thang.BackColor = Color.FromArgb(2, 69, 158);
            btn1thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn1thang.BackColor = Color.White;
            btn6thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn6thang.BackColor = Color.White;
            btn12thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn12thang.BackColor = Color.White;
            btn18thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn18thang.BackColor = Color.White;
        }

        private void btn6thang_Click(object sender, EventArgs e)
        {
            kiHan = 6;
            lblLaisuat.Text = "8%";
            laiSuat = 0.08;
            HienThiThongTin();

            btn6thang.ForeColor = Color.White;
            btn6thang.BackColor = Color.FromArgb(2, 69, 158);
            btn3thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn3thang.BackColor = Color.White;
            btn1thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn1thang.BackColor = Color.White;
            btn12thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn12thang.BackColor = Color.White;
            btn18thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn18thang.BackColor = Color.White;
        }

        private void btn12thang_Click(object sender, EventArgs e)
        {
            kiHan = 12;
            lblLaisuat.Text = "8,6%";
            laiSuat = 0.086;
            HienThiThongTin();

            btn12thang.ForeColor = Color.White;
            btn12thang.BackColor = Color.FromArgb(2, 69, 158);
            btn3thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn3thang.BackColor = Color.White;
            btn6thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn6thang.BackColor = Color.White;
            btn1thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn1thang.BackColor = Color.White;
            btn18thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn18thang.BackColor = Color.White;
        }

        private void btn18thang_Click(object sender, EventArgs e)
        {
            kiHan = 18;
            lblLaisuat.Text = "9%";
            laiSuat = 0.09;
            HienThiThongTin();

            btn18thang.ForeColor = Color.White;
            btn18thang.BackColor = Color.FromArgb(2, 69, 158);
            btn3thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn3thang.BackColor = Color.White;
            btn6thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn6thang.BackColor = Color.White;
            btn12thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn12thang.BackColor = Color.White;
            btn1thang.ForeColor = Color.FromArgb(2, 69, 158);
            btn1thang.BackColor = Color.White;
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin() == true)
            {
                tknh.SoDu = tknh.SoDu - tienGoc;
                tknhDAO.Sua(tknh);
                tenTKTK = txtTenTKTK.Text;
                TietKiem tkiem = new TietKiem(maTietKiem, DateTime.Now, tenTKTK, loaiSo, tienGoc, kiHan, laiSuat, tienLai, tongTien);
                GiaoDich gd = new GiaoDich("Gui tiet kiem", kh.TenNH, kh.TenTK, kh.SoTK, "HHB", txtTenTKTK.Text, maTietKiem.ToString(), int.Parse(txtSotien.Text), "");
                NguoiDung ngdung = new NguoiDung();
                ngdung = kh;
                tkiemDAO.Them(tkiem, ngdung);
                lsgdDAO.Them(gd);
                MessageBox.Show("Tạo tài khoản tiết kiệm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh, pnlNguoidung);
                DOAN_Nhom4.ClassAddForm.addForm(frmtietkiem, pnlNguoidung);
            }    
            else MessageBox.Show("Vui lòng điền đầy đủ các thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblTKTK_Click(object sender, EventArgs e)
        {
            FrmXemTKTK frmxemtktk = new FrmXemTKTK(kh, tknh, pnlNguoidung);
            DOAN_Nhom4.ClassAddForm.addForm(frmxemtktk, pnlNguoidung);
        }



        private void pnlTietkiem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
