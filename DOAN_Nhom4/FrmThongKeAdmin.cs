using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmThongKeAdmin : Form
    {
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        ThongKeDAO tkDAO = new ThongKeDAO();

        string ngayBatDau = DateTime.Now.Subtract(new TimeSpan(6, 0, 0, 0)).ToString("yyyy-MM-dd");
        string ngayKetThuc = DateTime.Now.ToString("yyyy-MM-dd");
        public FrmThongKeAdmin()
        {
            InitializeComponent();
        }

        private void FrmThongKeAdmin_Load(object sender, EventArgs e)
        {
            lblHienThiSoLuongTaiKhoang.Text = tkDAO.DemSoLuongTaiKhoang().ToString();
            lblHienThiTinDung.Text = tkDAO.DemSoLuongTinDung().ToString();
            lblHienThiTietKiem.Text = tkDAO.DemSoLuongSoTietKiem().ToString();
            lblHienThiVay.Text = tkDAO.DemSoLuongVay().ToString();
            lblHienThiNoXau.Text = tkDAO.DemSoLuongNoXau().ToString();

            gvQLGD.DataSource = lsgdDAO.HienThi();
            ThongKe.DataSource = tkDAO.ThongKeGiaoDichVayTien(ngayBatDau, ngayKetThuc);
            ThongKe.Series["ChuyenTien"].XValueMember = "ThoiGian";
            ThongKe.Series["ChuyenTien"].YValueMembers = "TongTien";
            ThongKe.Legends[1].Enabled = false;
            ThongKe.Legends[2].Enabled = false;
            ThongKe.Legends[3].Enabled = false;
            ThongKe.Legends[4].Enabled = false;
        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            MacDinh();
            ThongKe.Series["ChuyenTien"].Enabled = true;
            ThongKe.Legends[0].Enabled = true;
            ThongKe.DataSource = tkDAO.ThongKeGiaoDichChuyenTien(ngayBatDau, ngayKetThuc);
            ThongKe.Series["ChuyenTien"].XValueMember = "ThoiGian";
            ThongKe.Series["ChuyenTien"].YValueMembers = "TongTien";
            
        }

        private void btnVienThong_Click(object sender, EventArgs e)
        {
            MacDinh();
            ThongKe.Series["VienThong"].Enabled = true;
            ThongKe.Legends[1].Enabled = true;
            ThongKe.DataSource = tkDAO.ThongKeGiaoDichVienThong(ngayBatDau, ngayKetThuc);
            ThongKe.Series["VienThong"].XValueMember = "ThoiGian";
            ThongKe.Series["VienThong"].YValueMembers = "TongTien";
        }

        private void btnTinDung_Click(object sender, EventArgs e)
        {
            MacDinh();
            ThongKe.Series["TinDung"].Enabled = true;
            ThongKe.Legends[2].Enabled = true;
            ThongKe.DataSource = tkDAO.ThongKeGiaoDichTinDung(ngayBatDau, ngayKetThuc);
            ThongKe.Series["TinDung"].XValueMember = "ThoiGian";
            ThongKe.Series["TinDung"].YValueMembers = "TongTien";
        }

        private void btnTietKiem_Click(object sender, EventArgs e)
        {
            MacDinh();
            ThongKe.Series["TietKiem"].Enabled = true;
            ThongKe.Legends[3].Enabled = true;
            ThongKe.DataSource = tkDAO.ThongKeGiaoDichTietKiem(ngayBatDau, ngayKetThuc);
            ThongKe.Series["TietKiem"].XValueMember = "ThoiGian";
            ThongKe.Series["TietKiem"].YValueMembers = "TongTien";
        }

        private void btnVay_Click(object sender, EventArgs e)
        {
            MacDinh();
            ThongKe.Series["Vay"].Enabled = true;
            ThongKe.Legends[4].Enabled = true;
            ThongKe.DataSource = tkDAO.ThongKeGiaoDichVienThong(ngayBatDau, ngayKetThuc);
            ThongKe.Series["Vay"].XValueMember = "ThoiGian";
            ThongKe.Series["Vay"].YValueMembers = "TongTien";
        }

        public void MacDinh()
        {
            ThongKe.Series["ChuyenTien"].Enabled = false;
            ThongKe.Series["VienThong"].Enabled = false;
            ThongKe.Series["TinDung"].Enabled = false;
            ThongKe.Series["TietKiem"].Enabled = false;
            ThongKe.Series["Vay"].Enabled = false;
        }
    }
}
