-- Môn: SOF205 - Dự án mẫu
-- Người thực hiện: Nguyễn Ngọc Chiến
-- Ngày thực hiện: 17/09/2023

-- Câu lệnh tạo kích hoạt tự động (TRIGGER)

-- Bảng Nhân Viên

USE QuanLyBanHang
GO

-- 1. Xóa nhân viên và các cột khóa ngoại tham chiếu đến bảng nhân viên
CREATE OR ALTER TRIGGER XoaNhanVienVaKhoaNgoai
ON tblNhanVien
INSTEAD OF DELETE
AS
BEGIN
	UPDATE tblHang SET MaNV = NULL WHERE MaNV IN (SELECT deleted.MaNV FROM deleted)

	UPDATE tblKhachHang SET MaNV = NULL WHERE MaNV IN (SELECT deleted.MaNV FROM deleted)

	DELETE FROM tblNhanVien WHERE MaNV IN (SELECT deleted.MaNV FROM deleted)
END
GO
