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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DOAN_Nhom4
{
    public partial class FrmXemTKTK : Form
    {
        TietkiemDAO tietkiemDAO = new TietkiemDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        List<TietKiem> danhSachTietKiem = new List<TietKiem>();
        List<string> danhSachLuaChon = new List<string>();

        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoidung;

        private DateTime ngayDangky;

        public FrmXemTKTK()
        {
            InitializeComponent();
        }

        public FrmXemTKTK(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoidung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoidung = pnlNguoidung;
        }

        private void FrmXemTKTK_Load(object sender, EventArgs e)
        {
            danhSachLuaChon = tietkiemDAO.LayCotTKTK("ID");
            foreach (string matk in danhSachLuaChon)
            {
                TietKiem tkiem = new TietKiem();
                tkiem = tietkiemDAO.LayHangTKTK("ID", matk);
                danhSachTietKiem.Add(tkiem);
            }    
            cbTenTKTK.Items.AddRange(danhSachTietKiem.ToArray());
            cbTenTKTK.DisplayMember = "TenTKTK";
        }

        private void btnRuttien_Click(object sender, EventArgs e)
        {
            if (cbTenTKTK.Text == "")
                if (cbTenTKTK.Items.Count == 0) MessageBox.Show("Bạn chưa có tài khoản tiết kiệm nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Vui lòng chọn tài khoản tiết kiệm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DialogResult luachon = MessageBox.Show("Nếu rút trước thời hạn, bạn sẽ không được tính tiền lãi, bạn chắc chắn muốn rút không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (luachon == DialogResult.Yes)
                {
                    TietKiem tkiem = new TietKiem(int.Parse(lblMatietkiem.Text), ngayDangky, cbTenTKTK.Text, BigInteger.Parse(txtTiengoc.Text), int.Parse(txtKihan.Text), double.Parse(lblLaisuat.Text), BigInteger.Parse(lblTienlai.Text), BigInteger.Parse(lblTongtien.Text));
                    GiaoDich gd = new GiaoDich("Rut tiet kiem", kh.TenNH, tkiem.TenTKTK, tkiem.MaTietKiem.ToString(), "HHB", kh.tenTK, kh.SoTK, tkiem.TienGoc, "");
                    tknh.SoDu = tknh.SoDu + tkiem.TienGoc;
                    tknhDAO.Sua(tknh);
                    tietkiemDAO.Rut(tkiem);
                    lsgdDAO.Them(gd);
                    MessageBox.Show("Rút tiền trong tài khoản tiết kiệm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmXemTKTK frmxemtktk = new FrmXemTKTK(kh, tknh, pnlNguoidung);
                    DOAN_Nhom4.ClassAddForm.addForm(frmxemtktk, pnlNguoidung);
                }
            }
        }

        private void pBQuaylai_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh, pnlNguoidung);
            DOAN_Nhom4.ClassAddForm.addForm(frmtietkiem, pnlNguoidung);
        }

        private void cbTenTKTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenTKTK.SelectedItem != null && cbTenTKTK.SelectedItem is TietKiem)
            {
                TietKiem tkiem = (TietKiem)cbTenTKTK.SelectedItem;
                DateTime ngayToihan = tietkiemDAO.NgayToiHan(tkiem.NgayDangky, tkiem.KiHan);
                ngayDangky = tkiem.NgayDangky;
                lblMatietkiem.Text = tkiem.MaTietKiem.ToString();
                txtKihan.Text = tkiem.KiHan.ToString();
                txtTiengoc.Text = tkiem.TienGoc.ToString();
                lblTienlai.Text = tkiem.TienLai.ToString();
                lblLaisuat.Text = tkiem.LaiSuat.ToString();
                lblTongtien.Text = tkiem.TongTien.ToString();
                lblNgaydangky.Text = tkiem.NgayDangky.ToString("dd/MM/yyyy");
                lblNgaytoihan.Text = ngayToihan.ToString("dd/MM/yyyy");
            }
        }
    }
}
