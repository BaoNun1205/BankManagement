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
        public NguoiDung nguoiDung;
        public TaiKhoanNganHang tknh;
        private Panel pnlNguoidung;
        NguoiDungDAO khDAO = new NguoiDungDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        ChuyenTienDAO ChuyenTienDAO = new ChuyenTienDAO();
        List<string> danhSachSTKNgDung = new List<string>();
        List<NguoiDung> danhSachNguoiDung = new List<NguoiDung>();
        public FrmChuyentien()
        {
            InitializeComponent();
        }
        public FrmChuyentien(NguoiDung nguoiDung, TaiKhoanNganHang tknh, Panel pnlNguoidung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.pnlNguoidung = pnlNguoidung;
        }
        private void FrmChuyentien_Load(object sender, EventArgs e)
        {
            danhSachSTKNgDung = ChuyenTienDAO.LayThongTinSTKNhan(nguoiDung.SoTK);
            foreach (string stk in danhSachSTKNgDung)
            {
                NguoiDung ngDung = new NguoiDung();
                ngDung = ChuyenTienDAO.LayThongTinKhachHang("SoTK", stk);
                danhSachNguoiDung.Add(ngDung);
            }
            cbTennguoinhan.Items.AddRange(danhSachNguoiDung.ToArray());
            cbTennguoinhan.DisplayMember = "ThongTinCoBan";
            lblSoDu.Text = tknh.SoDu.ToString("N0") + " VND";
        }
       
        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(nguoiDung, tknh);
            DOAN_Nhom4.ClassAddForm.addForm(frmtrangchu, pnlNguoidung);
        }

        enum KiemTraTenNguoiNhan
        {
            hople,
            khongtontai,
            chinhban
        }

        KiemTraTenNguoiNhan kt;

        public void IsTonTai()
        {
            NguoiDung ngDung = new NguoiDung();
            TaiKhoanNganHang tk = new TaiKhoanNganHang();
            ngDung = khDAO.LayKhachHang("SoTK", txtSTK.Text, "TenNH", cbTenNH.Text);
            tk = tknhDAO.LayTaiKhoanNganHang("SoTK", txtSTK.Text, "TenNH", cbTenNH.Text);
            if (tk != null)
            {
                kt = KiemTraTenNguoiNhan.hople;
                txtTennguoinhan.Text = ngDung.TenTK.ToString();
                txtTennguoinhan.ForeColor = Color.Black;
            }
            else
            {
                kt = KiemTraTenNguoiNhan.khongtontai;
                txtTennguoinhan.Text = "Không tồn tại";
                txtTennguoinhan.ForeColor = Color.Black;
            }
            if (txtSTK.Text == nguoiDung.soTK)
            {
                kt = KiemTraTenNguoiNhan.chinhban;
                txtTennguoinhan.Text = "Không thể chuyển tiền cho cho chính bạn";
                txtTennguoinhan.ForeColor = Color.Red;
            }
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
                if (txtLoiNhan.Text == "") txtLoiNhan.Text = string.Format("{0} da chuyen {1}VND den {2} ", nguoiDung.TenTK.ToString(), txtSoTien.Text, txtTennguoinhan.Text); 
                GiaoDich gd = new GiaoDich("Chuyen Tien", nguoiDung.TenNH, nguoiDung.TenTK, nguoiDung.SoTK, cbTenNH.Text, txtTennguoinhan.Text, txtSTK.Text, int.Parse(txtSoTien.Text), txtLoiNhan.Text);
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

        void XoaThongTin()
        {
            cbTenNH.Text = "";
            txtSTK.Text = "";
            cbTennguoinhan.Text = "";
            txtSoTien.Text = "";
            txtLoiNhan.Text = "";
        }

        private void txtSTK_TextChanged(object sender, EventArgs e)
        {
            IsTonTai();
        }

        private void cbTenNH_TextChanged(object sender, EventArgs e)
        {
            IsTonTai();
        }

        private void cbTennguoinhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTennguoinhan.SelectedItem != null && cbTennguoinhan.SelectedItem is NguoiDung)
            {
                NguoiDung ngDung = (NguoiDung)cbTennguoinhan.SelectedItem;
                cbTenNH.Text = ngDung.tenNH.ToString();
                txtSTK.Text = ngDung.soTK.ToString();
                txtTennguoinhan.Text = ngDung.TenTK.ToString();
            }
        }
    }
}
