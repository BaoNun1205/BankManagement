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
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();

        public FrmLichSuGiaoDich()
        {
            InitializeComponent();
        }

        public FrmLichSuGiaoDich(NguoiDung kh)
        {
            InitializeComponent();
            this.kh = kh;
        }

        private void btn_TienVao_Click(object sender, EventArgs e)
        {
            GvTongGui.Visible = false;
            GvTongNhan.Visible = false;
            GvLSGD.Visible = true;
            GvLSGD.DataSource = lsgdDAO.LichSuGiaoDichNhanNguoiDung(kh, LayGiaTri());
            HienThi();
        }

        private void btn_TienRa_Click(object sender, EventArgs e)
        {
            GvTongGui.Visible = false;
            GvTongNhan.Visible = false;
            GvLSGD.Visible = true;
            GvLSGD.DataSource = lsgdDAO.LichSuGiaoDichGuiNguoiDung(kh, LayGiaTri());
            HienThi();
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
            HienThiToanBo();
        }

        private void FrmLichSuGiaoDich_Load(object sender, EventArgs e)
        {
            GvTongGui.Visible = false;
            GvTongNhan.Visible = false;            
        }

        private void HienThi()
        {
            GvLSGD.Columns[0].HeaderText = "Mã giao dịch";
            GvLSGD.Columns[1].HeaderText = "Loại giao dịch";
            GvLSGD.Columns[2].HeaderText = "Thời gian";
            GvLSGD.Columns[3].HeaderText = "Ngân hàng nhận";
            GvLSGD.Columns[4].HeaderText = "Số tài khoản nhận";
            GvLSGD.Columns[5].HeaderText = "Số tiền";
            GvLSGD.Columns[6].HeaderText = "Lời nhắn";
        }

        private void HienThiToanBo()
        {
            GvTongGui.Columns[0].HeaderText = "Mã giao dịch";
            GvTongGui.Columns[1].HeaderText = "Loaị giao dịch";
            GvTongGui.Columns[2].HeaderText = "Thời gian";
            GvTongGui.Columns[3].HeaderText = "Ngân hàng nhận";
            GvTongGui.Columns[4].HeaderText = "Số tài khoản nhận";
            GvTongGui.Columns[5].HeaderText = "Số tiền";
            GvTongGui.Columns[6].HeaderText = "Lời nhắn";

            GvTongNhan.Columns[0].HeaderText = "Mã giao dịch";
            GvTongNhan.Columns[1].HeaderText = "Loaị giao dịch";
            GvTongNhan.Columns[2].HeaderText = "Thời gian";
            GvTongNhan.Columns[3].HeaderText = "Ngân hàng nhận";
            GvTongNhan.Columns[4].HeaderText = "Số tài khoản nhận";
            GvTongNhan.Columns[5].HeaderText = "Số tiền";
            GvTongNhan.Columns[6].HeaderText = "Lời nhắn";
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            lsgdDAO.XuatExcel();
        }
    }
}
