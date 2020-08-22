USE master

GO

CREATE DATABASE DaiLyXeMayDien

GO

USE DaiLyXeMayDien

GO

-- Bảng tài khoản đăng nhập
CREATE TABLE AccountLogin
(
	UserName				NVARCHAR(50)	PRIMARY KEY,
	PassWord				NVARCHAR(50)	NOT NULL,
	LoaiTaiKhoan			INT				NOT NULL,  -- 1 là chủ | 0 : nhân viên
	TenHienThi				NVARCHAR(50)	NOT NULL,
	DienThoai				NVARCHAR(15)	NOT NULL,
	Email					NVARCHAR(100)	NOT NULL
)

GO
-- Bảng mặt hàng
CREATE TABLE MatHang
(						
	MaHang					NVARCHAR(20)	NOT NULL,		
	TenHang					NVARCHAR(50)	NOT NULL,		
	NhaSanXuat				NVARCHAR(50)	NOT NULL,		
	MoTa					NVARCHAR(100)	NULL,
	ThongTinBaoHanh			NVARCHAR(100)	NULL,	
	SoLuong					INT				NOT NULL,	
	DonViTinh				NVARCHAR(20)	NULL,
	GiaBan					INT				NOT NULL,
	AnhMinhHoa				NVARCHAR(500)	NOT NULL,		
	CONSTRAINT		pk_MatHang PRIMARY KEY(MaHang)
)

GO
-- Bảng nhân viên
CREATE TABLE NhanVien
(
	MaNhanVien				NVARCHAR(20)	NOT NULL,
	TenNhanVien				NVARCHAR(50)	NOT NULL,
	NamSinh					INT				NOT NULL,
	GioiTinh				NVARCHAR(10)	NOT NULL,
	DienThoai				NVARCHAR(15)	NULL,
	DiaChi					NVARCHAR(50)	NOT NULL,
	ChucVu					NVARCHAR(30)	NOT NULL,
	Luong					INT				NULL,
	CONSTRAINT		pk_NhanVien PRIMARY KEY(MaNhanVien)
)

GO
-- Bảng khách hàng
CREATE TABLE KhachHang
(
	MaKhachHang				NVARCHAR(20)	NOT NULL,
	TenKhachHang			NVARCHAR(50)	NOT NULL,
	DiaChi					NVARCHAR(50)	NOT NULL,
	DienThoai				NVARCHAR(15)	NULL,
	Email					NVARCHAR(100)	NULL,
	CONSTRAINT		pk_KhachHang PRIMARY KEY(MaKhachHang)
)
GO
-- Bảng nhà cung cấp
CREATE TABLE NhaCungCap
(
	MaNhaCungCap			NVARCHAR(20)	NOT NULL,
	TenNhaCungCap			NVARCHAR(50)	NOT NULL,
	DiaChi					NVARCHAR(50)	NOT NULL,
	DienThoai				NVARCHAR(15)	NULL,
	Email					NVARCHAR(100)	NULL,
	CONSTRAINT		pk_NhaCungCap PRIMARY KEY(MaNhaCungCap)
)

GO
--Bảng phiếu nhập
CREATE TABLE PhieuNhap
(
	MaPhieuNhap				NVARCHAR(20)	NOT NULL,
	MaNhanVien				NVARCHAR(20)	NOT NULL,
	MaNhaCungCap			NVARCHAR(20)	NOT NULL,
	NgayNhap				DATETIME		NOT NULL,
	CONSTRAINT		pk_PNhap	  PRIMARY KEY(MaPhieuNhap),
	CONSTRAINT		fk_PNhap_NhaCungCap   FOREIGN KEY(MaNhaCungCap)	  REFERENCES dbo.NhaCungCap(MaNhaCungCap),
	CONSTRAINT		fk_PNhap_NhanVien   FOREIGN KEY(MaNhanVien)	  REFERENCES dbo.NhanVien(MaNhanVien)
)

GO
--Bảng chi tiết phiếu nhập
CREATE TABLE ChiTietPhieuNhap
(
	MaPhieuNhap				NVARCHAR(20)	NOT NULL,
	MaHang					NVARCHAR(20)	NOT NULL,
	SoLuongNhap				INT				NOT NULL,
	DonGiaNhap				FLOAT			NOT NULL,
	Thue					FLOAT			NULL,
	CONSTRAINT		pk_CTPNhap		     PRIMARY KEY(MaPhieuNhap,MaHang),
	CONSTRAINT		fk_CTPNhap_MatHang   FOREIGN KEY(MaHang)	      REFERENCES dbo.MatHang(MaHang),
	CONSTRAINT		fk_CTPNhap_PNhap     FOREIGN KEY(MaPhieuNhap)	  REFERENCES dbo.PhieuNhap(MaPhieuNhap)
)

GO
--Bảng phiếu xuất
CREATE TABLE PhieuXuat
(
	MaPhieuXuat				NVARCHAR(20)	NOT NULL,
	MaNhanVien				NVARCHAR(20)	NOT NULL,
	MaKhachHang				NVARCHAR(20)	NOT NULL,
	NgayXuat				DATETIME		NOT NULL,
	CONSTRAINT		pk_PXuat	  PRIMARY KEY(MaPhieuXuat),
	CONSTRAINT		fk_PXuat_KhachHang   FOREIGN KEY(MaKhachHang)  REFERENCES dbo.KhachHang(MaKhachHang),
	CONSTRAINT		fk_PXuat_NhanVien   FOREIGN KEY(MaNhanVien)    REFERENCES dbo.NhanVien(MaNhanVien),
)

GO
--Bảng chi tiết phiếu xuất
CREATE TABLE ChiTietPhieuXuat
(
	MaPhieuXuat				NVARCHAR(20)	NOT NULL,
	MaHang					NVARCHAR(20)	NOT NULL,
	SoLuongXuat				INT				NOT NULL,
	DonGiaXuat				FLOAT			NOT NULL,
	Thue					FLOAT			NULL,
	CONSTRAINT		pk_CTPXuat		     PRIMARY KEY(MaPhieuXuat,MaHang),
	CONSTRAINT		fk_CTPXuat_MatHang	 FOREIGN KEY(MaHang)	      REFERENCES dbo.MatHang(MaHang),
	CONSTRAINT		fk_CTPXuat_PXuat     FOREIGN KEY(MaPhieuXuat)	  REFERENCES dbo.PhieuXuat(MaPhieuXuat)
)

GO
--Tạo một tai khoản admin mặc định cho app
	INSERT INTO dbo.AccountLogin
	VALUES ('admin', '1' , 1 , N'Admin', '0123456789','adminweloveanig@gmail.com')
GO
-- Các thủ tục cho bảng mặt hàng (thêm , sửa , xóa)

CREATE PROC USP_InsertMatHang 
@MaHang NVARCHAR(20), @TenHang NVARCHAR(50), @NhaSanXuat NVARCHAR(50), @Mota NVARCHAR(100), 
@ThongTinBaoHanh NVARCHAR(100),@SoLuong INT, @DonViTinh NVARCHAR(20), @GiaBan INT , @AnhMinhHoa NVARCHAR(500)
AS
BEGIN
	IF NOT EXISTS(SELECT MaHang FROM dbo.MatHang WHERE MaHang = @MaHang)
		INSERT INTO dbo.MatHang 
		VALUES(  @MaHang,@TenHang,@NhaSanXuat,@Mota,@ThongTinBaoHanh,@SoLuong,@DonViTinh,@GiaBan,@AnhMinhHoa)
	ELSE
		RAISERROR(N'Đã tồn tại mã hàng này',12,1)
END

GO

CREATE PROC USP_UpdateMatHang 
@MaHang NVARCHAR(20), @TenHang NVARCHAR(50), @NhaSanXuat NVARCHAR(50), @Mota NVARCHAR(100), 
@ThongTinBaoHanh NVARCHAR(100),@SoLuong INT, @DonViTinh NVARCHAR(20), @GiaBan INT, @AnhMinhHoa NVARCHAR(500)
AS
BEGIN
	IF NOT EXISTS(SELECT MaHang FROM dbo.MatHang WHERE MaHang = @MaHang)
		RAISERROR(N'Không tồn tại mã hàng này',12,1)
	ELSE
		UPDATE dbo.MatHang 
		SET TenHang = @TenHang, NhaSanXuat = @NhaSanXuat, Mota = @Mota, ThongTinBaoHanh = @ThongTinBaoHanh, 
		SoLuong = @SoLuong, DonViTinh =  @DonViTinh, GiaBan = @GiaBan , AnhMinhHoa = @AnhMinhHoa
		WHERE	MaHang = @MaHang
END

GO

CREATE PROC USP_DeleteMatHang 
@MaHang NVARCHAR(20)
AS
BEGIN
	IF NOT EXISTS(SELECT MaHang FROM dbo.MatHang WHERE MaHang = @MaHang)
		RAISERROR(N'Không tồn tại mã hàng này',12,1)
	ELSE
	BEGIN 
		DECLARE @Soluong INT = (SELECT SoLuong FROM dbo.MatHang WHERE MaHang = @MaHang)
		IF(@Soluong > 0)
			RAISERROR(N'Không thể xóa mã hàng này.',12,1)
		ELSE
			DELETE FROM dbo.MatHang WHERE MaHang = @MaHang
	END
END

GO
-- Các thủ tục cho bảng nhân viên (thêm , sửa , xóa)
CREATE PROC USP_InsertNhanVien 
@MaNhanVien	NVARCHAR(20), @TenNhanVien NVARCHAR(50), @NamSinh INT, @GioiTinh NVARCHAR(10),
@DienThoai	NVARCHAR(15), @DiaChi NVARCHAR(50), @ChucVu NVARCHAR(30), @Luong INT
AS
BEGIN
	IF (NOT EXISTS(SELECT MaNhanVien FROM dbo.NhanVien WHERE MaNhanVien = @MaNhanVien))
		INSERT INTO dbo.NhanVien 
		VALUES(@MaNhanVien, @TenNhanVien, @NamSinh, @GioiTinh, @DienThoai, @DiaChi, @ChucVu, @Luong )
	ELSE
		RAISERROR(N'Đã tồn tại mã nhân viên này.',12,1)
END

GO

CREATE PROC USP_UpdateNhanVien 
@MaNhanVien	NVARCHAR(20), @TenNhanVien NVARCHAR(50), @NamSinh INT, @GioiTinh NVARCHAR(10),
@DienThoai	NVARCHAR(15), @DiaChi NVARCHAR(50), @ChucVu NVARCHAR(30), @Luong INT
AS
BEGIN
	IF (NOT EXISTS(SELECT MaNhanVien FROM dbo.NhanVien WHERE MaNhanVien = @MaNhanVien))
		RAISERROR(N'Không có mã nhân viên này.',12,1)
	ELSE
		UPDATE dbo.NhanVien 
		SET TenNhanVien = @TenNhanVien, NamSinh = @NamSinh, GioiTinh= @GioiTinh,
		DienThoai = @DienThoai, DiaChi = @DiaChi, Luong = @Luong 
		WHERE MaNhanVien = @MaNhanVien
END

GO

CREATE PROC USP_DeleteNhanVien 
@MaNhanVien NVARCHAR(20)
AS
BEGIN
	IF (NOT EXISTS(SELECT MaNhanVien FROM dbo.NhanVien WHERE MaNhanVien = @MaNhanVien))
		RAISERROR(N'Không có mã nhân viên này hoặc đã nghỉ.',12,1)
	ELSE
		DELETE FROM dbo.NhanVien  WHERE MaNhanVien = @MaNhanVien
END
GO
-- Các thủ tục cho bảng Kháchh hàng (thêm , sửa , xóa)
CREATE PROC USP_InsertKhanhHang
@MaKhachHang NVARCHAR(20), @TenKhachHang NVARCHAR(50), @DiaChi NVARCHAR(50),@DienThoai NVARCHAR(15), @Email NVARCHAR(100)
AS
BEGIN
	IF(NOT EXISTS(SELECT MaKhachHang FROM dbo.KhachHang WHERE MaKhachHang = @MaKhachHang))
		INSERT INTO dbo.KhachHang 
		VALUES (@MaKhachHang, @TenKhachHang, @DiaChi, @DienThoai, @Email)
	ELSE
		RAISERROR(N'Khánh hàng này đã từng mua hàng ở đây.',12,1)
END 
GO

CREATE PROC USP_UpdateKhanhHang
@MaKhachHang NVARCHAR(20), @TenKhachHang NVARCHAR(50), @DiaChi NVARCHAR(50),@DienThoai NVARCHAR(15), @Email NVARCHAR(100)
AS
BEGIN
	IF(NOT EXISTS(SELECT MaKhachHang FROM dbo.KhachHang WHERE MaKhachHang = @MaKhachHang))
		RAISERROR(N'Không tồn tại khách hàng này.',12,1)
	ELSE
		UPDATE dbo.KhachHang 
		SET TenKhachHang = @TenKhachHang, DiaChi = @DiaChi , DienThoai = @DienThoai , Email = @Email 
		WHERE MaKhachHang = @MaKhachHang
END 

GO

CREATE PROC USP_DeleteKhanhHang
@MaKhachHang NVARCHAR(20)
AS
BEGIN
	IF(NOT EXISTS(SELECT MaKhachHang FROM dbo.KhachHang WHERE MaKhachHang = @MaKhachHang))
		RAISERROR(N'Không tồn tại khách hàng này.',12,1)
	ELSE
		DELETE FROM dbo.KhachHang WHERE MaKhachHang = @MaKhachHang
END 

GO
-- Các thủ tục cho bảng Nhà cung cấp
CREATE PROC USP_InsertNhaCC
@MaNhaCungCap NVARCHAR(20),@TenNhaCungCap NVARCHAR(50), 
@DiaChi	NVARCHAR(50), @DienThoai NVARCHAR(15), @Email NVARCHAR(100)
AS
BEGIN
	IF(NOT EXISTS(SELECT MaNhaCungCap FROM dbo.NhaCungCap WHERE MaNhaCungCap= @MaNhaCungCap))
		INSERT INTO dbo.NhaCungCap 
		VALUES (@MaNhaCungCap , @TenNhaCungCap  ,@DiaChi , @DienThoai , @Email)
	ELSE 
		RAISERROR(N'Đã tồn tại nhà cung cấp này.',12,1)
END

GO

CREATE PROC USP_UpdateNhaCC
@MaNhaCungCap NVARCHAR(20), @TenNhaCungCap NVARCHAR(50), 
@DiaChi	NVARCHAR(50), @DienThoai NVARCHAR(15), @Email NVARCHAR(100)
AS
BEGIN
	IF(NOT EXISTS(SELECT MaNhaCungCap FROM dbo.NhaCungCap WHERE MaNhaCungCap = @MaNhaCungCap))
		RAISERROR(N'Không tồn tại nhà cung cấp này.',12,1)
	ELSE
		UPDATE NHACUNGCAP 
		SET TenNhaCungCap = @TenNhaCungCap, DiaChi = @DiaChi, DienThoai = @DienThoai, Email = @Email 
		WHERE MaNhaCungCap = @MaNhaCungCap
END

GO

CREATE PROC USP_DeleteNhaCC
@MaNhaCungCap NVARCHAR(20)
AS
BEGIN
	IF NOT EXISTS(SELECT MaNhaCungCap FROM dbo.NhaCungCap WHERE MaNhaCungCap = @MaNhaCungCap)
		RAISERROR(N'Không tồn tại nhà cung cấp này.',12,1)
	ELSE
		DELETE FROM dbo.NhaCungCap  WHERE MaNhaCungCap = @MaNhaCungCap
END

GO
--Các thủ tục cho bảng Phiếu nhập
CREATE PROC USP_InsertPhieuNhap
@MaPhieuNhap NVARCHAR(20), @MaNhanVien NVARCHAR(20), @MaNhaCungCap NVARCHAR(20), @NgayNhap	DATETIME
AS 
BEGIN
	IF(EXISTS (SELECT MaPhieuNhap FROM dbo.PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap))
		RAISERROR(N'Đã tồn tại phiếu nhập này rồi.',12,1)
	IF(NOT EXISTS(SELECT MaNhanVien FROM dbo.NhanVien WHERE MaNhanVien = @MaNhanVien))
		RAISERROR(N'Không có mã nhân viên này.',12,1)
	IF(NOT EXISTS(SELECT MaNhaCungCap FROM dbo.NhaCungCap WHERE MaNhaCungCap = @MaNhaCungCap))
		RAISERROR(N'Chưa có thông tin về nhà cung cấp này.',12,1)
	ELSE
		IF(@NgayNhap>GETDATE()) 
			RAISERROR(N'Ngày nhập không phù hợp.',12,1)
	ELSE
		INSERT INTO dbo.PhieuNhap 
		VALUES (@MaPhieuNhap,@MaNhanVien,@MaNhaCungCap,@NgayNhap)
END

GO
	
CREATE PROC USP_UpdatePhieuNhap
@MaPhieuNhap NVARCHAR(20), @MaNhanVien NVARCHAR(20), @MaNhaCungCap NVARCHAR(20), @NgayNhap	DATETIME
AS
BEGIN
	IF(NOT EXISTS(SELECT MaPhieuNhap FROM dbo.PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap))
		RAISERROR(N'Không tồn tại mã phiếu nhập này.',12,1)
	ELSE
	BEGIN
		IF(@NgayNhap>GETDATE())
			RAISERROR(N'Sửa ngày nhập không phù hợp.',12,1)
		ELSE IF(NOT EXISTS(SELECT MaNhanVien FROM dbo.NhanVien WHERE MaNhanVien = @MaNhanVien))
			RAISERROR(N'Không tồn tại nhân viên này.',12,1)
		ELSE IF(NOT EXISTS(SELECT MaNhaCungCap FROM dbo.NhaCungCap WHERE MaNhaCungCap = @MaNhaCungCap))
			RAISERROR(N'Không tồn tại nhà cung cấp này.',12,1)
		ELSE 
			UPDATE dbo.PhieuNhap 
			SET MaNhanVien = @MaNhanVien, MaNhaCungCap = @MaNhaCungCap, NgayNhap = @NgayNhap 
			WHERE MaPhieuNhap=@MaPhieuNhap
	END
END

GO	

CREATE PROC USP_DeletePhieuNhap
( @MaPhieuNhap NVARCHAR(20) )
AS
BEGIN
	IF(NOT EXISTS(SELECT MaPhieuNhap FROM dbo.PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap))
		RAISERROR(N'Không tồn tại mã phiếu nhập này',12,1)
	ELSE 
		DELETE FROM dbo.PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap
END

GO
--Tạo các thủ tục cho bảng Phiếu Xuất
CREATE PROC USP_InsertPhieuXuat
@MaPhieuXuat NVARCHAR(20), @MaNhanVien NVARCHAR(20),@MaKhachHang NVARCHAR(20), @NgayXuat DATETIME
AS
BEGIN 
	IF(EXISTS (SELECT MaPhieuXuat FROM dbo.PhieuXuat WHERE MaPhieuXuat = @MaPhieuXuat))
		RAISERROR(N'Đã tồn tại mã phiếu xuất này.',12,1)
	IF(NOT EXISTS(SELECT MaNhanVien FROM dbo.NhanVien WHERE MaNhanVien = @MaNhanVien))
		RAISERROR(N'Không có mã nhân viên này.',12,1)
	IF(NOT EXISTS(SELECT MaKhachHang FROM dbo.KhachHang WHERE MaKhachHang = @MaKhachHang))
		RAISERROR(N'Chưa có thông tin về mã khách hàng này.',12,1)
	ELSE
	BEGIN 
		IF(@NgayXuat > GETDATE()) 
			RAISERROR(N'Ngày xuất hàng không phù hợp.',12,1)
		ELSE
			INSERT INTO dbo.PhieuXuat 
			VALUES (@MaPhieuXuat,@MaNhanVien,@MaKhachHang,@NgayXuat)
	END
END

GO

CREATE PROC USP_UpdatePhieuXuat
@MaPhieuXuat NVARCHAR(20), @MaNhanVien NVARCHAR(20),@MaKhachHang NVARCHAR(20), @NgayXuat DATETIME
AS
BEGIN 
	IF(NOT EXISTS(SELECT MaPhieuXuat FROM dbo.PhieuXuat WHERE MaPhieuXuat=@MaPhieuXuat))
		RAISERROR(N'Không tồn tại mã phiếu này.',12,1)
	ELSE
	BEGIN
		IF(@NgayXuat > GETDATE())
			RAISERROR(N'Ngày sửa không phù hợp.',12,1)
		ELSE IF(NOT EXISTS(SELECT MaNhanVien FROM dbo.NhanVien WHERE MaNhanVien = @MaNhanVien))
			RAISERROR(N'Không tồn tại mã nhân viên này.',12,1)
		ELSE IF(NOT EXISTS(SELECT MaKhachHang FROM dbo.KhachHang WHERE MaKhachHang = @MaKhachHang))
			RAISERROR(N'Không có thông tin khách hàng này.',12,1)
		ELSE 
			UPDATE dbo.PhieuXuat 
			SET MaNhanVien = @MaNhanVien, MaKhachHang = @MaKhachHang, NgayXuat = @NgayXuat
			WHERE MaPhieuXuat = @MaPhieuXuat
	END
END

GO

CREATE PROC USP_DeletePhieuXuat
@MaPhieuXuat NVARCHAR(20)
AS
BEGIN 
	IF(NOT EXISTS(SELECT MaPhieuXuat FROM dbo.PhieuXuat WHERE MaPhieuXuat=@MaPhieuXuat))
		RAISERROR(N'Không tồn tại mã phiếu xuất này.',12,1)
	ELSE 
		DELETE FROM dbo.PhieuXuat WHERE MaPhieuXuat=@MaPhieuXuat
END
GO
--Các thủ tục cho bảng chi tiết phiếu nhập

CREATE PROC USP_InsertCTPN
@MaPhieuNhap NVARCHAR(20), @MaHang NVARCHAR(20),
@SoLuongNhap INT, @DonGiaNhap FLOAT, @Thue FLOAT
AS
BEGIN
	IF(NOT EXISTS(SELECT MaPhieuNhap FROM dbo.PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap))
		RAISERROR(N'Chưa có phiếu nhập này trong bảng phiếu nhập.',12,1)
	ELSE IF(NOT EXISTS(SELECT MaHang FROM dbo.MatHang WHERE MaHang=@MaHang))
		RAISERROR(N'Chưa có thông tin về mặt hàng này.',12,1)
	ELSE IF(@SoLuongNhap<=0)
		RAISERROR(N'Số lượng nhập không hợp lý.',12,1)
	ELSE IF(@DonGiaNhap<=0)
		RAISERROR('Đơn giá nhập không hợp lý.',12,1)
	ELSE 
		INSERT INTO dbo.ChiTietPhieuNhap 
		VALUES (@MaPhieuNhap , @MaHang , @SoLuongNhap , @DonGiaNhap , @Thue)
END

GO

CREATE PROC USP_UpdateCTPN
@MaPhieuNhap NVARCHAR(20), @MaHang NVARCHAR(20),
@SoLuongNhap INT, @DonGiaNhap FLOAT, @Thue FLOAT
AS
BEGIN
	IF(NOT EXISTS(SELECT @MaPhieuNhap FROM dbo.ChiTietPhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap))
		RAISERROR(N'Không tồn tại mã phiếu nhập này.',12,1)
	ELSE
	BEGIN
		IF(NOT EXISTS(SELECT MaHang FROM dbo.MatHang WHERE MaHang = @MaHang))
			RAISERROR(N'Không có thông tin về mã hàng này.',12,1)
		IF(@SoLuongNhap<=0) 
			RAISERROR(N'Số lượng nhập không được nhỏ hơn 1',12,1)
		IF(@DonGiaNhap<=0)
			RAISERROR(N'Giá nhập không hợp lý.',12,1)
		ELSE
			UPDATE dbo.ChiTietPhieuNhap 
			SET SoLuongNhap=@SoLuongNhap , DonGiaNhap=@DonGiaNhap , Thue=@Thue  
			WHERE MaPhieuNhap = @MaPhieuNhap AND  MaHang = @MaHang
	END
END

GO

CREATE PROC USP_DeleteCTPN
@MaPhieuNhap NVARCHAR(20), @MaHang NVARCHAR(20)
AS
BEGIN
	IF(NOT EXISTS(SELECT @MaPhieuNhap FROM dbo.ChiTietPhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap))
		RAISERROR(N'Không tồn tại mã phiếu nhập này.',12,1)
	ELSE
		DELETE FROM dbo.ChiTietPhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap AND  MaHang = @MaHang
END

GO
-- Tạo các thủ thục cho bảng chi tiết phiếu xuất
CREATE PROC USP_InsertCTPX
@MaPhieuXuat NVARCHAR(20), @MaHang NVARCHAR(20),
@SoLuongXuat INT, @DonGiaXuat FLOAT, @Thue	FLOAT
AS
BEGIN
	IF(EXISTS(SELECT MaPhieuXuat FROM dbo.PhieuXuat WHERE MaPhieuXuat = @MaPhieuXuat))
		RAISERROR(N'Đã tồn tại phiếu xuất này.',12,1)
	ELSE IF(NOT EXISTS(SELECT MaHang FROM dbo.MatHang WHERE MaHang = @MaHang))
		RAISERROR(N'Chưa có thông tin về mặt hàng này.',12,1)
	ELSE IF(@SoLuongXuat>(SELECT SoLuong FROM dbo.MatHang WHERE MaHang = @MaHang))
		RAISERROR(N'Số lượng mặt hàng trong kho không đủ để xuất bán.',12,1)
	ELSE 
		INSERT INTO dbo.ChiTietPhieuXuat 
		VALUES (@MaPhieuXuat , @MaHang , @SoLuongXuat, @DonGiaXuat, @Thue)
END

GO

CREATE PROC USP_UpdateCTPX
@MaPhieuXuat NVARCHAR(20), @MaHang NVARCHAR(20),
@SoLuongXuat INT, @DonGiaXuat FLOAT, @Thue	FLOAT
AS
BEGIN
	IF(@SoLuongXuat>(SELECT SoLuong FROM dbo.MatHang WHERE MaHang = @MaHang))
		RAISERROR(N'Số lượng mặt hàng trong kho không đủ để xuất bán.',12,1)
	ELSE
		UPDATE dbo.ChiTietPhieuXuat  
		SET SoLuongXuat = @SoLuongXuat, DonGiaXuat=@DonGiaXuat , Thue = @Thue
		WHERE MaPhieuXuat = @MaPhieuXuat AND MaHang = @MaHang
END

GO

CREATE PROC USP_DeleteCTPX
@MaPhieuXuat NVARCHAR(20), @MaHang NVARCHAR(20)
AS
BEGIN
	IF(NOT EXISTS(SELECT MaPhieuXuat FROM dbo.ChiTietPhieuXuat WHERE MaPhieuXuat = @MaPhieuXuat))
		RAISERROR(N'Không tồn tại mã phiếu xuất này.',12,1)
	ELSE
		DELETE FROM dbo.ChiTietPhieuXuat WHERE MaPhieuXuat=@MaPhieuXuat AND MaHang=@MaHang
END

GO
--Các thủ tục cho bảng AccountLogin
CREATE PROC USP_InsertAcc
@UserName NVARCHAR(50), @PassWord NVARCHAR(50), @LoaiTaiKhoan INT,
@TenHienThi	NVARCHAR(50), @DienThoai NVARCHAR(15),  @Email NVARCHAR(100)
AS
BEGIN
	IF(EXISTS(SELECT UserName FROM dbo.AccountLogin WHERE UserName = @UserName))
		RAISERROR(N'Tài khoản này đã tồn tại.',12,1)
	ELSE
		INSERT INTO dbo.AccountLogin
		VALUES(@UserName,@PassWord,@LoaiTaiKhoan,@TenHienThi,@DienThoai,@Email)
END

GO

CREATE PROC USP_UpdateAcc
@UserName NVARCHAR(50), @PassWord NVARCHAR(50), @LoaiTaiKhoan INT,
@TenHienThi	NVARCHAR(50), @DienThoai NVARCHAR(15),  @Email NVARCHAR(100)
AS
BEGIN
	IF(NOT EXISTS(SELECT UserName FROM dbo.AccountLogin WHERE UserName = @UserName))
		RAISERROR(N'Không tồn tại tài khoản này.',12,1)
	ELSE
		UPDATE dbo.AccountLogin
		SET PassWord = @PassWord, LoaiTaiKhoan = @LoaiTaiKhoan, TenHienThi= @TenHienThi, DienThoai =@DienThoai, Email =@Email
		WHERE UserName = @UserName
END

GO

CREATE PROC USP_DeleteAcc
@UserName NVARCHAR(50)
AS
BEGIN
	IF(NOT EXISTS(SELECT UserName FROM dbo.AccountLogin WHERE UserName = @UserName))
		RAISERROR(N'Không tồn tại tài khoản này.',12,1)
	ELSE
		DELETE FROM dbo.AccountLogin WHERE UserName = @UserName
END

GO

-- Tạo các trigger cho bảng chi tiết phiếu nhập vầ xuất

CREATE TRIGGER UTG_Insert_CTPX
ON ChiTietPhieuXuat
FOR Insert
AS
BEGIN
	declare @mahang nvarchar(20)
	declare @maPX nvarchar(20)
	set @mahang= (SELECT MaHang FROM inserted)
	set @maPX=(SELECT MaPhieuXuat FROM inserted)
	if(not exists(SELECT * FROM PhieuXuat WHERE MaPhieuXuat=@maPX))
		BEGIN
			RAISERROR(N'Chưa tồn tại phiếu xuất này',16,1)
			ROLLBACK TRANSACTION
		END
	else
		if( exists(SELECT * FROM ChiTietPhieuNhap WHERE  MaHang=@mahang))
			BEGIN
				RAISERROR(N'Đã tồn tại mã phiếu xuất này',16,1)
				ROLLBACK TRANSACTION
			END
		else
			BEGIN
				if(not exists(SELECT * FROM MatHang WHERE  MaHang=@mahang))
				BEGIN
					RAISERROR(N'Không tồn tại mặt hàng này',16,1)
					ROLLBACK TRANSACTION
				END
			ELSE
	--Kiểm tra số lượng hàng trong kho
				BEGIN
					declare @slc int
					declare @slx int
					set @slc = (SELECT SoLuong FROM MatHang WHERE MaHang=@mahang)
					set @slx = (SELECT SoLuongXuat FROM inserted)
					if(@slc <@slx)
					BEGIN
						RAISERROR(N'Không đủ hàng',16,1)
						ROLLBACK TRANSACTION
					END
					else
						UPDATE MatHang SET SoLuong=SoLuong-@slx WHERE MaHang=@mahang
				END
			END
		
END

GO

CREATE TRIGGER UTG_Delete_CTPX
ON ChiTietPhieuXuat
FOR Delete
AS
BEGIN
	declare @maPX nvarchar(20)
	declare @mahang nvarchar(20)
	set @maPX = (SELECT MaPhieuXuat from deleted)
	set @mahang = (SELECT MaHang from deleted)
	if(exists (SELECT * FROM PhieuXuat WHERE MaPhieuXuat= @maPX))
		BEGIN
			RAISERROR(N'Còn tồn tại phiếu xuất, không thể xóa chi tiết phiếu xuất',16,1)
			ROLLBACK TRANSACTION
		END
	else
		if(not exists (SELECT * FROM ChiTietPhieuXuat WHERE MaPhieuXuat=@maPX))
			BEGIN
				RAISERROR(N'Không tồn tại phiếu xuất',16,1)
				ROLLBACK TRANSACTION
			END
		else
			BEGIN
				declare @sltra int
				set @sltra = (SELECT SoLuongXuat FROM deleted)
				update MatHang set SoLuong=SoLuong+@sltra WHERE MaHang=@mahang
			END
END

GO

CREATE TRIGGER UTG_Update_CTPX
ON ChiTietPhieuXuat
FOR Update
AS
BEGIN
	declare @maPX nvarchar(20)
	declare @mahang nvarchar(20)
	set @mahang = (SELECT MaHang FROM inserted)
	set @maPX = (SELECT MaPhieuXuat FROM inserted)
	if(not exists(SELECT * FROM PhieuXuat WHERE MaPhieuXuat=@maPX))
		BEGIN
			RAISERROR(N'Không tồn tại phiếu xuất',16,1)
			ROLLBACK TRANSACTION
		END
	else
		BEGIN
			declare @slt int
			declare @sls int
			set @slt = (SELECT SoLuongXuat FROM deleted)
			set @sls = (SELECT SoLuongXuat FROM inserted)
			update MatHang set SoLuong= SoLuong- (@sls -@slt) WHERE MaHang=@mahang
		END
END

GO

CREATE TRIGGER UTG_Insert_CTPN
ON ChiTietPhieuNhap
FOR Insert
AS
BEGIN
	declare @mahang nvarchar(20)
	declare @maPN nvarchar(20)
	set @mahang= (SELECT MaHang FROM inserted)
	set @maPN=(SELECT MaPhieuNhap FROM inserted)
	if(not exists(SELECT * FROM PhieuNhap WHERE MaPhieuNhap=@maPN))
		BEGIN
			RAISERROR(N'Chưa tồn tại phiếu nhập này',16,1)
			ROLLBACK TRANSACTION
		END
	else
		if( exists(SELECT * FROM ChiTietPhieuNhap WHERE  MaHang=@mahang))
			BEGIN
				declare @sln int
				set @sln =(SELECT SoLuongNhap FROM inserted)
				update MatHang set SoLuong=SoLuong+@sln WHERE MaHang=@mahang
			END
END

GO

CREATE TRIGGER UTG_Delete_CTPN
ON ChiTietPhieuNhap
FOR Delete
AS
BEGIN
	declare @maPN nvarchar(20)
	declare @mahang nvarchar(20)
	set @maPN = (SELECT MaPhieuNhap from deleted)
	set @mahang = (SELECT MaHang from deleted)
	if(exists (SELECT * FROM PhieuNhap WHERE MaPhieuNhap= @maPN))
		BEGIN
			RAISERROR(N'Còn tồn tại phiếu nhập, không thể xóa chi tiết phiếu nhập',16,1)
			ROLLBACK TRANSACTION
		END
	else
		if(not exists (SELECT * FROM ChiTietPhieuNhap WHERE MaPhieuNhap=@maPN))
			BEGIN
				RAISERROR(N'Không tồn tại phiếu xuất',16,1)
				ROLLBACK TRANSACTION
			END
		else
			BEGIN
				declare @slnhap int
				set @slnhap = (SELECT SoLuongNhap FROM deleted)
				update MatHang set SoLuong=SoLuong-@slnhap WHERE MaHang=@mahang
			END
END

GO

CREATE TRIGGER UTG_Update_CTPN
ON ChiTietPhieuNhap
FOR Update
AS
BEGIN
	declare @maPN nvarchar(20)
	declare @mahang nvarchar(20)
	set @mahang = (SELECT MaHang FROM inserted)
	set @maPN = (SELECT MaPhieuNhap FROM inserted)
	if(not exists(SELECT * FROM PhieuNhap WHERE MaPhieuNhap=@maPN))
		BEGIN
			RAISERROR(N'Không tồn tại phiếu nhập',16,1)
			ROLLBACK TRANSACTION
		END
	else
		BEGIN
			declare @slt int
			declare @sls int
			set @slt = (SELECT SoLuongNhap FROM deleted)
			set @sls = (SELECT SoLuongNhap FROM inserted)
			update MatHang set SoLuong= SoLuong- (@slt -@sls) WHERE MaHang=@mahang
		END
END
GO