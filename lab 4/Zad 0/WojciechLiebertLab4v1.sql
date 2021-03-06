USE [master]
GO
/****** Object:  Database [ShopWojciechLiebert]    Script Date: 14.12.2015 00:39:50 ******/
CREATE DATABASE [ShopWojciechLiebert]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Shop.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Shop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Shop_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ShopWojciechLiebert] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopWojciechLiebert].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopWojciechLiebert] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopWojciechLiebert] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopWojciechLiebert] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShopWojciechLiebert] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopWojciechLiebert] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShopWojciechLiebert] SET  MULTI_USER 
GO
ALTER DATABASE [ShopWojciechLiebert] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopWojciechLiebert] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopWojciechLiebert] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopWojciechLiebert] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ShopWojciechLiebert] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ShopWojciechLiebert]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 14.12.2015 00:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Opinion]    Script Date: 14.12.2015 00:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opinion](
	[Id] [int] NOT NULL,
	[OrderId] [int] NULL,
	[OpinionType] [nchar](10) NULL,
	[Opinion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Opinion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order]    Script Date: 14.12.2015 00:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(20,20) NOT NULL,
	[SellerId] [int] NULL,
	[CustomerId] [int] NULL,
	[ProductId] [int] NULL,
	[Amount] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 14.12.2015 00:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [decimal](5, 2) NULL,
	[Weight] [decimal](7, 4) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Seller]    Script Date: 14.12.2015 00:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seller](
	[Id] [int] NOT NULL,
	[SellerName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[BankAccount] [int] NULL,
 CONSTRAINT [PK_Seller] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Customer] ([Id], [UserName], [Email], [Phone]) VALUES (1, N'Artur Waręga', N'skwar4321@gmail.com', 796697796)
INSERT [dbo].[Customer] ([Id], [UserName], [Email], [Phone]) VALUES (2, N'Wojciech Liebert', N'shorti1996@gmail.com', 631136647)
INSERT [dbo].[Customer] ([Id], [UserName], [Email], [Phone]) VALUES (3, N'Alicja Waręga', N'alalal@gmail.com', 412547856)
INSERT [dbo].[Opinion] ([Id], [OrderId], [OpinionType], [Opinion]) VALUES (1, 1, N'POSITIVE  ', N'Super, polecam.')
INSERT [dbo].[Opinion] ([Id], [OrderId], [OpinionType], [Opinion]) VALUES (2, 2, N'POSITIVE  ', N'Super, polecam.')
INSERT [dbo].[Opinion] ([Id], [OrderId], [OpinionType], [Opinion]) VALUES (3, 40, N'POSITIVE  ', N'Super, polecam.')
INSERT [dbo].[Opinion] ([Id], [OrderId], [OpinionType], [Opinion]) VALUES (4, 60, N'NEGATIVE  ', N'Nie polecam.')
INSERT [dbo].[Opinion] ([Id], [OrderId], [OpinionType], [Opinion]) VALUES (5, 20180, N'NEGATIVE  ', N'Nie polecam')
INSERT [dbo].[Opinion] ([Id], [OrderId], [OpinionType], [Opinion]) VALUES (6, 20200, N'NEGATIVE  ', N'Porażka')
INSERT [dbo].[Opinion] ([Id], [OrderId], [OpinionType], [Opinion]) VALUES (7, 20220, N'POSITIVE  ', N'Super, polecam.')
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Id], [SellerId], [CustomerId], [ProductId], [Amount]) VALUES (1, 3, 1, 1, 3)
INSERT [dbo].[Order] ([Id], [SellerId], [CustomerId], [ProductId], [Amount]) VALUES (2, 1, 2, 2, 12)
INSERT [dbo].[Order] ([Id], [SellerId], [CustomerId], [ProductId], [Amount]) VALUES (40, 2, 1, 2, 22)
INSERT [dbo].[Order] ([Id], [SellerId], [CustomerId], [ProductId], [Amount]) VALUES (60, 3, 2, 1, 14)
INSERT [dbo].[Order] ([Id], [SellerId], [CustomerId], [ProductId], [Amount]) VALUES (20180, 1, 3, 1, 3)
INSERT [dbo].[Order] ([Id], [SellerId], [CustomerId], [ProductId], [Amount]) VALUES (20200, 1, 1, 2, 5)
INSERT [dbo].[Order] ([Id], [SellerId], [CustomerId], [ProductId], [Amount]) VALUES (20220, 2, 3, 2, 77)
SET IDENTITY_INSERT [dbo].[Order] OFF
INSERT [dbo].[Product] ([Id], [Name], [Price], [Weight]) VALUES (1, N'Cebula', CAST(2.30 AS Decimal(5, 2)), CAST(0.3000 AS Decimal(7, 4)))
INSERT [dbo].[Product] ([Id], [Name], [Price], [Weight]) VALUES (2, N'Piach', CAST(1.99 AS Decimal(5, 2)), CAST(1.6000 AS Decimal(7, 4)))
INSERT [dbo].[Seller] ([Id], [SellerName], [Email], [BankAccount]) VALUES (1, N'Artur Waręga', N'skwar4321@gmail.com', 123456)
INSERT [dbo].[Seller] ([Id], [SellerName], [Email], [BankAccount]) VALUES (2, N'Wojciech Liebert', N'shorti1996@gmail.com', 654321)
INSERT [dbo].[Seller] ([Id], [SellerName], [Email], [BankAccount]) VALUES (3, N'Alicja Waręga', N'alalal@gmail.com', 787878)
ALTER TABLE [dbo].[Opinion]  WITH CHECK ADD  CONSTRAINT [FK_Opinion_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
GO
ALTER TABLE [dbo].[Opinion] CHECK CONSTRAINT [FK_Opinion_Order]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Order] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Order]
GO
USE [master]
GO
ALTER DATABASE [ShopWojciechLiebert] SET  READ_WRITE 
GO
