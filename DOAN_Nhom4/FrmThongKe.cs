using DOAN_Nhom4.Entities;
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
        private KhachHang kh;
        private Panel pnlNguoiDung;
        ThongKeDAO tkDAO = new ThongKeDAO();
        string ngayBatDau = DateTime.Now.Subtract(new TimeSpan(6, 0, 0, 0)).ToString("yyyy-MM-dd");
        string ngayKetThuc = DateTime.Now.ToString("yyyy-MM-dd");
        
        public FrmThongKe()
        {
            InitializeComponent();
        }

        public FrmThongKe(KhachHang kh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            lblHienThiNgay.Text = string.Format("{0} đến {1}", ngayBatDau, ngayKetThuc);
            // Ban dau cho do thi tien gui hien thi khi vua mo form
            ThongKe.DataSource = tkDAO.ThongKeTienGui(ngayBatDau, ngayKetThuc, kh.TenNh, kh.SoTk);
            ThongKe.Series["TienGui"].XValueMember = "Ngay";
            ThongKe.Series["TienGui"].YValueMembers = "TongTien";
            ThongKe.Legends[0].Enabled = false;
            ThongKe.Legends[2].Enabled = false;
        }

        private void btnTienRa_Click(object sender, EventArgs e)
        {
            string s = "TienGui";
            MacDinhDoThi();
            ThongKe.Legends[1].Enabled = true;
            ThongKe.DataSource = tkDAO.ThongKeTienGui(ngayBatDau, ngayKetThuc, kh.TenNh, kh.SoTk);
            HienThiDuLieuDoThi(s);
        }

        private void btnTienVao_Click(object sender, EventArgs e)
        {
            string s = "TienNhan";
            MacDinhDoThi();
            ThongKe.Legends[0].Enabled = true;
            ThongKe.DataSource = tkDAO.ThongKeTienNhan(ngayBatDau, ngayKetThuc, kh.TenNh, kh.SoTk);
            HienThiDuLieuDoThi(s);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            string s = "TienTong";
            MacDinhDoThi();
            ThongKe.Legends[2].Enabled = true;
            ThongKe.DataSource = tkDAO.ThongKeTienTong(ngayBatDau, ngayKetThuc, kh.TenNh, kh.SoTk);
            HienThiDuLieuDoThi(s);
        }

        private void MacDinhDoThi() // Ban dau cho cac do thi khong hien thi
        {
            ThongKe.Series["TienGui"].Enabled = false;
            ThongKe.Series["TienNhan"].Enabled = false;
            ThongKe.Series["TienTong"].Enabled = false;
        }

        public void HienThiDuLieuDoThi(string s) // Dung de hien thi du lieu len do thi
        {
            ThongKe.Series[s].Enabled = true;
            ThongKe.Series[s].XValueMember = "Ngay";
            ThongKe.Series[s].YValueMembers = "TongTien";
        }
    }
}
