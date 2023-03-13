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
        public NguoiDung ngdung;
        public TaiKhoangNganHang tknh;
        private int kiHan;
        public FrmTietkiem()
        {
            InitializeComponent();
        }

        public FrmTietkiem(NguoiDung ngdung, TaiKhoangNganHang tknh)
        {
            InitializeComponent();
            this.ngdung = ngdung;
            this.tknh = tknh;
        }
        private void picBoxQuaylai_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung(ngdung, tknh);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
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

        private double TienLai(int tiengoc, double laisuat, int thoigian)
        {
            return tiengoc * laisuat * thoigian / 12;
        }

        private void btn1thang_Click(object sender, EventArgs e)
        {
            kiHan = 1;
            lblLaisuat.Text = "6%";
            btn1thang.ForeColor = Color.White;
            btn1thang.BackColor = Color.DodgerBlue;
            btn3thang.ForeColor = Color.DodgerBlue;
            btn3thang.BackColor = Color.White;
            btn6thang.ForeColor = Color.DodgerBlue;
            btn6thang.BackColor = Color.White;
            btn12thang.ForeColor = Color.DodgerBlue;
            btn12thang.BackColor = Color.White;
            btn18thang.ForeColor = Color.DodgerBlue;
            btn18thang.BackColor = Color.White;
        }

        private void btn3thang_Click(object sender, EventArgs e)
        {
            kiHan = 3;
            lblLaisuat.Text = "6%";
            btn1thang.ForeColor = Color.DodgerBlue;
            btn1thang.BackColor = Color.White;
            btn3thang.ForeColor = Color.White;
            btn3thang.BackColor = Color.DodgerBlue;
            btn6thang.ForeColor = Color.DodgerBlue;
            btn6thang.BackColor = Color.White;
            btn12thang.ForeColor = Color.DodgerBlue;
            btn12thang.BackColor = Color.White;
            btn18thang.ForeColor = Color.DodgerBlue;
            btn18thang.BackColor = Color.White;
        }

        private void btn6thang_Click(object sender, EventArgs e)
        {
            kiHan = 6;
            lblLaisuat.Text = "8%";
            btn1thang.ForeColor = Color.DodgerBlue;
            btn1thang.BackColor = Color.White;
            btn3thang.ForeColor = Color.DodgerBlue;
            btn3thang.BackColor = Color.White;
            btn6thang.ForeColor = Color.White;
            btn6thang.BackColor = Color.DodgerBlue;
            btn12thang.ForeColor = Color.DodgerBlue;
            btn12thang.BackColor = Color.White;
            btn18thang.ForeColor = Color.DodgerBlue;
            btn18thang.BackColor = Color.White;
        }

        private void btn12thang_Click(object sender, EventArgs e)
        {
            kiHan = 12;
            lblLaisuat.Text = "8,6%";
            btn1thang.ForeColor = Color.DodgerBlue;
            btn1thang.BackColor = Color.White;
            btn3thang.ForeColor = Color.DodgerBlue;
            btn3thang.BackColor = Color.White;
            btn6thang.ForeColor = Color.DodgerBlue;
            btn6thang.BackColor = Color.White;
            btn12thang.ForeColor = Color.White;
            btn12thang.BackColor = Color.DodgerBlue;
            btn18thang.ForeColor = Color.DodgerBlue;
            btn18thang.BackColor = Color.White;
        }

        private void btn18thang_Click(object sender, EventArgs e)
        {
            kiHan = 18;
            lblLaisuat.Text = "9%";
            btn1thang.ForeColor = Color.DodgerBlue;
            btn1thang.BackColor = Color.White;
            btn3thang.ForeColor = Color.DodgerBlue;
            btn3thang.BackColor = Color.White;
            btn6thang.ForeColor = Color.DodgerBlue;
            btn6thang.BackColor = Color.White;
            btn12thang.ForeColor = Color.DodgerBlue;
            btn12thang.BackColor = Color.White;
            btn18thang.ForeColor = Color.White;
            btn18thang.BackColor = Color.DodgerBlue;
        }
    }
}
