using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DOAN_Nhom4.Entities;

public partial class NganHangHhbContext : DbContext
{
    public NganHangHhbContext()
    {
    }

    public NganHangHhbContext(DbContextOptions<NganHangHhbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KhachHangNoXau> KhachHangNoXaus { get; set; }

    public virtual DbSet<KhachHangTungVay> KhachHangTungVays { get; set; }

    public virtual DbSet<KhachHangVay> KhachHangVays { get; set; }

    public virtual DbSet<LichSuGiaoDich> LichSuGiaoDiches { get; set; }

    public virtual DbSet<SoDienThoai> SoDienThoais { get; set; }

    public virtual DbSet<TaiKhoanNganHang> TaiKhoanNganHangs { get; set; }

    public virtual DbSet<TaiKhoanTietKiem> TaiKhoanTietKiems { get; set; }

    public virtual DbSet<TaiKhoanTinDung> TaiKhoanTinDungs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QLKhachHang;Integrated Security=True;Pooling=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => new { e.TenNh, e.SoTk }).HasName("PK__KhachHan__673A7C38A4DD839D");

            entity.ToTable("KhachHang");

            entity.HasIndex(e => new { e.TenNh, e.SoTk, e.Cccd, e.Email, e.Sdt }, "UC_KhachHang").IsUnique();

            entity.Property(e => e.TenNh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenNH");
            entity.Property(e => e.SoTk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SoTK");
            entity.Property(e => e.Cccd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenKh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<KhachHangNoXau>(entity =>
        {
            entity.HasKey(e => new { e.TenNh, e.SoTk }).HasName("PK__KhachHan__673A7C38353F4536");

            entity.ToTable("KhachHangNoXau");

            entity.Property(e => e.TenNh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenNH");
            entity.Property(e => e.SoTk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SoTK");
            entity.Property(e => e.Cccd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.NgayNo).HasColumnType("date");
            entity.Property(e => e.TenTk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TenTK");

            entity.HasOne(d => d.KhachHang).WithOne(p => p.KhachHangNoXau)
                .HasForeignKey<KhachHangNoXau>(d => new { d.TenNh, d.SoTk })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KhachHangNoXau__36B12243");
        });

        modelBuilder.Entity<KhachHangTungVay>(entity =>
        {
            entity.HasKey(e => e.SoTkvay).HasName("PK__KhachHan__4CC5A53B8D8B4CA4");

            entity.ToTable("KhachHangTungVay", "hr");

            entity.Property(e => e.SoTkvay).HasColumnName("SoTKVay");
            entity.Property(e => e.Cccd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.ChiNhanhVay)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DanhXung)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HoTen)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LaiSuat)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NgayDenHan).HasColumnType("date");
            entity.Property(e => e.NgayVay).HasColumnType("date");
            entity.Property(e => e.NgheNghiep)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhiTraCham).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Sdt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.SoTienHangThang).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SoTienVay).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Spvay)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SPVay");
            entity.Property(e => e.ThuNhap)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TongSoTienPhaiTra).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<KhachHangVay>(entity =>
        {
            entity.HasKey(e => new { e.TenNh, e.SoTkvay }).HasName("PK__KhachHan__E835EEC43DB9E66E");

            entity.ToTable("KhachHangVay");

            entity.Property(e => e.TenNh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenNH");
            entity.Property(e => e.SoTkvay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SoTKVay");
            entity.Property(e => e.Cccd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.ChiNhanhVay)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DanhXung)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GiaTriTaiSan).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.HoTen)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LaiSuat)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LoaiKhoanVay).HasMaxLength(255);
            entity.Property(e => e.NgayDenHan).HasColumnType("date");
            entity.Property(e => e.NgayVay).HasColumnType("date");
            entity.Property(e => e.NgheNghiep)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhiTraCham).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Sdt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.SoTienHangThang).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SoTienVay).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Spvay)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SPVay");
            entity.Property(e => e.TaiSanTheChap)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ThuNhap)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TongSoTienPhaiTra).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.KhachHang).WithOne(p => p.KhachHangVay)
                .HasForeignKey<KhachHangVay>(d => new { d.TenNh, d.SoTkvay })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KhachHangVay__33D4B598");
        });

        modelBuilder.Entity<LichSuGiaoDich>(entity =>
        {
            entity.HasKey(e => e.MaGd).HasName("PK__LichSuGi__2725AE81CEEB282C");

            entity.ToTable("LichSuGiaoDich", "hr");

            entity.Property(e => e.MaGd).HasColumnName("MaGD");
            entity.Property(e => e.LoaiGd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LoaiGD");
            entity.Property(e => e.LoiNhan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NganHangGui)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NganHangNhan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SoTien).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SoTkgui)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SoTKGui");
            entity.Property(e => e.SoTknhan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SoTKNhan");
            entity.Property(e => e.TenTkgui)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TenTKGui");
            entity.Property(e => e.TenTknhan)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TenTKNhan");
            entity.Property(e => e.ThoiGian).HasColumnType("date");
        });

        modelBuilder.Entity<SoDienThoai>(entity =>
        {
            entity.HasKey(e => e.Sdt).HasName("PK__SoDienTh__CA1930A4978DB2E6");

            entity.ToTable("SoDienThoai");

            entity.Property(e => e.Sdt)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.SoDu).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<TaiKhoanNganHang>(entity =>
        {
            entity.HasKey(e => new { e.TenNh, e.SoTk }).HasName("PK__TaiKhoan__673A7C38FC284C66");

            entity.ToTable("TaiKhoanNganHang");

            entity.HasIndex(e => new { e.TenNh, e.SoTk, e.TenDn }, "UC_TaiKHoangNganHang").IsUnique();

            entity.Property(e => e.TenNh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenNH");
            entity.Property(e => e.SoTk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SoTK");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgayDangKy).HasColumnType("date");
            entity.Property(e => e.SoDu).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TenDn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TenDN");

            entity.HasOne(d => d.KhachHang).WithOne(p => p.TaiKhoanNganHang)
                .HasForeignKey<TaiKhoanNganHang>(d => new { d.TenNh, d.SoTk })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaiKhoanNganHang__286302EC");
        });

        modelBuilder.Entity<TaiKhoanTietKiem>(entity =>
        {
            entity.HasKey(e => new { e.TenNh, e.SoTk, e.MaTietKiem }).HasName("PK__TaiKhoan__0E1A9189F330E873");

            entity.ToTable("TaiKhoanTietKiem");

            entity.Property(e => e.TenNh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenNH");
            entity.Property(e => e.SoTk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SoTK");
            entity.Property(e => e.NgayDangKy).HasColumnType("date");
            entity.Property(e => e.TenTktk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenTKTK");
            entity.Property(e => e.TienGoc).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TienLai).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.KhachHang).WithMany(p => p.TaiKhoanTietKiems)
                .HasForeignKey(d => new { d.TenNh, d.SoTk })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaiKhoanTietKiem__2D27B809");
        });

        modelBuilder.Entity<TaiKhoanTinDung>(entity =>
        {
            entity.HasKey(e => e.SoTktinDung).HasName("PK__TaiKhoan__240044BC3B755E6E");

            entity.ToTable("TaiKhoanTinDung");

            entity.Property(e => e.SoTktinDung)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SoTKTinDung");
            entity.Property(e => e.Cccd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HanMuc).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.HanThanhToan).HasColumnType("date");
            entity.Property(e => e.HoTen)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LaiSuat)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LoaiThe)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NgayMoThe).HasColumnType("date");
            entity.Property(e => e.NgaySaoKe).HasColumnType("date");
            entity.Property(e => e.NgheNghiep)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhiPhat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PhiTraCham).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Sdt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.SoTienDaSuDung).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SoTienSuDungSau).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ThuNhap)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
