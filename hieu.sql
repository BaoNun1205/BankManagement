CREATE TABLE [dbo].[KhachHang] (
    [TenNH]    VARCHAR (50) NOT NULL,
    [SoTK]     VARCHAR (10) NOT NULL,
    [TenKH]    VARCHAR (30) NULL,
    [NgaySinh] DATE         NULL,
    [CCCD]     VARCHAR (10) NULL,
    [Email]    VARCHAR (50) NULL,
    [SDT]      VARCHAR (12) NULL,
    PRIMARY KEY CLUSTERED ([TenNH] ASC, [SoTK] ASC),
    CONSTRAINT [UC_KhachHang] UNIQUE NONCLUSTERED ([TenNH] ASC, [SoTK] ASC, [CCCD] ASC, [Email] ASC, [SDT] ASC)
);

INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('HHB', '1234', 'TRAN THANH HIEU', '05/12/2003', '34234', 'hieuthanhtran12@gmail.com', '0383738129')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('HHB', '6789', 'TRIEU THANH HAN', '05/14/2003', '341254', 'hieuthanhtran13@@gmail.com', '0383738128')

CREATE TABLE [dbo].[TaiKhoanNganHang] (
    [TenNH]      VARCHAR (50) NOT NULL,
    [SoTK]       VARCHAR (10) NOT NULL,
    [TenDN]      VARCHAR (20) NOT NULL,
    [MatKhau]    VARCHAR (20) NULL,
    [SoDu]       BIGINT       NULL,
    [NgayDangKy] DATE         NULL,
    PRIMARY KEY CLUSTERED ([TenNH] ASC, [SoTK] ASC),
    CONSTRAINT [UC_TaiKHoangNganHang] UNIQUE NONCLUSTERED ([TenNH] ASC, [SoTK] ASC, [TenDN] ASC),
    FOREIGN KEY ([TenNH], [SoTK]) REFERENCES [dbo].[KhachHang] ([TenNH], [SoTK])
);

INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('HHB', '1234', 'hieulag1', '1234', '10000000', '01/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('HHB', '6789', 'hieulag2', '1234', '10000000', '09/01/2023')

CREATE SCHEMA hr;

CREATE TABLE [hr].[LichSuGiaoDich] (
    [MaGD]         INT           IDENTITY (1, 1) NOT NULL,
    [LoaiGD]       VARCHAR (30)  NULL,
    [NganHangGui]  VARCHAR (50)  NULL,
    [TenTKGui]     VARCHAR (30)  NULL,
    [SoTKGui]      VARCHAR (10)  NULL,
    [NganHangNhan] VARCHAR (50)  NULL,
    [TenTKNhan]    VARCHAR (30)  NULL,
    [SoTKNhan]     VARCHAR (10)  NULL,
    [ThoiGian]     DATE          NULL,
    [SoTien]       DECIMAL (18)  NULL,
    [LoiNhan]      VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([MaGD] ASC)
);

CREATE TABLE [dbo].[TaiKhoanTietKiem] (
    [TenNH]      VARCHAR (50) NOT NULL,
    [SoTK]       VARCHAR (10) NOT NULL,
    [MaTietKiem] VARCHAR (10) NOT NULL,
    [NgayDangKy] DATE         NOT NULL,
    [TenTKTK]    VARCHAR (50) NOT NULL,
    [LoaiSo]     INT          NOT NULL,
    [TienGoc]    DECIMAL (18) NULL,
    [KiHan]      INT          NULL,
    [LaiSuat]    REAL         NULL,
    [TienLai]    DECIMAL (18) NULL,
    [TongTien]   DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([TenNH] ASC, [SoTK] ASC, [MaTietKiem] ASC),
    FOREIGN KEY ([TenNH], [SoTK]) REFERENCES [dbo].[KhachHang] ([TenNH], [SoTK])
);

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

CREATE TABLE [dbo].[SoDienThoai] (
    [SDT]  VARCHAR (11) PRIMARY KEY,
    [SoDu] BIGINT  NOT NULL
);

INSERT INTO SoDienThoai(SDT, SoDu) VALUES ('0383738129', 50000)
INSERT INTO SoDienThoai(SDT, SoDu) VALUES ('0383738128', 50000)

CREATE TABLE KhachHangVay(
TenNH varchar(50),
LoaiKhoanVay nvarchar(255),
SoTKVay varchar(10),
DanhXung varchar(10), 
HoTen varchar(255),
CCCD varchar(255),
DiaChi varchar(255),
SDT varchar(100),
Email varchar(100),
NgheNghiep varchar(255),
ThuNhap varchar(255),
SPVay varchar(255),
SoTienVay BigInt,
ThoiGianVay int,
TaiSanTheChap varchar(255),
GiaTriTaiSan BigInt,
ChiNhanhVay varchar(255),
NgayVay Date,
LaiSuat varchar(10),
SoTienHangThang BigInt,
NgayDenHan Date,
TongSoTienPhaiTra BigInt,
PhiTraCham BigInt,
PRIMARY KEY CLUSTERED ([TenNH] ASC, [SoTKVay] ASC),
FOREIGN KEY ([TenNH], [SoTKVay]) REFERENCES [dbo].[KhachHang] ([TenNH], [SoTK])
)

create table dbo.KhachHangNoXau(
SoTK varchar(10),
TenTK varchar(255),
CCCD varchar(255),
NgayNo Date,
TenNH varchar(50),
PRIMARY KEY CLUSTERED ([TenNH] ASC, [SoTK] ASC),
FOREIGN KEY ([TenNH], [SoTK]) REFERENCES [dbo].[KhachHang] ([TenNH], [SoTK])
)

CREATE TABLE hr.KhachHangTungVay(
SoTKVay INT IDENTITY(1,1) Primary Key,
DanhXung varchar(10), 
HoTen varchar(255),
CCCD varchar(255),
DiaChi varchar(255),
SDT varchar(100),
Email varchar(100),
NgheNghiep varchar(255),
ThuNhap varchar(255),
SPVay varchar(255),
SoTienVay BigInt,
ThoiGianVay int,
ChiNhanhVay varchar(255),
NgayVay Date,
LaiSuat varchar(10),
SoTienHangThang BigInt,
NgayDenHan Date,
TongSoTienPhaiTra BigInt,
PhiTraCham BigInt
)

INSERT INTO hr.KhachHangTungVay(DanhXung, HoTen, CCCD, DiaChi, SDT, Email, NgheNghiep, ThuNhap, SPVay, SoTienVay, ThoiGianVay, ChiNhanhVay, NgayVay, LaiSuat, SoTienHangThang, NgayDenHan, TongSoTienPhaiTra, PhiTraCham)
OUTPUT INSERTED.SoTKVay
VALUES('Ông', 'Hi Hieu', '12345', 'QB', '0918512871', 'hihieu@gmail.com', 'Sinh vien, hoc sinh', '>= trieu dong', 'Mua dien thoai', 5000000, 7, 'HCM', '12/08/2022', '7.8', 900000, '01/08/2022', 11000000, 50000)
