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
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        public GiaoDich gd;
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();

        public FrmLichSuGiaoDich()
        {
            InitializeComponent();
        }

        public FrmLichSuGiaoDich(NguoiDung kh, GiaoDich gd, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            this.kh = kh;
            this.gd = gd;
            this.tknh = tknh;
        }

        private void picBoxQuaylai_Click(object sender, EventArgs e)
        {
            FrmTrangchu frmtrangchu = new FrmTrangchu(kh, tknh, gd);
            this.Hide();
            frmtrangchu.ShowDialog();
            this.Close();
        }

        private void btn_TienVao_Click(object sender, EventArgs e)
        {
            GvTongGui.Visible = false;
            GvTongNhan.Visible = false;
            GvLSGD.Visible = true;
            GvLSGD.DataSource = lsgdDAO.LichSuGiaoDichNhanNguoiDung(kh, LayGiaTri());
        }

        private void btn_TienRa_Click(object sender, EventArgs e)
        {
            GvTongGui.Visible = false;
            GvTongNhan.Visible = false;
            GvLSGD.Visible = true;
            GvLSGD.DataSource = lsgdDAO.LichSuGiaoDichGuiNguoiDung(kh, LayGiaTri());
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
        }

        private void FrmLichSuGiaoDich_Load(object sender, EventArgs e)
        {
            GvTongGui.Visible = false;
            GvTongNhan.Visible = false;
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            lsgdDAO.XuatExcel();
        }
    }
}
