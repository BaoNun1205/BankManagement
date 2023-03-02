CREATE TABLE KhachHang(
SoTK varchar(255),
TenTK varchar(255),
TenDN varchar(255),
MatKhau varchar(255),
NgaySinh varchar(255),
CCCD varchar(255),
SDT varchar(255)
CONSTRAINT KhachHang_PK PRIMARY KEY (SoTK)
);
INSERT INTO KhachHang(SoTK, TenTK, TenDN, MatKhau, NgaySinh, CCCD, SDT)
VALUES('1', 'Hoang Mai Hieu', 'hieu1', '12345678', '04/01/2003', '100001', '0905068123')
INSERT INTO KhachHang(SoTK, TenTK, TenDN, MatKhau, NgaySinh, CCCD, SDT)
VALUES('2', 'Hoang Mai Hieu', 'hieu2', '12345678', '04/01/2003', '100001', '0905068123')
select *from KhachHang
