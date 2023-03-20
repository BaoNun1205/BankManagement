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
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        NguoiDungDAO khDAO = new NguoiDungDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        public FrmChuyentien()
        {
            InitializeComponent();
            pnlChuyentien.Parent = picBoxChuyentien;
            pnlChuyentien.BackColor = Color.Transparent;
        }
        public FrmChuyentien(NguoiDung kh, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            pnlChuyentien.Parent = picBoxChuyentien;
            pnlChuyentien.BackColor = Color.Transparent;
            this.kh = kh;
            this.tknh = tknh;
        }
        private void FrmChuyentien_Load(object sender, EventArgs e)
        {
            lblSoDu.Text = tknh.SoDu.ToString();
        }
       
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(this.kh, tknh);
            this.Hide();
            frmtrangchu.ShowDialog();
            this.Close();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            if (lblTenTK.Text != "Khong ton tai" && int.Parse(lblSoDu.Text) > int.Parse(txtSoTien.Text))
            {
                GiaoDich gd = new GiaoDich("Chuyen Tien", kh.TenNH, kh.TenTK, kh.SoTK, cbTenNH.Text, lblTenTK.Text, txtSTK.Text, int.Parse(txtSoTien.Text), txtLoiNhan.Text);
                FrmXacnhanChuyentien frmxacnhan = new FrmXacnhanChuyentien(kh, tknh, gd);
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
            IsTonTai();
        }

        private void cbTenNH_TextChanged(object sender, EventArgs e)
        {
            IsTonTai();
        }

        public void IsTonTai()
        {
            NguoiDung kh = new NguoiDung();
            TaiKhoanNganHang tk = new TaiKhoanNganHang();
            kh = khDAO.LayKhachHang("SoTK", txtSTK.Text, "TenNH", cbTenNH.Text);
            tk = tknhDAO.LayTaiKhoanNganHang("SoTK", txtSTK.Text, "TenNH", cbTenNH.Text);
            if (tk != null)
            {
                lblTenTK.Text = kh.TenTK.ToString();
            }
            else
            {
                lblTenTK.Text = "Khong ton tai";
            }
        }
    }
}
