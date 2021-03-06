USE [master]
GO
/****** Object:  Database [Zad1]    Script Date: 15.12.2015 17:38:51 ******/
CREATE DATABASE [Zad1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Zad1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Zad1.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Zad1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Zad1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Zad1] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Zad1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Zad1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Zad1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Zad1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Zad1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Zad1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Zad1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Zad1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Zad1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Zad1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Zad1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Zad1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Zad1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Zad1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Zad1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Zad1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Zad1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Zad1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Zad1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Zad1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Zad1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Zad1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Zad1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Zad1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Zad1] SET  MULTI_USER 
GO
ALTER DATABASE [Zad1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Zad1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Zad1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Zad1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Zad1] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Zad1]
GO
/****** Object:  Table [dbo].[Accessory]    Script Date: 15.12.2015 17:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Accessory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AccessoryOrder]    Script Date: 15.12.2015 17:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessoryOrder](
	[Id] [int] NOT NULL,
	[OrderedById] [int] NULL,
	[OrderedForId] [int] NULL,
	[Comment] [nvarchar](50) NULL,
	[Amount] [numeric](18, 0) NULL,
	[AccessoryId] [int] NULL,
 CONSTRAINT [PK_AccessoryOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 15.12.2015 17:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Disease] [nvarchar](50) NULL,
 CONSTRAINT [PK_Medicine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MedicineOrder]    Script Date: 15.12.2015 17:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicineOrder](
	[Id] [int] NOT NULL,
	[OrderedById] [int] NULL,
	[Amount] [numeric](18, 0) NULL,
	[MedicineId] [int] NULL,
 CONSTRAINT [PK_MedicineOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Owner]    Script Date: 15.12.2015 17:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Owner](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
 CONSTRAINT [PK_Owner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payment]    Script Date: 15.12.2015 17:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Id] [int] NOT NULL,
	[VisitId] [int] NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pet]    Script Date: 15.12.2015 17:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pet](
	[Id] [int] NOT NULL,
	[OwnerId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[BirthDate] [date] NULL,
	[Type] [nvarchar](50) NULL,
	[Species] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salary]    Script Date: 15.12.2015 17:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[Id] [int] NOT NULL,
	[VetID] [int] NULL,
	[Money] [money] NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vet]    Script Date: 15.12.2015 17:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vet](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
 CONSTRAINT [PK_Vet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Visit]    Script Date: 15.12.2015 17:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[Id] [int] NOT NULL,
	[Reason] [nvarchar](50) NULL,
	[PetId] [int] NULL,
	[VetId] [int] NULL,
 CONSTRAINT [PK_Visit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Accessory] ([Id], [Name], [Price]) VALUES (1, N'Dog food', 10.0000)
INSERT [dbo].[Accessory] ([Id], [Name], [Price]) VALUES (2, N'Cat litter', 15.0000)
INSERT [dbo].[Accessory] ([Id], [Name], [Price]) VALUES (3, N'Cat food', 11.0000)
INSERT [dbo].[Accessory] ([Id], [Name], [Price]) VALUES (4, N'Dog boomerang', 6.0000)
INSERT [dbo].[Accessory] ([Id], [Name], [Price]) VALUES (5, N'Rodent food', 5.0000)
INSERT [dbo].[Owner] ([Id], [Name], [Surname]) VALUES (1, N'Jan', N'Kowalski')
INSERT [dbo].[Owner] ([Id], [Name], [Surname]) VALUES (2, N'Jerzy', N'Szumilewicz')
INSERT [dbo].[Owner] ([Id], [Name], [Surname]) VALUES (3, N'Alicja', N'Wardęga')
INSERT [dbo].[Payment] ([Id], [VisitId], [Price]) VALUES (1, 1, 50.0000)
INSERT [dbo].[Payment] ([Id], [VisitId], [Price]) VALUES (2, 2, 20.0000)
INSERT [dbo].[Payment] ([Id], [VisitId], [Price]) VALUES (3, 3, 100.0000)
INSERT [dbo].[Payment] ([Id], [VisitId], [Price]) VALUES (4, 4, 5.0000)
INSERT [dbo].[Payment] ([Id], [VisitId], [Price]) VALUES (5, 5, 8.0000)
INSERT [dbo].[Pet] ([Id], [OwnerId], [Name], [BirthDate], [Type], [Species]) VALUES (1, 2, N'Mania', CAST(N'1996-07-01' AS Date), N'Cow', N'Asturian Mountain')
INSERT [dbo].[Pet] ([Id], [OwnerId], [Name], [BirthDate], [Type], [Species]) VALUES (2, 1, N'Szarik', CAST(N'1966-09-25' AS Date), N'Dog', N'German Shepherd')
INSERT [dbo].[Pet] ([Id], [OwnerId], [Name], [BirthDate], [Type], [Species]) VALUES (3, 3, N'Mruczek', CAST(N'2012-11-11' AS Date), N'Cat', N'Maine Coon')
INSERT [dbo].[Pet] ([Id], [OwnerId], [Name], [BirthDate], [Type], [Species]) VALUES (4, 3, N'Puszek', CAST(N'2013-12-11' AS Date), N'Cat', N'British Longhair')
INSERT [dbo].[Vet] ([Id], [Name], [Surname]) VALUES (1, N'Artur', N'Walęga')
INSERT [dbo].[Vet] ([Id], [Name], [Surname]) VALUES (2, N'Wojciech', N'Liebert')
INSERT [dbo].[Vet] ([Id], [Name], [Surname]) VALUES (3, N'Patrycja', N'Gałkus')
INSERT [dbo].[Vet] ([Id], [Name], [Surname]) VALUES (4, N'Michał', N'Pasierbiewicz')
INSERT [dbo].[Visit] ([Id], [Reason], [PetId], [VetId]) VALUES (1, N'Sore tooth', 3, 1)
INSERT [dbo].[Visit] ([Id], [Reason], [PetId], [VetId]) VALUES (2, N'Teary eyes', 4, 3)
INSERT [dbo].[Visit] ([Id], [Reason], [PetId], [VetId]) VALUES (3, N'Udders issue', 1, 2)
INSERT [dbo].[Visit] ([Id], [Reason], [PetId], [VetId]) VALUES (4, N'Cutting the claws', 4, 1)
INSERT [dbo].[Visit] ([Id], [Reason], [PetId], [VetId]) VALUES (5, N'Nothing special', 2, 4)
ALTER TABLE [dbo].[AccessoryOrder]  WITH CHECK ADD  CONSTRAINT [FK_AccessoryOrder_Accessory] FOREIGN KEY([AccessoryId])
REFERENCES [dbo].[Accessory] ([Id])
GO
ALTER TABLE [dbo].[AccessoryOrder] CHECK CONSTRAINT [FK_AccessoryOrder_Accessory]
GO
ALTER TABLE [dbo].[AccessoryOrder]  WITH CHECK ADD  CONSTRAINT [FK_AccessoryOrder_Owner] FOREIGN KEY([OrderedForId])
REFERENCES [dbo].[Owner] ([Id])
GO
ALTER TABLE [dbo].[AccessoryOrder] CHECK CONSTRAINT [FK_AccessoryOrder_Owner]
GO
ALTER TABLE [dbo].[AccessoryOrder]  WITH CHECK ADD  CONSTRAINT [FK_AccessoryOrder_Vet] FOREIGN KEY([OrderedById])
REFERENCES [dbo].[Vet] ([Id])
GO
ALTER TABLE [dbo].[AccessoryOrder] CHECK CONSTRAINT [FK_AccessoryOrder_Vet]
GO
ALTER TABLE [dbo].[MedicineOrder]  WITH CHECK ADD  CONSTRAINT [FK_MedicineOrder_Medicine] FOREIGN KEY([MedicineId])
REFERENCES [dbo].[Medicine] ([Id])
GO
ALTER TABLE [dbo].[MedicineOrder] CHECK CONSTRAINT [FK_MedicineOrder_Medicine]
GO
ALTER TABLE [dbo].[MedicineOrder]  WITH CHECK ADD  CONSTRAINT [FK_MedicineOrder_Vet] FOREIGN KEY([OrderedById])
REFERENCES [dbo].[Vet] ([Id])
GO
ALTER TABLE [dbo].[MedicineOrder] CHECK CONSTRAINT [FK_MedicineOrder_Vet]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Visit] FOREIGN KEY([VisitId])
REFERENCES [dbo].[Visit] ([Id])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Visit]
GO
ALTER TABLE [dbo].[Pet]  WITH CHECK ADD  CONSTRAINT [FK_Pet_Owner] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Owner] ([Id])
GO
ALTER TABLE [dbo].[Pet] CHECK CONSTRAINT [FK_Pet_Owner]
GO
ALTER TABLE [dbo].[Vet]  WITH NOCHECK ADD  CONSTRAINT [FK_Vet_Salary] FOREIGN KEY([Id])
REFERENCES [dbo].[Salary] ([Id])
GO
ALTER TABLE [dbo].[Vet] NOCHECK CONSTRAINT [FK_Vet_Salary]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Pet] FOREIGN KEY([PetId])
REFERENCES [dbo].[Pet] ([Id])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Pet]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Vet] FOREIGN KEY([VetId])
REFERENCES [dbo].[Vet] ([Id])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Vet]
GO
USE [master]
GO
ALTER DATABASE [Zad1] SET  READ_WRITE 
GO
