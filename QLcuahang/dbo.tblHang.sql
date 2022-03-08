CREATE TABLE [dbo].[tblHang] (
    [MaHang]     NVARCHAR (50)  NOT NULL,
    [TenHang]    NVARCHAR (100)  NOT NULL,
    [MaMuiHuong] NVARCHAR (50)  NOT NULL,
    [SoLuong]    FLOAT     NOT NULL,
    [DonGiaNhap] FLOAT     NOT NULL,
    [DonGiaBan]  FLOAT     NOT NULL,
    [Anh]        NVARCHAR (500) NOT NULL,
    [GhiChu]     NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaHang] ASC)
);

