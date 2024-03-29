USE [MuzickaProdavnica]
GO
ALTER TABLE [dbo].[Izdanje] DROP CONSTRAINT [FK_Izdanje_Zanr]
GO
ALTER TABLE [dbo].[Izdanje] DROP CONSTRAINT [FK_Izdanje_TipIzdanja]
GO
ALTER TABLE [dbo].[Izdanje] DROP CONSTRAINT [FK_Izdanje_Izdavac]
GO
ALTER TABLE [dbo].[Izdanje] DROP CONSTRAINT [FK_Izdanje_Drzava]
GO
/****** Object:  Table [dbo].[Zanr]    Script Date: 26-Jun-19 17:27:26 ******/
DROP TABLE [dbo].[Zanr]
GO
/****** Object:  Table [dbo].[TipIzdanja]    Script Date: 26-Jun-19 17:27:26 ******/
DROP TABLE [dbo].[TipIzdanja]
GO
/****** Object:  Table [dbo].[Izdavac]    Script Date: 26-Jun-19 17:27:26 ******/
DROP TABLE [dbo].[Izdavac]
GO
/****** Object:  Table [dbo].[Izdanje]    Script Date: 26-Jun-19 17:27:26 ******/
DROP TABLE [dbo].[Izdanje]
GO
/****** Object:  Table [dbo].[Drzava]    Script Date: 26-Jun-19 17:27:26 ******/
DROP TABLE [dbo].[Drzava]
GO
USE [master]
GO
/****** Object:  Database [MuzickaProdavnica]    Script Date: 26-Jun-19 17:27:26 ******/
DROP DATABASE [MuzickaProdavnica]
GO
/****** Object:  Database [MuzickaProdavnica]    Script Date: 26-Jun-19 17:27:26 ******/
CREATE DATABASE [MuzickaProdavnica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MuzickaProdavnica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVERDEV\MSSQL\DATA\MuzickaProdavnica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MuzickaProdavnica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVERDEV\MSSQL\DATA\MuzickaProdavnica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MuzickaProdavnica] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MuzickaProdavnica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MuzickaProdavnica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET ARITHABORT OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MuzickaProdavnica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MuzickaProdavnica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MuzickaProdavnica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MuzickaProdavnica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET RECOVERY FULL 
GO
ALTER DATABASE [MuzickaProdavnica] SET  MULTI_USER 
GO
ALTER DATABASE [MuzickaProdavnica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MuzickaProdavnica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MuzickaProdavnica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MuzickaProdavnica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MuzickaProdavnica] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MuzickaProdavnica', N'ON'
GO
ALTER DATABASE [MuzickaProdavnica] SET QUERY_STORE = OFF
GO
USE [MuzickaProdavnica]
GO
/****** Object:  Table [dbo].[Drzava]    Script Date: 26-Jun-19 17:27:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drzava](
	[DrzavaID] [int] IDENTITY(1,1) NOT NULL,
	[NazivDrzave] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Drzava] PRIMARY KEY CLUSTERED 
(
	[DrzavaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Izdanje]    Script Date: 26-Jun-19 17:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Izdanje](
	[IzdanjeID] [int] NOT NULL,
	[TipIzdanja] [int] NOT NULL,
	[Izvodjac] [nvarchar](50) NOT NULL,
	[Album] [nvarchar](50) NOT NULL,
	[Zanr] [int] NOT NULL,
	[Godina] [int] NOT NULL,
	[Izdavac] [int] NOT NULL,
	[Drzava] [int] NOT NULL,
	[Cena] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Izdanje] PRIMARY KEY CLUSTERED 
(
	[IzdanjeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Izdavac]    Script Date: 26-Jun-19 17:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Izdavac](
	[IzdavacID] [int] IDENTITY(1,1) NOT NULL,
	[NazivIzdavaca] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Izdavac] PRIMARY KEY CLUSTERED 
(
	[IzdavacID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipIzdanja]    Script Date: 26-Jun-19 17:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipIzdanja](
	[TipIzdanjaID] [int] IDENTITY(1,1) NOT NULL,
	[NazivTipa] [nvarchar](30) NULL,
 CONSTRAINT [PK_TipIzdanja] PRIMARY KEY CLUSTERED 
(
	[TipIzdanjaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zanr]    Script Date: 26-Jun-19 17:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zanr](
	[ZanrID] [int] IDENTITY(1,1) NOT NULL,
	[NazivZanra] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Zanr] PRIMARY KEY CLUSTERED 
(
	[ZanrID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Drzava] ON 

INSERT [dbo].[Drzava] ([DrzavaID], [NazivDrzave]) VALUES (1, N'Srbija')
INSERT [dbo].[Drzava] ([DrzavaID], [NazivDrzave]) VALUES (2, N'USA')
INSERT [dbo].[Drzava] ([DrzavaID], [NazivDrzave]) VALUES (3, N'Hrvatska')
INSERT [dbo].[Drzava] ([DrzavaID], [NazivDrzave]) VALUES (4, N'Španija')
INSERT [dbo].[Drzava] ([DrzavaID], [NazivDrzave]) VALUES (5, N'Portugal')
INSERT [dbo].[Drzava] ([DrzavaID], [NazivDrzave]) VALUES (6, N'Kanada')
INSERT [dbo].[Drzava] ([DrzavaID], [NazivDrzave]) VALUES (7, N'Švedska')
INSERT [dbo].[Drzava] ([DrzavaID], [NazivDrzave]) VALUES (8, N'Grčka')
INSERT [dbo].[Drzava] ([DrzavaID], [NazivDrzave]) VALUES (9, N'Kuba')
SET IDENTITY_INSERT [dbo].[Drzava] OFF
INSERT [dbo].[Izdanje] ([IzdanjeID], [TipIzdanja], [Izvodjac], [Album], [Zanr], [Godina], [Izdavac], [Drzava], [Cena]) VALUES (111, 1, N'Robbie Williams', N'Escapology', 1, 2002, 7, 2, CAST(800.00 AS Decimal(18, 2)))
INSERT [dbo].[Izdanje] ([IzdanjeID], [TipIzdanja], [Izvodjac], [Album], [Zanr], [Godina], [Izdavac], [Drzava], [Cena]) VALUES (188, 2, N'Azra', N'Azra', 2, 1982, 2, 3, CAST(1300.00 AS Decimal(18, 2)))
INSERT [dbo].[Izdanje] ([IzdanjeID], [TipIzdanja], [Izvodjac], [Album], [Zanr], [Godina], [Izdavac], [Drzava], [Cena]) VALUES (222, 2, N'The Doors', N'The Doors', 2, 1969, 5, 2, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Izdanje] ([IzdanjeID], [TipIzdanja], [Izvodjac], [Album], [Zanr], [Godina], [Izdavac], [Drzava], [Cena]) VALUES (306, 3, N'Phil Collins', N'In The Air Tonight', 6, 1981, 4, 2, CAST(900.00 AS Decimal(18, 2)))
INSERT [dbo].[Izdanje] ([IzdanjeID], [TipIzdanja], [Izvodjac], [Album], [Zanr], [Godina], [Izdavac], [Drzava], [Cena]) VALUES (345, 3, N'vdgdf', N'xcvxcv', 6, 2004, 7, 3, CAST(799.00 AS Decimal(18, 2)))
INSERT [dbo].[Izdanje] ([IzdanjeID], [TipIzdanja], [Izvodjac], [Album], [Zanr], [Godina], [Izdavac], [Drzava], [Cena]) VALUES (353, 3, N'Bob Marley', N'Buffalo Soldier', 9, 1976, 5, 2, CAST(850.00 AS Decimal(18, 2)))
INSERT [dbo].[Izdanje] ([IzdanjeID], [TipIzdanja], [Izvodjac], [Album], [Zanr], [Godina], [Izdavac], [Drzava], [Cena]) VALUES (777, 1, N'dasdas', N'bnbn', 5, 2001, 3, 2, CAST(800.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Izdavac] ON 

INSERT [dbo].[Izdavac] ([IzdavacID], [NazivIzdavaca]) VALUES (1, N'Komuna')
INSERT [dbo].[Izdavac] ([IzdavacID], [NazivIzdavaca]) VALUES (2, N'Croatia Records')
INSERT [dbo].[Izdavac] ([IzdavacID], [NazivIzdavaca]) VALUES (3, N'Columbia Records')
INSERT [dbo].[Izdavac] ([IzdavacID], [NazivIzdavaca]) VALUES (4, N'Epic Records')
INSERT [dbo].[Izdavac] ([IzdavacID], [NazivIzdavaca]) VALUES (5, N'Sunset Sound Recorders')
INSERT [dbo].[Izdavac] ([IzdavacID], [NazivIzdavaca]) VALUES (6, N'City Records')
INSERT [dbo].[Izdavac] ([IzdavacID], [NazivIzdavaca]) VALUES (7, N'EMI Records')
INSERT [dbo].[Izdavac] ([IzdavacID], [NazivIzdavaca]) VALUES (8, N'Jugoton')
SET IDENTITY_INSERT [dbo].[Izdavac] OFF
SET IDENTITY_INSERT [dbo].[TipIzdanja] ON 

INSERT [dbo].[TipIzdanja] ([TipIzdanjaID], [NazivTipa]) VALUES (1, N'CD')
INSERT [dbo].[TipIzdanja] ([TipIzdanjaID], [NazivTipa]) VALUES (2, N'Muzička ploča')
INSERT [dbo].[TipIzdanja] ([TipIzdanjaID], [NazivTipa]) VALUES (3, N'Kaseta')
SET IDENTITY_INSERT [dbo].[TipIzdanja] OFF
SET IDENTITY_INSERT [dbo].[Zanr] ON 

INSERT [dbo].[Zanr] ([ZanrID], [NazivZanra]) VALUES (1, N'Pop')
INSERT [dbo].[Zanr] ([ZanrID], [NazivZanra]) VALUES (2, N'Rock')
INSERT [dbo].[Zanr] ([ZanrID], [NazivZanra]) VALUES (3, N'House')
INSERT [dbo].[Zanr] ([ZanrID], [NazivZanra]) VALUES (4, N'Country')
INSERT [dbo].[Zanr] ([ZanrID], [NazivZanra]) VALUES (5, N'Dance')
INSERT [dbo].[Zanr] ([ZanrID], [NazivZanra]) VALUES (6, N'Pop/Rock')
INSERT [dbo].[Zanr] ([ZanrID], [NazivZanra]) VALUES (7, N'Heavy metal')
INSERT [dbo].[Zanr] ([ZanrID], [NazivZanra]) VALUES (8, N'Jazz')
INSERT [dbo].[Zanr] ([ZanrID], [NazivZanra]) VALUES (9, N'R''N''B')
SET IDENTITY_INSERT [dbo].[Zanr] OFF
ALTER TABLE [dbo].[Izdanje]  WITH CHECK ADD  CONSTRAINT [FK_Izdanje_Drzava] FOREIGN KEY([Drzava])
REFERENCES [dbo].[Drzava] ([DrzavaID])
GO
ALTER TABLE [dbo].[Izdanje] CHECK CONSTRAINT [FK_Izdanje_Drzava]
GO
ALTER TABLE [dbo].[Izdanje]  WITH CHECK ADD  CONSTRAINT [FK_Izdanje_Izdavac] FOREIGN KEY([Izdavac])
REFERENCES [dbo].[Izdavac] ([IzdavacID])
GO
ALTER TABLE [dbo].[Izdanje] CHECK CONSTRAINT [FK_Izdanje_Izdavac]
GO
ALTER TABLE [dbo].[Izdanje]  WITH CHECK ADD  CONSTRAINT [FK_Izdanje_TipIzdanja] FOREIGN KEY([TipIzdanja])
REFERENCES [dbo].[TipIzdanja] ([TipIzdanjaID])
GO
ALTER TABLE [dbo].[Izdanje] CHECK CONSTRAINT [FK_Izdanje_TipIzdanja]
GO
ALTER TABLE [dbo].[Izdanje]  WITH CHECK ADD  CONSTRAINT [FK_Izdanje_Zanr] FOREIGN KEY([Zanr])
REFERENCES [dbo].[Zanr] ([ZanrID])
GO
ALTER TABLE [dbo].[Izdanje] CHECK CONSTRAINT [FK_Izdanje_Zanr]
GO
USE [master]
GO
ALTER DATABASE [MuzickaProdavnica] SET  READ_WRITE 
GO
