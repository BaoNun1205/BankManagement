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
    public partial class FrmTietkiem : Form
    {
        private Random rand;
        int ID;
        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoidung;
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        TietkiemDAO tkiemDAO = new TietkiemDAO();

        private string tenTKTK;
        private int tienGoc;
        private int kiHan;
        private double laiSuat;
        private double tienLai;
        private double tongTien;
        public FrmTietkiem()
        {
            InitializeComponent();
        }

        public FrmTietkiem(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoidung)
        {
            InitializeComponent();
            txtTenTKTK.Focus();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoidung = pnlNguoidung;
            rand = new Random();
            ID = rand.Next(100000, 999999);
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
        private void btn1thang_Click(object sender, EventArgs e)
        {
            kiHan = 1;
            lblLaisuat.Text = "6%";
            laiSuat = 0.06;
            if (txtSotien.Text != "Bạn muốn gửi bao nhiêu?")
            {
                if (tkiemDAO.ktSotien(int.Parse(txtSotien.Text), tknh.SoDu) == true)
                {
                    tienGoc = int.Parse(txtSotien.Text);
                    tienLai = tkiemDAO.TienLai(tienGoc, laiSuat, kiHan);
                    lblTongtienlai.Text = tienLai.ToString();
                    tongTien = tkiemDAO.TongTien(tienGoc, tienLai);
                    lblTongtien.Text = tongTien.ToString();
                }
                else { MessageBox.Show("Vui lòng nhập lại số tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
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
            if (txtSotien.Text != "Bạn muốn gửi bao nhiêu?")
            {
                if (tkiemDAO.ktSotien(int.Parse(txtSotien.Text), tknh.SoDu) == true)
                {
                    tienGoc = int.Parse(txtSotien.Text);
                    tienLai = tkiemDAO.TienLai(tienGoc, laiSuat, kiHan);
                    lblTongtienlai.Text = tienLai.ToString();
                    tongTien = tkiemDAO.TongTien(tienGoc, tienLai);
                    lblTongtien.Text = tongTien.ToString();
                }
                else { MessageBox.Show("Vui lòng nhập lại số tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
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
            if (txtSotien.Text != "Bạn muốn gửi bao nhiêu?")
            {
                if (tkiemDAO.ktSotien(int.Parse(txtSotien.Text), tknh.SoDu) == true)
                {
                    tienGoc = int.Parse(txtSotien.Text);
                    tienLai = tkiemDAO.TienLai(tienGoc, laiSuat, kiHan);
                    lblTongtienlai.Text = tienLai.ToString();
                    tongTien = tkiemDAO.TongTien(tienGoc, tienLai);
                    lblTongtien.Text = tongTien.ToString();
                }
                else { MessageBox.Show("Vui lòng nhập lại số tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
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
            if (txtSotien.Text != "Bạn muốn gửi bao nhiêu?")
            {
                if (tkiemDAO.ktSotien(int.Parse(txtSotien.Text), tknh.SoDu) == true)
                {
                    tienGoc = int.Parse(txtSotien.Text);
                    tienLai = tkiemDAO.TienLai(tienGoc, laiSuat, kiHan);
                    lblTongtienlai.Text = tienLai.ToString();
                    tongTien = tkiemDAO.TongTien(tienGoc, tienLai);
                    lblTongtien.Text = tongTien.ToString();
                }
                else { MessageBox.Show("Vui lòng nhập lại số tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
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
            if (txtSotien.Text != "Bạn muốn gửi bao nhiêu?")
            {
                if (tkiemDAO.ktSotien(int.Parse(txtSotien.Text), tknh.SoDu) == true)
                {
                    tienGoc = int.Parse(txtSotien.Text);
                    tienLai = tkiemDAO.TienLai(tienGoc, laiSuat, kiHan);
                    lblTongtienlai.Text = tienLai.ToString();
                    tongTien = tkiemDAO.TongTien(tienGoc, tienLai);
                    lblTongtien.Text = tongTien.ToString();
                }
                else { MessageBox.Show("Vui lòng nhập lại số tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
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
            tknh.SoDu = tknh.SoDu - tienGoc;
            tknhDAO.Sua(tknh);
            tenTKTK = txtTenTKTK.Text;
            TietKiem tkiem = new TietKiem(ID, tenTKTK, tienGoc, kiHan, laiSuat, tienLai, tongTien);
            tkiemDAO.Them(tkiem);
            MessageBox.Show("Tạo tài khoản tiết kiệm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh, pnlNguoidung);
            DOAN_Nhom4.ClassAddForm.addForm(frmtietkiem, pnlNguoidung);
        }

        private void lblTKTK_Click(object sender, EventArgs e)
        {
            FrmXemTKTK frmxemtktk = new FrmXemTKTK(kh, tknh, pnlNguoidung);
            DOAN_Nhom4.ClassAddForm.addForm(frmxemtktk, pnlNguoidung);
        }
    }
}
