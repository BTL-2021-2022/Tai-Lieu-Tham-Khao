/*
Created		8/13/2021
Modified		8/13/2021
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/
USE [master]
GO
CREATE DATABASE [QuanLyBanGiay]
go
USE [QuanLyBanGiay]
GO

Create table [NGUOIQUANLY]
(
	[MaNQL] Varchar(20) NOT NULL,
	[TenNQL] Nvarchar(50) NOT NULL,
	[DiaChiNQL] Nvarchar(50) NOT NULL,
	[MatKhau] Varchar(10) NOT NULL,
	[TinhTrang] Nvarchar(20) NOT NULL,
	[SDTNQL] Varchar(10) NOT NULL,
Primary Key ([MaNQL])
) 
go

Create table [KHACHHANG]
(
	[SDT] Varchar(10) NOT NULL,
	[TenKH] Nvarchar(50) NOT NULL,
	[DiaChiKH] Nvarchar(50) NOT NULL,
	[TongTien] Money NOT NULL,
Primary Key ([SDT])
) 
go

Create table [HOADONBAN]
(
	[SoHD] Integer Identity NOT NULL,
	[SDT] Varchar(10) NOT NULL,
	[MaNQL] Varchar(20) NOT NULL,
	[NgayBan] Datetime NOT NULL,
	[ChietKhau] Float NULL,
	[TinhTrangDoiTra] Nvarchar(20) NULL,	
Primary Key ([SoHD])
) 
go

Create table [NHACUNGCAP]
(
	[MaNCC] Varchar(5) NOT NULL,
	[TenNCC] Nvarchar(50) NOT NULL,
	[DiaChiNCC] Nvarchar(50) NOT NULL,
	[SDTNCC] Varchar(10) NOT NULL,
	[TinhTrang] Nvarchar(20) NOT NULL,
Primary Key ([MaNCC])
) 
go

Create table [SoLuongCon]
(
	[Size] Integer NOT NULL,
	[SLCon] Integer NOT NULL,
	[MaSP] Varchar(5) NOT NULL,
	[Mau] Nvarchar(20) NOT NULL,
	[OrderLevel] Integer ,
Primary Key ([Size],[MaSP],[Mau])
) 
go

Create table [HOADONNHAP]
(
	[SoHDN] Integer Identity NOT NULL,
	[MaNCC] Varchar(5) NOT NULL,
	[MaNQL] Varchar(20) NOT NULL,
	[NgayNhap] Datetime NOT NULL,
Primary Key ([SoHDN])
) 
go

Create table [SANPHAM]
(
	[MaSP] Varchar(5) NOT NULL,
	[TenSP] Nvarchar(50) NOT NULL,
	[GiaBan] Money NOT NULL,
	[TinhTrang] Nvarchar(20) NOT NULL,
	[ThongTin] varchar(30),
Primary Key ([MaSP])
) 
go

Create table [DONKHDAT]
(
	[SoHD] Integer Identity NOT NULL,
	[TenKH] Nvarchar(50) NOT NULL,
	[SDT] Varchar(10) NOT NULL,
	[DiaChiKH] Nvarchar(50),
	[TienCoc] Money NOT NULL,
	[TinhTrang] Nvarchar(30) NOT NULL,
	[NgayDat] Datetime NOT NULL,
Primary Key ([SoHD])
) 
go

Create table [CHITIETKHDAT]
(
	[MaSP] Varchar(5) NOT NULL,
	[SoHD] Integer NOT NULL,
	[Size] Integer NOT NULL,
	[Mau] Nvarchar(20) NOT NULL,
	[TenSP] Nvarchar(50) NOT NULL,
	[SoLuongDat] Integer NOT NULL,
	[DonGiaNhap] Money NOT NULL,
	[ThanhTien] Money NOT NULL,
Primary Key ([MaSP],[SoHD],[Size],[Mau])
) 
go

Create table [CHITIETHOADON]
(
	[MaSP] Varchar(5) NOT NULL,
	[SoHD] Integer NOT NULL,
	[Size] Integer NOT NULL,
	[Mau] Nvarchar(20) NOT NULL,
	[SoLuongBan] Integer NOT NULL,
	[GiaBan] Money NOT NULL,
	[ThanhTien] Money NOT NULL,	
Primary Key ([MaSP],[SoHD],[Size],[Mau])
) 
go

Create table [CHITIETHOADONNHAP]
(
	[SoHDN] Integer NOT NULL,
	[MaSP] Varchar(5) NOT NULL,
	[Size] Integer NOT NULL,
	[Mau] Nvarchar(20) NOT NULL,
	[TenSP] Nvarchar(50) NOT NULL,
	[SoLuongNhap] Integer NOT NULL,
	[DonGiaNhap] Money NOT NULL,
	[ThanhTien] Money NOT NULL,
Primary Key ([SoHDN],[MaSP],[Size],[Mau])
) 
go

Create table [DATHANGNCC]
(
	[MaHDDatHang] Integer Identity NOT NULL,
	[MaNCC] Varchar(5) NOT NULL,
	[NgayThang] Datetime NOT NULL,
	[NguoiLap] Nvarchar(50) NOT NULL,
	[TinhTrang] Integer NOT NULL,
Primary Key ([MaHDDatHang])
) 
go

Create table [CHITIETDATHANG]
(
	[MaHDDatHang] Integer NOT NULL,
	[MaSP] Varchar(5) NOT NULL,
	[Size] Integer NOT NULL,
	[Mau] Nvarchar(20) NOT NULL,
	[SoLuongDat] Integer NOT NULL,
	[TienCoc] Money NOT NULL,
	[ThanhTien] Money NOT NULL,
	[TenSP] Nvarchar(50) NOT NULL,
	[DonGiaDat] Money NOT NULL,
Primary Key ([MaHDDatHang],[MaSP],[Size],[Mau])
) 
go

Create table [CHITIETDATHANG_NHAP]
(

	[MaSP] Varchar(5) NOT NULL,
	[Size] Integer NOT NULL,
	[Mau] Nvarchar(20) NOT NULL,
	[TenSP] Nvarchar(50) NOT NULL,
	[SoLuongDat] Integer NOT NULL,
	[DonGiaDat] Money NOT NULL,
	[TienCoc] Money NOT NULL,
	[ThanhTien] Money NOT NULL,

Primary Key ([MaSP],[Size],[Mau])
) 
go

Create table [DONHANGMUA_NHAP]
(

	[MaSP] Varchar(5) NOT NULL,
	[Size] Integer NOT NULL,
	[Mau] Nvarchar(20) NOT NULL,
	[TenSP] Nvarchar(50) NOT NULL,
	[SoLuongMua] Integer NOT NULL,
	[DonGiaMua] Money NOT NULL,	

Primary Key ([MaSP],[Size],[Mau])
) 
go

Create table[PHIEUDOITRA](
	[SoPhieu] integer Identity NOT NULL,
	[SoHD] Integer NOT NULL,
	[MaSPMoi] varchar(5) NOT NULL,
	[TenSPMoi] Nvarchar(50) NOT NULL,
	[Size] Integer NOT NULL,
	[Mau] Nvarchar(20)  NULL,
	[DonGia] Money NOT NULL,
	[SoLuong] int NOT NULL,
	[ThanhTien] Money  NULL,
	Primary Key ([SoPhieu])
)
go
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (1, N'SP02', 34, N'Vàng', 10, 30000000.0000, 49000000.0000, N'Giày Nike', 4900000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (1, N'SP04', 35, N'Xanh', 10, 30000000.0000, 50000000.0000, N'Giày ADIDAS', 5000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (1, N'SP06', 36, N'Trắng', 15, 30000000.0000, 60000000.0000, N'Giày Puma', 4000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (2, N'SP01', 34, N'Vàng', 10, 7000000.0000, 9000000.0000, N'Giày Thể Thao', 900000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (2, N'SP05', 38, N'Xanh', 10, 20000000.0000, 49000000.0000, N'Giày Supreme', 4900000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (2, N'SP08', 35, N'Xanh', 15, 15000000.0000, 25500000.0000, N'Balenciaga', 1700000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (3, N'SP01', 33, N'Xanh', 20, 10000000.0000, 18000000.0000, N'Giày Thể Thao', 900000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (3, N'SP06', 35, N'Trắng', 20, 30000000.0000, 78000000.0000, N'Giày Puma', 3900000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (4, N'SP07', 34, N'Vàng', 10, 15000000.0000, 30000000.0000, N'Converse', 3000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (4, N'SP07', 35, N'Xanh', 10, 15000000.0000, 30000000.0000, N'Converse', 3000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (4, N'SP07', 38, N'Xanh', 10, 15000000.0000, 30000000.0000, N'Converse', 3000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (5, N'SP04', 35, N'Xanh', 12, 40000000.0000, 60000000.0000, N'Giày ADIDAS', 5000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (5, N'SP04', 36, N'Xanh', 12, 40000000.0000, 60000000.0000, N'Giày ADIDAS', 5000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (5, N'SP04', 39, N'Vàng', 12, 40000000.0000, 60000000.0000, N'Giày ADIDAS', 5000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (6, N'SP05', 34, N'Vàng', 12, 23000000.0000, 48000000.0000, N'Giày Supreme', 4000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (6, N'SP05', 36, N'Vàng', 12, 23000000.0000, 48000000.0000, N'Giày Supreme', 4000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (6, N'SP06', 34, N'Vàng', 15, 20000000.0000, 45000000.0000, N'Giày Puma', 3000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (7, N'SP06', 38, N'Trắng', 10, 25000000.0000, 40000000.0000, N'Giày Puma', 4000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (7, N'SP06', 38, N'Vàng', 10, 25000000.0000, 40000000.0000, N'Giày Puma', 4000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (7, N'SP08', 40, N'Xanh', 10, 10000000.0000, 15000000.0000, N'Balenciaga', 1500000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (7, N'SP08', 42, N'Xanh', 10, 10000000.0000, 15000000.0000, N'Balenciaga', 1500000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (8, N'SP06', 36, N'Vàng', 20, 40000000.0000, 78000000.0000, N'Giày Puma', 3900000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (8, N'SP06', 36, N'Xanh', 20, 40000000.0000, 78000000.0000, N'Giày Puma', 3900000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (8, N'SP07', 35, N'Đỏ', 25, 45000000.0000, 75000000.0000, N'Converse', 3000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (8, N'SP07', 37, N'Đỏ', 25, 45000000.0000, 75000000.0000, N'Converse', 3000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (9, N'SP03', 39, N'Đen', 10, 10000000.0000, 20000000.0000, N'Giày Air Jordan', 2000000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (9, N'SP08', 35, N'Trắng', 19, 20000000.0000, 28500000.0000, N'Balenciaga', 1500000.0000)
INSERT [dbo].[CHITIETDATHANG] ([MaHDDatHang], [MaSP], [Size], [Mau], [SoLuongDat], [TienCoc], [ThanhTien], [TenSP], [DonGiaDat]) VALUES (9, N'SP08', 37, N'Xanh', 19, 20000000.0000, 28500000.0000, N'Balenciaga', 1500000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP01', 1, 32, N'Đen', 1, 25000.0000, 2500000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP01', 2, 32, N'Đen', 2, 1000000.0000, 2000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP01', 5, 32, N'Đen', 3, 1000000.0000, 3000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP01', 6, 32, N'Đen', 2, 1000000.0000, 2000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP01', 7, 32, N'Đen', 2, 1000000.0000, 2000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP02', 1, 39, N'Đen', 3, 20000.0000, 60000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP02', 2, 43, N'Đen', 3, 20000.0000, 60000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP02', 3, 39, N'Đỏ', 1, 20000.0000, 20000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP02', 5, 39, N'Đen', 1, 2000.0000, 2000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP03', 2, 38, N'Đỏ', 1, 30000.0000, 30000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP03', 3, 39, N'Đen', 2, 2900000.0000, 5800000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP03', 4, 36, N'Đỏ', 1, 30000.0000, 30000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP03', 4, 39, N'Đen', 1, 2900000.0000, 2900000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP03', 4, 41, N'Trắng', 1, 2900000.0000, 2900000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP04', 3, 41, N'Đỏ', 2, 40000.0000, 80000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP04', 7, 39, N'Vàng', 2, 6000000.0000, 12000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP04', 10, 40, N'Trắng', 2, 6000000.0000, 12000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP04', 10, 40, N'Vàng', 2, 6000000.0000, 12000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP05', 4, 43, N'Đỏ', 1, 50000.0000, 50000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP05', 9, 38, N'Tím', 2, 5600000.0000, 11200000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP06', 8, 38, N'Trắng', 2, 4500000.0000, 9000000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP07', 3, 40, N'Tím', 2, 3900000.0000, 7800000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP07', 4, 40, N'Tím', 1, 3900000.0000, 3900000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP08', 7, 39, N'Đen', 2, 2300000.0000, 4600000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP09', 6, 38, N'Nâu', 1, 4900000.0000, 4900000.0000)
INSERT [dbo].[CHITIETHOADON] ([MaSP], [SoHD], [Size], [Mau], [SoLuongBan], [GiaBan], [ThanhTien]) VALUES (N'SP09', 6, 38, N'Xám', 1, 4900000.0000, 4900000.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP01', 1, 32, N'Đỏ', N'Giày thể thao', 2, 1000000.0000, 2000000.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP02', 1, 39, N'Đỏ', N'Giày Balenciaga', 1, 2000.0000, 200.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'sp02', 2, 40, N'Đỏ', N'Giày Balenciaga', 1, 2000.0000, 200.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'sp03', 2, 38, N'Đỏ', N'Giày Converse', 2, 3000.0000, 600.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP03', 3, 39, N'Lam', N'Giày Air Jordan', 3, 2900000.0000, 870000.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP03', 7, 41, N'Đen', N'Giày Air Jordan', 2, 2900000.0000, 580000.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP04', 6, 40, N'Trắng', N'Giày ADIDAS', 1, 6000000.0000, 600000.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP04', 6, 40, N'Vàng', N'Giày ADIDAS', 1, 6000000.0000, 600000.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP05', 2, 36, N'Đen', N'Giày Supreme', 2, 5600000.0000, 1120000.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP06', 3, 40, N'Lam', N'Giày Puma', 1, 4500000.0000, 450000.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP07', 4, 38, N'Đen', N'Converse', 2, 3900000.0000, 780000.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP07', 4, 40, N'Đen', N'Converse', 2, 3900000.0000, 780000.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP09', 5, 38, N'Nâu', N'Giày Vans', 1, 4900000.0000, 490000.0000)
INSERT [dbo].[CHITIETKHDAT] ([MaSP], [SoHD], [Size], [Mau], [TenSP], [SoLuongDat], [DonGiaNhap], [ThanhTien]) VALUES (N'SP09', 5, 38, N'Xám', N'Giày Vans', 1, 4900000.0000, 490000.0000)
SET IDENTITY_INSERT [dbo].[DATHANGNCC] ON 

INSERT [dbo].[DATHANGNCC] ([MaHDDatHang], [MaNCC], [NgayThang], [NguoiLap], [TinhTrang]) VALUES (1, N'NCC2', CAST(N'2021-08-29 15:06:22.023' AS DateTime), N'Vũ Kim Anh', 0)
INSERT [dbo].[DATHANGNCC] ([MaHDDatHang], [MaNCC], [NgayThang], [NguoiLap], [TinhTrang]) VALUES (2, N'NCC2', CAST(N'2021-08-29 15:11:10.987' AS DateTime), N'Vũ Kim Anh', 1)
INSERT [dbo].[DATHANGNCC] ([MaHDDatHang], [MaNCC], [NgayThang], [NguoiLap], [TinhTrang]) VALUES (3, N'NCC1', CAST(N'2021-08-29 15:14:00.300' AS DateTime), N'Vũ Kim Anh', 0)
INSERT [dbo].[DATHANGNCC] ([MaHDDatHang], [MaNCC], [NgayThang], [NguoiLap], [TinhTrang]) VALUES (4, N'NCC3', CAST(N'2021-08-29 15:15:23.200' AS DateTime), N'Vũ Kim Anh', 1)
INSERT [dbo].[DATHANGNCC] ([MaHDDatHang], [MaNCC], [NgayThang], [NguoiLap], [TinhTrang]) VALUES (5, N'NCC4', CAST(N'2021-08-29 15:16:14.677' AS DateTime), N'Vũ Kim Anh', 1)
INSERT [dbo].[DATHANGNCC] ([MaHDDatHang], [MaNCC], [NgayThang], [NguoiLap], [TinhTrang]) VALUES (6, N'NCC1', CAST(N'2021-08-29 15:17:13.727' AS DateTime), N'Vũ Kim Anh', 0)
INSERT [dbo].[DATHANGNCC] ([MaHDDatHang], [MaNCC], [NgayThang], [NguoiLap], [TinhTrang]) VALUES (7, N'NCC4', CAST(N'2021-08-29 15:18:55.480' AS DateTime), N'Nguyễn Tiến Đạt', 1)
INSERT [dbo].[DATHANGNCC] ([MaHDDatHang], [MaNCC], [NgayThang], [NguoiLap], [TinhTrang]) VALUES (8, N'NCC6', CAST(N'2021-08-29 15:26:36.837' AS DateTime), N'Nguyễn Tiến Đạt', 0)
INSERT [dbo].[DATHANGNCC] ([MaHDDatHang], [MaNCC], [NgayThang], [NguoiLap], [TinhTrang]) VALUES (9, N'NCC1', CAST(N'2021-08-29 15:29:04.117' AS DateTime), N'Nguyễn Tiến Đạt', 0)
SET IDENTITY_INSERT [dbo].[DATHANGNCC] OFF
SET IDENTITY_INSERT [dbo].[DONKHDAT] ON 

INSERT [dbo].[DONKHDAT] ([SoHD], [TenKH], [SDT], [DiaChiKH], [TienCoc], [TinhTrang], [NgayDat]) VALUES (1, N'Phan Văn Anh', N'0987654678', N'Ninh Bình', 2000000.0000, N'Chờ xử lý', CAST(N'2021-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DONKHDAT] ([SoHD], [TenKH], [SDT], [DiaChiKH], [TienCoc], [TinhTrang], [NgayDat]) VALUES (2, N'Nguyễn Trường An', N'0378675432', N'Hải Dương', 3000000.0000, N'Chờ xử lý', CAST(N'2021-08-29 13:58:09.600' AS DateTime))
INSERT [dbo].[DONKHDAT] ([SoHD], [TenKH], [SDT], [DiaChiKH], [TienCoc], [TinhTrang], [NgayDat]) VALUES (3, N'Chu Đức Anh', N'0876598765', N'Hải Phòng', 1320000.0000, N'Chờ xử lý', CAST(N'2021-08-29 14:02:30.140' AS DateTime))
INSERT [dbo].[DONKHDAT] ([SoHD], [TenKH], [SDT], [DiaChiKH], [TienCoc], [TinhTrang], [NgayDat]) VALUES (4, N'Nguyễn Thị Linh', N'0987896543', N'Phú Yên', 1560000.0000, N'Chờ xử lý', CAST(N'2021-08-29 14:09:12.317' AS DateTime))
INSERT [dbo].[DONKHDAT] ([SoHD], [TenKH], [SDT], [DiaChiKH], [TienCoc], [TinhTrang], [NgayDat]) VALUES (5, N'Nguyễn Văn Đức', N'0345678888', N'Phú Thọ', 2000000.0000, N'Đã xử lý', CAST(N'2021-08-29 14:10:18.040' AS DateTime))
INSERT [dbo].[DONKHDAT] ([SoHD], [TenKH], [SDT], [DiaChiKH], [TienCoc], [TinhTrang], [NgayDat]) VALUES (6, N'hải Đăng', N'0987687543', N'Hà Tĩnh', 3000000.0000, N'Chờ xử lý', CAST(N'2021-08-29 14:12:34.170' AS DateTime))
INSERT [dbo].[DONKHDAT] ([SoHD], [TenKH], [SDT], [DiaChiKH], [TienCoc], [TinhTrang], [NgayDat]) VALUES (7, N'Chu Linh', N'0356782828', N'Đà Nẵng', 2000000.0000, N'Chờ xử lý', CAST(N'2021-08-29 14:15:15.073' AS DateTime))
SET IDENTITY_INSERT [dbo].[DONKHDAT] OFF
SET IDENTITY_INSERT [dbo].[HOADONBAN] ON 

INSERT [dbo].[HOADONBAN] ([SoHD], [SDT], [MaNQL], [NgayBan], [ChietKhau], [TinhTrangDoiTra]) VALUES (1, N'0372899829', N'NQL01', CAST(N'2021-08-23 00:00:00.000' AS DateTime), 2, N'đã đổi trả')
INSERT [dbo].[HOADONBAN] ([SoHD], [SDT], [MaNQL], [NgayBan], [ChietKhau], [TinhTrangDoiTra]) VALUES (2, N'0356567345', N'NQL01', CAST(N'2021-08-29 11:52:21.193' AS DateTime), 12, N'chưa đổi trả')
INSERT [dbo].[HOADONBAN] ([SoHD], [SDT], [MaNQL], [NgayBan], [ChietKhau], [TinhTrangDoiTra]) VALUES (3, N'0372899829', N'NQL01', CAST(N'2021-08-29 11:53:01.140' AS DateTime), 0, N'chưa đổi trả')
INSERT [dbo].[HOADONBAN] ([SoHD], [SDT], [MaNQL], [NgayBan], [ChietKhau], [TinhTrangDoiTra]) VALUES (4, N'0373657362', N'NQL02', CAST(N'2021-08-29 11:55:52.720' AS DateTime), 9, N'đã đổi trả')
INSERT [dbo].[HOADONBAN] ([SoHD], [SDT], [MaNQL], [NgayBan], [ChietKhau], [TinhTrangDoiTra]) VALUES (5, N'0374983724', N'NQL02', CAST(N'2021-08-29 12:11:36.457' AS DateTime), 2, N'đã đổi trả')
INSERT [dbo].[HOADONBAN] ([SoHD], [SDT], [MaNQL], [NgayBan], [ChietKhau], [TinhTrangDoiTra]) VALUES (6, N'0345678888', N'NQL04', CAST(N'2021-08-29 14:16:10.590' AS DateTime), 10, N'chưa đổi trả')
INSERT [dbo].[HOADONBAN] ([SoHD], [SDT], [MaNQL], [NgayBan], [ChietKhau], [TinhTrangDoiTra]) VALUES (7, N'0987543678', N'NQL04', CAST(N'2021-08-29 14:32:02.753' AS DateTime), 10, N'chưa đổi trả')
INSERT [dbo].[HOADONBAN] ([SoHD], [SDT], [MaNQL], [NgayBan], [ChietKhau], [TinhTrangDoiTra]) VALUES (8, N'0987654789', N'NQL01', CAST(N'2021-08-29 14:35:48.560' AS DateTime), 10, N'chưa đổi trả')
INSERT [dbo].[HOADONBAN] ([SoHD], [SDT], [MaNQL], [NgayBan], [ChietKhau], [TinhTrangDoiTra]) VALUES (9, N'0374983724', N'NQL04', CAST(N'2021-08-29 14:39:48.060' AS DateTime), 10, N'chưa đổi trả')
INSERT [dbo].[HOADONBAN] ([SoHD], [SDT], [MaNQL], [NgayBan], [ChietKhau], [TinhTrangDoiTra]) VALUES (10, N'0374983724', N'NQL02', CAST(N'2021-08-29 14:45:49.687' AS DateTime), 10, N'chưa đổi trả')
SET IDENTITY_INSERT [dbo].[HOADONBAN] OFF
INSERT [dbo].[KHACHHANG] ([SDT], [TenKH], [DiaChiKH], [TongTien]) VALUES (N'0345678888', N'Nguyễn Văn Đức', N'Phú Thọ', 10620000.0000)
INSERT [dbo].[KHACHHANG] ([SDT], [TenKH], [DiaChiKH], [TongTien]) VALUES (N'0356567345', N'Nguyễn Văn Nam', N'Thanh Hóa', 4760000.0000)
INSERT [dbo].[KHACHHANG] ([SDT], [TenKH], [DiaChiKH], [TongTien]) VALUES (N'0372899829', N'Trần Văn Đại', N'Hà Nội', 15600000.0000)
INSERT [dbo].[KHACHHANG] ([SDT], [TenKH], [DiaChiKH], [TongTien]) VALUES (N'0373657362', N'Nguyễn Thúy Bình', N'Hà Nội', 12827000.0000)
INSERT [dbo].[KHACHHANG] ([SDT], [TenKH], [DiaChiKH], [TongTien]) VALUES (N'0374983724', N'Nguyễn Thị Nga', N'Vĩnh Phúc', 37120000.0000)
INSERT [dbo].[KHACHHANG] ([SDT], [TenKH], [DiaChiKH], [TongTien]) VALUES (N'0987543678', N'Nguyễn Hải Long', N'Nam Định', 16740000.0000)
INSERT [dbo].[KHACHHANG] ([SDT], [TenKH], [DiaChiKH], [TongTien]) VALUES (N'0987654789', N'Nguyễn Hải Dương', N'Bình Định', 8100000.0000)
INSERT [dbo].[NGUOIQUANLY] ([MaNQL], [TenNQL], [DiaChiNQL], [MatKhau], [TinhTrang], [SDTNQL]) VALUES (N'NQL01', N'Vũ Kim Anh', N'Hà Nội', N'NQL01', N'ADMIN', N'0372899867')
INSERT [dbo].[NGUOIQUANLY] ([MaNQL], [TenNQL], [DiaChiNQL], [MatKhau], [TinhTrang], [SDTNQL]) VALUES (N'NQL02', N'Nguyễn Tiến Đạt', N'Long An', N'NQL02', N'ADMIN', N'0372566487')
INSERT [dbo].[NGUOIQUANLY] ([MaNQL], [TenNQL], [DiaChiNQL], [MatKhau], [TinhTrang], [SDTNQL]) VALUES (N'NQL03', N'Nguyễn Đức Hùng', N'Thanh Hóa', N'NQL03', N'VHH', N'0368566235')
INSERT [dbo].[NGUOIQUANLY] ([MaNQL], [TenNQL], [DiaChiNQL], [MatKhau], [TinhTrang], [SDTNQL]) VALUES (N'NQL04', N'Phan Bá Toại', N'Vĩnh Phúc', N'NQL04', N'NV', N'0398479327')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC], [TinhTrang]) VALUES (N'NCC1', N'Long sơn 2', N'Khánh hoà', N'0988654321', N'N')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC], [TinhTrang]) VALUES (N'NCC2', N'Thiên An', N'Đồng Nai', N'0986876895', N'N')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC], [TinhTrang]) VALUES (N'NCC3', N'Giầy Dép số 1 Việt Nam', N'Bình Phước', N'0986456234', N'K')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC], [TinhTrang]) VALUES (N'NCC4', N'Công ty Vàm Cổ', N'An Giang', N'0986062627', N'N')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC], [TinhTrang]) VALUES (N'NCC5', N'Công ty giày Nike', N'Hà Nam', N'0987987654', N'N')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC], [TinhTrang]) VALUES (N'NCC6', N'Công Ty Minh Thành', N'Bắc Giang', N'0345643267', N'N')
SET IDENTITY_INSERT [dbo].[PHIEUDOITRA] ON 

INSERT [dbo].[PHIEUDOITRA] ([SoPhieu], [SoHD], [MaSPMoi], [TenSPMoi], [Size], [Mau], [DonGia], [SoLuong], [ThanhTien]) VALUES (1, 1, N'SP01', N'Giày Thể Thao', 32, N'Đen', 1000000.0000, 2, 2000000.0000)
INSERT [dbo].[PHIEUDOITRA] ([SoPhieu], [SoHD], [MaSPMoi], [TenSPMoi], [Size], [Mau], [DonGia], [SoLuong], [ThanhTien]) VALUES (2, 4, N'SP05', N'Giày Supreme', 38, N'Tím', 5600000.0000, 2, 11200000.0000)
INSERT [dbo].[PHIEUDOITRA] ([SoPhieu], [SoHD], [MaSPMoi], [TenSPMoi], [Size], [Mau], [DonGia], [SoLuong], [ThanhTien]) VALUES (3, 1, N'SP01', N'Giày Thể Thao', 32, N'Đen', 1000000.0000, 2, 2000000.0000)
INSERT [dbo].[PHIEUDOITRA] ([SoPhieu], [SoHD], [MaSPMoi], [TenSPMoi], [Size], [Mau], [DonGia], [SoLuong], [ThanhTien]) VALUES (4, 1, N'SP01', N'Giày Thể Thao', 32, N'Đen', 1000000.0000, 2, 2000000.0000)
INSERT [dbo].[PHIEUDOITRA] ([SoPhieu], [SoHD], [MaSPMoi], [TenSPMoi], [Size], [Mau], [DonGia], [SoLuong], [ThanhTien]) VALUES (5, 1, N'SP01', N'Giày Thể Thao', 32, N'Đen', 1000000.0000, 2, 2000000.0000)
INSERT [dbo].[PHIEUDOITRA] ([SoPhieu], [SoHD], [MaSPMoi], [TenSPMoi], [Size], [Mau], [DonGia], [SoLuong], [ThanhTien]) VALUES (6, 5, N'SP01', N'Giày Thể Thao', 32, N'Đen', 1000000.0000, 2, 2000000.0000)
INSERT [dbo].[PHIEUDOITRA] ([SoPhieu], [SoHD], [MaSPMoi], [TenSPMoi], [Size], [Mau], [DonGia], [SoLuong], [ThanhTien]) VALUES (7, 5, N'SP04', N'Giày ADIDAS', 39, N'Vàng', 6000000.0000, 2, 12000000.0000)
SET IDENTITY_INSERT [dbo].[PHIEUDOITRA] OFF
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [TinhTrang], [ThongTin]) VALUES (N'SP01', N'Giày Thể Thao', 1000000.0000, N'N', N'36 - 44')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [TinhTrang], [ThongTin]) VALUES (N'SP02', N'Giày Nike', 5500000.0000, N'N', N'36 - 44')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [TinhTrang], [ThongTin]) VALUES (N'SP03', N'Giày Air Jordan', 2900000.0000, N'N', N'36 - 44')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [TinhTrang], [ThongTin]) VALUES (N'SP04', N'Giày ADIDAS', 6000000.0000, N'N', N'36 - 44')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [TinhTrang], [ThongTin]) VALUES (N'SP05', N'Giày Supreme', 5600000.0000, N'K', N'36 - 44')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [TinhTrang], [ThongTin]) VALUES (N'SP06', N'Giày Puma', 4500000.0000, N'N', N'36 - 44')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [TinhTrang], [ThongTin]) VALUES (N'SP07', N'Converse', 3900000.0000, N'N', N'36 - 44')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [TinhTrang], [ThongTin]) VALUES (N'SP08', N'Balenciaga', 2300000.0000, N'N', N'36 - 44')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [GiaBan], [TinhTrang], [ThongTin]) VALUES (N'SP09', N'Giày Vans', 4900000.0000, N'N', N'36 - 44')
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (32, 61, N'SP01', N'Đen', 5)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (32, 40, N'SP01', N'Đỏ', 5)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (35, 47, N'SP01', N'Trắng', 10)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (35, 50, N'SP02', N'Trắng', 5)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (35, 60, N'SP02', N'Xanh', 10)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (36, 45, N'SP01', N'Đen', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (36, 25, N'SP01', N'Trắng', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (36, 15, N'SP03', N'Đỏ', 15)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (37, 11, N'SP03', N'Đen', 4)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (38, 50, N'SP03', N'Đỏ', 3)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (38, 29, N'SP03', N'Trắng Xanh', 10)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (38, 43, N'SP05', N'Tím', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (38, 54, N'SP06', N'Trắng', 10)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (38, 36, N'SP07', N'Đen', 10)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (38, 34, N'SP08', N'Vàng', 10)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (38, 54, N'SP08', N'Xám', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (38, 43, N'SP09', N'Nâu', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (38, 64, N'SP09', N'Xám', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (39, 10, N'SP02', N'Đen', 7)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (39, 52, N'SP02', N'Xanh', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (39, 42, N'SP03', N'Đen', 10)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (39, 63, N'SP04', N'Vàng', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (39, 57, N'SP05', N'Đen', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (39, 20, N'SP05', N'Đỏ', 30)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (39, 39, N'SP05', N'Tím', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (39, 30, N'SP06', N'Trắng', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (39, 63, N'SP08', N'Đen', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (39, 55, N'SP09', N'Đen ', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (40, 41, N'SP04', N'Trắng', 10)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (40, 54, N'SP04', N'Vàng', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (40, 10, N'SP05', N'Đen', 50)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (40, 35, N'SP06', N'Trắng', 15)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (40, 45, N'SP07', N'Đen', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (40, 31, N'SP07', N'Tím', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (40, 43, N'SP08', N'Đen', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (41, 41, N'SP03', N'Trắng', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (41, 60, N'SP04', N'Đen', 2)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (41, 43, N'SP04', N'Vàng', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (41, 44, N'SP08', N'Đen', NULL)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (42, 15, N'SP02', N'Đỏ', 8)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (42, 10, N'SP04', N'Đỏ', 6)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (43, 13, N'SP01', N'Đỏ', 10)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (43, 17, N'SP02', N'Đen', 9)
INSERT [dbo].[SoLuongCon] ([Size], [SLCon], [MaSP], [Mau], [OrderLevel]) VALUES (43, 20, N'SP04', N'Đen', 20)
SET IDENTITY_INSERT [dbo].[HOADONNHAP] ON 

INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNCC], [MaNQL], [NgayNhap]) VALUES (1, N'NCC2', N'NQL01', CAST(N'2021-08-29T18:11:34.290' AS DateTime))
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNCC], [MaNQL], [NgayNhap]) VALUES (2, N'NCC1', N'NQL01', CAST(N'2021-08-29T18:12:36.497' AS DateTime))
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNCC], [MaNQL], [NgayNhap]) VALUES (3, N'NCC3', N'NQL01', CAST(N'2021-08-29T18:15:57.337' AS DateTime))
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNCC], [MaNQL], [NgayNhap]) VALUES (4, N'NCC4', N'NQL01', CAST(N'2021-08-29T18:16:12.980' AS DateTime))
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNCC], [MaNQL], [NgayNhap]) VALUES (5, N'NCC6', N'NQL01', CAST(N'2021-08-29T18:24:13.170' AS DateTime))
SET IDENTITY_INSERT [dbo].[HOADONNHAP] OFF
GO
INSERT [dbo].[CHITIETHOADONNHAP] ([SoHDN], [MaSP], [Size], [Mau], [TenSP], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (1, N'SP02', 34, N'Vàng', N'Giày Nike', 5, 4900000.0000, 245000000000000.0000)
INSERT [dbo].[CHITIETHOADONNHAP] ([SoHDN], [MaSP], [Size], [Mau], [TenSP], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (1, N'SP04', 35, N'Xanh', N'Giày ADIDAS', 5, 5000000.0000, 250000000000000.0000)
INSERT [dbo].[CHITIETHOADONNHAP] ([SoHDN], [MaSP], [Size], [Mau], [TenSP], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (2, N'SP01', 33, N'Xanh', N'Giày Thể Thao', 5, 900000.0000, 16200000000000.0000)
INSERT [dbo].[CHITIETHOADONNHAP] ([SoHDN], [MaSP], [Size], [Mau], [TenSP], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (3, N'SP07', 34, N'Vàng', N'Converse', 5, 3000000.0000, 90000000000000.0000)
INSERT [dbo].[CHITIETHOADONNHAP] ([SoHDN], [MaSP], [Size], [Mau], [TenSP], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (3, N'SP07', 35, N'Xanh', N'Converse', 5, 3000000.0000, 90000000000000.0000)
INSERT [dbo].[CHITIETHOADONNHAP] ([SoHDN], [MaSP], [Size], [Mau], [TenSP], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (4, N'SP04', 35, N'Xanh', N'Giày ADIDAS', 2, 5000000.0000, 300000000000000.0000)
INSERT [dbo].[CHITIETHOADONNHAP] ([SoHDN], [MaSP], [Size], [Mau], [TenSP], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (4, N'SP04', 36, N'Xanh', N'Giày ADIDAS', 2, 5000000.0000, 300000000000000.0000)
INSERT [dbo].[CHITIETHOADONNHAP] ([SoHDN], [MaSP], [Size], [Mau], [TenSP], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (5, N'SP06', 36, N'Vàng', N'Giày Puma', 5, 3900000.0000, 234000000000000.0000)
INSERT [dbo].[CHITIETHOADONNHAP] ([SoHDN], [MaSP], [Size], [Mau], [TenSP], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (5, N'SP06', 36, N'Xanh', N'Giày Puma', 5, 3900000.0000, 234000000000000.0000)
INSERT [dbo].[CHITIETHOADONNHAP] ([SoHDN], [MaSP], [Size], [Mau], [TenSP], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (5, N'SP07', 35, N'Đỏ', N'Converse', 5, 3000000.0000, 225000000000000.0000)
GO
Alter table [HOADONNHAP] add  foreign key([MaNQL]) references [NGUOIQUANLY] ([MaNQL])  on update no action on delete no action 
go
Alter table [HOADONBAN] add  foreign key([MaNQL]) references [NGUOIQUANLY] ([MaNQL])  on update no action on delete no action 
go
Alter table [HOADONBAN] add  foreign key([SDT]) references [KHACHHANG] ([SDT])  on update no action on delete no action 
go
Alter table [CHITIETHOADON] add  foreign key([SoHD]) references [HOADONBAN] ([SoHD])  on update no action on delete no action 
go
Alter table [HOADONNHAP] add  foreign key([MaNCC]) references [NHACUNGCAP] ([MaNCC])  on update no action on delete no action 
go
Alter table [DATHANGNCC] add  foreign key([MaNCC]) references [NHACUNGCAP] ([MaNCC])  on update no action on delete no action 
go
Alter table [CHITIETHOADONNHAP] add  foreign key([SoHDN]) references [HOADONNHAP] ([SoHDN])  on update no action on delete no action 
go
Alter table [CHITIETKHDAT] add  foreign key([MaSP]) references [SANPHAM] ([MaSP])  on update no action on delete no action 
go
Alter table [SoLuongCon] add  foreign key([MaSP]) references [SANPHAM] ([MaSP])  on update no action on delete no action 
go
Alter table [CHITIETHOADON] add  foreign key([MaSP]) references [SANPHAM] ([MaSP])  on update no action on delete no action 
go
Alter table [CHITIETHOADONNHAP] add  foreign key([MaSP]) references [SANPHAM] ([MaSP])  on update no action on delete no action 
go
Alter table [CHITIETDATHANG] add  foreign key([MaSP]) references [SANPHAM] ([MaSP])  on update no action on delete no action 
go
Alter table [CHITIETKHDAT] add  foreign key([SoHD]) references [DONKHDAT] ([SoHD])  on update no action on delete no action 
go
Alter table [CHITIETDATHANG] add  foreign key([MaHDDatHang]) references [DATHANGNCC] ([MaHDDatHang])  on update no action on delete no action 
go
Alter table [PHIEUDOITRA] add  foreign key([SoHD]) references [HOADONBAN] ([SoHD])  on update no action on delete no action 
go

Set quoted_identifier on
go


Set quoted_identifier off
go


