using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
        private KhachHang kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoidung;
        TietkiemDAO tietkiemDAO = new TietkiemDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();

        public FrmXemTKTK()
        {
            InitializeComponent();
        }

        public FrmXemTKTK(KhachHang kh, TaiKhoanNganHang tknh, Panel pnlNguoidung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoidung = pnlNguoidung;
        }

        private void FrmXemTKTK_Load(object sender, EventArgs e)
        {           
            HienThi();
            lblTongtiengui.Text = TongTienGui().ToString() + " VNĐ";
        }

        private void GvTaikhoantietkiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = GvTaikhoantietkiem.CurrentRow.Index;
            lblMaTietKiem.Text = GvTaikhoantietkiem.Rows[i].Cells[0].Value.ToString();
            dtNgaydangky.Text = GvTaikhoantietkiem.Rows[i].Cells[1].Value.ToString();
            lblTenTKTK.Text = GvTaikhoantietkiem.Rows[i].Cells[2].Value.ToString();
            txtTiengoc.Text = GvTaikhoantietkiem.Rows[i].Cells[4].Value.ToString() + " VNĐ";
            txtKihan.Text = GvTaikhoantietkiem.Rows[i].Cells[5].Value.ToString();
            lblLaisuat.Text = GvTaikhoantietkiem.Rows[i].Cells[6].Value.ToString();
            lblTienlai.Text = GvTaikhoantietkiem.Rows[i].Cells[7].Value.ToString() + " VNĐ";
            lblTongtien.Text = GvTaikhoantietkiem.Rows[i].Cells[8].Value.ToString() + " VNĐ";
            if (txtKihan.Text != null) dtNgaytoihan.Text = tietkiemDAO.NgayToiHan(dtNgaydangky.Value, int.Parse(txtKihan.Text)).ToString();
        }

        private decimal TongTienGui() // Tính tổng số tiền đã gửi tiết kiệm
        {
            int columnIndex = GvTaikhoantietkiem.Columns["TienGoc"].Index;
            decimal tongTienGuiTK = 0;
            foreach (DataGridViewRow row in GvTaikhoantietkiem.Rows)
            {
                if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value != DBNull.Value)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value != DBNull.Value)
                    {
                        tongTienGuiTK += Convert.ToDecimal(row.Cells[columnIndex].Value);
                    }
                }
            }
            return tongTienGuiTK;
        }

        private void HienThi()
        {
            GvTaikhoantietkiem.DataSource = tietkiemDAO.DanhSachTietKiem(tknh);
            GvTaikhoantietkiem.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            GvTaikhoantietkiem.Columns[0].HeaderText = "Mã tiết kiệm";
            GvTaikhoantietkiem.Columns[1].HeaderText = "Ngày đăng ký";
            GvTaikhoantietkiem.Columns[2].HeaderText = "Tên TKTK";
            GvTaikhoantietkiem.Columns[3].HeaderText = "Loại sổ";
            GvTaikhoantietkiem.Columns[4].HeaderText = "Tiền gốc";
            GvTaikhoantietkiem.Columns[5].HeaderText = "Kì hạn";
            GvTaikhoantietkiem.Columns[6].HeaderText = "Lãi suất";
            GvTaikhoantietkiem.Columns[7].HeaderText = "Tiền lãi";
            GvTaikhoantietkiem.Columns[8].HeaderText = "Tổng tiền";
        }

        private void btnRuttien_Click(object sender, EventArgs e)
        {
            if (GvTaikhoantietkiem.RowCount == 0) MessageBox.Show("Bạn chưa có tài khoản tiết kiệm nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtTiengoc.Text == "") MessageBox.Show("Vui lòng chọn tài khoản tiết kiệm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DialogResult luachon = MessageBox.Show("Nếu rút trước thời hạn, bạn sẽ không được tính tiền lãi, bạn chắc chắn muốn rút không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (luachon == DialogResult.Yes)
                {                   
                    TaiKhoanTietKiem? tkiem = tietkiemDAO.LayThongTinSoTietKiem(tknh.TenNh, tknh.SoTk, int.Parse(lblMaTietKiem.Text));
                    if (tkiem != null)
                    {
                        LichSuGiaoDich gd = new LichSuGiaoDich()
                        {
                            LoaiGd = "Rut Tiet Kiem",
                            NganHangGui = kh.TenNh,
                            TenTkgui = tkiem?.TenTktk,
                            SoTkgui = tkiem?.MaTietKiem.ToString(),
                            NganHangNhan = "HHB",
                            TenTknhan = kh.TenKh,
                            SoTknhan = kh.SoTk,
                            ThoiGian = DateTime.Now,
                            SoTien = tkiem.TienGoc,
                            LoiNhan = "Rut tien tiet kiem"
                        };
                        tknh.SoDu = tknh.SoDu + tkiem.TienGoc;
                        tknhDAO.Sua(tknh);
                        tietkiemDAO.Rut(tkiem);
                        lsgdDAO.Them(gd);
                        MessageBox.Show("Rút tiền trong tài khoản tiết kiệm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmXemTKTK frmxemtktk = new FrmXemTKTK(kh, tknh, pnlNguoidung);
                        Utility.addForm(frmxemtktk, pnlNguoidung);
                    }
                    
                }
            }
        }

        private void pbQuaylai_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh, pnlNguoidung);
            Utility.addForm(frmtietkiem, pnlNguoidung);
        }
    }
}
