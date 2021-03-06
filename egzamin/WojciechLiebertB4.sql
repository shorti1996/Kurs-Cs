USE [WojciechLiebertB4]
GO
/****** Object:  Table [dbo].[ConjuctionTable]    Script Date: 09.02.2016 12:21:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConjuctionTable](
	[LicenseNr] [int] NULL,
	[EvalueeNr] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Egzaminator]    Script Date: 09.02.2016 12:21:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Egzaminator](
	[LicenseNr] [int] NULL,
	[UserName] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Test]    Script Date: 09.02.2016 12:21:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[GroupName] [nvarchar](50) NULL,
	[EvalueeNr] [int] NULL,
	[Result] [nvarchar](50) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[Egzaminator] ([LicenseNr], [UserName]) VALUES (1, N'a')
INSERT [dbo].[Egzaminator] ([LicenseNr], [UserName]) VALUES (2, N'b')
INSERT [dbo].[Test] ([GroupName], [EvalueeNr], [Result]) VALUES (N'a', 1, N'3')
INSERT [dbo].[Test] ([GroupName], [EvalueeNr], [Result]) VALUES (N'b', 2, N'4')
