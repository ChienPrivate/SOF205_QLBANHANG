-- Môn: Dự án mẫu
-- Người thực hiện: Nguyễn Ngọc Chiến
-- Ngày thực hiện 17/09/2023

-- Câu lệnh tạo Database
USE master
GO

CREATE DATABASE QuanLyBanHang
GO

USE QuanLyBanHang
GO

-- Câu lệnh tạo bảng

-- bảng nhân viên (tblNhanVien)
CREATE TABLE tblNhanVien(
	Id INT IDENTITY(1,1),
	MaNV VARCHAR(20) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	TenNV NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	VaiTro TINYINT NOT NULL,
	TinhTrang TINYINT NOT NULL,
	MatKhau VARBINARY(64) DEFAULT HASHBYTES('MD5','abc123')
	CONSTRAINT PK_tblNhanVien PRIMARY KEY (MaNV)
)
GO

-- bảng sản phẩm (tblHang)
CREATE TABLE tblHang(
	MaHang VARCHAR(20) NOT NULL,
	TenHang NVARCHAR(50) NOT NULL,
	SoLuong INT NOT NULL,
	DonGiaBan FLOAT NOT NULL,
	DonGiaNhap FLOAT NOT NULL,
	HinhAnh VARCHAR(400),
	GhiChu NVARCHAR(100),
	MaNV VARCHAR(20),
	CONSTRAINT PK_tblHang PRIMARY KEY (MaHang),
	CONSTRAINT FK_tblHang_tblNhanVien FOREIGN KEY (MaNV) REFERENCES tblNhanVien
)
GO

-- bảng khách hàng (tblKhachHang)
CREATE TABLE tblKhachHang(
	DienThoai VARCHAR(15) NOT NULL,
	TenKhachHang NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL,
	Phai NVARCHAR(5) NOT NULL,
	MaNV VARCHAR(20),
	CONSTRAINT PK_tblKhachHang PRIMARY KEY (DienThoai),
	CONSTRAINT FK_tblKhachHang_Hang FOREIGN KEY (MaNV) REFERENCES tblNhanVien
)
GO