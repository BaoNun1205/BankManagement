using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmLichSuGiaoDich : Form
    {
        private NguoiDung kh;
        private Panel pnlNguoiDung;
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();

        public FrmLichSuGiaoDich()
        {
            InitializeComponent();
        }

        public FrmLichSuGiaoDich(NguoiDung kh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void FrmLichSuGiaoDich_Load(object sender, EventArgs e)
        {
            // Cho cac bang ban dau khong hien thi
            BangMacDinh();
        }

        private void btnTienVao_Click(object sender, EventArgs e)
        {
            BangMacDinh();
            GvLSGD.Visible = true;
            GvLSGD.DataSource = lsgdDAO.LichSuGiaoDichNhanNguoiDung(kh, LayGiaTri());
            HienThiTienVao(GvLSGD);
        }

        private void btnTienRa_Click(object sender, EventArgs e)
        {
            BangMacDinh();
            GvLSGD.Visible = true;
            GvLSGD.DataSource = lsgdDAO.LichSuGiaoDichGuiNguoiDung(kh, LayGiaTri());
            HienThiTienRa(GvLSGD);
        }

        private void btnToanBo_Click(object sender, EventArgs e)
        {
            BangMacDinh();
            GvTongGui.Visible = true;
            GvTongNhan.Visible = true;
            GvTongGui.DataSource = lsgdDAO.LichSuGiaoDichGuiNguoiDung(kh, LayGiaTri());
            GvTongNhan.DataSource = lsgdDAO.LichSuGiaoDichNhanNguoiDung(kh, LayGiaTri());
            HienThiTienRa(GvTongNhan);
            HienThiTienVao(GvTongGui);
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            lsgdDAO.XuatExcel();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            FrmThongKe frmthongke = new FrmThongKe(kh, pnlNguoiDung);
            Utility.addForm(frmthongke, pnlNguoiDung);
        }

        public int LayGiaTri() // lay gia tri de hien thi so ngay gan nhat
        {
            if (cmNgay.SelectedItem == null)
                return 1000;
            int selectedIndex = cmNgay.SelectedIndex;
            if (selectedIndex == 0)
                return 1;
            if (selectedIndex == 1)
                return 3;
            if (selectedIndex == 2)
                return 7;
            if (selectedIndex == 3)
                return 30;
            if (selectedIndex == 4)
                return 100;
            return 1000;
        }

        private void HienThiTienRa(DataGridView gv)
        {
            gv.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            gv.Columns[0].HeaderText = "Mã giao dịch";
            gv.Columns[1].HeaderText = "Loại giao dịch";
            gv.Columns[2].HeaderText = "Thời gian";
            gv.Columns[3].HeaderText = "Ngân hàng nhận";
            gv.Columns[4].HeaderText = "Số tài khoản nhận";
            gv.Columns[5].HeaderText = "Số tiền";
            gv.Columns[6].HeaderText = "Lời nhắn";
        }
        private void HienThiTienVao(DataGridView gv)
        {
            gv.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            gv.Columns[0].HeaderText = "Mã giao dịch";
            gv.Columns[1].HeaderText = "Loại giao dịch";
            gv.Columns[2].HeaderText = "Thời gian";
            gv.Columns[3].HeaderText = "Ngân hàng gửi";
            gv.Columns[4].HeaderText = "Số tài khoản gửi";
            gv.Columns[5].HeaderText = "Số tiền";
            gv.Columns[6].HeaderText = "Lời nhắn";
        }

        private void BangMacDinh()
        {
            GvTongGui.Visible = false;
            GvTongNhan.Visible = false;
            GvLSGD.Visible = false;
        }

        // Cac ham phia duoi de doi mau khi di chuot vao
        private void btnTienRa_MouseEnter(object sender, EventArgs e)
        {
            btnTienRa.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btnTienRa_MouseLeave(object sender, EventArgs e)
        {
            btnTienRa.BackColor = Color.LightSlateGray;
        }

        private void btnTienVao_MouseEnter(object sender, EventArgs e)
        {
            btnTienVao.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btnTienVao_MouseLeave(object sender, EventArgs e)
        {
            btnTienVao.BackColor = Color.LightSlateGray;
        }

        private void btnToanBo_MouseEnter(object sender, EventArgs e)
        {
            btnToanBo.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btn_ToanBo_MouseLeave(object sender, EventArgs e)
        {
            btnToanBo.BackColor = Color.LightSlateGray;
        }

        private void btnXuatExcel_MouseEnter(object sender, EventArgs e)
        {
            btnXuatExcel.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btnXuatExcel_MouseLeave(object sender, EventArgs e)
        {
            btnXuatExcel.BackColor = Color.LightSlateGray;
        }

        private void btnThongke_MouseEnter(object sender, EventArgs e)
        {
            btnThongke.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btnThongke_MouseLeave(object sender, EventArgs e)
        {
            btnThongke.BackColor = Color.LightSlateGray;
        }
    }
}
