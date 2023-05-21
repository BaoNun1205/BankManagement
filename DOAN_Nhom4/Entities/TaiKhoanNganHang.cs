using System;
using System.Collections.Generic;

namespace DOAN_Nhom4.Entities;

public partial class TaiKhoanNganHang
{
    public string TenNh { get; set; } = null!;

    public string SoTk { get; set; } = null!;

    public string TenDn { get; set; } = null!;

    public string? MatKhau { get; set; }

    public decimal? SoDu { get; set; }

    public DateTime? NgayDangKy { get; set; }

    public virtual KhachHang KhachHang { get; set; } = null!;
}
