using System;
using System.Collections.Generic;

namespace DOAN_Nhom4.Entities;

public partial class TaiKhoanTinDung
{
    public string SoTktinDung { get; set; } = null!;

    public string? HoTen { get; set; }

    public string? Cccd { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public string? NgheNghiep { get; set; }

    public string? ThuNhap { get; set; }

    public string? LoaiThe { get; set; }

    public DateTime? HanThanhToan { get; set; }

    public DateTime? NgaySaoKe { get; set; }

    public decimal? HanMuc { get; set; }

    public string? LaiSuat { get; set; }

    public decimal? SoTienDaSuDung { get; set; }

    public decimal? SoTienSuDungSau { get; set; }

    public DateTime? NgayMoThe { get; set; }

    public decimal? PhiTraCham { get; set; }

    public decimal? PhiPhat { get; set; }
}
