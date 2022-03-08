CREATE TABLE [dbo].[tblKhach] (
    [MaKhachHang]  NCHAR (10) NOT NULL,
    [TenKhachHang] NCHAR (50) NOT NULL,
    [DiaChi]       NCHAR (50) NOT NULL,
    [SoDienThoai]  NCHAR (12) NOT NULL,
    [GioiTinh] NCHAR(10) NOT NULL, 
    PRIMARY KEY CLUSTERED ([MaKhachHang] ASC)
);

