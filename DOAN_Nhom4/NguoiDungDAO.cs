using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    internal class NguoiDungDAO
    {
        NganHangHhbContext hhb = new NganHangHhbContext();
        DBConnection data = new DBConnection();
        public List<object> LayDanhSach()
        {
            var customerAccountList = from customer in hhb.KhachHangs
                                      join account in hhb.TaiKhoanNganHangs
                                      on new { customer.TenNh, customer.SoTk } equals new { account.TenNh, account.SoTk }
                                      where account.TenNh == "HHB"
                                      select new
                                      {
                                          TenNh = customer.TenNh,
                                          SoTK = customer.SoTk,
                                          TenKH = customer.TenKh,
                                          TenDN = account.TenDn,
                                          MatKhau = account.MatKhau,
                                          SoDu = account.SoDu,
                                          NgaySinh = customer.NgaySinh,
                                          CCCD = customer.Cccd,
                                          Email = customer.Email,
                                          SDT = customer.Sdt,
                                          NgayDangKy = account.NgayDangKy
                                      };
            return customerAccountList.ToList<object>();

        }
        public void Them(KhachHang kh)
        {
            hhb.KhachHangs.Add(kh);
            hhb.SaveChanges();
        }

        public void Xoa(KhachHang kh)
        {
            KhachHang? khachHang = hhb.KhachHangs.Where(khachHang => khachHang.SoTk == kh.SoTk && khachHang.TenNh == kh.TenNh).SingleOrDefault();
            if (khachHang != null )
            {
                hhb.Remove(khachHang);
                hhb.SaveChanges();
            }
        }
        public void Sua(KhachHang kh)
        {
            KhachHang? khachHang = hhb.KhachHangs.Where(khachHang => khachHang.SoTk == kh.SoTk && khachHang.TenNh == kh.TenNh).SingleOrDefault();
            if (khachHang != null)
            {
                khachHang.NgaySinh = kh.NgaySinh;
                khachHang.Cccd = kh.Cccd;
                khachHang.Sdt = kh.Sdt;
                khachHang.Email = kh.Email;
                khachHang.TenKh = kh.TenKh;
                hhb.SaveChanges();
            }
        }

        public KhachHang? LayKhachHang(string giaTriDau, string giaTriCuoi)
        {
            return hhb.KhachHangs.Where(kh => kh.SoTk == giaTriDau && kh.TenNh == giaTriCuoi).SingleOrDefault();
        }

        public bool IsEmpty(KhachHang kh)
        {
            if (kh.SoTk != "" && kh.TenKh != "" && kh.Cccd != "" && kh.Sdt != "" && kh.Email != "")
                return false;
            return true;
        }
        public bool IsPhone(KhachHang kh)
        {
            return data.IsPhone(kh.Sdt ?? "0");
        }
        public bool IsEmail(KhachHang kh)
        {
            return data.IsEmail(kh.Email ?? "0");
        }
    }
}
