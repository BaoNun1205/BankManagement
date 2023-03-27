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
    public class ClassAddForm
    {
        static public void addForm(Form form, Panel pnlNguoidung)
        {
            pnlNguoidung.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlNguoidung.Controls.Add(form);
            pnlNguoidung.Tag = form;
            form.Show();
        }
    }
    public partial class FrmNguoidung : Form
    {
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        public GiaoDich gd;
        public FrmNguoidung()
        {
            InitializeComponent();
        }

        public FrmNguoidung(NguoiDung kh, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh);
            //addForm(frmtrangchu);
            DOAN_Nhom4.ClassAddForm.addForm(frmtrangchu, pnlNguoidung);
            this.kh = kh;
            this.tknh = tknh;
        }

        public FrmNguoidung(NguoiDung kh, TaiKhoanNganHang tknh, GiaoDich gd)
        {
            InitializeComponent();
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh);
            //addForm(frmtrangchu);
            DOAN_Nhom4.ClassAddForm.addForm(frmtrangchu, pnlNguoidung);
            this.kh = kh;
            this.tknh = tknh;
            this.gd = gd;
        }

        private void FrmNguoidung_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = kh.TenTK.ToString();
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan(kh, tknh);
            //addForm(frmHienThiThongTinCaNhan);
            DOAN_Nhom4.ClassAddForm.addForm(frmHienThiThongTinCaNhan, pnlNguoidung);
        }

        private void btnChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(kh, tknh);
            //addForm(frmchuyentien);
            DOAN_Nhom4.ClassAddForm.addForm(frmchuyentien, pnlNguoidung);
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh);
            //addForm(frmtrangchu);
            DOAN_Nhom4.ClassAddForm.addForm(frmtrangchu, pnlNguoidung);
        }

        private void btnTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh, pnlNguoidung);
            //addForm(frmtietkiem);
            DOAN_Nhom4.ClassAddForm.addForm(frmtietkiem, pnlNguoidung);
        }

        private void btnTienich_Click(object sender, EventArgs e)
        {
            FrmTienIch frmTienIch = new FrmTienIch(kh, tknh, pnlNguoidung);
            //addForm(frmTienIch);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIch, pnlNguoidung);
        }

        private void pBThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
