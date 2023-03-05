CREATE TABLE [dbo].[KhachHang] (
    [SoTK]     VARCHAR (255) NOT NULL,
    [TenTK]    VARCHAR (255) NULL,
    [TenDN]    VARCHAR (255) NULL,
    [MatKhau]  VARCHAR (255) NULL,
    [NgaySinh] DATETIME NULL,
    [CCCD]     VARCHAR (255) NULL,
    [SDT]      VARCHAR (255) NULL,
    [SoDu]     BIGINT        NULL,
    CONSTRAINT [KhachHang_PK] PRIMARY KEY CLUSTERED ([SoTK] ASC)
);

