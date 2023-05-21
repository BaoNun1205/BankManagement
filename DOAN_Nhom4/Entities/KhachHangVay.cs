using System;
using System.Collections.Generic;

namespace DOAN_Nhom4.Entities;

public partial class KhachHangVay
{
    public string TenNh { get; set; } = null!;

    public string? LoaiKhoanVay { get; set; }

    public string SoTkvay { get; set; } = null!;

    public string? DanhXung { get; set; }

    public string? HoTen { get; set; }

    public string? Cccd { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public string? NgheNghiep { get; set; }

    public string? ThuNhap { get; set; }

    public string? Spvay { get; set; }

    public decimal? SoTienVay { get; set; }

    public int? ThoiGianVay { get; set; }

    public string? TaiSanTheChap { get; set; }

    public decimal? GiaTriTaiSan { get; set; }

    public string? ChiNhanhVay { get; set; }

    public DateTime? NgayVay { get; set; }

    public string? LaiSuat { get; set; }

    public decimal? SoTienHangThang { get; set; }

    public DateTime? NgayDenHan { get; set; }

    public decimal? TongSoTienPhaiTra { get; set; }

    public decimal? PhiTraCham { get; set; }

    public virtual KhachHang KhachHang { get; set; } = null!;
}
