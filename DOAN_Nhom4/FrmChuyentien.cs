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
        List<string> danhSachLuaChon = new List<string>();
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
            danhSachLuaChon = ChuyenTienDAO.LayThongTinSTKNhan();
            cbTennguoinhan.Items.AddRange(danhSachLuaChon.ToArray());
        }
        private void FrmChuyentien_Load(object sender, EventArgs e)
        {
            lblSoDu.Text = tknh.SoDu.ToString();
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
                cbTennguoinhan.Text = ngDung.TenTK.ToString();
                cbTennguoinhan.ForeColor = Color.Black;
            }
            else
            {
                kt = KiemTraTenNguoiNhan.khongtontai;
                cbTennguoinhan.Text = "Không tồn tại";
                cbTennguoinhan.ForeColor = Color.Black;
            }
            if (txtSTK.Text == nguoiDung.soTK)
            {
                kt = KiemTraTenNguoiNhan.chinhban;
                cbTennguoinhan.Text = "Không thể chuyển tiền cho cho chính bạn";
                cbTennguoinhan.ForeColor = Color.Red;
            }
        }
        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            if (cbTenNH.Text == "" || txtSTK.Text == "" || cbTennguoinhan.Text == "" || txtSoTien.Text == "")
            {
                { MessageBox.Show("Vui lòng điền đầy đủ các thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else if (kt == KiemTraTenNguoiNhan.hople && int.Parse(lblSoDu.Text) > int.Parse(txtSoTien.Text))
            {
                if (txtLoiNhan.Text == "") txtLoiNhan.Text = nguoiDung.TenTK.ToString() + " da chuyen tien den " + cbTennguoinhan.Text; 
                GiaoDich gd = new GiaoDich("Chuyen Tien", nguoiDung.TenNH, nguoiDung.TenTK, nguoiDung.SoTK, cbTenNH.Text, cbTennguoinhan.Text, txtSTK.Text, int.Parse(txtSoTien.Text), txtLoiNhan.Text);
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
            NguoiDung ngDung = new NguoiDung();
            ngDung = ChuyenTienDAO.LayThongTinKhachHang("TenKH", cbTennguoinhan.Text);
            cbTenNH.Text = ngDung.tenNH.ToString();
            txtSTK.Text = ngDung.soTK.ToString();
        }
    }
}
