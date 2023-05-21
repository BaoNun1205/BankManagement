using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class ThongKeDAO
    {
        NganHangHhbContext hhb = new NganHangHhbContext();
        DBConnection data = new DBConnection();
        public ThongKeDAO() { }

        public List<dynamic> ThongKeTienGui(string ngayBatDau, string ngayKetThuc, string nganHang, string soTK)
        {
            var result = new List<dynamic>();
            var dateRange = Enumerable.Range(0, (DateTime.Parse(ngayKetThuc) - DateTime.Parse(ngayBatDau)).Days + 1)
                                      .Select(offset => DateTime.Parse(ngayBatDau).AddDays(offset));

            var thongKeTienGui = from d in dateRange
                                 join ls in hhb.LichSuGiaoDiches on d.Date equals ls.ThoiGian.Value.Date into gj
                                 from ls in gj.DefaultIfEmpty()
                                 where d >= DateTime.Parse(ngayBatDau) && d <= DateTime.Parse(ngayKetThuc)
                                       && (ls == null || (ls.NganHangGui == nganHang && ls.SoTkgui == soTK))
                                 group ls by d into g
                                 select new
                                 {
                                     Ngay = g.Key.ToString("dd/MM/yyyy"),
                                     TongTien = g.Sum(ls => ls != null ? ls.SoTien : 0)
                                     // Các thuộc tính khác của đối tượng
                                 };
            foreach (var date in dateRange)
            {
                var thongKe = thongKeTienGui.FirstOrDefault(t => t.Ngay == date.ToString("dd/MM/yyyy"));
                if (thongKe != null)
                {
                    result.Add(thongKe);
                }
                else
                {
                    result.Add(new
                    {
                        Ngay = date.ToString("dd/MM/yyyy"),
                        TongTien = 0
                        // Các thuộc tính khác của đối tượng
                    });
                }
            }
            return result;
        }

        public List<dynamic> ThongKeTienNhan(string ngayBatDau, string ngayKetThuc, string nganHang, string soTK)
        {
            var result = new List<dynamic>();
            var dateRange = Enumerable.Range(0, (DateTime.Parse(ngayKetThuc) - DateTime.Parse(ngayBatDau)).Days + 1)
                                      .Select(offset => DateTime.Parse(ngayBatDau).AddDays(offset));

            var thongKeTienGui = from d in dateRange
                                 join ls in hhb.LichSuGiaoDiches on d.Date equals ls.ThoiGian.Value.Date into gj
                                 from ls in gj.DefaultIfEmpty()
                                 where d >= DateTime.Parse(ngayBatDau) && d <= DateTime.Parse(ngayKetThuc)
                                       && (ls == null || (ls.NganHangNhan == nganHang && ls.SoTknhan == soTK))
                                 group ls by d into g
                                 select new
                                 {
                                     Ngay = g.Key.ToString("dd/MM/yyyy"),
                                     TongTien = g.Sum(ls => ls != null ? ls.SoTien : 0)
                                     // Các thuộc tính khác của đối tượng
                                 };
            foreach (var date in dateRange)
            {
                var thongKe = thongKeTienGui.FirstOrDefault(t => t.Ngay == date.ToString("dd/MM/yyyy"));
                if (thongKe != null)
                {
                    result.Add(thongKe);
                }
                else
                {
                    result.Add(new
                    {
                        Ngay = date.ToString("dd/MM/yyyy"),
                        TongTien = 0
                        // Các thuộc tính khác của đối tượng
                    });
                }
            }
            return result;
        }

        public List<dynamic> ThongKeTienTong(string ngayBatDau, string ngayKetThuc, string nganHang, string soTK)
        {
            var result = new List<dynamic>();
            var dateRange = Enumerable.Range(0, (DateTime.Parse(ngayKetThuc) - DateTime.Parse(ngayBatDau)).Days + 1)
                                      .Select(offset => DateTime.Parse(ngayBatDau).AddDays(offset));

            var thongKeTienGui = from d in dateRange
                                 join ls in hhb.LichSuGiaoDiches on d.Date equals ls.ThoiGian.Value.Date into gj
                                 from ls in gj.DefaultIfEmpty()
                                 where d >= DateTime.Parse(ngayBatDau) && d <= DateTime.Parse(ngayKetThuc)
                                       && ((ls == null || (ls.NganHangGui == nganHang && ls.SoTkgui == soTK))
                                       || (ls == null || (ls.NganHangNhan == nganHang && ls.SoTknhan == soTK)))
                                 group ls by d into g
                                 select new
                                 {
                                     Ngay = g.Key.ToString("dd/MM/yyyy"),
                                     TongTien = g.Sum(ls => ls != null ? ls.SoTien : 0)
                                     // Các thuộc tính khác của đối tượng
                                 };
            foreach (var date in dateRange)
            {
                var thongKe = thongKeTienGui.FirstOrDefault(t => t.Ngay == date.ToString("dd/MM/yyyy"));
                if (thongKe != null)
                {
                    result.Add(thongKe);
                }
                else
                {
                    result.Add(new
                    {
                        Ngay = date.ToString("dd/MM/yyyy"),
                        TongTien = 0
                        // Các thuộc tính khác của đối tượng
                    });
                }
            }
            return result;
        }

        public List<dynamic> ThongKeGiaoDichChuyenTien(string ngayBatDau, string ngayKetThuc)
        {
            string s = "Chuyen Tien";
            var result = new List<dynamic>();
            var dateRange = Enumerable.Range(0, (DateTime.Parse(ngayKetThuc) - DateTime.Parse(ngayBatDau)).Days + 1)
                                      .Select(offset => DateTime.Parse(ngayBatDau).AddDays(offset));

            var thongKeTienGui = from d in dateRange
                                 join ls in hhb.LichSuGiaoDiches on d.Date equals ls.ThoiGian.Value.Date into gj
                                 from ls in gj.DefaultIfEmpty()
                                 where d >= DateTime.Parse(ngayBatDau) && d <= DateTime.Parse(ngayKetThuc)
                                       && (ls.LoaiGd == s)
                                 group ls by d into g
                                 select new
                                 {
                                     Ngay = g.Key.ToString("dd/MM/yyyy"),
                                     TongTien = g.Sum(ls => ls != null ? ls.SoTien : 0)
                                     // Các thuộc tính khác của đối tượng
                                 };
            foreach (var date in dateRange)
            {
                var thongKe = thongKeTienGui.FirstOrDefault(t => t.Ngay == date.ToString("dd/MM/yyyy"));
                if (thongKe != null)
                {
                    result.Add(thongKe);
                }
                else
                {
                    result.Add(new
                    {
                        Ngay = date.ToString("dd/MM/yyyy"),
                        TongTien = 0
                        // Các thuộc tính khác của đối tượng
                    });
                }
            }
            return result;
        }

        public List<dynamic> ThongKeGiaoDichVienThong(string ngayBatDau, string ngayKetThuc)
        {
            string s = "Nap Tien Dien Thoai";
            var result = new List<dynamic>();
            var dateRange = Enumerable.Range(0, (DateTime.Parse(ngayKetThuc) - DateTime.Parse(ngayBatDau)).Days + 1)
                                      .Select(offset => DateTime.Parse(ngayBatDau).AddDays(offset));

            var thongKeTienGui = from d in dateRange
                                 join ls in hhb.LichSuGiaoDiches on d.Date equals ls.ThoiGian.Value.Date into gj
                                 from ls in gj.DefaultIfEmpty()
                                 where d >= DateTime.Parse(ngayBatDau) && d <= DateTime.Parse(ngayKetThuc)
                                       && (ls.LoaiGd == s)
                                 group ls by d into g
                                 select new
                                 {
                                     Ngay = g.Key.ToString("dd/MM/yyyy"),
                                     TongTien = g.Sum(ls => ls != null ? ls.SoTien : 0)
                                     // Các thuộc tính khác của đối tượng
                                 };
            foreach (var date in dateRange)
            {
                var thongKe = thongKeTienGui.FirstOrDefault(t => t.Ngay == date.ToString("dd/MM/yyyy"));
                if (thongKe != null)
                {
                    result.Add(thongKe);
                }
                else
                {
                    result.Add(new
                    {
                        Ngay = date.ToString("dd/MM/yyyy"),
                        TongTien = 0
                        // Các thuộc tính khác của đối tượng
                    });
                }
            }
            return result;
        }

        public List<dynamic> ThongKeGiaoDichTinDung(string ngayBatDau, string ngayKetThuc)
        {
            string s = "Tin Dung";
            var result = new List<dynamic>();
            var dateRange = Enumerable.Range(0, (DateTime.Parse(ngayKetThuc) - DateTime.Parse(ngayBatDau)).Days + 1)
                                      .Select(offset => DateTime.Parse(ngayBatDau).AddDays(offset));

            var thongKeTienGui = from d in dateRange
                                 join ls in hhb.LichSuGiaoDiches on d.Date equals ls.ThoiGian.Value.Date into gj
                                 from ls in gj.DefaultIfEmpty()
                                 where d >= DateTime.Parse(ngayBatDau) && d <= DateTime.Parse(ngayKetThuc)
                                       && (ls.LoaiGd == s)
                                 group ls by d into g
                                 select new
                                 {
                                     Ngay = g.Key.ToString("dd/MM/yyyy"),
                                     TongTien = g.Sum(ls => ls != null ? ls.SoTien : 0)
                                     // Các thuộc tính khác của đối tượng
                                 };
            foreach (var date in dateRange)
            {
                var thongKe = thongKeTienGui.FirstOrDefault(t => t.Ngay == date.ToString("dd/MM/yyyy"));
                if (thongKe != null)
                {
                    result.Add(thongKe);
                }
                else
                {
                    result.Add(new
                    {
                        Ngay = date.ToString("dd/MM/yyyy"),
                        TongTien = 0
                        // Các thuộc tính khác của đối tượng
                    });
                }
            }
            return result;
        }

        public List<dynamic> ThongKeGiaoDichTietKiem(string ngayBatDau, string ngayKetThuc)
        {
            string giaTriThuNhat = "Gui Tiet Kiem";
            string giaTriThuHai = "Rut Tiet Kiem";
            var result = new List<dynamic>();
            var dateRange = Enumerable.Range(0, (DateTime.Parse(ngayKetThuc) - DateTime.Parse(ngayBatDau)).Days + 1)
                                      .Select(offset => DateTime.Parse(ngayBatDau).AddDays(offset));

            var thongKeTienGui = from d in dateRange
                                 join ls in hhb.LichSuGiaoDiches on d.Date equals ls.ThoiGian.Value.Date into gj
                                 from ls in gj.DefaultIfEmpty()
                                 where d >= DateTime.Parse(ngayBatDau) && d <= DateTime.Parse(ngayKetThuc)
                                       && ls.LoaiGd == giaTriThuNhat && ls.LoaiGd == giaTriThuHai
                                 group ls by d into g
                                 select new
                                 {
                                     Ngay = g.Key.ToString("dd/MM/yyyy"),
                                     TongTien = g.Sum(ls => ls != null ? ls.SoTien : 0)
                                     // Các thuộc tính khác của đối tượng
                                 };
            foreach (var date in dateRange)
            {
                var thongKe = thongKeTienGui.FirstOrDefault(t => t.Ngay == date.ToString("dd/MM/yyyy"));
                if (thongKe != null)
                {
                    result.Add(thongKe);
                }
                else
                {
                    result.Add(new
                    {
                        Ngay = date.ToString("dd/MM/yyyy"),
                        TongTien = 0
                        // Các thuộc tính khác của đối tượng
                    });
                }
            }
            return result;
        }

        public List<dynamic> ThongKeGiaoDichVayTien(string ngayBatDau, string ngayKetThuc)
        {
            string giaTriThuNhat = "Vay Tien";
            string giaTriThuHai = "Thanh Toan Khoan Vay";
            var result = new List<dynamic>();
            var dateRange = Enumerable.Range(0, (DateTime.Parse(ngayKetThuc) - DateTime.Parse(ngayBatDau)).Days + 1)
                                      .Select(offset => DateTime.Parse(ngayBatDau).AddDays(offset));

            var thongKeTienGui = from d in dateRange
                                 join ls in hhb.LichSuGiaoDiches on d.Date equals ls.ThoiGian.Value.Date into gj
                                 from ls in gj.DefaultIfEmpty()
                                 where d >= DateTime.Parse(ngayBatDau) && d <= DateTime.Parse(ngayKetThuc)
                                       && ls.LoaiGd == giaTriThuNhat && ls.LoaiGd == giaTriThuHai
                                 group ls by d into g
                                 select new
                                 {
                                     Ngay = g.Key.ToString("dd/MM/yyyy"),
                                     TongTien = g.Sum(ls => ls != null ? ls.SoTien : 0)
                                     // Các thuộc tính khác của đối tượng
                                 };
            foreach (var date in dateRange)
            {
                var thongKe = thongKeTienGui.FirstOrDefault(t => t.Ngay == date.ToString("dd/MM/yyyy"));
                if (thongKe != null)
                {
                    result.Add(thongKe);
                }
                else
                {
                    result.Add(new
                    {
                        Ngay = date.ToString("dd/MM/yyyy"),
                        TongTien = 0
                        // Các thuộc tính khác của đối tượng
                    });
                }
            }
            return result;
        }

        public int DemSoLuongTaiKhoang()
        {
            var soLuongTaiKhoan = hhb.TaiKhoanNganHangs.Count();
            return soLuongTaiKhoan;
        }

        public int DemSoLuongTinDung()
        {
            var soLuongTaiKhoan = hhb.TaiKhoanTinDungs.Count();
            return soLuongTaiKhoan;
        }

        public int DemSoLuongSoTietKiem()
        {
            var soLuongTaiKhoan = hhb.TaiKhoanTietKiems.Count();
            return soLuongTaiKhoan;
        }

        public int DemSoLuongVay()
        {
            var soLuongTaiKhoan = hhb.KhachHangVays.Count();
            return soLuongTaiKhoan;
        }

        public int DemSoLuongNoXau()
        {
            var soLuongTaiKhoan = hhb.KhachHangNoXaus.Count();
            return soLuongTaiKhoan;
        }
    }
}
