-- Môn: SOF205 - Dự án mẫu
-- Người thực hiện: Nguyễn Ngọc Chiến
-- Ngày thực hiện: 17/09/2023

-- Câu lệnh tạo thủ tục lưu trữ (Stored Procedure)

-- 1. Bảng nhân viên (tblNhanVien) 

-- 1.1 Tính năng đăng nhập
USE QuanLyBanHang
GO

CREATE OR ALTER PROC DangNhap (@email VARCHAR(50), @matkhau VARBINARY(64))
AS
BEGIN
	IF EXISTS ( SELECT 1 FROM tblNhanVien WHERE Email = @email AND @matkhau = MatKhau)
	BEGIN
		RETURN 1
	END
	ELSE
	BEGIN
		RETURN 0
	END
END
GO

-- 1.2 Tính năng quên mật khẩu
CREATE OR ALTER PROC QuenMatKhau 
	(@email VARCHAR(50),
	@matkhaumoi VARCHAR(50), 
	@result NVARCHAR(50) OUTPUT)
AS
BEGIN
	IF EXISTS (SELECT Email FROM tblNhanVien WHERE @email = Email)
		BEGIN
			DECLARE @matkhaumd5 VARBINARY(64) = CAST(@matkhaumoi AS VARBINARY(64))
			UPDATE tblNhanVien
			SET MatKhau = HASHBYTES('MD5',@matkhaumd5)
			WHERE Email = @email
			SET @result = @email
		END
	ELSE
		BEGIN
			SET @result = N'Email Chưa được đăng ký'
			RETURN
		END
END
GO

-- 1.3 Chức năng đổi mật khẩu
CREATE OR ALTER PROC DoiMatKhau 
	(@email VARCHAR(50),
	@matkhaucu VARCHAR(50),
	@matkhaumoi VARCHAR(50))
AS
BEGIN
	DECLARE @matkhaucumd5 VARBINARY(64) = CAST(@matkhaucu AS VARBINARY(64))
	DECLARE @matkhaumoimd5 VARBINARY(64) = CAST(@matkhaumoi AS varbinary(64))
	IF EXISTS (SELECT 1 FROM tblNhanVien WHERE Email = @email)
		BEGIN
			UPDATE tblNhanVien
			SET MatKhau = HASHBYTES('MD5', @matkhaumoimd5)
			WHERE Email = @email AND MatKhau = HASHBYTES('MD5', @matkhaucumd5)
		END
END
GO


--1.4 Chức năng lấy danh sách nhân viên
CREATE OR ALTER PROC DanhSachNhanVien
AS
BEGIN
	SELECT * FROM tblNhanVien
END
GO

--1.5 Chức năng lấy vai trò nhân viên
CREATE OR ALTER PROC VaiTroNhanVien (@email VARCHAR(50))
AS
BEGIN
	DECLARE @result INT
	SET @result = (SELECT VaiTro FROM tblNhanVien WHERE Email = @email)
	SELECT @result
END
GO

--1.6 chức năng lấy tình trạng nhân viên
CREATE OR ALTER PROC TinhTrangNhanVien (@email VARCHAR(50))
AS
BEGIN
	DECLARE @result INT
	SET @result = (SELECT TinhTrang FROM tblNhanVien WHERE Email = @email )
	SELECT @result
END
GO

-- 1.7 chức năng Thêm nhân viên
CREATE OR ALTER PROC ThemNhanVien 
	(@manv VARCHAR(20),
	@email VARCHAR(50), 
	@tennv NVARCHAR(50), 
	@diachi NVARCHAR(100), 
	@vaitro INT,
	@tinhtrang INT)
AS
BEGIN
	DECLARE @thongbao NVARCHAR(50)
	IF EXISTS (SELECT 1 FROM tblNhanVien WHERE Email = @email)
	BEGIN
		SET @thongbao = N'Thêm Không thành công, Email đã tồn tại'
		SELECT @thongbao
		RETURN
	END
	ELSE
	BEGIN
		INSERT INTO tblNhanVien (MaNV, Email, TenNV, DiaChi, VaiTro, TinhTrang)
			VALUES
				(@manv, @email, @tennv, @diachi, @vaitro, @tinhtrang)
		SET @thongbao = N'Thêm nhân viên thành công'
		SELECT @thongbao
	END
END
GO

-- 1.8 chức năng xóa nhân viên
CREATE OR ALTER PROC XoaNhanVien (@email VARCHAR(50))
AS
BEGIN
	DECLARE @thongbao NVARCHAR(50)
	IF EXISTS (SELECT 1 FROM tblNhanVien WHERE @email = Email)
		BEGIN
			DELETE FROM tblNhanVien
			WHERE Email = @email
			SET @thongbao = N'Xóa thành công'
			SELECT @thongbao
		END
	ELSE
		BEGIN
			SET @thongbao = N'Xóa không thành công, không có nhân viên này'
			SELECT @thongbao
			RETURN
		END
END
GO

--1.9 chức năng cập nhật nhân viên
CREATE OR ALTER PROC CapNhatNhanVien
	(@email VARCHAR(50), 
	@tennv NVARCHAR(50), 
	@diachi NVARCHAR(100), 
	@vaitro INT,
	@tinhtrang INT)
AS
BEGIN
	DECLARE @thongbao NVARCHAR(50)
	IF EXISTS (SELECT 1 FROM tblNhanVien WHERE @email = Email)
		BEGIN
			UPDATE tblNhanVien
			SET TenNV = @tennv,
				DiaChi = @diachi,
				VaiTro = @vaitro,
				TinhTrang = @tinhtrang
			WHERE Email = @email
			SET @thongbao = N'Cập nhật thành công'
			SELECT @thongbao
		END
	ELSE
		BEGIN
			SET @thongbao = N'Không thể cập nhật, nhân viên không tồn tại'
			SELECT @thongbao
		END
END
GO

-- 1.10 chức năng tìm kiếm nhân viên
CREATE OR ALTER PROC TimKiemNhanVien (@tennv NVARCHAR(50))
AS
BEGIN
	SELECT * 
	FROM tblNhanVien
	WHERE TenNV LIKE '%' + @tennv + '%'
END
GO

-- 2. Bảng Sản Phẩm (tblHang)

-- 2.1 chức năng thêm sản phẩm
CREATE OR ALTER PROC ThemSanPham 
	(@mahang VARCHAR(20),
	@tenhang NVARCHAR(50),
	@soluong INT,
	@dgb FLOAT,
	@dgn FLOAT,
	@hinhanh VARCHAR(400),
	@ghichu NVARCHAR(100),
	@manv VARCHAR(20))
AS
BEGIN
	INSERT INTO tblHang (MaHang, TenHang, SoLuong, DonGiaBan, DonGiaNhap,HinhAnh, GhiChu, MaNV)
		VALUES
			(@mahang, @tenhang, @soluong, @dgb, @dgn, @hinhanh, @ghichu, @manv)
END
GO

-- 2.2 chức năng xóa sản phẩm
CREATE OR ALTER PROC XoaSanPham
	(@masp VARCHAR(20))
AS
BEGIN
	DELETE FROM tblHang
	WHERE MaHang = @masp
END
GO

-- 2.3 chức năng cập nhật sản phẩm
CREATE OR ALTER PROC CapNhatSanPham
	(@mahang VARCHAR(20),
	@tenhang NVARCHAR(50),
	@soluong INT,
	@dgb FLOAT,
	@dgn FLOAT,
	@hinhanh VARCHAR(400),
	@ghichu NVARCHAR(100),
	@manv VARCHAR(20))
AS
BEGIN
	UPDATE tblHang
	SET TenHang = @tenhang,
		SoLuong = @soluong,
		DonGiaBan = @dgb,
		DonGiaNhap = @dgn,
		HinhAnh = @hinhanh,
		GhiChu = @ghichu,
		MaNV = @manv
	WHERE MaHang = @mahang
END
GO

-- 2.4 chức năng tìm kiếm sản phẩm
CREATE OR ALTER PROC TimKiemSanPham
	(@tensp NVARCHAR(50))
AS
BEGIN
	SELECT *
	FROM tblHang
	WHERE TenHang LIKE '%' + @tensp + '%'
END
GO

-- 3. Bảng Khách hàng (tblKhachHang)

-- 3.1 chức năng thêm khách hàng
CREATE OR ALTER PROC ThemKhachHang 
	(@dienthoai VARCHAR(15),
	@tenkhachhang NVARCHAR(50),
	@diachi NVARCHAR(50),
	@phai NVARCHAR(5),
	@manv VARCHAR(20))
AS
BEGIN
	DECLARE @result NVARCHAR(50)
	IF EXISTS (SELECT 1 FROM tblKhachHang WHERE DienThoai = @dienthoai)
		BEGIN
			SET @result = N'Số điện thoại đã được đăng ký, xin hãy kiểm tra lại'
			SELECT @result
			RETURN
		END
	ELSE
		BEGIN
			INSERT INTO tblKhachHang (DienThoai, TenKhachHang, DiaChi, Phai, MaNV)
				VALUES
					(@dienthoai, @tenkhachhang, @diachi, @phai, @manv)
			SET @result = N'Thêm khách hàng thành công'
			SELECT @result
		END
END
GO

-- 3.2 chức năng xóa khách hàng
CREATE OR ALTER PROC XoaKhachHang 
	(@dienthoai VARCHAR(15))
AS
BEGIN
	DECLARE @result NVARCHAR(50)
	IF NOT EXISTS (SELECT 1 FROM tblKhachHang WHERE DienThoai = @dienthoai)
		BEGIN
			SET @result = N'khách hàng này chưa được đăng ký'
			SELECT @result
			RETURN
		END
	ELSE
		BEGIN
			DELETE FROM tblKhachHang 
			WHERE DienThoai = @dienthoai
			SET @result = N'xóa khách hàng thành công'
			SELECT @result
		END
END
GO

-- 3.3 chức năng cập nhật khách hàng
CREATE OR ALTER PROC CapNhatKhachHang
	(@dienthoai VARCHAR(15),
	@tenkhachhang NVARCHAR(50),
	@diachi NVARCHAR(50),
	@phai NVARCHAR(5),
	@manv VARCHAR(20))
AS
BEGIN
	DECLARE @result NVARCHAR(50)
	IF NOT EXISTS (SELECT 1 FROM tblKhachHang WHERE DienThoai = @dienthoai)
		BEGIN
			SET @result = N'Khách hàng này không có trong danh sách'
			SELECT @result
			RETURN
		END
	ELSE
		BEGIN
			SET @result = N'Cập nhật khách hàng thành công'
			UPDATE tblKhachHang
			SET TenKhachHang = @tenkhachhang,
				DiaChi = @diachi,
				Phai = @phai,
				MaNV = @manv
			WHERE DienThoai = @dienthoai
			SELECT @result
		END
END
GO

-- 3.4 chức năng tìm kiếm khách hàng
CREATE OR ALTER PROC TimKiemKhachHang (@tenkhachhang NVARCHAR(50))
AS
BEGIN
	SELECT * FROM tblKhachHang WHERE TenKhachHang LIKE '%' + @tenkhachhang + '%'
END
GO

-- 4. Bảng thống kê (DashBoard)

-- 4.1 Tính tổng số lượng hàng tồn kho
CREATE OR ALTER PROC TongTonKho
AS
BEGIN
	SELECT SUM(SoLuong)
	FROM tblHang
END
GO

-- 4.2 Tính tổng tiền hàng
CREATE OR ALTER PROC TongTienHang
AS
BEGIN
	SELECT SUM(DonGiaNhap)
	FROM tblHang
END
GO

-- 4.3 Đếm số lượng khách hàng
CREATE OR ALTER PROC SoLuongKhachHang
AS
BEGIN
	SELECT COUNT(*)
	FROM tblKhachHang
END
GO

-- 4.4 Thống kê sản phẩm nhập kho theo từng nhân viên
CREATE OR ALTER PROC SanPhamNhapKho
AS
BEGIN
	SELECT NV.MaNV [Mã Nhân Viên], NV.TenNV [Tên Nhân Viên], SUM(H.SoLuong) [Số Lượng Sản Phẩm Nhập]
	FROM tblHang H JOIN tblNhanVien NV 
	ON H.MaNV = NV.MaNV
	GROUP BY NV.MaNV, NV.TenNV
END
GO

-- 4.5 Thống kê số lượng sản phẩm tồn kho
CREATE OR ALTER PROC TonKho
AS
BEGIN
	SELECT TenHang, SoLuong
	FROM tblHang
END
GO

-- 4.6 Thống kê top 5 sản phẩm có số lượng nhiều nhất
CREATE OR ALTER PROC Top5SanPham
AS
BEGIN
	SELECT TOP 5 WITH TIES TenHang, SoLuong 
	FROM tblHang
	ORDER BY SoLuong DESC
END
GO