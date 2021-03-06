USE [MedicoDb]
GO
ALTER TABLE [dbo].[Horaire] DROP CONSTRAINT [chkDay]
GO
/****** Object:  Index [UKMailClient]    Script Date: 07-11-16 16:20:04 ******/
ALTER TABLE [dbo].[Client] DROP CONSTRAINT [UKMailClient]
GO
/****** Object:  Index [UKClient]    Script Date: 07-11-16 16:20:04 ******/
ALTER TABLE [dbo].[Client] DROP CONSTRAINT [UKClient]
GO
/****** Object:  Table [dbo].[Horaire]    Script Date: 07-11-16 16:20:04 ******/
DROP TABLE [dbo].[Horaire]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 07-11-16 16:20:04 ******/
DROP TABLE [dbo].[Client]
GO
USE [master]
GO
/****** Object:  Database [MedicoDb]    Script Date: 07-11-16 16:20:04 ******/
DROP DATABASE [MedicoDb]
GO
/****** Object:  Database [MedicoDb]    Script Date: 07-11-16 16:20:04 ******/
CREATE DATABASE [MedicoDb];

USE [MedicoDb]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 07-11-16 16:20:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[NomClient] [nvarchar](250) NOT NULL,
	[PrenomClient] [nvarchar](250) NOT NULL,
	[DateNaissance] [date] NOT NULL,
	[TelClient] [nvarchar](12) NOT NULL,
	[MailClient] [nvarchar](256) NULL,
	[RueClient] [nvarchar](250) NOT NULL,
	[VilleClient] [nvarchar](125) NOT NULL,
	[CodePostalClient] [int] NOT NULL,
	[Login] [nvarchar](250) NOT NULL,
	[Password] [nvarchar](256) NOT NULL,
	[Sexe] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Horaire]    Script Date: 07-11-16 16:20:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horaire](
	[IdHoraire] [int] IDENTITY(1,1) NOT NULL,
	[Jour] [nvarchar](8) NOT NULL,
	[DebMat] [time](7) NOT NULL,
	[FinMat] [time](7) NOT NULL,
	[DebAprem] [time](7) NOT NULL,
	[FinAprem] [time](7) NOT NULL,
	[DebDate] [date] NOT NULL,
	[FinDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHoraire] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Client] ON 

GO
INSERT [dbo].[Client] ([IdClient], [NomClient], [PrenomClient], [DateNaissance], [TelClient], [MailClient], [RueClient], [VilleClient], [CodePostalClient], [Login], [Password], [Sexe]) VALUES (1, N'Person', N'Michaël', CAST(0x143C0B00 AS Date), N'0478914707', N'michael.person@cognitic.be', N'Allées des marmottes 12', N'Neuville', 5600, N'Ali', N'Test1234=', 1)
GO
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Horaire] ON 

GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (1, N'Lundi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (2, N'Mardi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (3, N'Mercredi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (4, N'Jeudi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (5, N'Vendredi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (6, N'Samedi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
SET IDENTITY_INSERT [dbo].[Horaire] OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UKClient]    Script Date: 07-11-16 16:20:04 ******/
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [UKClient] UNIQUE NONCLUSTERED 
(
	[NomClient] ASC,
	[PrenomClient] ASC,
	[DateNaissance] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UKMailClient]    Script Date: 07-11-16 16:20:04 ******/
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [UKMailClient] UNIQUE NONCLUSTERED 
(
	[MailClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Horaire]  WITH CHECK ADD  CONSTRAINT [chkDay] CHECK  (([Jour]='Samedi' OR [Jour]='Vendredi' OR [Jour]='Jeudi' OR [Jour]='Mercredi' OR [Jour]='Mardi' OR [Jour]='Lundi'))
GO
ALTER TABLE [dbo].[Horaire] CHECK CONSTRAINT [chkDay]
GO
USE [master]
GO
ALTER DATABASE [MedicoDb] SET  READ_WRITE 
GO
