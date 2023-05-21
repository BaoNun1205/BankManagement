using System;
using System.Collections.Generic;

namespace DOAN_Nhom4.Entities;

public partial class KhachHangNoXau
{
    public string SoTk { get; set; } = null!;

    public string? TenTk { get; set; }

    public string? Cccd { get; set; }

    public DateTime? NgayNo { get; set; }

    public string TenNh { get; set; } = null!;

    public virtual KhachHang KhachHang { get; set; } = null!;
}
