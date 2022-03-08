CREATE TABLE [dbo].[tblChiTietHDBan] (
    [MaHDBan]   NVARCHAR (50) NOT NULL,
    [MaHang]    NVARCHAR (50) NOT NULL,
    [SoLuong]   FLOAT (53)    NOT NULL,
    [DonGia]    FLOAT (53)    NOT NULL,
    [GiamGia]   FLOAT (53)    NOT NULL,
    [ThanhTien] FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([MaHDBan]),
	FOREIGN KEY ([MaHang]) REFERENCES [dbo].[tblHang] ([MaHang])
);

