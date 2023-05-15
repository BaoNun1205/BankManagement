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

        private void btn_TienVao_Click(object sender, EventArgs e)
        {
            GvTongGui.Visible = false;
            GvTongNhan.Visible = false;
            GvLSGD.Visible = true;
            GvLSGD.DataSource = lsgdDAO.LichSuGiaoDichNhanNguoiDung(kh, LayGiaTri());
            HienThiTienVao(GvLSGD);
        }

        private void btn_TienRa_Click(object sender, EventArgs e)
        {
            GvTongGui.Visible = false;
            GvTongNhan.Visible = false;
            GvLSGD.Visible = true;
            GvLSGD.DataSource = lsgdDAO.LichSuGiaoDichGuiNguoiDung(kh, LayGiaTri());
            HienThiTienRa(GvLSGD);
        }

        public int LayGiaTri()
        {
            if (cmNgay.SelectedItem == null)
                return 1000;
            string selectedCountry = cmNgay.SelectedItem.ToString();
            if (selectedCountry == "1 ngày gần đây nhất")
                return 1;
            if (selectedCountry == "3 ngày gần đây nhất")
                return 3;
            if (selectedCountry == "7 ngày gần đây nhất")
                return 7;
            if (selectedCountry == "30 ngày gần đây nhất")
                return 30;
            if (selectedCountry == "100 ngày gần đây nhất")
                return 100;
            return 1000;
        }

        private void btn_ToanBo_Click(object sender, EventArgs e)
        {
            GvLSGD.Visible = false;
            GvTongGui.Visible = true;
            GvTongNhan.Visible = true;
            GvTongGui.DataSource = lsgdDAO.LichSuGiaoDichGuiNguoiDung(kh, LayGiaTri());
            GvTongNhan.DataSource = lsgdDAO.LichSuGiaoDichNhanNguoiDung(kh, LayGiaTri());
            HienThiTienRa(GvTongNhan);
            HienThiTienVao(GvTongGui);
        }

        private void FrmLichSuGiaoDich_Load(object sender, EventArgs e)
        {
            GvTongGui.Visible = false;
            GvTongNhan.Visible = false;            
        }

        private void HienThiTienRa(DataGridView gv)
        {
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
            gv.Columns[0].HeaderText = "Mã giao dịch";
            gv.Columns[1].HeaderText = "Loại giao dịch";
            gv.Columns[2].HeaderText = "Thời gian";
            gv.Columns[3].HeaderText = "Ngân hàng gửi";
            gv.Columns[4].HeaderText = "Số tài khoản gửi";
            gv.Columns[5].HeaderText = "Số tiền";
            gv.Columns[6].HeaderText = "Lời nhắn";
        }
        private void vbButton2_Click(object sender, EventArgs e)
        {
            lsgdDAO.XuatExcel();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            FrmThongKe frmthongke = new FrmThongKe(kh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmthongke, pnlNguoiDung);
        }

        private void btn_TienRa_MouseEnter(object sender, EventArgs e)
        {
            btn_TienRa.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btn_TienRa_MouseLeave(object sender, EventArgs e)
        {
            btn_TienRa.BackColor = Color.LightSlateGray;
        }

        private void btn_TienVao_MouseEnter(object sender, EventArgs e)
        {
            btn_TienVao.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btn_TienVao_MouseLeave(object sender, EventArgs e)
        {
            btn_TienVao.BackColor = Color.LightSlateGray;
        }

        private void btn_ToanBo_MouseEnter(object sender, EventArgs e)
        {
            btn_ToanBo.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btn_ToanBo_MouseLeave(object sender, EventArgs e)
        {
            btn_ToanBo.BackColor = Color.LightSlateGray;
        }

        private void btn_XuatExcel_MouseEnter(object sender, EventArgs e)
        {
            btn_XuatExcel.BackColor = Color.FromArgb(2, 69, 158);
        }

        private void btn_XuatExcel_MouseLeave(object sender, EventArgs e)
        {
            btn_XuatExcel.BackColor = Color.LightSlateGray;
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
