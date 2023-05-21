using System;
using System.Collections.Generic;

namespace DOAN_Nhom4.Entities;

public partial class LichSuGiaoDich
{
    public int MaGd { get; set; }

    public string? LoaiGd { get; set; }

    public string? NganHangGui { get; set; }

    public string? TenTkgui { get; set; }

    public string? SoTkgui { get; set; }

    public string? NganHangNhan { get; set; }

    public string? TenTknhan { get; set; }

    public string? SoTknhan { get; set; }

    public DateTime? ThoiGian { get; set; }

    public decimal? SoTien { get; set; }

    public string? LoiNhan { get; set; }
}
