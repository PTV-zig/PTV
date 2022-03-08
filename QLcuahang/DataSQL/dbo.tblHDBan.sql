CREATE TABLE [dbo].[tblHDBan] (
    [MaHDBan]    NVARCHAR (50) NOT NULL,
    [MaNhanVien] NVARCHAR (50) NOT NULL,
    [NgayBan]    DATETIME2 (7) NOT NULL,
    [MaKhach]    NVARCHAR (50) NOT NULL,
    [TongTien]   FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([MaHDBan] ASC),
	FOREIGN KEY (MaNhanVien) REFERENCES [dbo].[tblNhanVien] (MaNhanVien),
	FOREIGN KEY (MaKhach) REFERENCES [dbo].[tblKhach] (MaKhach),
);

