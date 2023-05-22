using DOAN_Nhom4.Entities;
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
    public partial class FrmThongbaoChuyentien : Form
    {
        private KhachHang kh;
        private TaiKhoanNganHang tknh;
        private LichSuGiaoDich gd;
        private Panel pnlNguoidung;
        public FrmThongbaoChuyentien()
        {
            InitializeComponent();
        }

        public FrmThongbaoChuyentien(KhachHang kh, LichSuGiaoDich gd, TaiKhoanNganHang tknh, Panel pnlNguoidung)
        {
            InitializeComponent();
            this.kh = kh;
            this.gd = gd;
            this.tknh = tknh;
            this.pnlNguoidung = pnlNguoidung;
        }

        private void FrmThongbaoChuyentien_Load(object sender, EventArgs e)
        {
            lblSotien.Text = gd.SoTien.Value.ToString("N0") + " VNĐ";
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblNguoinhan.Text = gd.TenTknhan.ToString();
            lblSTK.Text = gd.SoTknhan.ToString();
            lblNganhang.Text = gd.NganHangNhan.ToString();
            txtNoidung.Text = gd.LoiNhan.ToString();
            lblHienThiLoai.Text = gd.LoaiGd.ToString();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmNguoidung))
                {
                    form.Hide();
                    form.Close();
                }
            }
        }

        private void btnVetrangchu_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung(kh, tknh);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }
    }
}
