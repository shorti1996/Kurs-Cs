USE [master]
GO
/****** Object:  Database [SuperZarcie]    Script Date: 11.01.2016 19:40:43 ******/
CREATE DATABASE [SuperZarcie]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SuperZarcie', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SuperZarcie.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SuperZarcie_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SuperZarcie_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SuperZarcie] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SuperZarcie].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SuperZarcie] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SuperZarcie] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SuperZarcie] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SuperZarcie] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SuperZarcie] SET ARITHABORT OFF 
GO
ALTER DATABASE [SuperZarcie] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SuperZarcie] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SuperZarcie] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SuperZarcie] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SuperZarcie] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SuperZarcie] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SuperZarcie] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SuperZarcie] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SuperZarcie] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SuperZarcie] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SuperZarcie] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SuperZarcie] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SuperZarcie] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SuperZarcie] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SuperZarcie] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SuperZarcie] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SuperZarcie] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SuperZarcie] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SuperZarcie] SET  MULTI_USER 
GO
ALTER DATABASE [SuperZarcie] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SuperZarcie] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SuperZarcie] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SuperZarcie] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SuperZarcie] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SuperZarcie]
GO
/****** Object:  User [RomekKucharz]    Script Date: 11.01.2016 19:40:43 ******/
CREATE USER [RomekKucharz] FOR LOGIN [RomekKucharz] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Box]    Script Date: 11.01.2016 19:40:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Box](
	[Id] [int] NULL,
	[CustomerId] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11.01.2016 19:40:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerGUID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[OrderId] [int] NULL,
 CONSTRAINT [PK_Custome] PRIMARY KEY CLUSTERED 
(
	[CustomerGUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Meal]    Script Date: 11.01.2016 19:40:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order]    Script Date: 11.01.2016 19:40:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[CustomerId] [nvarchar](50) NULL,
	[MealId] [int] NULL,
	[BoxId] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 11.01.2016 19:40:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NULL,
	[UserGUID] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Box] ([Id], [CustomerId]) VALUES (1, N'190aee50-b8c1-45b0-a781-19f10320d0db')
INSERT [dbo].[Box] ([Id], [CustomerId]) VALUES (2, N'21534aa6-3709-49e2-b48f-76a815c82554')
INSERT [dbo].[Box] ([Id], [CustomerId]) VALUES (3, N'36763866-8172-43b7-b902-2e984254bf23')
INSERT [dbo].[Box] ([Id], [CustomerId]) VALUES (4, N'698bd736-694d-416d-852c-49612ede14d0')
INSERT [dbo].[Box] ([Id], [CustomerId]) VALUES (5, N'922eec46-25b1-4c05-b793-a9596c3a81f4')
INSERT [dbo].[Box] ([Id], [CustomerId]) VALUES (7, N'e587f401-5c1d-486b-933e-15f709661880')
INSERT [dbo].[Customer] ([CustomerGUID], [Name], [Surname], [Address], [OrderId]) VALUES (N'190aee50-b8c1-45b0-a781-19f10320d0db', N'adasdsadas', N'asdasd', N'asdasdas', 0)
INSERT [dbo].[Customer] ([CustomerGUID], [Name], [Surname], [Address], [OrderId]) VALUES (N'21534aa6-3709-49e2-b48f-76a815c82554', N'Armur', N'Wardęga', N'daleko', 0)
INSERT [dbo].[Customer] ([CustomerGUID], [Name], [Surname], [Address], [OrderId]) VALUES (N'36763866-8172-43b7-b902-2e984254bf23', N'Zygfryd', N'Kozinoga', N'Zagrodno', 0)
INSERT [dbo].[Customer] ([CustomerGUID], [Name], [Surname], [Address], [OrderId]) VALUES (N'39180519-bd78-48a2-b273-a602f4a751cc', N'Patrycja', N'Suklag', N'LA', 2)
INSERT [dbo].[Customer] ([CustomerGUID], [Name], [Surname], [Address], [OrderId]) VALUES (N'62628bbd-af7e-4e8e-ba38-a4b6bcfd2210', N'Artur', N'Wardęga', N'Kraszowice 666', 1)
INSERT [dbo].[Customer] ([CustomerGUID], [Name], [Surname], [Address], [OrderId]) VALUES (N'698bd736-694d-416d-852c-49612ede14d0', N'Andrzej', N'Bąk', N'gdzieś', 0)
INSERT [dbo].[Customer] ([CustomerGUID], [Name], [Surname], [Address], [OrderId]) VALUES (N'922eec46-25b1-4c05-b793-a9596c3a81f4', N'Wojtek', N'Li', N'blisko', 0)
INSERT [dbo].[Customer] ([CustomerGUID], [Name], [Surname], [Address], [OrderId]) VALUES (N'a890a09d-db19-4247-a930-4388ac5b3dc5', N'1', N'2', N'3', 0)
INSERT [dbo].[Customer] ([CustomerGUID], [Name], [Surname], [Address], [OrderId]) VALUES (N'bbf7608c-613e-4ff2-b6ce-fe43b0d78e07', N'dfs', N'sdfs', N'sfds', 0)
INSERT [dbo].[Customer] ([CustomerGUID], [Name], [Surname], [Address], [OrderId]) VALUES (N'e587f401-5c1d-486b-933e-15f709661880', N'Zbigniew', N'Dwurura', N'Sosnowiec', 0)
SET IDENTITY_INSERT [dbo].[Meal] ON 

INSERT [dbo].[Meal] ([Id], [Name], [Price]) VALUES (1, N'Spaghetti', 10.0000)
INSERT [dbo].[Meal] ([Id], [Name], [Price]) VALUES (2, N'Pizza', 20.0000)
INSERT [dbo].[Meal] ([Id], [Name], [Price]) VALUES (3, N'Sałatka Ceasar', 55.0000)
INSERT [dbo].[Meal] ([Id], [Name], [Price]) VALUES (4, N'Burger', 5.0000)
INSERT [dbo].[Meal] ([Id], [Name], [Price]) VALUES (5, N'Golonka', 20.0000)
INSERT [dbo].[Meal] ([Id], [Name], [Price]) VALUES (6, N'Zapiekanka', 5.0000)
INSERT [dbo].[Meal] ([Id], [Name], [Price]) VALUES (7, N'Boczek w kostkach', 6.0000)
INSERT [dbo].[Meal] ([Id], [Name], [Price]) VALUES (8, N'Tortilla', 12.0000)
SET IDENTITY_INSERT [dbo].[Meal] OFF
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'190aee50-b8c1-45b0-a781-19f10320d0db', 2, 1)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'190aee50-b8c1-45b0-a781-19f10320d0db', 2, 1)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'190aee50-b8c1-45b0-a781-19f10320d0db', 2, 1)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'190aee50-b8c1-45b0-a781-19f10320d0db', 4, 1)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'a890a09d-db19-4247-a930-4388ac5b3dc5', 2, NULL)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'a890a09d-db19-4247-a930-4388ac5b3dc5', 2, NULL)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'bbf7608c-613e-4ff2-b6ce-fe43b0d78e07', 2, NULL)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'bbf7608c-613e-4ff2-b6ce-fe43b0d78e07', 2, NULL)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'21534aa6-3709-49e2-b48f-76a815c82554', 4, 2)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'21534aa6-3709-49e2-b48f-76a815c82554', 4, 2)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'21534aa6-3709-49e2-b48f-76a815c82554', 4, 2)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'922eec46-25b1-4c05-b793-a9596c3a81f4', 1, 5)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'922eec46-25b1-4c05-b793-a9596c3a81f4', 2, 5)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'698bd736-694d-416d-852c-49612ede14d0', 7, 4)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'698bd736-694d-416d-852c-49612ede14d0', 7, 4)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'698bd736-694d-416d-852c-49612ede14d0', 3, 4)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'e587f401-5c1d-486b-933e-15f709661880', 8, 7)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'e587f401-5c1d-486b-933e-15f709661880', 4, 7)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'e587f401-5c1d-486b-933e-15f709661880', 3, 7)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'e587f401-5c1d-486b-933e-15f709661880', 3, 7)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'36763866-8172-43b7-b902-2e984254bf23', 1, 3)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'36763866-8172-43b7-b902-2e984254bf23', 5, 3)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'36763866-8172-43b7-b902-2e984254bf23', 5, 3)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'36763866-8172-43b7-b902-2e984254bf23', 5, 3)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'36763866-8172-43b7-b902-2e984254bf23', 5, 3)
INSERT [dbo].[Order] ([CustomerId], [MealId], [BoxId]) VALUES (N'36763866-8172-43b7-b902-2e984254bf23', 5, 3)
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Login], [Password], [Role], [UserGUID]) VALUES (1, N'Heniek', N'BF3035FEC861E6B58A642C1B701CD3CDEC205535', N'Driver', N'56014687-b7b8-487e-8991-0bf4e1ef7de7')
INSERT [dbo].[User] ([Id], [Login], [Password], [Role], [UserGUID]) VALUES (2, N'Romek', N'4484CC06344978F07389C0B1B59814964CFEEB1D', N'Cook', N'5b494c28-c8af-442e-8580-5c6adfef602c')
INSERT [dbo].[User] ([Id], [Login], [Password], [Role], [UserGUID]) VALUES (3, N'Artur', N'18CC6091CAC7602E183151D360171BEC859D984C', N'Boss', N'46e16af1-a4bb-44b2-a06b-205bf067ef60')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Box]  WITH CHECK ADD  CONSTRAINT [FK_Box_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerGUID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Box] CHECK CONSTRAINT [FK_Box_Customer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerGUID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Meal] FOREIGN KEY([MealId])
REFERENCES [dbo].[Meal] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Meal]
GO
/****** Object:  StoredProcedure [dbo].[insBox]    Script Date: 11.01.2016 19:40:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insBox] @CustomerId nvarchar(50), @BoxId int
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN TRANSACTION;
IF EXISTS (SELECT 1 FROM Box WHERE CustomerId = @CustomerId)
BEGIN
  UPDATE Box
	SET          Id = @BoxId
	WHERE  (CustomerId = @CustomerId)
END
ELSE
BEGIN
	INSERT INTO Box (Id, CustomerId)
	VALUES (@BoxId,@CustomerId)
END
COMMIT TRANSACTION;

GO
/****** Object:  StoredProcedure [dbo].[OrdersToCustomer]    Script Date: 11.01.2016 19:40:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrdersToCustomer]
AS
	SET NOCOUNT ON;
SELECT tableA.CustomerGUID, tableA.Name, tableA.Surname, tableA.Address, tableA.OrderId, tableB.CustomerId
FROM     Customer AS tableA LEFT OUTER JOIN
                      (SELECT CustomerId
                       FROM      [Order] AS tableA
                       GROUP BY CustomerId
                       HAVING  (COUNT(*) > 1)) AS tableB ON tableA.CustomerGUID = tableB.CustomerId
GO
/****** Object:  StoredProcedure [dbo].[SelectLoginAndPassword]    Script Date: 11.01.2016 19:40:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectLoginAndPassword]
AS
	SET NOCOUNT ON;
SELECT Id, Login, Password, Role
FROM     [User]
WHERE  (Login LIKE '%') AND (Password LIKE '%')
GO
/****** Object:  StoredProcedure [dbo].[SelectOrdersToCustomerQuery]    Script Date: 11.01.2016 19:40:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectOrdersToCustomerQuery]
AS
	SET NOCOUNT ON;
SELECT tableA.Name, tableA.Surname, tableA.Address, tableA.CustomerGUID
FROM     Customer AS tableA LEFT OUTER JOIN
                      (SELECT CustomerId
                       FROM      [Order] AS tableA
                       GROUP BY CustomerId
                       HAVING  (COUNT(*) > 1)) AS tableB ON tableA.CustomerGUID = tableB.CustomerId
GO
USE [master]
GO
ALTER DATABASE [SuperZarcie] SET  READ_WRITE 
GO
