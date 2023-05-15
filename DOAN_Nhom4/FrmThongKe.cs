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
            ThongKe.DataSource = tkDAO.ThongKeTienGui(ngayBatDau, ngayKetThuc, kh.TenNH, kh.SoTK);
            ThongKe.Series["VNĐ"].XValueMember = "ThoiGian";
            ThongKe.Series["VNĐ"].YValueMembers = "TongTien";
            ThongKe.Titles.Add("Thong Ke");
        }
    }
}
