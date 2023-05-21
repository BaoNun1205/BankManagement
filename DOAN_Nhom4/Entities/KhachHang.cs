using System;
using System.Collections.Generic;

namespace DOAN_Nhom4.Entities;

public partial class KhachHang
{
    public string TenNh { get; set; } = null!;

    public string SoTk { get; set; } = null!;

    public string? TenKh { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? Cccd { get; set; }

    public string? Email { get; set; }

    public string? Sdt { get; set; }

    public virtual KhachHangNoXau? KhachHangNoXau { get; set; }

    public virtual KhachHangVay? KhachHangVay { get; set; }

    public virtual TaiKhoanNganHang? TaiKhoanNganHang { get; set; }

    public virtual ICollection<TaiKhoanTietKiem> TaiKhoanTietKiems { get; set; } = new List<TaiKhoanTietKiem>();
}
