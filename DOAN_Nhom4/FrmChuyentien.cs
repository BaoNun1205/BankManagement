using DOAN_Nhom4.Entities;
using Microsoft.VisualStudio.Services.FormInput;
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
        public KhachHang nguoiDung;
        public TaiKhoanNganHang tknh;
        private Panel pnlNguoidung;
        NguoiDungDAO khDAO = new NguoiDungDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        ChuyenTienDAO ChuyenTienDAO = new ChuyenTienDAO();

        List<GiaoDich> danhSachGiaoDich = new List<GiaoDich>();

        enum KiemTraTenNguoiNhan
        {
            hople,
            khongtontai,
            chinhban
        }
        KiemTraTenNguoiNhan kt;
        public FrmChuyentien()
        {
            InitializeComponent();
        }

        public FrmChuyentien(KhachHang nguoiDung, TaiKhoanNganHang tknh, Panel pnlNguoidung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.pnlNguoidung = pnlNguoidung;
        }

        private void FrmChuyentien_Load(object sender, EventArgs e)
        {
            danhSachGiaoDich = ChuyenTienDAO.LayDanhSachGiaoDich(nguoiDung.SoTk);
            cbTennguoinhan.Items.AddRange(danhSachGiaoDich.ToArray());
            cbTennguoinhan.DisplayMember = "ThongTinCoBan";
            lblSoDu.Text = tknh.SoDu.Value.ToString("N0") + " VND";
        }
       
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(nguoiDung, tknh);
            Utility.addForm(frmtrangchu, pnlNguoidung);
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            if (cbTenNH.Text == "" || txtSTK.Text == "" || txtTennguoinhan.Text == "" || txtSoTien.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (int.Parse(txtSoTien.Text) < 10000)
            {
                MessageBox.Show("Vui lòng nhập tối thiểu 10000VNĐ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (kt == KiemTraTenNguoiNhan.hople && tknh.SoDu >= int.Parse(txtSoTien.Text))
            {
                if (txtLoiNhan.Text == "") txtLoiNhan.Text = string.Format("{0} da chuyen {1}VND den {2} ", nguoiDung.TenKh.ToString(), txtSoTien.Text, txtTennguoinhan.Text);
                GiaoDich gd = new GiaoDich("Chuyen Tien", nguoiDung.TenNh, nguoiDung.TenKh, nguoiDung.SoTk, cbTenNH.Text, txtTennguoinhan.Text, txtSTK.Text, int.Parse(txtSoTien.Text), txtLoiNhan.Text);
                FrmXacnhanChuyentien frmxacnhan = new FrmXacnhanChuyentien(nguoiDung, tknh, gd, pnlNguoidung);
                frmxacnhan.ShowDialog();
                this.Close();
            }
            else
            {
                if (kt == KiemTraTenNguoiNhan.khongtontai)
                { MessageBox.Show("Tài khoản không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else if (kt == KiemTraTenNguoiNhan.chinhban)
                { MessageBox.Show("Không thể chuyển tiền cho cho chính bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                { MessageBox.Show("Số dư của bạn không đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                XoaThongTin();
            }
        }

        private void txtSTK_TextChanged(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void cbTenNH_TextChanged(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void cbTennguoinhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTennguoinhan.SelectedItem != null && cbTennguoinhan.SelectedItem is GiaoDich)
            {
                GiaoDich gd = (GiaoDich)cbTennguoinhan.SelectedItem;
                cbTenNH.Text = gd.NganHangNhan.ToString();
                txtSTK.Text = gd.SoTKNhan.ToString();
                txtTennguoinhan.Text = gd.TenTKNhan.ToString();
            }
        }

        public void HienThiThongTin()
        {
            KhachHang ngDung = new KhachHang();
            TaiKhoanNganHang tk = new TaiKhoanNganHang();
            ngDung = khDAO.LayKhachHang(txtSTK.Text, cbTenNH.Text);
            tk = tknhDAO.LayTaiKhoanNganHang(txtSTK.Text, cbTenNH.Text);
            if (tk != null)
            {
                kt = KiemTraTenNguoiNhan.hople;
                txtTennguoinhan.Text = ngDung.TenKh.ToString();
                txtTennguoinhan.ForeColor = Color.Black;
            }
            else
            {
                kt = KiemTraTenNguoiNhan.khongtontai;
                txtTennguoinhan.Text = "Không tồn tại";
                txtTennguoinhan.ForeColor = Color.Black;
            }
            if (txtSTK.Text == nguoiDung.SoTk && cbTenNH.Text == nguoiDung.TenNh)
            {
                kt = KiemTraTenNguoiNhan.chinhban;
                txtTennguoinhan.Text = "Không thể chuyển tiền cho cho chính bạn";
                txtTennguoinhan.ForeColor = Color.Red;
            }
        }
        
        void XoaThongTin()
        {
            cbTenNH.Text = "";
            txtSTK.Text = "";
            cbTennguoinhan.Text = "";
            txtSoTien.Text = "";
            txtLoiNhan.Text = "";
        }
    }
}
