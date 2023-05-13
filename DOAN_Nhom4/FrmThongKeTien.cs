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
        ThongKeDAO thongKeDAO = new ThongKeDAO();
        public FrmThongKeTien()
        {
            InitializeComponent();
            //cartesianChart1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(55, 32, 49));
            ThongKe.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    StrokeDashArray = new DoubleCollection(1),
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))

                }
            });
            ThongKe.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1.5,
                    StrokeDashArray = new DoubleCollection(4),
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
        }

        private void FrmThongKeTien_Load(object sender, EventArgs e)
        {
            lblFrom.Text = DateTime.Now.Subtract(new TimeSpan(6, 0, 0, 0)).ToString("yyyy-MM-dd");
            lblTo.Text = DateTime.Now.ToString("yyyy-MM-dd");
            var lineSeries = new LineSeries();
            lineSeries = thongKeDAO.ThongKeTienGui(lblFrom.Text, lblTo.Text, "HHB", "1234");
            ThongKe.Series.Add(lineSeries);
            Controls.Add(ThongKe);

            List<double> yValues = new List<double>(); // Danh sách giá trị của cột y
            List<DateTime> xValues = new List<DateTime>(); // Danh sách giá trị của cột x

            DateTime currentDate = DateTime.Now.Date; // Thời điểm hiện tại
            int numDays = 7; // Số ngày cần lấy giá trị

            for (int i = numDays - 1; i >= 0; i--)
            {
                DateTime date = currentDate.AddDays(-i); // Tính toán giá trị của cột x
                xValues.Add(date); // Thêm giá trị của cột x vào danh sách
            }

            //ThongKe.Series[0].Values = new ChartValues<double>(yValues); // Thiết lập giá trị của cột y
            ThongKe.AxisX.Clear(); // Xóa các giá trị cột x hiện tại
            ThongKe.AxisX.Add(new LiveCharts.Wpf.Axis // Thêm các giá trị mới của cột x
            {
                Title = "Date",
                Labels = xValues.Select(x => x.ToShortDateString()).ToList(),

            });
        }
    }
}
