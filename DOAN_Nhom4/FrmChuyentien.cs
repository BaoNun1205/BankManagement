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
        private Panel pnlNguoidung;
        NguoiDungDAO khDAO = new NguoiDungDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        ChuyenTienDAO ChuyenTienDAO = new ChuyenTienDAO();
        List<string> danhSachLuaChon = new List<string>();
        public FrmChuyentien()
        {
            InitializeComponent();
        }
        public FrmChuyentien(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoidung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoidung = pnlNguoidung;
            danhSachLuaChon = ChuyenTienDAO.LayThongTinSTKNhan();
            cbTennguoinhan.Items.AddRange(danhSachLuaChon.ToArray());
        }
        private void FrmChuyentien_Load(object sender, EventArgs e)
        {
            lblSoDu.Text = tknh.SoDu.ToString();
        }
       
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(this.kh, tknh);
            DOAN_Nhom4.ClassAddForm.addForm(frmtrangchu, pnlNguoidung);
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            if (cbTennguoinhan.Text != "Khong ton tai" && int.Parse(lblSoDu.Text) > int.Parse(txtSoTien.Text))
            {
                GiaoDich gd = new GiaoDich("Chuyen Tien", kh.TenNH, kh.TenTK, kh.SoTK, cbTenNH.Text, cbTennguoinhan.Text, txtSTK.Text, int.Parse(txtSoTien.Text), txtLoiNhan.Text);
                FrmXacnhanChuyentien frmxacnhan = new FrmXacnhanChuyentien(kh, tknh, gd, pnlNguoidung);
                frmxacnhan.ShowDialog();
                this.Close();
            }
            else
            {
                if (cbTennguoinhan.Text == "Khong ton tai")
                    MessageBox.Show("Tai khoan khong ton tai");
                else
                    MessageBox.Show("So du cua ban khong du");
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
                cbTennguoinhan.Text = kh.TenTK.ToString();
            }
            else
            {
                cbTennguoinhan.Text = "Khong ton tai";
            }
        }

        private void cbTennguoinhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            NguoiDung ngDung = new NguoiDung();
            ngDung = ChuyenTienDAO.LayThongTinKhachHang("TenKH", cbTennguoinhan.Text);
            cbTenNH.Text = ngDung.tenNH.ToString();
            txtSTK.Text = ngDung.soTK.ToString();
        }
    }
}
