using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Brushes = System.Windows.Media.Brushes;
using LiveCharts.WinForms;
using Microsoft.Office.Interop.Excel;
using LiveCharts.Wpf.Charts.Base;
using LiveCharts.Definitions.Charts;


namespace DOAN_Nhom4
{
    public partial class FrmThongKeTien : Form
    {
        private NguoiDung kh;
        private Panel pnlNguoiDung;
        ThongKeDAO thongKeDAO = new ThongKeDAO();
        string ngayBatDau = DateTime.Now.Subtract(new TimeSpan(6, 0, 0, 0)).ToString("yyyy-MM-dd");
        string ngayKetThuc = DateTime.Now.ToString("yyyy-MM-dd");
        public FrmThongKeTien()
        {
            InitializeComponent();
        }

        public FrmThongKeTien(NguoiDung kh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void FrmThongKeTien_Load(object sender, EventArgs e)
        {
            lblKhoangthoigian.Text = string.Format("Từ ngày {0} đến ngày {1}", ngayBatDau, ngayKetThuc);
            ThietKeDoThi();
        }

        private void btnTongTienVao_Click(object sender, EventArgs e)
        {
            ThongKe.Series.Clear();
            var lineSeries = new LineSeries();
            lineSeries = thongKeDAO.ThongKeTienNhan(ngayBatDau, ngayKetThuc, kh.TenNH, kh.SoTK);
            ThongKe.Series.Add(lineSeries);
            Controls.Add(ThongKe);
        }

        public void ThietKeDoThi()
        {
            List<DateTime> xValues = new List<DateTime>(); // Danh sách giá trị của cột x
            DateTime currentDate = DateTime.Now.Date; // Thời điểm hiện tại
            int numDays = 7; // Số ngày cần lấy giá trị
            for (int i = numDays - 1; i >= 0; i--)
            {
                DateTime date = currentDate.AddDays(-i); // Tính toán giá trị của cột x
                xValues.Add(date); // Thêm giá trị của cột x vào danh sách
            }
            ThongKe.AxisX.Clear(); // Xóa các giá trị cột x hiện tại

            //cartesianChart1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(55, 32, 49));
            ThongKe.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                IsMerged = true,
                Title = "Date",
                Labels = xValues.Select(x => x.ToShortDateString()).ToList(),
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    StrokeDashArray = new DoubleCollection(1),
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
            ThongKe.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                
                MinValue = 0,
                IsMerged = true,
                Title = "VNĐ",
                Separator = new Separator
                {
                    StrokeThickness = 1.5,
                    StrokeDashArray = new DoubleCollection(4),
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });   
        }

        private void btnTongTienRa_Click(object sender, EventArgs e)
        {
            ThongKe.Series.Clear();
            var lineSeries = new LineSeries();
            lineSeries = thongKeDAO.ThongKeTienGui(ngayBatDau, ngayKetThuc, kh.TenNH, kh.SoTK);
            ThongKe.Series.Add(lineSeries);
            Controls.Add(ThongKe);
        }

        private void btnToanBo_Click(object sender, EventArgs e)
        {
            ThongKe.Series.Clear();
            var lineSeries = new LineSeries();
            lineSeries = thongKeDAO.ThongKeTienTong(ngayBatDau, ngayKetThuc, kh.TenNH, kh.SoTK);
            ThongKe.Series.Add(lineSeries);
            Controls.Add(ThongKe);
        }
    }
}
