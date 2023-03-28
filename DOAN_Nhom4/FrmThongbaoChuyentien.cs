﻿using System;
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
    public partial class FrmThongbaoChuyentien : Form
    {
        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private GiaoDich gd;
        private Panel pnlNguoidung;
        public FrmThongbaoChuyentien()
        {
            InitializeComponent();
        }

        public FrmThongbaoChuyentien(NguoiDung kh, GiaoDich gd, TaiKhoanNganHang tknh, Panel pnlNguoidung)
        {
            InitializeComponent();
            this.kh = kh;
            this.gd = gd;
            this.tknh = tknh;
            this.pnlNguoidung = pnlNguoidung;
        }
        private void FrmThongbaoChuyentien_Load(object sender, EventArgs e)
        {
            lblSotien.Text = gd.SoTien.ToString() + " VNĐ";
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblNguoinhan.Text = gd.TenTKNhan.ToString();
            lblSTK.Text = gd.SoTKNhan.ToString();
            lblNganhang.Text = gd.NganHangNhan.ToString();
            lblNoidung.Text = gd.LoiNhan.ToString();
        }

        private void btnVetrangchu_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh, pnlNguoidung);
            this.Hide();
            DOAN_Nhom4.ClassAddForm.addForm(frmtrangchu, pnlNguoidung);
            this.Close();
        }
    }
}
