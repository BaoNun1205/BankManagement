using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    internal class LichSuGiaoDichDAO
    {
        NganHangHhbContext hhb = new NganHangHhbContext();
        DBConnection data = new DBConnection();
        public LichSuGiaoDichDAO() { }

        public List<object> HienThi()
        {
            var result = from ls in hhb.LichSuGiaoDiches
                         select new
                         {
                             MaGd = ls.MaGd,
                             LoaiGd = ls.LoaiGd,
                             NganHangNhan = ls.NganHangNhan,
                             SoTknhan = ls.SoTknhan,
                             NganHangGui = ls.NganHangGui,
                             SoTkgui = ls.SoTkgui,
                             SoTien = ls.SoTien,
                             LoiNhan = ls.LoiNhan,
                             ThoiGian = ls.ThoiGian
                         };
            return result.ToList<object>();
        }
        public void Them(LichSuGiaoDich gd)
        {
            hhb.LichSuGiaoDiches.Add(gd);
            hhb.SaveChanges();
        }

        /*public DataTable LichSuGiaoDichNhanNguoiDung(KhachHang kh, int x)
        {
            DateTime fromDate = DateTime.Now.AddDays(-x);

            var danhSachGiaoDich = hhb.LichSuGiaoDiches
                .Where(gd => gd.SoTknhan == kh.SoTk && gd.ThoiGian >= fromDate)
                .Select(gd => new { gd.MaGd, gd.LoaiGd, gd.ThoiGian, gd.NganHangGui, gd.SoTkgui, gd.SoTien, gd.LoiNhan })
                .ToList();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaGD");
            dataTable.Columns.Add("LoaiGD");
            dataTable.Columns.Add("ThoiGian");
            dataTable.Columns.Add("NganHangGui");
            dataTable.Columns.Add("SoTKGui");
            dataTable.Columns.Add("SoTien");
            dataTable.Columns.Add("LoiNhan");

            foreach (var giaoDich in danhSachGiaoDich)
            {
                dataTable.Rows.Add(giaoDich.MaGd, giaoDich.LoaiGd, giaoDich.ThoiGian, giaoDich.NganHangGui, giaoDich.SoTkgui, giaoDich.SoTien, giaoDich.LoiNhan);
            }

            return dataTable;
        }*/

        public List<object> LichSuGiaoDichNhanNguoiDung(KhachHang kh, int x)
        {
            DateTime fromDate = DateTime.Now.AddDays(-x);

            var danhSachGiaoDich = hhb.LichSuGiaoDiches
                .Where(gd => gd.SoTknhan == kh.SoTk && gd.ThoiGian >= fromDate)
                .Select(gd => new
                {
                    gd.MaGd,
                    gd.LoaiGd,
                    gd.ThoiGian,
                    gd.NganHangGui,
                    gd.SoTkgui,
                    gd.SoTien,
                    gd.LoiNhan
                })
                .ToList();

            List<object> danhSachGiaoDichObj = new List<object>();

            foreach (var giaoDich in danhSachGiaoDich)
            {
                danhSachGiaoDichObj.Add(new
                {
                    MaGD = giaoDich.MaGd,
                    LoaiGD = giaoDich.LoaiGd,
                    ThoiGian = giaoDich.ThoiGian,
                    NganHangGui = giaoDich.NganHangGui,
                    SoTKGui = giaoDich.SoTkgui,
                    SoTien = giaoDich.SoTien,
                    LoiNhan = giaoDich.LoiNhan
                });
            }

            return danhSachGiaoDichObj;
        }


        /*public DataTable LichSuGiaoDichGuiNguoiDung(KhachHang kh, int x)
        {
            DateTime fromDate = DateTime.Now.AddDays(-x);

            var danhSachGiaoDich = hhb.LichSuGiaoDiches
                .Where(gd => gd.SoTkgui == kh.SoTk && gd.ThoiGian >= fromDate)
                .Select(gd => new { gd.MaGd, gd.LoaiGd, gd.ThoiGian, gd.NganHangNhan, gd.SoTknhan, gd.SoTien, gd.LoiNhan })
                .ToList();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaGD");
            dataTable.Columns.Add("LoaiGD");
            dataTable.Columns.Add("ThoiGian");
            dataTable.Columns.Add("NganHangNhan");
            dataTable.Columns.Add("SoTKNhan");
            dataTable.Columns.Add("SoTien");
            dataTable.Columns.Add("LoiNhan");

            foreach (var giaoDich in danhSachGiaoDich)
            {
                dataTable.Rows.Add(giaoDich.MaGd, giaoDich.LoaiGd, giaoDich.ThoiGian, giaoDich.NganHangNhan, giaoDich.SoTknhan, giaoDich.SoTien, giaoDich.LoiNhan);
            }

            return dataTable;
        }*/

        public List<object> LichSuGiaoDichGuiNguoiDung(KhachHang kh, int x)
        {
            DateTime fromDate = DateTime.Now.AddDays(-x);

            var danhSachGiaoDich = hhb.LichSuGiaoDiches
                .Where(gd => gd.SoTkgui == kh.SoTk && gd.ThoiGian >= fromDate)
                .Select(gd => new
                {
                    gd.MaGd,
                    gd.LoaiGd,
                    gd.ThoiGian,
                    gd.NganHangNhan,
                    gd.SoTknhan,
                    gd.SoTien,
                    gd.LoiNhan
                })
                .ToList();

            List<object> danhSachGiaoDichObj = new List<object>();

            foreach (var giaoDich in danhSachGiaoDich)
            {
                danhSachGiaoDichObj.Add(new
                {
                    MaGD = giaoDich.MaGd,
                    LoaiGD = giaoDich.LoaiGd,
                    ThoiGian = giaoDich.ThoiGian,
                    NganHangNhan = giaoDich.NganHangNhan,
                    SoTKNhan = giaoDich.SoTknhan,
                    SoTien = giaoDich.SoTien,
                    LoiNhan = giaoDich.LoiNhan
                });
            }

            return danhSachGiaoDichObj;
        }


        public void XuatExcel()
        {
            // Sử dụng LINQ để truy vấn và lấy dữ liệu từ nguồn dữ liệu
            var data = hhb.LichSuGiaoDiches.ToList();

            // Tạo một đối tượng ExcelPackage mới
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một worksheet mới và thiết lập tên cho nó
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("MyWorksheet");

                // Lấy danh sách tên cột từ danh sách thuộc tính của đối tượng
                var columnNames = typeof(LichSuGiaoDich).GetProperties().Select(property => property.Name).ToList();

                // Thiết lập cột tiêu đề cho worksheet
                for (int i = 0; i < columnNames.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = columnNames[i];
                }

                // Thiết lập dữ liệu cho worksheet
                for (int row = 0; row < data.Count; row++)
                {
                    for (int col = 0; col < columnNames.Count; col++)
                    {
                        // Lấy giá trị của thuộc tính tương ứng trong dữ liệu
                        var propertyValue = data[row].GetType().GetProperty(columnNames[col]).GetValue(data[row]);
                        worksheet.Cells[row + 2, col + 1].Value = propertyValue?.ToString();
                    }
                }

                // Khởi tạo hộp thoại lưu tập tin
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                saveFileDialog1.Title = "Save Excel File";

                // Hiển thị hộp thoại lưu tập tin và kiểm tra kết quả
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Lưu workbook vào đường dẫn đã chọn
                    FileInfo file = new FileInfo(saveFileDialog1.FileName);
                    excelPackage.SaveAs(file);
                    MessageBox.Show("Xác nhận thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
