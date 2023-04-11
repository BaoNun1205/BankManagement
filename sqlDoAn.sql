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

CREATE TABLE [dbo].[TaiKhoanNganHang] (
    [TenNH]   VARCHAR (50) NOT NULL,
    [SoTK]    VARCHAR (10) NOT NULL,
    [TenDN]   VARCHAR (20) NOT NULL,
    [MatKhau] VARCHAR (20) NULL,
    [SoDu]    BIGINT       NULL,
    [NgayDangKy] DATE      NULL,
    PRIMARY KEY CLUSTERED ([TenNH] ASC, [SoTK] ASC),
    CONSTRAINT [UC_TaiKHoangNganHang] UNIQUE NONCLUSTERED ([TenNH] ASC, [SoTK] ASC, [TenDN] ASC),
    FOREIGN KEY ([TenNH], [SoTK]) REFERENCES [dbo].[KhachHang] ([TenNH], [SoTK])
);

INSERT INTO KhachHang VALUES ('HHB', '1234', 'TRAN THANH HIEU', '2003/08/29', '897978', 'hieuthanhtran12@gmail.com', '0383738129')
INSERT INTO KhachHang VALUES ('HHB', '6789', 'TRIEU THANH HAN', '2003/08/29', '123342', 'hieuthanhtran29@gmail.com', '0383738128')

INSERT INTO TaiKhoanNganHang VALUES ('HHB', '1234', 'hieulag1', '1234', 1000000, '2022/08/29')
INSERT INTO TaiKhoanNganHang VALUES ('HHB', '6789', 'hieulag2', '1234', 1000000, '2022/08/29')

DROP TABLE hr.LichSuGiaoDich

CREATE SCHEMA hr;

CREATE TABLE hr.LichSuGiaoDich(
	MaGD INT IDENTITY(1,1) PRIMARY KEY,
    LoaiGD VARCHAR(30),
	NganHangGui VARCHAR(50),
	TenTKGui VARCHAR(30),
	SoTKGui VARCHAR(10),
	NganHangNhan VARCHAR(50),
	TenTKNhan VARCHAR(30),
	SoTKNhan VARCHAR(10),
	ThoiGian DATE,
	SoTien BIGINT,
	LoiNhan VARCHAR(100)
)


CREATE TABLE KhachHangVay(
SoTKVay varchar(100) Primary Key,
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

INSERT INTO KhachHangVay(SoTKVay, DanhXung, HoTen, CCCD, DiaChi, SDT, Email, NgheNghiep, ThuNhap, SPVay, SoTienVay, ThoiGianVay, ChiNhanhVay, NgayVay, LaiSuat, SoTienHangThang, NgayDenHan, TongSoTienPhaiTra, PhiTraCham)
VALUES('100', 'Ông', 'Hi Hieu', '12345', 'QB', '0918512871', 'hihieu@gmail.com', 'Sinh vien, hoc sinh', '>= trieu dong', 'Mua dien thoai', 5000000, 7, 'HCM', '12/08/2022', '7.8', 900000, '01/08/2022', 11000000, 50000)

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
    [NgayDaoHan]     DATE          NULL,
    [HanMuc]         BIGINT        NULL,
    [LaiSuat]        VARCHAR (10)  NULL,
    [SoTienDaSuDung] BIGINT        NULL,
    [NgayMoThe]      DATE          NULL,
    [PhiTraCham]     BIGINT        NULL,
    [PhiThuongNien]  BIGINT        NULL,
    PRIMARY KEY CLUSTERED ([SoTKTinDung] ASC)
);

CREATE TABLE [dbo].[TaiKhoanTietKiem] (
    [ID]       INT           NOT NULL,
    [TenTKTK]  VARCHAR (255) NOT NULL,
    [TienGoc]  DECIMAL (18)  NULL,
    [KiHan]    INT           NULL,
    [LaiSuat]  REAL          NULL,
    [TienLai]  DECIMAL (18)  NULL,
    [TongTien] DECIMAL (18)  NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
