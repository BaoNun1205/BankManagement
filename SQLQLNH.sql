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

INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('HHB', '1205', 'Le Nguyen Bao', '05/12/2003', '34234', 'bao@gmail.com', '0375969227')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('HHB', '1222', 'Le Nguyen Nun', '05/14/2003', '341254', 'bao2@gmail.com', '0365969228')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('HHB', '1', 'Hoang Mai Hieu', '05/14/2003', '1', 'hihieu@gmail.com', '0918512871')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('HHB', '2', 'Hieu Mai Hoang', '05/14/2003', '2', 'hiue@gmail.com', '0905048501')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('HHB', '3', 'Tran Thanh Hieu', '05/14/2003', '3', 'thanhhieu@gmail.com', '0844349916')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('ACB', '1', 'Nguyen Van A', '05/14/2003', '1', 'hihieu@gmail.com', '0918512872')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('ACB', '2', 'Nguyen Van B', '05/14/2003', '2', 'hiue@gmail.com', '0905048502')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('ACB', '3', 'Nguyen Van C', '05/14/2003', '3', 'thanhhieu@gmail.com', '0844349917')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('Agribank', '1', 'Nguyen Van D', '05/14/2003', '1', 'hihieu@gmail.com', '0918512873')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('Agribank', '2', 'Nguyen Van E', '05/14/2003', '2', 'hiue@gmail.com', '0905048504')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('Agribank', '3', 'Nguyen Van F', '05/14/2003', '3', 'thanhhieu@gmail.com', '0844349918')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('BIDV', '1', 'Nguyen Van G', '05/14/2003', '1', 'hihieu@gmail.com', '0918512874')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('BIDV', '2', 'Nguyen Van H', '05/14/2003', '2', 'hiue@gmail.com', '0905048503')
INSERT INTO KhachHang(TenNH, SoTK, TenKH, NgaySinh, CCCD, Email, SDT) VALUES ('BIDV', '3', 'Nguyen Van K', '05/14/2003', '3', 'thanhhieu@gmail.com', '0844349919')

CREATE TABLE [dbo].[TaiKhoanNganHang] (
    [TenNH]      VARCHAR (50) NOT NULL,
    [SoTK]       VARCHAR (10) NOT NULL,
    [TenDN]      VARCHAR (20) NOT NULL,
    [MatKhau]    VARCHAR (20) NULL,
    [SoDu]       DECIMAL       NULL,
    [NgayDangKy] DATE         NULL,
    PRIMARY KEY CLUSTERED ([TenNH] ASC, [SoTK] ASC),
    CONSTRAINT [UC_TaiKHoangNganHang] UNIQUE NONCLUSTERED ([TenNH] ASC, [SoTK] ASC, [TenDN] ASC),
    FOREIGN KEY ([TenNH], [SoTK]) REFERENCES [dbo].[KhachHang] ([TenNH], [SoTK])
);

INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('HHB', '1205', 'bao', '1234', '1000000', '01/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('HHB', '1222', 'nun', '1234', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('HHB', '1', 'hihieu', '1', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('HHB', '2', 'hihieu1', '1', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('HHB', '3', 'hihieu2', '1', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('ACB', '1', 'a', '1', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('ACB', '2', 'b', '1', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('ACB', '3', 'c', '1', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('Agribank', '1', 'd', '1', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('Agribank', '2', 'e', '1', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('Agribank', '3', 'f', '1', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('BIDV', '1', 'g', '1', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('BIDV', '2', 'h', '1', '1000000', '09/01/2023')
INSERT INTO TaiKhoanNganHang(TenNH, SoTK, TenDN, MatKhau, SoDu, NgayDangKy) VALUES ('BIDV', '3', 'k', '1', '1000000', '09/01/2023')

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



INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Gui Tiet Kiem', 'HHB', 'Le Nguyen Bao', '1205', 'HHB', 'tk1', '100001', '05/17/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Gui Tiet Kiem', 'HHB', 'Le Nguyen Bao', '1205', 'HHB', 'tk2', '100002', '05/18/2023', '2000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Gui Tiet Kiem', 'HHB', 'Le Nguyen Bao', '1205', 'HHB', 'tk3', '100003', '05/19/2023', '3000000', '')

INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Gui Tiet Kiem', 'HHB', 'Hoang Mai Hieu', '1', 'HHB', 'tk1', '200001', '05/17/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Gui Tiet Kiem', 'HHB', 'Hoang Mai Hieu', '1', 'HHB', 'tk2', '200002', '05/18/2023', '2000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Gui Tiet Kiem', 'HHB', 'Hoang Mai Hieu', '1', 'HHB', 'tk3', '200003', '05/19/2023', '3000000', '')

INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Gui Tiet Kiem', 'HHB', 'Tran Thanh Hieu', '3', 'HHB', 'tk1', '300001', '05/17/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Gui Tiet Kiem', 'HHB', 'Tran Thanh Hieu', '3', 'HHB', 'tk2', '300002', '05/18/2023', '2000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Gui Tiet Kiem', 'HHB', 'Tran Thanh Hieu', '3', 'HHB', 'tk3', '300003', '05/19/2023', '3000000', '')

INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Rut Tiet Kiem', 'HHB', 'tk1', '200001', 'HHB', 'Le Nguyen Bao', '1205', '05/17/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Rut Tiet Kiem', 'HHB', 'tk2', '200002', 'HHB', 'Le Nguyen Bao', '1205', '05/18/2023', '2000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Rut Tiet Kiem', 'HHB', 'tk3', '200003', 'HHB', 'Le Nguyen Bao', '1205', '05/19/2023', '3000000', '')

INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Rut Tiet Kiem', 'HHB', 'tk1', '200001', 'HHB', 'Hoang Mai Hieu', '1', '05/17/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Rut Tiet Kiem', 'HHB', 'tk2', '200002', 'HHB', 'Hoang Mai Hieu', '1', '05/18/2023', '2000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Rut Tiet Kiem', 'HHB', 'tk3', '200003', 'HHB', 'Hoang Mai Hieu', '1', '05/19/2023', '3000000', '')

INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Rut Tiet Kiem', 'HHB', 'tk1', '300001', 'HHB', 'Tran Thanh Hieu', '3', '05/17/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Rut Tiet Kiem', 'HHB', 'tk2', '300002', 'HHB', 'Tran Thanh Hieu', '3', '05/18/2023', '2000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Rut Tiet Kiem', 'HHB', 'tk3', '300003', 'HHB', 'Tran Thanh Hieu', '3', '05/19/2023', '3000000', '')

INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Le Nguyen Bao', '1205', 'HHB', 'Tran Thanh Hieu', '3', '05/17/2023', '100000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Le Nguyen Bao', '1205', 'HHB', 'Hoang Mai Hieu', '1', '05/18/2023', '200000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Le Nguyen Bao', '1205', 'ACB', 'Nguyen Van A', '1', '05/19/2023', '300000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Le Nguyen Bao', '1205', 'Argibank', 'Nguyen Van D', '1', '05/19/2023', '400000', '')

INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Hoang Mai Hieu', '1', 'HHB', 'Tran Thanh Hieu', '3', '05/17/2023', '100000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Hoang Mai Hieu', '1', 'HHB', 'Le Nguyen Bao', '1205', '05/18/2023', '200000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Hoang Mai Hieu', '1', 'ACB', 'Nguyen Van A', '1', '05/19/2023', '300000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Hoang Mai Hieu', '1', 'Argibank', 'Nguyen Van D', '1', '05/19/2023', '400000', '')

INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Tran Thanh Hieu', '3', 'HHB', 'Le Nguyen Bao', '1205', '05/17/2023', '100000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Tran Thanh Hieu', '3', 'HHB', 'Hoang Mai Hieu', '1', '05/18/2023', '200000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Tran Thanh Hieu', '3', 'ACB', 'Nguyen Van A', '1', '05/19/2023', '300000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Chuyen Tien', 'HHB', 'Tran Thanh Hieu', '3', 'Argibank', 'Nguyen Van D', '1', '05/19/2023', '400000', '')

INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Le Nguyen Bao', '1205', 'So Dien Thoai', 'So Dien Thoai', '0375969227', '05/17/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Le Nguyen Bao', '1205', 'So Dien Thoai', 'So Dien Thoai', '0918512871', '05/18/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Le Nguyen Bao', '1205', 'So Dien Thoai', 'So Dien Thoai', '0905048501', '05/19/2023', '300000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Le Nguyen Bao', '1205', 'So Dien Thoai', 'So Dien Thoai', '0844348877', '05/19/2023', '500000', '')

INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Hoang Mai Hieu', '1', 'So Dien Thoai', 'So Dien Thoai', '0375969227', '05/17/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Hoang Mai Hieu', '1', 'So Dien Thoai', 'So Dien Thoai', '0918512871', '05/18/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Hoang Mai Hieu', '1', 'So Dien Thoai', 'So Dien Thoai', '0905048501', '05/19/2023', '300000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Hoang Mai Hieu', '1', 'So Dien Thoai', 'So Dien Thoai', '0844348877', '05/19/2023', '500000', '')

INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Tran Thanh Hieu', '3', 'So Dien Thoai', 'So Dien Thoai', '0375969227', '05/17/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Tran Thanh Hieu', '3', 'So Dien Thoai', 'So Dien Thoai', '0918512871', '05/18/2023', '1000000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Tran Thanh Hieu', '3', 'So Dien Thoai', 'So Dien Thoai', '0905048501', '05/19/2023', '300000', '')
INSERT INTO hr.LichSuGiaoDich(LoaiGD, NganHangGui, TenTKGui, SoTKGui, NganHangNhan, TenTKNhan, SoTKNhan, ThoiGian,  SoTien, LoiNhan) VALUES ('Nap Tien Dien Thoai', 'HHB', 'Tran Thanh Hieu', '3', 'So Dien Thoai', 'So Dien Thoai', '0844348877', '05/19/2023', '500000', '')

INSERT hr.LichSuGiaoDich VALUES ('Tin Dung', 'HHB',	'Hoang Mai Hieu', '1', 'TinDung', 'Hoang Mai Hieu', '12345', '2023-5-20', 10000000,	'Thanh toan tien tinh dung')
INSERT hr.LichSuGiaoDich VALUES ('Tin Dung', 'HHB',	'Hieu Mai Hoang', '2', 'TinDung', 'Hieu Mai Hoang', '12345345', '2023-5-19', 15000000,	'Thanh toan tien tinh dung')
INSERT hr.LichSuGiaoDich VALUES ('Tin Dung', 'HHB',	'Le Nguyen Bao', '1205', 'TinDung', 'Le Nguyen Bao', '123345', '2023-5-18', 13000000,	'Thanh toan tien tinh dung')
INSERT hr.LichSuGiaoDich VALUES ('Tin Dung', 'HHB',	'Le Nguyen Nun', '1222', 'TinDung', 'Le Nguyen Nun', '167845', '2023-5-17', 19000000,	'Thanh toan tien tinh dung')
INSERT hr.LichSuGiaoDich VALUES ('Tin Dung', 'HHB',	'Tran Thanh Hieu', '3', 'TinDung', 'Tran Thanh Hieu', '112335', '2023-5-16', 11000000,	'Thanh toan tien tinh dung')
INSERT hr.LichSuGiaoDich VALUES ('Tin Dung', 'HHB',	'Hoang Mai Hieu', '1', 'TinDung', 'Hoang Mai Hieu', '12345', '2023-5-21', 10000000,	'Thanh toan tien tinh dung')
INSERT hr.LichSuGiaoDich VALUES ('Tin Dung', 'HHB',	'Hieu Mai Hoang', '2', 'TinDung', 'Hieu Mai Hoang', '12345345', '2023-5-22', 15000000,	'Thanh toan tien tinh dung')
INSERT hr.LichSuGiaoDich VALUES ('Tin Dung', 'HHB',	'Le Nguyen Bao', '1205', 'TinDung', 'Le Nguyen Bao', '123345', '2023-5-23', 13000000,	'Thanh toan tien tinh dung')
INSERT hr.LichSuGiaoDich VALUES ('Tin Dung', 'HHB',	'Le Nguyen Nun', '1222', 'TinDung', 'Le Nguyen Nun', '167845', '2023-5-24', 19000000,	'Thanh toan tien tinh dung')
INSERT hr.LichSuGiaoDich VALUES ('Tin Dung', 'HHB',	'Tran Thanh Hieu', '3', 'TinDung', 'Tran Thanh Hieu', '112335', '2023-5-25', 11000000,	'Thanh toan tien tinh dung')

INSERT hr.LichSuGiaoDich 
VALUES ('Thanh Toan Khoan Vay', 'HHB',	'Hoang Mai Hieu', '1', 'HHB', '', '', '2023-5-14', 1000000, 'Thanh toan khoan vay')
INSERT hr.LichSuGiaoDich 
VALUES ('Thanh Toan Khoan Vay', 'HHB',	'Hoang Mai Hieu', '1', 'HHB', '', '', '2023-5-15', 3000000, 'Thanh toan khoan vay')
INSERT hr.LichSuGiaoDich 
VALUES ('Thanh Toan Khoan Vay', 'HHB',	'Hoang Mai Hieu', '1', 'HHB', '', '', '2023-5-16', 300000, 'Thanh toan khoan vay')
INSERT hr.LichSuGiaoDich 
VALUES ('Thanh Toan Khoan Vay', 'HHB',	'Hoang Mai Hieu', '1', 'HHB', '', '', '2023-5-17', 200000, 'Thanh toan khoan vay')
INSERT hr.LichSuGiaoDich 
VALUES ('Thanh Toan Khoan Vay', 'HHB',	'Hoang Mai Hieu', '1', 'HHB', '', '', '2023-5-18', 10000000, 'Thanh toan khoan vay')
INSERT hr.LichSuGiaoDich 
VALUES ('Thanh Toan Khoan Vay', 'HHB',	'Hoang Mai Hieu', '1', 'HHB', '', '', '2023-5-19', 9000000, 'Thanh toan khoan vay')
INSERT hr.LichSuGiaoDich 
VALUES ('Thanh Toan Khoan Vay', 'HHB',	'Hoang Mai Hieu', '1', 'HHB', '', '', '2023-5-20', 10000000, 'Thanh toan khoan vay')
INSERT hr.LichSuGiaoDich 
VALUES ('Thanh Toan Khoan Vay', 'HHB',	'Hoang Mai Hieu', '1', 'HHB', '', '', '2023-5-21', 10000000, 'Thanh toan khoan vay')
INSERT hr.LichSuGiaoDich 
VALUES ('Thanh Toan Toan Bo Khoan Vay', 'HHB',	'Hoang Mai Hieu', '1', 'HHB', '', '', '2023-5-15', 10000000, 'Thanh toan khoan vay')
INSERT hr.LichSuGiaoDich 
VALUES ('Thanh Toan Toan Bo Khoan Vay', 'HHB',	'Hoang Mai Hieu', '1', 'HHB', '', '', '2023-5-16', 1000000, 'Thanh toan khoan vay')


CREATE TABLE [dbo].[TaiKhoanTietKiem] (
    [TenNH]      VARCHAR (50) NOT NULL,
    [SoTK]       VARCHAR (10) NOT NULL,
    [MaTietKiem] INT		  NOT NULL,
    [NgayDangKy] DATE         NOT NULL,
    [TenTKTK]    VARCHAR (50) NOT NULL,
    [LoaiSo]     INT          NOT NULL,
    [TienGoc]    DECIMAL		  NULL,
    [KiHan]      INT          NULL,
    [LaiSuat]    REAL       NULL,
    [TienLai]    DECIMAL	  NULL,
    [TongTien]   DECIMAL	  NULL,
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
    [HanMuc]         DECIMAL        NULL,
    [LaiSuat]        VARCHAR (10)  NULL,
    [SoTienDaSuDung] DECIMAL       NULL,
    [SoTienSuDungSau] DECIMAL      NULL,
    [NgayMoThe]      DATE          NULL,
    [PhiTraCham]     DECIMAL       NULL,
    [PhiPhat]        DECIMAL      NULL,
    PRIMARY KEY CLUSTERED ([SoTKTinDung] ASC)
);

CREATE TABLE [dbo].[SoDienThoai] (
    [SDT]  VARCHAR (11) PRIMARY KEY,
    [SoDu] DECIMAL  NOT NULL
);

INSERT INTO SoDienThoai(SDT, SoDu) VALUES ('0375969227', 50000)
INSERT INTO SoDienThoai(SDT, SoDu) VALUES ('0918512871', 50000)
INSERT INTO SoDienThoai(SDT, SoDu) VALUES ('0905048501', 50000)
INSERT INTO SoDienThoai(SDT, SoDu) VALUES ('0844348877', 50000)
INSERT INTO SoDienThoai(SDT, SoDu) VALUES ('0375969228', 50000)
INSERT INTO SoDienThoai(SDT, SoDu) VALUES ('0918512872', 50000)
INSERT INTO SoDienThoai(SDT, SoDu) VALUES ('0905048502', 50000)
INSERT INTO SoDienThoai(SDT, SoDu) VALUES ('0844348878', 50000)

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
SoTienVay DECIMAL,
ThoiGianVay int,
TaiSanTheChap varchar(255),
GiaTriTaiSan DECIMAL,
ChiNhanhVay varchar(255),
NgayVay Date,
LaiSuat varchar(10),
SoTienHangThang DECIMAL,
NgayDenHan Date,
TongSoTienPhaiTra DECIMAL,
PhiTraCham DECIMAL,
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
SoTienVay DECIMAL,
ThoiGianVay int,
ChiNhanhVay varchar(255),
NgayVay Date,
LaiSuat varchar(10),
SoTienHangThang DECIMAL,
NgayDenHan Date,
TongSoTienPhaiTra DECIMAL,
PhiTraCham DECIMAL
)

