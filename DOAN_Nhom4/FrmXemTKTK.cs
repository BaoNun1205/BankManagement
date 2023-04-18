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
        List<string> danhSachLuaChon = new List<string>();

        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoidung;

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
            danhSachLuaChon = tietkiemDAO.LayCotTKTK("TenTKTK");
            cbTenTKTK.Items.AddRange(danhSachLuaChon.ToArray());
        }
        private void FrmXemTKTK_Load(object sender, EventArgs e)
        {
            cbTenTKTK.Items.AddRange(danhSachLuaChon.ToArray());
            
        }
        

        private void Xoa()
        {
            lblMatietkiem.Text = "";
            cbTenTKTK.Text = "";
            txtTiengoc.Text = "";
            txtKihan.Text = "";
            lblLaisuat.Text = "";
            lblTienlai.Text = "";
            lblTongtien.Text = "";
        }

        private void btnRuttien_Click(object sender, EventArgs e)
        {
            TietKiem tkiem = new TietKiem(int.Parse(lblMatietkiem.Text), cbTenTKTK.Text, BigInteger.Parse(txtTiengoc.Text), int.Parse(txtKihan.Text), double.Parse(lblLaisuat.Text), BigInteger.Parse(lblTienlai.Text), BigInteger.Parse(lblTongtien.Text));
            GiaoDich gd = new GiaoDich("Rut tiet kiem", kh.TenNH, tkiem.TenTKTK, tkiem.Id.ToString(), "HHB", kh.tenTK, kh.SoTK, tkiem.TienGoc, "");
            tknh.SoDu = tknh.SoDu + tkiem.TienGoc;
            tknhDAO.Sua(tknh);
            tietkiemDAO.Rut(tkiem);
            lsgdDAO.Them(gd);
            MessageBox.Show("Rút tiền trong tài khoản tiết kiệm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Xoa();
        }

        private void pBQuaylai_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh, pnlNguoidung);
            DOAN_Nhom4.ClassAddForm.addForm(frmtietkiem, pnlNguoidung);
        }

        private void cbTenTKTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            TietKiem tkiem = new TietKiem();
            tkiem = tietkiemDAO.LayHangTKTK("TenTKTK", cbTenTKTK.Text);
            lblMatietkiem.Text = tkiem.Id.ToString();
            txtKihan.Text = tkiem.KiHan.ToString();
            txtTiengoc.Text = tkiem.TienGoc.ToString();  
            lblTienlai.Text = tkiem.TienLai.ToString();
            lblLaisuat.Text = tkiem.LaiSuat.ToString();
            lblTongtien.Text = tkiem.TongTien.ToString();
        }
    }
}
