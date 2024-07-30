USE [master]
GO
/****** Object:  Database [ManavDB]    Script Date: 3.07.2024 10:02:49 ******/
CREATE DATABASE [ManavDB]
GO
USE [ManavDB]
GO
/****** Object:  Table [dbo].[Baharatlar]    Script Date: 3.07.2024 10:02:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Baharatlar](
	[Urun] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Kategorisi] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Fiyati] [nchar](20) COLLATE Turkish_CI_AS NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Caylar]    Script Date: 3.07.2024 10:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caylar](
	[Urun] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Kategorisi] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Fiyati] [nchar](20) COLLATE Turkish_CI_AS NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EtUrunleri]    Script Date: 3.07.2024 10:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EtUrunleri](
	[Urun] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Kategorisi] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Fiyati] [nchar](20) COLLATE Turkish_CI_AS NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kahvaltilik]    Script Date: 3.07.2024 10:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kahvaltilik](
	[Urun] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Kategorisi] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Fiyati] [nchar](20) COLLATE Turkish_CI_AS NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 3.07.2024 10:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Sifre] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[KullaniciTipi] [nvarchar](20) COLLATE Turkish_CI_AS NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mezeler]    Script Date: 3.07.2024 10:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mezeler](
	[Urun] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Kategorisi] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Fiyati] [nchar](20) COLLATE Turkish_CI_AS NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriTablo]    Script Date: 3.07.2024 10:02:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriTablo](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdi] [nvarchar](100) COLLATE Turkish_CI_AS NOT NULL,
	[AlinanUrun] [nvarchar](100) COLLATE Turkish_CI_AS NOT NULL,
	[Adedi] [int] NOT NULL,
	[AlinanTarih] [datetime] NOT NULL,
	[Tutar] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Baharatlar] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Nane', N'Baharat', N'275                 ')
GO
INSERT [dbo].[Baharatlar] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Kimyon', N'Baharat', N'300                 ')
GO
INSERT [dbo].[Baharatlar] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Sumak', N'Baharat', N'110                 ')
GO
INSERT [dbo].[Baharatlar] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Kekik', N'Baharat', N'100                 ')
GO
INSERT [dbo].[Baharatlar] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Zerdeçal', N'Baharat', N'160                 ')
GO
INSERT [dbo].[Baharatlar] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Karabiber', N'Baharatlar', N'32                  ')
GO
INSERT [dbo].[Caylar] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Ofçay Filiz', N'Cay', N'160                 ')
GO
INSERT [dbo].[Caylar] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Çaykur Tiryaki', N'Cay', N'150                 ')
GO
INSERT [dbo].[Caylar] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Lipton Earl Grey', N'Cay', N'130                 ')
GO
INSERT [dbo].[Caylar] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Karali Siyah', N'Cay', N'140                 ')
GO
INSERT [dbo].[Caylar] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Çaykur Filiz', N'Cay', N'153                 ')
GO
INSERT [dbo].[EtUrunleri] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Sucuk', N'Et', N'999                 ')
GO
INSERT [dbo].[EtUrunleri] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Tavuk', N'Et', N'165                 ')
GO
INSERT [dbo].[EtUrunleri] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Kavurma', N'Et', N'1000                ')
GO
INSERT [dbo].[EtUrunleri] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Pastırma', N'Et', N'1360                ')
GO
INSERT [dbo].[EtUrunleri] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Kıyma', N'EtUrunleri', N'781.28              ')
GO
INSERT [dbo].[Kahvaltilik] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Peynir', N'Kahvaltı', N'120                 ')
GO
INSERT [dbo].[Kahvaltilik] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Zeytin', N'Kahvaltı', N'80                  ')
GO
INSERT [dbo].[Kahvaltilik] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Bal', N'Kahvaltı', N'250                 ')
GO
INSERT [dbo].[Kahvaltilik] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Reçel', N'Kahvaltı', N'140                 ')
GO
INSERT [dbo].[Kahvaltilik] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Yumurta', N'Kahvaltı', N'5                   ')
GO
INSERT [dbo].[Kahvaltilik] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Çemen', N'Kahvaltilik', N'61.5                ')
GO
SET IDENTITY_INSERT [dbo].[Kullanicilar] ON 
GO
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (1, N'admin', N'admin123', N'Yönetici')
GO
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (2, N'kerem', N'kerem61', N'Yönetici')
GO
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (3, N'emrah', N'02emrah', N'Yönetici')
GO
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (4, N'mehmet', N'mehmet12', N'Müşteri')
GO
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (5, N'sıla', N'sıla65', N'Müşteri')
GO
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (6, N'melisa', N'melis55', N'Müşteri')
GO
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (7, N'ercan', N'57ercan', N'Müşteri')
GO
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (8, N'oğuz', N'oğuz9191', N'Müşteri')
GO
SET IDENTITY_INSERT [dbo].[Kullanicilar] OFF
GO
INSERT [dbo].[Mezeler] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Haydari', N'Meze', N'45                  ')
GO
INSERT [dbo].[Mezeler] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Acılı Ezme', N'Meze', N'50                  ')
GO
INSERT [dbo].[Mezeler] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Humus', N'Meze', N'65                  ')
GO
INSERT [dbo].[Mezeler] ([Urun], [Kategorisi], [Fiyati]) VALUES (N'Atom Meze', N'Meze', N'80                  ')
GO
SET IDENTITY_INSERT [dbo].[MusteriTablo] ON 
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (1, N'sıla', N'Zeytin', 1, CAST(N'2024-07-01T20:24:06.513' AS DateTime), CAST(80.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (2, N'sıla', N'Reçel', 3, CAST(N'2024-07-01T20:24:06.577' AS DateTime), CAST(420.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (3, N'sıla', N'Bal', 1, CAST(N'2024-07-01T20:24:06.587' AS DateTime), CAST(250.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (4, N'sıla', N'Yumurta', 5, CAST(N'2024-07-01T20:24:06.587' AS DateTime), CAST(25.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (5, N'sıla', N'Ofçay Filiz', 4, CAST(N'2024-07-01T20:24:06.587' AS DateTime), CAST(640.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (6, N'sıla', N'Karali Siyah', 1, CAST(N'2024-07-01T20:24:06.600' AS DateTime), CAST(140.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (7, N'sıla', N'Sucuk', 3, CAST(N'2024-07-01T20:24:06.600' AS DateTime), CAST(2997.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (8, N'sıla', N'Pastırma', 2, CAST(N'2024-07-01T20:24:06.600' AS DateTime), CAST(2720.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (9, N'melisa', N'Tavuk', 5, CAST(N'2024-07-01T23:50:32.733' AS DateTime), CAST(825.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (10, N'melisa', N'Lipton Earl Grey', 3, CAST(N'2024-07-01T23:50:32.837' AS DateTime), CAST(390.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (11, N'melisa', N'Reçel', 2, CAST(N'2024-07-01T23:50:32.837' AS DateTime), CAST(280.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (12, N'melisa', N'Yumurta', 6, CAST(N'2024-07-01T23:50:32.837' AS DateTime), CAST(30.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (13, N'oğuz', N'Humus', 2, CAST(N'2024-07-02T00:32:10.043' AS DateTime), CAST(130.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (14, N'oğuz', N'Atom Meze', 3, CAST(N'2024-07-02T00:32:10.153' AS DateTime), CAST(240.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (15, N'oğuz', N'Ofçay Filiz', 5, CAST(N'2024-07-02T00:32:10.160' AS DateTime), CAST(800.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (16, N'oğuz', N'Çaykur Tiryaki', 3, CAST(N'2024-07-02T00:32:10.167' AS DateTime), CAST(450.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (17, N'oğuz', N'Lipton Earl Grey', 3, CAST(N'2024-07-02T00:32:10.170' AS DateTime), CAST(390.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (18, N'oğuz', N'Peynir', 3, CAST(N'2024-07-02T00:32:10.183' AS DateTime), CAST(360.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (19, N'oğuz', N'Zeytin', 2, CAST(N'2024-07-02T00:32:10.187' AS DateTime), CAST(160.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (20, N'ercan', N'Peynir', 2, CAST(N'2024-07-02T14:55:24.023' AS DateTime), CAST(240.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (21, N'ercan', N'Bal', 3, CAST(N'2024-07-02T14:55:24.053' AS DateTime), CAST(750.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (22, N'ercan', N'Ofçay Filiz', 3, CAST(N'2024-07-02T14:55:24.053' AS DateTime), CAST(480.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (23, N'ercan', N'Karali Siyah', 2, CAST(N'2024-07-02T14:55:24.070' AS DateTime), CAST(280.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (24, N'ercan', N'Çaykur Filiz', 1, CAST(N'2024-07-02T14:55:24.070' AS DateTime), CAST(153.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (25, N'ercan', N'Haydari', 3, CAST(N'2024-07-02T14:55:24.070' AS DateTime), CAST(135.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (26, N'ercan', N'Humus', 1, CAST(N'2024-07-02T14:55:24.070' AS DateTime), CAST(65.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (27, N'mehmet', N'Peynir', 3, CAST(N'2024-07-02T14:58:36.487' AS DateTime), CAST(360.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (28, N'mehmet', N'Zeytin', 2, CAST(N'2024-07-02T14:58:36.487' AS DateTime), CAST(160.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (29, N'mehmet', N'Yumurta', 15, CAST(N'2024-07-02T14:58:36.487' AS DateTime), CAST(75.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (30, N'mehmet', N'Çemen', 7, CAST(N'2024-07-02T14:58:36.500' AS DateTime), CAST(4305.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (31, N'mehmet', N'Acılı Ezme', 3, CAST(N'2024-07-02T14:58:36.503' AS DateTime), CAST(150.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (32, N'mehmet', N'Kekik', 2, CAST(N'2024-07-02T14:58:36.507' AS DateTime), CAST(200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (33, N'mehmet', N'Zerdeçal', 3, CAST(N'2024-07-02T14:58:36.510' AS DateTime), CAST(480.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (34, N'mehmet', N'Çaykur Tiryaki', 1, CAST(N'2024-07-02T14:58:36.513' AS DateTime), CAST(150.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (35, N'mehmet', N'Lipton Earl Grey', 1, CAST(N'2024-07-02T14:58:36.520' AS DateTime), CAST(130.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (36, N'mehmet', N'Tavuk', 3, CAST(N'2024-07-02T14:58:36.523' AS DateTime), CAST(495.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (37, N'mehmet', N'Kavurma', 2, CAST(N'2024-07-02T14:58:36.523' AS DateTime), CAST(2000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (38, N'mehmet', N'Kıyma', 4, CAST(N'2024-07-02T16:01:13.730' AS DateTime), CAST(312512.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (39, N'mehmet', N'Çaykur Filiz', 1, CAST(N'2024-07-02T16:01:13.787' AS DateTime), CAST(153.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (40, N'melisa', N'Karabiber', 4, CAST(N'2024-07-03T02:28:50.810' AS DateTime), CAST(128.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (41, N'melisa', N'Bal', 4, CAST(N'2024-07-03T02:28:50.840' AS DateTime), CAST(1000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (42, N'melisa', N'Reçel', 1, CAST(N'2024-07-03T02:28:50.840' AS DateTime), CAST(140.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MusteriTablo] ([MusteriID], [MusteriAdi], [AlinanUrun], [Adedi], [AlinanTarih], [Tutar]) VALUES (43, N'melisa', N'Ofçay Filiz', 5, CAST(N'2024-07-03T02:28:50.857' AS DateTime), CAST(800.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[MusteriTablo] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Kullanıc__748892B9247C63F3]    Script Date: 3.07.2024 10:02:51 ******/
ALTER TABLE [dbo].[Kullanicilar] ADD UNIQUE NONCLUSTERED 
(
	[KullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ManavDB] SET  READ_WRITE 
GO
