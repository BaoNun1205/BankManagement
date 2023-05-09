using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.IO;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public DBConnection() { }
        public DataTable LayDanhSach(string sqlStr)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dt);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public List<string> LayCot(string sqlStr, string tenCot)
        {
            List<string> cot = new List<string>();
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlStr, conn);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cot.Add(reader[tenCot].ToString());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return cot;
        }

        public TietKiem LayThongTinSoTietKiem(string sqlStr)
        {
            TietKiem tkiem = new TietKiem();
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlStr, conn);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tkiem.MaTietKiem = int.Parse(reader["MaTietKiem"].ToString());
                    tkiem.NgayDangky = DateTime.Parse(reader["NgayDangKy"].ToString());
                    tkiem.TenTKTK = reader["TenTKTK"].ToString();
                    tkiem.LoaiSo = int.Parse(reader["LoaiSo"].ToString());
                    tkiem.TienGoc = BigInteger.Parse(reader["TienGoc"].ToString());
                    tkiem.KiHan = int.Parse(reader["KiHan"].ToString());
                    tkiem.LaiSuat = double.Parse(reader["LaiSuat"].ToString());
                    tkiem.TienLai = BigInteger.Parse(reader["TienLai"].ToString());
                    tkiem.TongTien = BigInteger.Parse(reader["TongTien"].ToString());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return tkiem;
        }

        public NguoiDung LayThongTinKhachHang(string sqlStr)
        {
            NguoiDung ngDung = new NguoiDung();
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlStr, conn);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ngDung.TenNH = reader["TenNH"].ToString();
                    ngDung.SoTK =  reader["SoTK"].ToString();
                    ngDung.tenTK = reader["TenKH"].ToString();
                    ngDung.ngaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                    ngDung.Cccd = reader["CCCD"].ToString();
                    ngDung.Email = reader["Email"].ToString();
                    ngDung.Sdt = reader["SDT"].ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return ngDung;
        }

        public void xuLi(string kh, string tknh)
        {
            conn.Open();
            SqlTransaction transaction = conn.BeginTransaction();
            try
            {
                SqlCommand cmdKH = new SqlCommand(kh, conn);
                cmdKH.Transaction = transaction;
                cmdKH.ExecuteNonQuery();

                SqlCommand cmdNH = new SqlCommand(tknh, conn);
                cmdNH.Transaction = transaction;
                cmdNH.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Loi ket noi" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void xuLi(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public TaiKhoanNganHang XuLi(string sqlStr)
        {
            TaiKhoanNganHang tknh = new TaiKhoanNganHang();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    tknh.TenNH = reader.GetString(0);
                    tknh.SoTK = reader.GetString(1);
                    tknh.TenDN = reader.GetString(2);
                    tknh.MatKhau = reader.GetString(3);
                    tknh.SoDu = reader.GetInt64(4);
                }
                else
                    return null;
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return tknh;
        }

        public NguoiDung Xuli(string sqlStr)
        {
            NguoiDung khachHang = new NguoiDung();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    khachHang.TenNH = reader.GetString(0);
                    khachHang.SoTK = reader.GetString(1);
                    khachHang.TenTK = reader.GetString(2);
                    khachHang.NgaySinh = reader.GetDateTime(3);
                    khachHang.Cccd = reader.GetString(4);
                    khachHang.Email = reader.GetString(5);
                    khachHang.Sdt = reader.GetString(6);
                }
                else
                    return null;
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return khachHang;
        }
        public ThongTinNguoiDungVay XuLiNgDungVay(string sqlStr)
        {
            ThongTinNguoiDungVay ttNgDung = new ThongTinNguoiDungVay();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    ttNgDung.TenNH = reader.GetString(0);
                    ttNgDung.LoaiKhoanVay = reader.GetString(1);
                    ttNgDung.SoTKVay = reader.GetString(2);
                    ttNgDung.DanhXung = reader.GetString(3);
                    ttNgDung.HoTen = reader.GetString(4);
                    ttNgDung.Cccd = reader.GetString(5);
                    ttNgDung.DiaChi = reader.GetString(6);
                    ttNgDung.Sdt = reader.GetString(7);
                    ttNgDung.Email = reader.GetString(8); 
                    ttNgDung.NgheNghiep = reader.GetString(9);
                    ttNgDung.ThuNhap = reader.GetString(10);
                    ttNgDung.SpVay = reader.GetString(11);
                    ttNgDung.SoTienVay = reader.GetInt64(12);
                    ttNgDung.ThoiGianVay = reader.GetInt32(13);
                    ttNgDung.TaiSan = reader.GetString(14);
                    ttNgDung.GiaTriTaiSan = reader.GetInt64(15);
                    ttNgDung.ChiNhanhVay = reader.GetString(16);
                    ttNgDung.NgayVay = reader.GetDateTime(17);
                    ttNgDung.Lai = double.Parse(reader.GetString(18));
                    ttNgDung.SoTienHangThang = reader.GetInt64(19);
                    ttNgDung.NgayDenHan = reader.GetDateTime(20);
                    ttNgDung.TongSoTienPhaiTra = reader.GetInt64(21);
                    ttNgDung.PhiTraCham = reader.GetInt64(22);
                }
                else
                    return null;
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return ttNgDung;
        }
        public ThongTinTinDung XuLiNgDungTinDung(string sqlStr)
        {
            ThongTinTinDung ttTinDung = new ThongTinTinDung();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    ttTinDung.SoTKTinDung = reader.GetString(0);
                    ttTinDung.HoTen = reader.GetString(1);
                    ttTinDung.Cccd = reader.GetString(2);
                    ttTinDung.DiaChi = reader.GetString(3);
                    ttTinDung.Sdt = reader.GetString(4);
                    ttTinDung.Email = reader.GetString(5);
                    ttTinDung.NgheNghiep = reader.GetString(6);
                    ttTinDung.ThuNhap = reader.GetString(7);
                    ttTinDung.LoaiThe = reader.GetString(8);
                    ttTinDung.HanThanhToan = reader.GetDateTime(9);
                    ttTinDung.NgaySaoKe = reader.GetDateTime(10);
                    ttTinDung.HanMuc = reader.GetInt64(11);
                    ttTinDung.LaiSuat = double.Parse(reader.GetString(12));
                    ttTinDung.SoTienDaSuDung = reader.GetInt64(13);
                    ttTinDung.SoTienSuDungSau = reader.GetInt64(14);
                    ttTinDung.NgayMoThe = reader.GetDateTime(15);
                    ttTinDung.PhiTraCham = reader.GetInt64(16);
                    ttTinDung.PhiPhat = reader.GetInt64(17);
                }
                else
                    return null;
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return ttTinDung;
        }
        public KHNoXau XuLiKHNoXau(string sqlStr)
        {
            KHNoXau KHNoXau = new KHNoXau();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    KHNoXau.SoTK = reader.GetString(0);
                    KHNoXau.TenTK = reader.GetString(1);
                    KHNoXau.Cccd = reader.GetString(2);
                    KHNoXau.NgayNo = reader.GetDateTime(3);
                    KHNoXau.TenNH = reader.GetString(4);
                }
                else
                    return null;
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return KHNoXau;
        }
        public SoDienThoai XuLiSoDienThoai(string sqlStr)
        {
            SoDienThoai sdt = new SoDienThoai();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    sdt.Sdt = reader.GetString(0);
                    sdt.SoDu = reader.GetInt64(1);
                }
                else
                    return null;
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return sdt;
        }
        public bool IsEmail(string email)
        {
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(email);
        }
        public bool IsPhone(string numberphone)
        {
            string strRegex = @"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(numberphone);
        }
        /*
        public void XuatExcel(string sql)
        {
            try
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    // Thực thi câu truy vấn và tạo một SqlDataReader
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        // Tạo một đối tượng ExcelPackage mới
                        ExcelPackage excelPackage = new ExcelPackage();

                        // Tạo một worksheet mới và thiết lập tên cho nó
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("MyWorksheet");

                        // Thiết lập cột tiêu đề cho worksheet
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataReader.GetName(i);
                        }

                        // Thiết lập dữ liệu cho worksheet
                        int row = 2;
                        while (dataReader.Read())
                        {
                            for (int i = 0; i < dataReader.FieldCount; i++)
                            {
                                worksheet.Cells[row, i + 1].Value = dataReader.GetValue(i).ToString();
                            }
                            row++;
                        }
                        // Thiết lập đường dẫn lưu tập tin Excel
                        string fileName = @"D:\lAY\MyWorkbook.xlsx";

                        // Lưu workbook vào đường dẫn đã thiết lập
                        FileStream stream = new FileStream(fileName, FileMode.Create);
                        excelPackage.SaveAs(stream);
                        stream.Close();

                        // Giải phóng tài nguyên
                        excelPackage.Dispose();
                    }
                }
                MessageBox.Show("Export successful!");
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
        }
        */

        public void XuatExcel(string sql)
        {
            try
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    // Thực thi câu truy vấn và tạo một SqlDataReader
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        // Tạo một đối tượng ExcelPackage mới
                        ExcelPackage excelPackage = new ExcelPackage();

                        // Tạo một worksheet mới và thiết lập tên cho nó
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("MyWorksheet");

                        // Thiết lập cột tiêu đề cho worksheet
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataReader.GetName(i);
                        }

                        // Thiết lập dữ liệu cho worksheet
                        int row = 2;
                        while (dataReader.Read())
                        {
                            for (int i = 0; i < dataReader.FieldCount; i++)
                            {
                                worksheet.Cells[row, i + 1].Value = dataReader.GetValue(i).ToString();
                            }
                            row++;
                        }

                        // Khởi tạo hộp thoại lưu tập tin
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        saveFileDialog1.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                        saveFileDialog1.Title = "Save Excel File";
                        saveFileDialog1.ShowDialog();

                        // Nếu người dùng đã chọn đường dẫn lưu
                        if (saveFileDialog1.FileName != "")
                        {
                            // Lưu workbook vào đường dẫn đã chọn
                            FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                            excelPackage.SaveAs(stream);
                            stream.Close();
                        }

                        // Giải phóng tài nguyên
                        excelPackage.Dispose();
                    }
                }
                MessageBox.Show("Export successful!");
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
