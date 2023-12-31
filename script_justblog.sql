CREATE DATABASE [JustBlogDb]
GO
USE [JustBlogDb]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[Age] [int] NOT NULL,
	[AboutMe] [nvarchar](max) NULL,
	[Sex] [bit] NOT NULL,
	[UrlFacebook] [nvarchar](max) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[UrlSlug] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[IsDeleted] [bit] NOT NULL,
	[InsertAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[CommentHeader] [nvarchar](max) NULL,
	[CommentText] [nvarchar](max) NULL,
	[CommentTime] [datetime2](7) NOT NULL,
	[PostId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[InsertAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[CommentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posts]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posts](
	[PostId] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[ShortDescription] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[PostContent] [nvarchar](max) NULL,
	[UrlSlug] [nvarchar](max) NULL,
	[Published] [bit] NOT NULL,
	[PublishDate] [datetime2](7) NOT NULL,
	[ViewCount] [int] NOT NULL,
	[RateCount] [int] NOT NULL,
	[Totalrate] [int] NOT NULL,
	[CategoryId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[InsertAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostTags]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostTags](
	[PostId] [uniqueidentifier] NOT NULL,
	[TagId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_PostTags] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC,
	[TagId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 5/21/2023 5:05:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[TagId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[UrlSlug] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Count] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[InsertAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[TagId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211206123745_InitialApp', N'5.0.12')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'A7F098E4-D8F9-43EF-BAD6-65034FDEDC45', N'Contributor', N'CONTRIBUTOR', N'ed7a5be0-237d-42f6-b0a5-358685275653')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'B6812DFE-3F6B-4128-90B3-DE050C5FFF46', N'Blog Owner', N'BLOG OWNER', N'f0f17ded-80b0-4baf-be41-b0f29699baa4')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ED09F0E5-6627-4EE4-94DC-A446B52921B0', N'User', N'USER', N'012c21f7-c342-4f88-94c3-0af3ef96fe43')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'590c7a5d-7c2f-485d-f27a-08d9b894db0a', N'A7F098E4-D8F9-43EF-BAD6-65034FDEDC45')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'590c7a5d-7c2f-485d-f27a-08d9b894db0a', N'B6812DFE-3F6B-4128-90B3-DE050C5FFF46')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'590c7a5d-7c2f-485d-f27a-08d9b894db0a', N'ED09F0E5-6627-4EE4-94DC-A446B52921B0')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Age], [AboutMe], [Sex], [UrlFacebook], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'590c7a5d-7c2f-485d-f27a-08d9b894db0a', 0, NULL, 0, NULL, N'test@gmail.com', N'TEST@GMAIL.COM', N'test@gmail.com', N'TEST@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAELY90+pWj8esXEfaKBnDxvpflRSfxGtA3ywCXlRREccwMRfM5cB70qbe4quz5biOAg==', N'XSH4GERHMS5GC6F4OQD6P62EO5LQWM33', N'7c881424-62e0-4e52-b0b2-0b9500783a9a', NULL, 0, 0, NULL, 0, 0)
GO
INSERT [dbo].[Categories] ([CategoryId], [Name], [UrlSlug], [Description], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'ff85e290-573f-477b-bc75-3afef7acb469', N'Technololy', N'Empty', N'All posts relate to .Net or other.', 0, CAST(N'2021-11-23T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-23T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Categories] ([CategoryId], [Name], [UrlSlug], [Description], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'b20c815f-5f83-449d-9102-c74b4f11db6b', N'Food or Drinks', N'Empty', N'All products relate to Food or Drinks', 0, CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'1f5892a4-d7da-421c-817a-08d9b8d2784a', N'Anonymous', NULL, NULL, NULL, CAST(N'2021-12-06T23:07:15.0332920' AS DateTime2), N'b11d633c-6c67-47aa-8ff5-36f219473a73', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'bdcac4e9-2e6f-459e-817b-08d9b8d2784a', N'Anonymous', NULL, NULL, NULL, CAST(N'2021-12-06T23:07:23.2313929' AS DateTime2), N'b11d633c-6c67-47aa-8ff5-36f219473a73', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'd4dc97e3-3c31-406f-6966-08d9b8d29195', N'Anonymous', NULL, NULL, N'abc', CAST(N'2021-12-06T23:07:57.4675338' AS DateTime2), N'fa680590-599c-4b70-a3ed-3dc42f0a79c6', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'f5498efc-08c4-4b02-6967-08d9b8d29195', N'Anonymous', NULL, NULL, N'abc', CAST(N'2021-12-06T23:08:00.8908513' AS DateTime2), N'fa680590-599c-4b70-a3ed-3dc42f0a79c6', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'2174cc9e-8dbb-4c14-7300-08d9b924917d', N'Anonymous', NULL, NULL, N'abc', CAST(N'2021-12-07T08:54:55.0447859' AS DateTime2), N'b11d633c-6c67-47aa-8ff5-36f219473a73', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'646220ae-1fa9-42e1-8efc-08d9b924fdf3', N'Anonymous', NULL, NULL, N'hảo hảo', CAST(N'2021-12-07T08:57:58.0104470' AS DateTime2), N'fa680590-599c-4b70-a3ed-3dc42f0a79c6', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'f3abed46-34c5-48e0-20c7-08d9b925233a', N'Anonymous', NULL, NULL, N'rất ngon', CAST(N'2021-12-07T08:59:00.5486312' AS DateTime2), N'b11d633c-6c67-47aa-8ff5-36f219473a73', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'a47e5d9a-b61f-428d-4dc7-08d9b98dc483', N'Anonymous', NULL, NULL, N'Hello Trí Bug', CAST(N'2021-12-07T21:27:58.8021623' AS DateTime2), N'b11d633c-6c67-47aa-8ff5-36f219473a73', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'bda163ee-609e-4a6b-733d-08db40e2fc9e', N'Anonymous', NULL, NULL, N'ái xà', CAST(N'2023-04-19T21:33:04.7990483' AS DateTime2), N'fa680590-599c-4b70-a3ed-3dc42f0a79c6', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'dcff144c-4ce2-4a4d-bba8-139790c9fb5b', N'Cá sấu hoa cà', N'mous@example.com', N'For comments', N'Excellent !', CAST(N'2021-10-14T00:00:00.0000000' AS DateTime2), N'6c6f1427-8e1c-4a5a-a53c-5ea5d040e080', 0, CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'a39a34ab-67d0-4c76-9075-238da9cb3fde', N'Cáo ẩn danh', N'mous@example.com', N'For comments', N'hahaha good', CAST(N'2021-10-14T00:00:00.0000000' AS DateTime2), N'fa680590-599c-4b70-a3ed-3dc42f0a79c6', 0, CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'e704b5a7-9609-4d59-80c5-65578c9ed19a', N'Thỏ mũm mĩm', N'mous@example.com', N'For comments', N'Very good', CAST(N'2021-10-14T00:00:00.0000000' AS DateTime2), N'b11d633c-6c67-47aa-8ff5-36f219473a73', 0, CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'afa431cd-f436-4d4b-93a3-6a8d7a596223', N'Chuột chũi đại dương', N'mous@example.com', N'For comments', N'5 stars', CAST(N'2021-10-14T00:00:00.0000000' AS DateTime2), N'2da4df58-d2b8-4442-97c1-6b43e6bb520d', 0, CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'd02d4926-3ad8-47dd-b77c-714c86ab613a', N'Mèo mướp ẩn danh', N'mous@example.com', N'For comments', N'Ngon !', CAST(N'2021-10-14T00:00:00.0000000' AS DateTime2), N'fa680590-599c-4b70-a3ed-3dc42f0a79c6', 0, CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'5d79493f-41a3-4c6f-bba4-d457b1a20696', N'Cá mập biển sâu', N'mous@example.com', N'For comments', N'Yo Yo', CAST(N'2021-10-14T00:00:00.0000000' AS DateTime2), N'96d1d69d-613a-484d-9f31-aac1a65c17d5', 0, CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comments] ([CommentId], [Name], [Email], [CommentHeader], [CommentText], [CommentTime], [PostId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'cab6fb6b-d118-47b2-b862-e06a41c66ab4', N'Sóc nâu', N'mous@example.com', N'For comments', N'Hảo sản phẩm', CAST(N'2021-10-14T00:00:00.0000000' AS DateTime2), N'fa680590-599c-4b70-a3ed-3dc42f0a79c6', 0, CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-25T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Posts] ([PostId], [Title], [ShortDescription], [ImageUrl], [PostContent], [UrlSlug], [Published], [PublishDate], [ViewCount], [RateCount], [Totalrate], [CategoryId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'b11d633c-6c67-47aa-8ff5-36f219473a73', N'Some thing about Coffee #Coffee', N'Coffee is the most drink for people.', N'https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1', N'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?', N'Empty', 1, CAST(N'2021-11-23T00:00:00.0000000' AS DateTime2), 120, 10, 10, N'b20c815f-5f83-449d-9102-c74b4f11db6b', 0, CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Posts] ([PostId], [Title], [ShortDescription], [ImageUrl], [PostContent], [UrlSlug], [Published], [PublishDate], [ViewCount], [RateCount], [Totalrate], [CategoryId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'fa680590-599c-4b70-a3ed-3dc42f0a79c6', N'Some thing about Tea #Tea', N'Tea is the most drink for people.', N'https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1', N'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?', N'Empty', 1, CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2), 120, 10, 10, N'b20c815f-5f83-449d-9102-c74b4f11db6b', 0, CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Posts] ([PostId], [Title], [ShortDescription], [ImageUrl], [PostContent], [UrlSlug], [Published], [PublishDate], [ViewCount], [RateCount], [Totalrate], [CategoryId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'6c6f1427-8e1c-4a5a-a53c-5ea5d040e080', N'Some thing about Milks #Milks', N'Milks is the most drink for people.', N'https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1', N'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?', N'Empty', 1, CAST(N'2021-11-12T00:00:00.0000000' AS DateTime2), 120, 10, 10, N'b20c815f-5f83-449d-9102-c74b4f11db6b', 0, CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Posts] ([PostId], [Title], [ShortDescription], [ImageUrl], [PostContent], [UrlSlug], [Published], [PublishDate], [ViewCount], [RateCount], [Totalrate], [CategoryId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'2da4df58-d2b8-4442-97c1-6b43e6bb520d', N'Some thing about Sting #Drinks', N'Drinks is the most drink for people.', N'https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1', N'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?', N'Empty', 1, CAST(N'2021-11-14T00:00:00.0000000' AS DateTime2), 120, 10, 10, N'b20c815f-5f83-449d-9102-c74b4f11db6b', 0, CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Posts] ([PostId], [Title], [ShortDescription], [ImageUrl], [PostContent], [UrlSlug], [Published], [PublishDate], [ViewCount], [RateCount], [Totalrate], [CategoryId], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'96d1d69d-613a-484d-9f31-aac1a65c17d5', N'Some thing about OngTho #Milks', N'Milks is the most drink for people.', N'https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1', N'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit. Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?', N'Empty', 1, CAST(N'2021-11-16T00:00:00.0000000' AS DateTime2), 5000, 7, 8, N'b20c815f-5f83-449d-9102-c74b4f11db6b', 0, CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-24T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[PostTags] ([PostId], [TagId]) VALUES (N'6c6f1427-8e1c-4a5a-a53c-5ea5d040e080', N'87d23734-54ff-43e3-a4e2-2e05a4384af0')
INSERT [dbo].[PostTags] ([PostId], [TagId]) VALUES (N'6c6f1427-8e1c-4a5a-a53c-5ea5d040e080', N'27e03338-543d-4c60-9ccc-2f8da894980c')
INSERT [dbo].[PostTags] ([PostId], [TagId]) VALUES (N'b11d633c-6c67-47aa-8ff5-36f219473a73', N'732c6995-d666-4b24-b7ff-5e7538f49975')
INSERT [dbo].[PostTags] ([PostId], [TagId]) VALUES (N'fa680590-599c-4b70-a3ed-3dc42f0a79c6', N'e36b9bab-596c-47da-90ca-99999e8881a2')
INSERT [dbo].[PostTags] ([PostId], [TagId]) VALUES (N'2da4df58-d2b8-4442-97c1-6b43e6bb520d', N'e36b9bab-596c-47da-90ca-99999e8881a2')
GO
INSERT [dbo].[Tags] ([TagId], [Name], [UrlSlug], [Description], [Count], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'87d23734-54ff-43e3-a4e2-2e05a4384af0', N'#Milks', N'Empty', N'All tea will be tag #Milks.', 15, 0, CAST(N'2021-11-11T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-15T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Tags] ([TagId], [Name], [UrlSlug], [Description], [Count], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'27e03338-543d-4c60-9ccc-2f8da894980c', N'#Coffees', N'Empty', N'All tea will be tag #Coffees.', 11, 0, CAST(N'2021-10-11T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-15T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Tags] ([TagId], [Name], [UrlSlug], [Description], [Count], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'732c6995-d666-4b24-b7ff-5e7538f49975', N'#Drinks', N'Empty', N'All tea will be tag #Drinks.', 12, 0, CAST(N'2021-11-11T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-15T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Tags] ([TagId], [Name], [UrlSlug], [Description], [Count], [IsDeleted], [InsertAt], [UpdateAt]) VALUES (N'e36b9bab-596c-47da-90ca-99999e8881a2', N'#Teas', N'Empty', N'All tea will be tag #Teas.', 10, 0, CAST(N'2021-11-11T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-15T00:00:00.0000000' AS DateTime2))
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Posts_PostId] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([PostId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Posts_PostId]
GO
ALTER TABLE [dbo].[Posts]  WITH CHECK ADD  CONSTRAINT [FK_Posts_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Posts] CHECK CONSTRAINT [FK_Posts_Categories_CategoryId]
GO
ALTER TABLE [dbo].[PostTags]  WITH CHECK ADD  CONSTRAINT [FK_PostTags_Posts_PostId] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([PostId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PostTags] CHECK CONSTRAINT [FK_PostTags_Posts_PostId]
GO
ALTER TABLE [dbo].[PostTags]  WITH CHECK ADD  CONSTRAINT [FK_PostTags_Tags_TagId] FOREIGN KEY([TagId])
REFERENCES [dbo].[Tags] ([TagId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PostTags] CHECK CONSTRAINT [FK_PostTags_Tags_TagId]
GO
