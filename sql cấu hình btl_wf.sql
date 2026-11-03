CREATE DATABASE QuanLySachWF;
GO
USE QuanLySachWF;

CREATE TABLE Sach (
    MaSach NVARCHAR(10) PRIMARY KEY,
    TenSach NVARCHAR(100),
    TacGia NVARCHAR(50),
    TheLoai NVARCHAR(50),
    NhaXuatBan NVARCHAR(50),
    NamXuatBan INT,
    GiaNhap INT,
    GiaBan INT,
    SoLuongTon INT
);
INSERT INTO Sach VALUES
(N'S001', N'Dế Mèn phiêu lưu ký', N'Tô Hoài', N'Văn học', N'Kim Đồng', 2020, 45000, 60000, 25),
(N'S002', N'Lão Hạc', N'Nam Cao', N'Văn học', N'Văn Học', 2019, 25000, 35000, 18);

select * from sach;
CREATE TABLE NguoiDung(
    Ma NVARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    TenDN NVARCHAR(50) UNIQUE,
    MatKhau NVARCHAR(100),
    VaiTro NVARCHAR(30),
    TrangThai NVARCHAR(30)
);
INSERT INTO NguoiDung VALUES
(N'ND001', N'Nguyễn Văn An', 'admin', '123456', N'Quản trị viên', N'Đang hoạt động'),
(N'ND002', N'Trần Thị Lan', 'lan', '123456', N'Nhân viên', N'Đang hoạt động');
select * from nguoidung;
CREATE TABLE VaiTro(
    MaVaiTro NVARCHAR(10) PRIMARY KEY,
    TenVaiTro NVARCHAR(30) NOT NULL,
    MoTa NVARCHAR(100)
);
INSERT INTO VaiTro VALUES
(N'VT01', N'Quản trị viên', N'Toàn quyền hệ thống'),
(N'VT02', N'Nhân viên', N'Bán hàng, nhập kho');

CREATE TABLE TrangThai(
    MaTrangThai NVARCHAR(10) PRIMARY KEY,
    TenTrangThai NVARCHAR(30) NOT NULL,
    MoTa NVARCHAR(100)
);
INSERT INTO TrangThai VALUES
(N'TT01', N'Đang hoạt động', N'Được phép đăng nhập'),
(N'TT02', N'Đã khóa', N'Không được đăng nhập');
select tendn, matkhau from nguoidung;
CREATE TABLE DanhMuc(
    MaDM  NVARCHAR(10)  PRIMARY KEY,
    TenDM NVARCHAR(100) NOT NULL UNIQUE,
    MoTa  NVARCHAR(255)
);

INSERT INTO DanhMuc VALUES
(N'DM001', N'Văn học',     N'Các tác phẩm văn học trong và ngoài nước'),
(N'DM002', N'Giáo khoa',   N'Sách giáo khoa và tài liệu học tập'),
(N'DM003', N'Thiếu nhi',   N'Sách dành cho trẻ em'),
(N'DM004', N'Kỹ năng sống', N'Sách phát triển kỹ năng cá nhân');

select * from danhmuc;
-- xoa bang ở master
USE master;
GO
DROP TABLE IF EXISTS DanhMuc;


DROP TABLE IF EXISTS DanhMuc;
GO
CREATE TABLE DanhMuc(
    MaDM  NVARCHAR(10)  PRIMARY KEY,
    TenDM NVARCHAR(100) NOT NULL UNIQUE,
    MoTa  NVARCHAR(255)
);
GO
INSERT INTO DanhMuc VALUES
(N'DM001', N'Văn học',      N'Các tác phẩm văn học trong và ngoài nước'),
(N'DM002', N'Giáo khoa',    N'Sách giáo khoa và tài liệu học tập'),
(N'DM003', N'Thiếu nhi',    N'Sách dành cho trẻ em'),
(N'DM004', N'Kỹ năng sống', N'Sách phát triển kỹ năng cá nhân');
GO
SELECT * FROM DanhMuc;
CREATE TABLE NhanVien(
    MaNV        NVARCHAR(10)  PRIMARY KEY,
    HoTen       NVARCHAR(100) NOT NULL,
    NgaySinh    DATE,
    GioiTinh    NVARCHAR(5),
    SoDienThoai NVARCHAR(15),
    Email       NVARCHAR(100),
    ChucVu      NVARCHAR(50),
    DiaChi      NVARCHAR(255)
);
GO

INSERT INTO NhanVien VALUES
(N'NV001', N'Nguyễn Văn An', '2000-05-15', N'Nam', N'0901234567', N'an@example.com',   N'Nhân viên bán hàng', N'Hà Nội'),
(N'NV002', N'Trần Thị Lan',  '2001-08-20', N'Nữ',  N'0902345678', N'lan@example.com',  N'Thủ kho',            N'Hà Nội'),
(N'NV003', N'Lê Minh',       '1998-03-10', N'Nam', N'0903456789', N'minh@example.com', N'Quản lý',            N'Hà Nội');
GO

SELECT * FROM NhanVien;