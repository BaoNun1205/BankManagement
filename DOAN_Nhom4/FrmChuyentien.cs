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
    public partial class FrmChuyentien : Form
    {
        NguoiDungDAO NguoiDungDAO = new NguoiDungDAO();
        public NguoiDung nguoiDung;
        private string tenTK;
        public FrmChuyentien()
        {
            InitializeComponent();
            pnlChuyentien.Parent = picBoxChuyentien;
            pnlChuyentien.BackColor = Color.Transparent;
        }
        public FrmChuyentien(NguoiDung kh)
        {
            InitializeComponent();
            pnlChuyentien.Parent = picBoxChuyentien;
            pnlChuyentien.BackColor = Color.Transparent;
            nguoiDung = kh;
        }
        private void FrmChuyentien_Load(object sender, EventArgs e)
        {
            lblSoDu.Text = nguoiDung.SoDu.ToString();
        }
       
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmNguoidung frmnguoidung = new FrmNguoidung(nguoiDung);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            if (lblTenTK.Text != "Khong ton tai" && int.Parse(lblSoDu.Text) > int.Parse(txtSoTien.Text))
            {
                GiaoDichChuyenTien chuyenTien = new GiaoDichChuyenTien(tenTK, txtSTK.Text, int.Parse(txtSoTien.Text), cbTenNH.Text , txtLoiNhan.Text);
                FrmXacnhanChuyentien frmxacnhan = new FrmXacnhanChuyentien(nguoiDung);
                frmxacnhan.gdchuyentien = chuyenTien;
                this.Hide();
                frmxacnhan.ShowDialog();
                this.Close();
            }
            else
            {
                if (lblTenTK.Text == "Khong ton tai")
                    MessageBox.Show("Tai khoang khong ton tai");
                else
                    MessageBox.Show("So Du cua ban khong du");
            }
        }

        private void txtSTK_TextChanged(object sender, EventArgs e)
        {
            NguoiDung kh = new NguoiDung();
            kh = NguoiDungDAO.LayKhachHang("SoTK", txtSTK.Text);
            if (kh != null)
            {
                lblTenTK.Text = kh.TenTK.ToString();
                tenTK = kh.TenTK.ToString();
            }                   
            else
                lblTenTK.Text = "Khong ton tai";
        }
    }
}
