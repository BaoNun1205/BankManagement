using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DOAN_Nhom4
{
    public partial class FrmThongKe : Form
    {
        private NguoiDung kh;
        private Panel pnlNguoiDung;
        ThongKeDAO tkDAO = new ThongKeDAO();
        string ngayBatDau = DateTime.Now.Subtract(new TimeSpan(6, 0, 0, 0)).ToString("yyyy-MM-dd");
        string ngayKetThuc = DateTime.Now.ToString("yyyy-MM-dd");
        
        public FrmThongKe()
        {
            InitializeComponent();
        }

        public FrmThongKe(NguoiDung kh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            lblHienThiNgay.Text = string.Format("{0} đến {1}", ngayBatDau, ngayKetThuc);
            ThongKe.DataSource = tkDAO.ThongKeTienGui(ngayBatDau, ngayKetThuc, kh.TenNH, kh.SoTK);
            ThongKe.Series["TienGui"].XValueMember = "ThoiGian";
            ThongKe.Series["TienGui"].YValueMembers = "TongTien";
            ThongKe.Legends[0].Enabled = false;
            ThongKe.Legends[2].Enabled = false;
        }

        private void btnTienRa_Click(object sender, EventArgs e)
        {
            ThongKe.Series["TienGui"].Enabled = true;
            ThongKe.Series["TienTong"].Enabled = false;
            ThongKe.Series["TienNhan"].Enabled = false;
            ThongKe.DataSource = tkDAO.ThongKeTienGui(ngayBatDau, ngayKetThuc, kh.TenNH, kh.SoTK);
            ThongKe.Series["TienGui"].XValueMember = "ThoiGian";
            ThongKe.Series["TienGui"].YValueMembers = "TongTien";
            ThongKe.Legends[1].Enabled = true;
        }

        private void btnTienVao_Click(object sender, EventArgs e)
        {
            ThongKe.Series["TienNhan"].Enabled = true;
            ThongKe.Series["TienTong"].Enabled = false;
            ThongKe.Series["TienGui"].Enabled = false;
            ThongKe.DataSource = tkDAO.ThongKeTienNhan(ngayBatDau, ngayKetThuc, kh.TenNH, kh.SoTK);
            ThongKe.Series["TienNhan"].XValueMember = "ThoiGian";
            ThongKe.Series["TienNhan"].YValueMembers = "TongTien";
            ThongKe.Legends[0].Enabled = true;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            ThongKe.Series["TienTong"].Enabled = true;
            ThongKe.Series["TienNhan"].Enabled = false;
            ThongKe.Series["TienGui"].Enabled = false;
            ThongKe.DataSource = tkDAO.ThongKeTienTong(ngayBatDau, ngayKetThuc, kh.TenNH, kh.SoTK);
            ThongKe.Series["TienTong"].XValueMember = "ThoiGian";
            ThongKe.Series["TienTong"].YValueMembers = "TongTien";
            ThongKe.Legends[2].Enabled = true;
        }
    }
}
