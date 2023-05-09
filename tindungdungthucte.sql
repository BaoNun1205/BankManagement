CREATE TABLE [dbo].[TaiKhoanTinDung] (
    [SoTKTinDung]    VARCHAR (100) NOT NULL,
    [HoTen]          VARCHAR (255) NULL,
    [CCCD]           VARCHAR (255) NULL,
    [DiaChi]         VARCHAR (255) NULL,
    [SDT]            VARCHAR (100) NULL,
    [Email]          VARCHAR (100) NULL,
    [NgheNghiep]     VARCHAR (255) NULL,
    [ThuNhap]        VARCHAR (255) NULL,
    [LoaiThe]        VARCHAR (40)  NULL,
    [HanThanhToan]   DATE          NULL,
    [NgaySaoKe]      DATE          NULL,
    [HanMuc]         BIGINT        NULL,
    [LaiSuat]        VARCHAR (10)  NULL,
    [SoTienDaSuDung] BIGINT        NULL,
    [SoTienSuDungSau] BIGINT       NULL,
    [NgayMoThe]      DATE          NULL,
    [PhiTraCham]     BIGINT        NULL,
    [PhiPhat]        BIGINT        NULL,
    PRIMARY KEY CLUSTERED ([SoTKTinDung] ASC)
);



DROP Table TaiKhoanTinDung