# DaoTaoTrucTuyen
# Online-Training-Project
Online Training Project - ASP.NET MVC .NET Framework
# Tutorial
https://www.youtube.com/playlist?list=PLN7LGSL0xSzpJZevSies4nC5Vshn0Jihn

# Database Script
USE [DaoTaoTrucTuyen]
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 7/22/2024 20:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[MetaTitle] [varchar](250) NULL,
	[Code] [varchar](10) NULL,
	[QuestionList] [varchar](200) NULL,
	[AnswerList] [varchar](200) NULL,
	[ProductID] [bigint] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[TotalScore] [smallint] NULL,
	[Time] [smallint] NULL,
	[TotalQuestion] [smallint] NULL,
	[Type] [varchar](1) NULL,
	[Status] [bit] NULL,
	[QuestionEssay] [nvarchar](max) NULL,
	[UserList] [nvarchar](3000) NULL,
	[SoreList] [varchar](200) NULL,
 CONSTRAINT [PK_Exam] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/22/2024 20:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Code] [varchar](10) NULL,
	[MetaTitle] [varchar](250) NULL,
	[Description] [nvarchar](500) NULL,
	[Image] [nvarchar](250) NULL,
	[Price] [decimal](18, 0) NULL,
	[PromotionPrice] [decimal](18, 0) NULL,
	[IncludeVAT] [bit] NULL,
	[Quantity] [int] NULL,
	[CategoryID] [bigint] NULL,
	[Detail] [ntext] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[MetaKeywords] [nvarchar](250) NULL,
	[MetaDescriptions] [nvarchar](250) NULL,
	[Status] [bit] NULL,
	[ViewCount] [int] NULL,
	[LinkVideo] [varchar](50) NULL,
	[ListType] [varchar](250) NULL,
	[ListFile] [nvarchar](3000) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 7/22/2024 20:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MetaTitle] [varchar](250) NULL,
	[ParentID] [bigint] NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Status] [bit] NULL,
	[ShowOnHome] [bit] NULL,
 CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 7/22/2024 20:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](3000) NULL,
	[Content] [nvarchar](max) NULL,
	[Answer] [nvarchar](4000) NULL,
	[Type] [varchar](1) NULL,
	[ProductID] [bigint] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Result]    Script Date: 7/22/2024 20:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[UserID] [bigint] IDENTITY(1,1) NOT NULL,
	[ExamID] [bigint] NOT NULL,
	[ResultQuiz] [varchar](300) NULL,
	[ResultEssay] [nvarchar](max) NULL,
	[StartDateQuiz] [varchar](3000) NULL,
	[StartTimeQuiz] [varchar](20) NULL,
	[FinishDateQuiz] [datetime] NULL,
	[FinishTimeQuiz] [varchar](20) NULL,
	[StartDateEssay] [datetime] NULL,
	[StartTimeEssay] [varchar](20) NULL,
	[FinishTimeEssay] [varchar](20) NULL,
	[Status] [bit] NULL,
	[Score] [varchar](10) NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[ExamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/22/2024 20:12:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [bigint] NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](32) NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](150) NULL,
	[Phone] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Status] [bit] NOT NULL,
	[ProductList] [varchar](250) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (1, N'admin', N'202cb962ac59075b964b07152d234b70', N'Admin', N'Việt Nam', N'admin@test.xyz', NULL, CAST(N'2024-07-12T16:57:20.633' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (2, N'user1', N'202cb962ac59075b964b07152d234b70', N'User1', N'Việt Nam', N'user1@test.xyz', NULL, CAST(N'2024-07-17T23:13:19.750' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (3, N'user2', N'202cb962ac59075b964b07152d234b70', N'User2', N'Việt Nam', N'user2@test.xyz', NULL, CAST(N'2024-07-17T23:18:43.897' AS DateTime), NULL, NULL, 0, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (4, N'user3', N'202cb962ac59075b964b07152d234b70', N'User3', N'Việt Nam', N'user3@test.xyz', NULL, CAST(N'2024-07-21T13:39:00.000' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (5, N'user4', N'202cb962ac59075b964b07152d234b70', N'User4', N'Việt Nam', N'user4@test.xyz', NULL, CAST(N'2024-07-18T10:30:37.473' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (6, N'user5', N'202cb962ac59075b964b07152d234b70', N'User5', N'Việt Nam', N'user5@test.xyz', NULL, CAST(N'2024-07-18T12:44:42.987' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (7, N'user6', N'202cb962ac59075b964b07152d234b70', N'User6', N'Việt Nam', N'user6@test.xyz', NULL, CAST(N'2024-07-18T12:45:05.683' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (8, N'user7', N'202cb962ac59075b964b07152d234b70', N'User7', N'Việt Nam', N'user7@test.xyz', NULL, CAST(N'2024-07-18T12:45:39.217' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (9, N'user8', N'202cb962ac59075b964b07152d234b70', N'User8', N'Việt Nam', N'user8@test.xyz', NULL, CAST(N'2024-07-18T12:45:59.860' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (10, N'user9', N'202cb962ac59075b964b07152d234b70', N'User9', N'Việt Nam', N'user9@test.xyz', NULL, CAST(N'2024-07-18T12:46:28.600' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (11, N'user10', N'202cb962ac59075b964b07152d234b70', N'User10', N'Việt Nam', N'user10@test.xyz', NULL, CAST(N'2024-07-19T19:11:17.463' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (12, N'user11', N'202cb962ac59075b964b07152d234b70', N'User11', N'Việt Nam', N'user11@test.xyz', NULL, CAST(N'2024-07-21T13:31:26.190' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (13, N'user12', N'202cb962ac59075b964b07152d234b70', N'User12', N'Việt Nam', N'user12@test.xyz', NULL, CAST(N'2024-07-21T13:36:54.500' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (14, N'user13', N'202cb962ac59075b964b07152d234b70', N'User13', N'Việt Nam', N'user13@test.xyz', NULL, CAST(N'2024-07-21T13:57:00.000' AS DateTime), NULL, NULL, 1, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [Name], [Address], [Email], [Phone], [CreateDate], [ModifiedDate], [ModifiedBy], [Status], [ProductList]) VALUES (15, N'user14', N'202cb962ac59075b964b07152d234b70', N'User14', N'Việt Nam', N'user14@test.xyz', NULL, CAST(N'2024-07-21T13:58:34.857' AS DateTime), NULL, NULL, 1, NULL)
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ProductCategory] ADD  CONSTRAINT [DF_ProductCategory_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
