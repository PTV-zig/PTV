CREATE TABLE [dbo].[tblHang] (
    [MaHang]     NVARCHAR (50)  NOT NULL,
    [TenHang]    NVARCHAR (100) NOT NULL,
    [TenMuiHuong] NVARCHAR (50)  NOT NULL,
    [SoLuong]    NVARCHAR (50)  NOT NULL,
    [DonGiaNhap] NVARCHAR (50)  NOT NULL,
    [DonGiaBan]  NVARCHAR (50)  NOT NULL,
    [Anh]        NVARCHAR (200) NOT NULL,
    [GhiChu]     NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaHang] ASC),
    FOREIGN KEY ([TenMuiHuong]) REFERENCES [dbo].[tblMuiHuong] ([TenMuiHuong])
);

