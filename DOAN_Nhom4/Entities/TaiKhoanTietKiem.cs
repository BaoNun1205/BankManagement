using System;
using System.Collections.Generic;

namespace DOAN_Nhom4.Entities;

public partial class TaiKhoanTietKiem
{
    public string TenNh { get; set; } = null!;

    public string SoTk { get; set; } = null!;

    public int MaTietKiem { get; set; }

    public DateTime NgayDangKy { get; set; }

    public string TenTktk { get; set; } = null!;

    public int LoaiSo { get; set; }

    public decimal? TienGoc { get; set; }

    public int? KiHan { get; set; }

    public float? LaiSuat { get; set; }

    public decimal? TienLai { get; set; }

    public decimal? TongTien { get; set; }

    public virtual KhachHang KhachHang { get; set; } = null!;
}
