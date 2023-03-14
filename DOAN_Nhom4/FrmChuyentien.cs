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
        public TaiKhoangNganHang tknh;
        NguoiDungDAO khDAO = new NguoiDungDAO();
        TaiKhoangNganHangDAO tknhDAO = new TaiKhoangNganHangDAO();
        public FrmChuyentien()
        {
            InitializeComponent();
            pnlChuyentien.Parent = picBoxChuyentien;
            pnlChuyentien.BackColor = Color.Transparent;
        }
        public FrmChuyentien(NguoiDung kh, TaiKhoangNganHang tknh)
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
            FrmTrangchu frmnguoidung = new FrmTrangchu(this.kh, tknh);
            this.Hide();
            frmnguoidung.ShowDialog();
            this.Close();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            if (lblTenTK.Text != "Khong ton tai" && int.Parse(lblSoDu.Text) > int.Parse(txtSoTien.Text))
            {
                GiaoDichChuyenTien gd = new GiaoDichChuyenTien(this.kh.TenTK, txtSTK.Text, int.Parse(txtSoTien.Text), cbTenNH.Text, txtLoiNhan.Text);
                FrmXacnhanChuyentien frmxacnhan = new FrmXacnhanChuyentien(this.kh, tknh, gd);
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
            TaiKhoangNganHang tk = new TaiKhoangNganHang();
            kh = khDAO.LayKhachHang("SoTK", txtSTK.Text);
            tk = tknhDAO.LayTaiKhoanNganHang("SoTK", txtSTK.Text);
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
