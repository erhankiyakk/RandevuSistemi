# RandevuSistemi
randevu sistemi sql kodu
USE [master]
GO
/****** Object:  Database [Randevu]    Script Date: 11.02.2020 00:38:18 ******/
CREATE DATABASE [Randevu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Randevu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Randevu.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Randevu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Randevu_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Randevu] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Randevu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Randevu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Randevu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Randevu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Randevu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Randevu] SET ARITHABORT OFF 
GO
ALTER DATABASE [Randevu] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Randevu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Randevu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Randevu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Randevu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Randevu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Randevu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Randevu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Randevu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Randevu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Randevu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Randevu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Randevu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Randevu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Randevu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Randevu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Randevu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Randevu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Randevu] SET  MULTI_USER 
GO
ALTER DATABASE [Randevu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Randevu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Randevu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Randevu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Randevu] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Randevu]
GO
/****** Object:  User [erhan]    Script Date: 11.02.2020 00:38:18 ******/
CREATE USER [erhan] FOR LOGIN [erhan] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[tblIsYeri]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblIsYeri](
	[IsYeriID] [int] IDENTITY(1,1) NOT NULL,
	[IsYeriIsmi] [nvarchar](20) NULL,
	[Adres] [nvarchar](max) NULL,
	[TelefonNumarasi] [nchar](14) NULL,
	[KategoriID] [int] NULL,
	[YetkiliTanimlamaDurum] [tinyint] NULL,
	[IsYeriYetkiliID] [int] NULL,
 CONSTRAINT [PK_tblIsYeri] PRIMARY KEY CLUSTERED 
(
	[IsYeriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblIsYeriYetkilileri]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblIsYeriYetkilileri](
	[IsYeriYetkiliID] [int] IDENTITY(1,1) NOT NULL,
	[DogumTarihi] [date] NOT NULL,
	[TCKimlik] [nchar](11) NOT NULL,
	[Login_KullaniciAdi] [nvarchar](20) NOT NULL,
	[Login_Sifre] [nvarchar](20) NOT NULL,
	[TelefonNumarasi] [nchar](10) NOT NULL,
	[Isim] [nvarchar](20) NOT NULL,
	[Soyisim] [nvarchar](20) NOT NULL,
	[Adres] [nvarchar](max) NOT NULL,
	[Eposta] [nvarchar](max) NOT NULL,
	[IsYeriTanimlamaDurum] [tinyint] NOT NULL,
 CONSTRAINT [PK_tblIsYeriYetkilileri] PRIMARY KEY CLUSTERED 
(
	[IsYeriYetkiliID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblKategori]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKategori](
	[KategoriID] [int] IDENTITY(1,1) NOT NULL,
	[KategoriIsmi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblKategori] PRIMARY KEY CLUSTERED 
(
	[KategoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMusaitOlmayanZaman]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMusaitOlmayanZaman](
	[MusaitOlmayanZamanID] [int] IDENTITY(1,1) NOT NULL,
	[ZamanID] [int] NOT NULL,
	[IsYeriID] [int] NOT NULL,
 CONSTRAINT [PK_tblMusaitOlmayanZaman] PRIMARY KEY CLUSTERED 
(
	[MusaitOlmayanZamanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNormalKullanici]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNormalKullanici](
	[NormalKullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[Login_KullaniciAdi] [nvarchar](20) NOT NULL,
	[Login_Sifre] [nvarchar](20) NOT NULL,
	[TelefonNumarasi] [nchar](10) NOT NULL,
	[Isim] [nvarchar](20) NOT NULL,
	[Soyisim] [nvarchar](20) NOT NULL,
	[Adres] [nvarchar](max) NOT NULL,
	[Eposta] [nvarchar](max) NOT NULL,
	[SonGirisZamani] [date] NULL,
	[KullaniciOnayDurum] [tinyint] NOT NULL,
 CONSTRAINT [PK_tblNormalKullanici] PRIMARY KEY CLUSTERED 
(
	[NormalKullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblRandevuAlma]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRandevuAlma](
	[RandevuID] [int] IDENTITY(1,1) NOT NULL,
	[NormalKullaniciID] [int] NOT NULL,
	[IsYeriID] [int] NOT NULL,
	[ZamanID] [int] NOT NULL,
	[OnayDurum] [tinyint] NOT NULL,
	[IsYeriYetkiliID] [int] NOT NULL,
 CONSTRAINT [PK_tblRandevuAlma] PRIMARY KEY CLUSTERED 
(
	[RandevuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSoruCevap]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSoruCevap](
	[SoruCevapID] [int] IDENTITY(1,1) NOT NULL,
	[Soru] [nvarchar](max) NULL,
	[Cevap] [nvarchar](max) NULL,
	[CevaplanmaDurum] [bit] NULL,
	[IsYeriID] [int] NULL,
	[NormalKullaniciID] [int] NULL,
	[IsYeriYetkiliID] [int] NULL,
 CONSTRAINT [PK_tblSoruCevap] PRIMARY KEY CLUSTERED 
(
	[SoruCevapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblZaman]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblZaman](
	[ZamanID] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [date] NOT NULL,
	[Slot] [tinyint] NOT NULL,
 CONSTRAINT [PK_tblZaman] PRIMARY KEY CLUSTERED 
(
	[ZamanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[FN_isYeriSorular]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FN_isYeriSorular](@YetkiliId int) 
RETURNS TABLE 
AS
RETURN 
select s.Soru,n.Isim,n.Soyisim
from tblSoruCevap s inner join tblNormalKullanici n on s.NormalKullaniciID=n.NormalKullaniciID
where s.CevaplanmaDurum=0 and  s.IsYeriYetkiliID=@YetkiliId
GO
/****** Object:  View [dbo].[FirmaListele]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[FirmaListele] (Firma_Ismi)
as
select IsYeriIsmi
from tblIsYeri
GO
/****** Object:  View [dbo].[IsYeriMusaitOlmadigi]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[IsYeriMusaitOlmadigi](isim,tarih,slot)
AS  
select i.IsYeriIsmi ,z.Tarih ,z.Slot
from tblIsYeri i inner join tblMusaitOlmayanZaman m on i.IsYeriID=m.IsYeriID
inner join tblZaman z on m.ZamanID=z.ZamanID
GO
/****** Object:  View [dbo].[ViewFirmaListeleme]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ViewFirmaListeleme]
as
select IsYeriIsmi from tblIsYeri
GO
/****** Object:  View [dbo].[ViewIsYeriYetkiliListesi]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[ViewIsYeriYetkiliListesi]
as
select Isim from tblIsYeriYetkilileri
GO
/****** Object:  View [dbo].[ViewKullaniciListeleme]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[ViewKullaniciListeleme]
as
Select Isim from tblNormalKullanici
GO
/****** Object:  View [dbo].[ViewRandevuOnay]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewRandevuOnay]
AS
SELECT NK.Isim,NK.Soyisim,Z.Tarih,Z.Slot,ra.OnayDurum
FROM tblNormalKullanici NK
INNER JOIN tblRandevuAlma RA ON NK.NormalKullaniciID = RA.NormalKullaniciID
INNER JOIN tblZaman Z ON RA.ZamanID= Z.ZamanID
GO
SET IDENTITY_INSERT [dbo].[tblIsYeri] ON 

INSERT [dbo].[tblIsYeri] ([IsYeriID], [IsYeriIsmi], [Adres], [TelefonNumarasi], [KategoriID], [YetkiliTanimlamaDurum], [IsYeriYetkiliID]) VALUES (10, N'deniz', N'seyrek', N'1234355666    ', 3, 1, 6)
INSERT [dbo].[tblIsYeri] ([IsYeriID], [IsYeriIsmi], [Adres], [TelefonNumarasi], [KategoriID], [YetkiliTanimlamaDurum], [IsYeriYetkiliID]) VALUES (11, N'e', N'kiyak', N'1231232133    ', 2, 1, 7)
INSERT [dbo].[tblIsYeri] ([IsYeriID], [IsYeriIsmi], [Adres], [TelefonNumarasi], [KategoriID], [YetkiliTanimlamaDurum], [IsYeriYetkiliID]) VALUES (13, N'de', N'kiyak', N'3335333333    ', 4, 1, 12)
INSERT [dbo].[tblIsYeri] ([IsYeriID], [IsYeriIsmi], [Adres], [TelefonNumarasi], [KategoriID], [YetkiliTanimlamaDurum], [IsYeriYetkiliID]) VALUES (18, N'eneme', N'dddaasdas', N'5645654656    ', NULL, 0, NULL)
INSERT [dbo].[tblIsYeri] ([IsYeriID], [IsYeriIsmi], [Adres], [TelefonNumarasi], [KategoriID], [YetkiliTanimlamaDurum], [IsYeriYetkiliID]) VALUES (45, N'erhan', N'kiyak', N'333 333333    ', NULL, 1, 13)
INSERT [dbo].[tblIsYeri] ([IsYeriID], [IsYeriIsmi], [Adres], [TelefonNumarasi], [KategoriID], [YetkiliTanimlamaDurum], [IsYeriYetkiliID]) VALUES (1047, N'emelin şirketi', N'denizli', N'5534548597    ', NULL, 1, 15)
SET IDENTITY_INSERT [dbo].[tblIsYeri] OFF
SET IDENTITY_INSERT [dbo].[tblIsYeriYetkilileri] ON 

INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (1, CAST(N'1999-03-15' AS Date), N'1234567891 ', N'er', N'dgd', N'1234567   ', N'dfd', N'dsgfds', N'dgdsf', N'dfgdfg', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (3, CAST(N'1888-02-15' AS Date), N'1234567895 ', N'dfgsd', N'dsgs', N'12345     ', N'dsgsd', N'fgfd', N'fgfdg', N'dsdgf', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (4, CAST(N'1988-12-04' AS Date), N'45645645   ', N'sddfsa', N'SDFSD', N'12345     ', N'fdsf', N'dsfgsd', N'dsgsd', N'dsgsd', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (5, CAST(N'1999-11-11' AS Date), N'1          ', N'ds', N'd', N'1         ', N'd', N'd', N'd', N'halil@dsad', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (6, CAST(N'1999-11-11' AS Date), N'4          ', N'a', N'1', N'5         ', N'dsad', N'dsa', N'sd', N'halil@dsad', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (7, CAST(N'1999-11-11' AS Date), N'1          ', N'b', N'1', N'1         ', N'd', N'd', N'd', N'halil@dsad', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (9, CAST(N'1982-11-11' AS Date), N'308567645  ', N'hayro', N'1', N'5456456456', N'hayri', N'cimen', N'seyrek', N'hayri@hotmail.com', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (10, CAST(N'1977-11-11' AS Date), N'12345678   ', N'abc', N'1', N'1234565467', N'abc', N'asd', N'sadaskdkj', N'erahdh@hotmail.com', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (11, CAST(N'1999-11-11' AS Date), N'1          ', N'sdaad', N'1', N'3         ', N'xcx', N'xcxc', N'xcxc', N'dsad@hotmail.com', 0)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (12, CAST(N'1999-11-11' AS Date), N'1          ', N'sdaad', N'1', N'3         ', N'xcx', N'xcxc', N'xcxc', N'dsad@hotmail.com', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (13, CAST(N'1999-11-11' AS Date), N'1          ', N'sdaad', N'1', N'3         ', N'xcx', N'xcxc', N'xcxc', N'dsad@hotmail.com', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (14, CAST(N'1999-11-11' AS Date), N'332265     ', N'erhan1389', N'1', N'123456    ', N'edsad', N'dfds', N'dsfd', N'hayri@hotmail.com', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (15, CAST(N'1977-11-11' AS Date), N'12314564   ', N'vahid', N'1', N'1215456   ', N'vahid', N'hoca', N'safdasf', N'ererer@hotmail.com', 1)
INSERT [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID], [DogumTarihi], [TCKimlik], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [IsYeriTanimlamaDurum]) VALUES (16, CAST(N'1982-11-11' AS Date), N'123456     ', N'deniz', N'1', N'1234564   ', N'jksdkjd', N'dsfds', N'sadfsdf', N'ererer@hotmail.com', 1)
SET IDENTITY_INSERT [dbo].[tblIsYeriYetkilileri] OFF
SET IDENTITY_INSERT [dbo].[tblKategori] ON 

INSERT [dbo].[tblKategori] ([KategoriID], [KategoriIsmi]) VALUES (1, N'Dişci')
INSERT [dbo].[tblKategori] ([KategoriID], [KategoriIsmi]) VALUES (2, N'Doktor')
INSERT [dbo].[tblKategori] ([KategoriID], [KategoriIsmi]) VALUES (3, N'Psikolog')
INSERT [dbo].[tblKategori] ([KategoriID], [KategoriIsmi]) VALUES (4, N'Spor')
INSERT [dbo].[tblKategori] ([KategoriID], [KategoriIsmi]) VALUES (5, N'Eğitim')
SET IDENTITY_INSERT [dbo].[tblKategori] OFF
SET IDENTITY_INSERT [dbo].[tblMusaitOlmayanZaman] ON 

INSERT [dbo].[tblMusaitOlmayanZaman] ([MusaitOlmayanZamanID], [ZamanID], [IsYeriID]) VALUES (44, 48, 10)
SET IDENTITY_INSERT [dbo].[tblMusaitOlmayanZaman] OFF
SET IDENTITY_INSERT [dbo].[tblNormalKullanici] ON 

INSERT [dbo].[tblNormalKullanici] ([NormalKullaniciID], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [SonGirisZamani], [KullaniciOnayDurum]) VALUES (1, N'dsgsg', N'dsgsdf', N'123454678 ', N'dsfsd', N'DSFSDFsdg', N'dsgsdg', N'dfgdsgsd', CAST(N'2005-11-12' AS Date), 1)
INSERT [dbo].[tblNormalKullanici] ([NormalKullaniciID], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [SonGirisZamani], [KullaniciOnayDurum]) VALUES (2, N'fghdfg', N'dsgdf', N'1234354   ', N'dfdsgds', N'dfsfsdfds', N'fdsfsdf', N'dfsfsdf', CAST(N'1444-12-12' AS Date), 1)
INSERT [dbo].[tblNormalKullanici] ([NormalKullaniciID], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [SonGirisZamani], [KullaniciOnayDurum]) VALUES (5, N'wqewqr', N'hasd', N'8987      ', N'halil', N'yeşil', N'dsffds', N'fdsd', CAST(N'1998-11-11' AS Date), 1)
INSERT [dbo].[tblNormalKullanici] ([NormalKullaniciID], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [SonGirisZamani], [KullaniciOnayDurum]) VALUES (7, N'dsad', N'sadas', N'456       ', N'erhan', N'kıyak', N'sadsaasd', N'sdfsa', CAST(N'2019-11-19' AS Date), 1)
INSERT [dbo].[tblNormalKullanici] ([NormalKullaniciID], [Login_KullaniciAdi], [Login_Sifre], [TelefonNumarasi], [Isim], [Soyisim], [Adres], [Eposta], [SonGirisZamani], [KullaniciOnayDurum]) VALUES (8, N'a', N'1', N'2156465   ', N'dsad', N'sdfsdf', N'sfdfsdf', N'ererer@hotmail.com', NULL, 1)
SET IDENTITY_INSERT [dbo].[tblNormalKullanici] OFF
SET IDENTITY_INSERT [dbo].[tblRandevuAlma] ON 

INSERT [dbo].[tblRandevuAlma] ([RandevuID], [NormalKullaniciID], [IsYeriID], [ZamanID], [OnayDurum], [IsYeriYetkiliID]) VALUES (11, 2, 11, 36, 0, 7)
INSERT [dbo].[tblRandevuAlma] ([RandevuID], [NormalKullaniciID], [IsYeriID], [ZamanID], [OnayDurum], [IsYeriYetkiliID]) VALUES (25, 8, 10, 43, 1, 6)
INSERT [dbo].[tblRandevuAlma] ([RandevuID], [NormalKullaniciID], [IsYeriID], [ZamanID], [OnayDurum], [IsYeriYetkiliID]) VALUES (26, 8, 10, 43, 0, 6)
INSERT [dbo].[tblRandevuAlma] ([RandevuID], [NormalKullaniciID], [IsYeriID], [ZamanID], [OnayDurum], [IsYeriYetkiliID]) VALUES (27, 8, 10, 47, 1, 6)
INSERT [dbo].[tblRandevuAlma] ([RandevuID], [NormalKullaniciID], [IsYeriID], [ZamanID], [OnayDurum], [IsYeriYetkiliID]) VALUES (28, 8, 10, 33, 1, 6)
SET IDENTITY_INSERT [dbo].[tblRandevuAlma] OFF
SET IDENTITY_INSERT [dbo].[tblZaman] ON 

INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (6, CAST(N'1998-11-22' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (7, CAST(N'2020-06-12' AS Date), 2)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (8, CAST(N'2020-08-13' AS Date), 3)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (9, CAST(N'2016-11-11' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (10, CAST(N'2016-11-11' AS Date), 2)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (11, CAST(N'2016-11-11' AS Date), 3)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (12, CAST(N'2020-03-15' AS Date), 3)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (13, CAST(N'2020-03-15' AS Date), 4)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (14, CAST(N'2020-03-15' AS Date), 5)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (15, CAST(N'2020-11-22' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (16, CAST(N'2020-11-22' AS Date), 2)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (17, CAST(N'2020-11-22' AS Date), 3)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (18, CAST(N'2020-11-22' AS Date), 4)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (19, CAST(N'2020-01-20' AS Date), 5)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (20, CAST(N'2020-01-20' AS Date), 6)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (21, CAST(N'2020-01-20' AS Date), 7)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (22, CAST(N'2020-01-20' AS Date), 8)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (23, CAST(N'2020-01-09' AS Date), 5)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (24, CAST(N'2020-01-09' AS Date), 6)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (25, CAST(N'2020-09-30' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (26, CAST(N'2020-04-17' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (27, CAST(N'2020-06-14' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (28, CAST(N'2020-03-29' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (29, CAST(N'2020-09-27' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (30, CAST(N'2020-07-25' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (31, CAST(N'2020-01-06' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (32, CAST(N'2020-01-08' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (33, CAST(N'2020-01-16' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (34, CAST(N'1999-11-10' AS Date), 2)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (35, CAST(N'2022-11-10' AS Date), 2)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (36, CAST(N'2021-11-10' AS Date), 2)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (37, CAST(N'2020-01-26' AS Date), 14)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (38, CAST(N'2020-01-24' AS Date), 14)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (39, CAST(N'2020-01-24' AS Date), 13)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (40, CAST(N'2020-01-31' AS Date), 14)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (41, CAST(N'2020-06-13' AS Date), 8)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (42, CAST(N'2020-03-20' AS Date), 10)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (43, CAST(N'2020-01-06' AS Date), 8)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (44, CAST(N'2020-01-17' AS Date), 14)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (45, CAST(N'2020-01-16' AS Date), 15)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (46, CAST(N'2020-01-17' AS Date), 1)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (47, CAST(N'2020-01-16' AS Date), 8)
INSERT [dbo].[tblZaman] ([ZamanID], [Tarih], [Slot]) VALUES (48, CAST(N'2020-01-15' AS Date), 1)
SET IDENTITY_INSERT [dbo].[tblZaman] OFF
ALTER TABLE [dbo].[tblIsYeri]  WITH CHECK ADD  CONSTRAINT [FK_tblIsYeri_tblIsYeriYetkilileri] FOREIGN KEY([IsYeriYetkiliID])
REFERENCES [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID])
GO
ALTER TABLE [dbo].[tblIsYeri] CHECK CONSTRAINT [FK_tblIsYeri_tblIsYeriYetkilileri]
GO
ALTER TABLE [dbo].[tblIsYeri]  WITH CHECK ADD  CONSTRAINT [FK_tblIsYeri_tblKategori] FOREIGN KEY([KategoriID])
REFERENCES [dbo].[tblKategori] ([KategoriID])
GO
ALTER TABLE [dbo].[tblIsYeri] CHECK CONSTRAINT [FK_tblIsYeri_tblKategori]
GO
ALTER TABLE [dbo].[tblMusaitOlmayanZaman]  WITH CHECK ADD  CONSTRAINT [FK_tblMusaitOlmayanZaman_tblIsYeri] FOREIGN KEY([IsYeriID])
REFERENCES [dbo].[tblIsYeri] ([IsYeriID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblMusaitOlmayanZaman] CHECK CONSTRAINT [FK_tblMusaitOlmayanZaman_tblIsYeri]
GO
ALTER TABLE [dbo].[tblMusaitOlmayanZaman]  WITH CHECK ADD  CONSTRAINT [FK_tblMusaitOlmayanZaman_tblZaman] FOREIGN KEY([ZamanID])
REFERENCES [dbo].[tblZaman] ([ZamanID])
GO
ALTER TABLE [dbo].[tblMusaitOlmayanZaman] CHECK CONSTRAINT [FK_tblMusaitOlmayanZaman_tblZaman]
GO
ALTER TABLE [dbo].[tblRandevuAlma]  WITH CHECK ADD  CONSTRAINT [FK_tblRandevuAlma_tblIsYeri] FOREIGN KEY([IsYeriID])
REFERENCES [dbo].[tblIsYeri] ([IsYeriID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblRandevuAlma] CHECK CONSTRAINT [FK_tblRandevuAlma_tblIsYeri]
GO
ALTER TABLE [dbo].[tblRandevuAlma]  WITH CHECK ADD  CONSTRAINT [FK_tblRandevuAlma_tblIsYeriYetkilileri] FOREIGN KEY([IsYeriYetkiliID])
REFERENCES [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID])
GO
ALTER TABLE [dbo].[tblRandevuAlma] CHECK CONSTRAINT [FK_tblRandevuAlma_tblIsYeriYetkilileri]
GO
ALTER TABLE [dbo].[tblRandevuAlma]  WITH CHECK ADD  CONSTRAINT [FK_tblRandevuAlma_tblNormalKullanici] FOREIGN KEY([NormalKullaniciID])
REFERENCES [dbo].[tblNormalKullanici] ([NormalKullaniciID])
GO
ALTER TABLE [dbo].[tblRandevuAlma] CHECK CONSTRAINT [FK_tblRandevuAlma_tblNormalKullanici]
GO
ALTER TABLE [dbo].[tblRandevuAlma]  WITH CHECK ADD  CONSTRAINT [FK_tblRandevuAlma_tblZaman] FOREIGN KEY([ZamanID])
REFERENCES [dbo].[tblZaman] ([ZamanID])
GO
ALTER TABLE [dbo].[tblRandevuAlma] CHECK CONSTRAINT [FK_tblRandevuAlma_tblZaman]
GO
ALTER TABLE [dbo].[tblSoruCevap]  WITH CHECK ADD  CONSTRAINT [FK_tblSoruCevap_tblIsYeri] FOREIGN KEY([IsYeriID])
REFERENCES [dbo].[tblIsYeri] ([IsYeriID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSoruCevap] CHECK CONSTRAINT [FK_tblSoruCevap_tblIsYeri]
GO
ALTER TABLE [dbo].[tblSoruCevap]  WITH CHECK ADD  CONSTRAINT [FK_tblSoruCevap_tblIsYeriYetkilileri] FOREIGN KEY([IsYeriYetkiliID])
REFERENCES [dbo].[tblIsYeriYetkilileri] ([IsYeriYetkiliID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSoruCevap] CHECK CONSTRAINT [FK_tblSoruCevap_tblIsYeriYetkilileri]
GO
ALTER TABLE [dbo].[tblSoruCevap]  WITH CHECK ADD  CONSTRAINT [FK_tblSoruCevap_tblNormalKullanici] FOREIGN KEY([NormalKullaniciID])
REFERENCES [dbo].[tblNormalKullanici] ([NormalKullaniciID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSoruCevap] CHECK CONSTRAINT [FK_tblSoruCevap_tblNormalKullanici]
GO
/****** Object:  StoredProcedure [dbo].[sp_CevapGonderme]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_CevapGonderme](
   @yetkiliID int,
   @isim varchar(20),
   @soyisim varchar(20),
   @soru nvarchar(max),
   @cevap nvarchar(max)
)
as
update tblSoruCevap 
set CevaplanmaDurum=1 ,Cevap=@cevap
where SoruCevapID=(select SoruCevapID
					from tblSoruCevap s inner join tblNormalKullanici n 
				    on s.NormalKullaniciID=n.NormalKullaniciID 
					inner join tblIsYeri i on i.IsYeriID=s.IsYeriID 
					where s.SoruCevapID=(select SoruCevapID 
					                    from tblSoruCevap
										where Soru=@soru) 
					and i.IsYeriID=(select IsYeriID
									from tblIsYeri
									where IsYeriYetkiliID=@yetkiliID)
					and n.NormalKullaniciID=(select NormalKullaniciID 
											from tblNormalKullanici
											where Isim=@isim and Soyisim=@soyisim)
					)
GO
/****** Object:  StoredProcedure [dbo].[sp_NormalKullanici_Ekle]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_NormalKullanici_Ekle]
       @kullaniciAdi nvarchar(20)
as
begin
   if exists (select * from tblNormalKullanici where Login_KullaniciAdi=@kullaniciAdi)
       begin
	        print 'Zaten böyle bir kayıt var'
		end
	else
	   begin tran
	       Insert into tblNormalKullanici
		       (
			     Login_KullaniciAdi
			   )
			values
			   (
			      @kullaniciAdi
			   )
end
GO
/****** Object:  StoredProcedure [dbo].[sp_RandevuOnay]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_RandevuOnay](
   @yetkiliID int,
   @isim varchar(20),
   @soyisim varchar(20),
   @tarih date,
   @slot tinyint
)
as
update tblRandevuAlma
set OnayDurum=1
where RandevuID=(select RandevuID 
				from tblRandevuAlma r inner join tblNormalKullanici n 
				on r.NormalKullaniciID=n.NormalKullaniciID
				 inner join tblZaman z on z.ZamanID=r.ZamanID
				 inner join tblIsYeri i on r.IsYeriID=i.IsYeriID
				 where z.ZamanID=(select ZamanID
				 from tblZaman
				 where Tarih=@tarih and Slot=@slot) 
				 and n.NormalKullaniciID=(select NormalKullaniciID 
											from tblNormalKullanici
											where Isim=@isim and Soyisim=@soyisim) 
				 and i.IsYeriID=(select IsYeriID
									from tblIsYeri
									where IsYeriYetkiliID=@yetkiliID)) 
GO
/****** Object:  StoredProcedure [dbo].[sp_RandevuSil]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_RandevuSil](
   @yetkiliID int,
   @isim varchar(20),
   @soyisim varchar(20),
   @tarih date,
   @slot tinyint
)
as
delete 
from tblRandevuAlma
where RandevuID=(select RandevuID 
				from tblRandevuAlma r inner join tblNormalKullanici n 
				on r.NormalKullaniciID=n.NormalKullaniciID
				 inner join tblZaman z on z.ZamanID=r.ZamanID
				 inner join tblIsYeri i on r.IsYeriID=i.IsYeriID
				 where z.ZamanID=(select ZamanID
				 from tblZaman
				 where Tarih=@tarih and Slot=@slot) 
				 and n.NormalKullaniciID=(select NormalKullaniciID 
											from tblNormalKullanici
											where Isim=@isim and Soyisim=@soyisim) 
				 and i.IsYeriID=(select IsYeriID
									from tblIsYeri
									where IsYeriYetkiliID=@yetkiliID)) 
GO
/****** Object:  StoredProcedure [dbo].[sp_randevuTalepEt]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_randevuTalepEt]
( @NormalKullaniciID int,
@IsYeriIsim nvarchar(20),
@tarih date,
@slot tinyint)
AS
declare @isYeriID int
declare @isYeriYetkiliID int
declare @zamanID int

select @zamanID=0
select @zamanID=ZamanID from tblZaman where Slot=@slot And Tarih=@tarih
if(@zamanID>0)
begin
select @isYeriID=i.IsYeriID ,@isYeriYetkiliID=IsYeriYetkiliID
from tblIsYeri i
where i.IsYeriIsmi=@IsYeriIsim
end
else
begin
insert into tblZaman
values( @tarih , @slot)
end
select @isYeriID=i.IsYeriID,@zamanID =z.ZamanID,@isYeriYetkiliID=i.IsYeriYetkiliID
from tblIsYeri i,tblZaman z
where z.Tarih=@tarih and z.Slot=@slot and i.IsYeriIsmi=@IsYeriIsim
insert into tblRandevuAlma(NormalKullaniciID,IsYeriID,OnayDurum,ZamanID,IsYeriYetkiliID)
values(@NormalKullaniciID,@isYeriID,'0',@zamanID,@isYeriYetkiliID)

GO
/****** Object:  StoredProcedure [dbo].[spMusaitOlmayanZaman]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMusaitOlmayanZaman]
( @yetkiliID int,@tarih Date,@baslamaslot int,@bitisslot int)
AS
declare @isyeriID int
declare @bslot int
declare @fslot int
Select @isyeriID=IsYeriID from tblIsYeri where IsYeriYetkiliID=@yetkiliID
select @bslot=@baslamaslot
select @fslot=@bitisslot

while(@bslot<@fslot)
begin
	declare @kayıtlızaman int
	select @kayıtlızaman=0
	select @kayıtlızaman=ZamanID from tblZaman where Slot=@bslot and Tarih=@tarih
	if(@kayıtlızaman>0)
	begin
	insert into tblMusaitOlmayanZaman
	Values (@kayıtlızaman,@isyeriID)
	set @bslot=@bslot+1
	end
	else
	begin
	insert into tblZaman (tarih,Slot)
Values (@tarih,@bslot)
select @kayıtlızaman=ZamanID  from tblZaman where Slot=@bslot and Tarih=@tarih
insert into tblMusaitOlmayanZaman  
Values (@kayıtlızaman,@isyeriID)
set @bslot=@bslot+1
end

end
GO
/****** Object:  StoredProcedure [dbo].[spSoruSor]    Script Date: 11.02.2020 00:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[spSoruSor] ( @IsYeriIsim nvarchar(20),
@Soru nvarchar(MAX),
@CevaplanmaDurum bit,
@NormalKullaniciID int)
AS
declare @IsYeriID int ,@IsYeriYetkiliID int
select @IsYeriID=IsYeriID, @IsYeriYetkiliID=IsYeriYetkiliID from tblIsYeri where IsYeriIsmi=@IsYeriIsim
insert into tblSoruCevap(Soru,CevaplanmaDurum,IsYeriID,NormalKullaniciID,IsYeriYetkiliID)
Values (@Soru,'False',@IsYeriID,@NormalKullaniciID,@IsYeriYetkiliID)
GO
USE [master]
GO
ALTER DATABASE [Randevu] SET  READ_WRITE 
GO



