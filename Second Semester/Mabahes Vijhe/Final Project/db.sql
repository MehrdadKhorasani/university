USE [master]
GO
/****** Object:  Database [Library]    Script Date: 1/31/2025 2:48:38 PM ******/
CREATE DATABASE [Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Library] SET  MULTI_USER 
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Library] SET QUERY_STORE = ON
GO
ALTER DATABASE [Library] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Library]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 1/31/2025 2:48:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 1/31/2025 2:48:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BNo] [nchar](10) NOT NULL,
	[BStandardCode] [nchar](10) NULL,
	[BTitle] [nvarchar](70) NULL,
	[BOName] [nchar](20) NULL,
	[BOLName] [nchar](30) NULL,
	[BOName2] [nchar](20) NULL,
	[BOLName2] [nchar](30) NULL,
	[BPublisher] [nchar](30) NULL,
	[BTName1] [nchar](20) NULL,
	[BTLName1] [nchar](20) NULL,
	[BTName2] [nchar](20) NULL,
	[BTLName2] [nchar](30) NULL,
	[BPyear] [nchar](5) NULL,
	[BPRice] [decimal](20, 2) NULL,
	[BCNT] [smallint] NULL,
	[BISBN] [nchar](20) NULL,
	[BCCNT] [smallint] NULL,
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrow]    Script Date: 1/31/2025 2:48:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrow](
	[BRNo] [bigint] IDENTITY(10000,1) NOT NULL,
	[MNo] [nchar](10) NULL,
	[BNo] [nchar](10) NULL,
	[BSdate] [datetime] NULL,
	[BEDate] [datetime] NULL,
	[BRRDate] [datetime] NULL,
	[BFine] [decimal](20, 2) NULL,
	[BRRET] [char](10) NULL,
 CONSTRAINT [PK_Borrow] PRIMARY KEY CLUSTERED 
(
	[BRNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 1/31/2025 2:48:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MNCode] [nchar](10) NOT NULL,
	[MName] [nchar](20) NOT NULL,
	[MLastName] [nchar](30) NOT NULL,
	[MStartDate] [datetime] NULL,
	[MExpireDate] [datetime] NULL,
	[MBMax] [tinyint] NULL,
	[MBirthDate] [datetime] NULL,
	[MAddress] [nvarchar](100) NULL,
	[MTelNo] [nchar](11) NULL,
	[MPostCode] [nchar](10) NULL,
	[MFatherName] [nchar](20) NULL,
	[MDebt] [decimal](20, 2) NULL,
	[MState] [tinyint] NULL,
	[MNo] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserve]    Script Date: 1/31/2025 2:48:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserve](
	[RNo] [int] IDENTITY(1,1) NOT NULL,
	[BNo] [nchar](10) NOT NULL,
	[MNo] [int] NOT NULL,
	[nearestDate] [date] NOT NULL,
	[isBorrowed] [nvarchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([Username], [Password]) VALUES (N'admin', N'1234')
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([BNo], [BStandardCode], [BTitle], [BOName], [BOLName], [BOName2], [BOLName2], [BPublisher], [BTName1], [BTLName1], [BTName2], [BTLName2], [BPyear], [BPRice], [BCNT], [BISBN], [BCCNT], [AutoID]) VALUES (N'002       ', N'1500      ', N'1', N'1                   ', N'1                             ', N'1                   ', N'1                             ', N'1                             ', N'1                   ', N'1                   ', N'1                   ', N'1                             ', N'1    ', CAST(1.00 AS Decimal(20, 2)), 1, N'1                   ', 0, 2)
INSERT [dbo].[Book] ([BNo], [BStandardCode], [BTitle], [BOName], [BOLName], [BOName2], [BOLName2], [BPublisher], [BTName1], [BTLName1], [BTName2], [BTLName2], [BPyear], [BPRice], [BCNT], [BISBN], [BCCNT], [AutoID]) VALUES (N'005       ', N'9966      ', N'کتاب جدید', N'علی                 ', N'علوی                          ', N'احسان               ', N'مظفری                         ', N'بهرام                         ', N'ثانی                ', N'-                   ', N'-                   ', N'نشر کاج                       ', N'1999 ', CAST(1900.00 AS Decimal(20, 2)), 2500, N'5                   ', 0, 5)
INSERT [dbo].[Book] ([BNo], [BStandardCode], [BTitle], [BOName], [BOLName], [BOName2], [BOLName2], [BPublisher], [BTName1], [BTLName1], [BTName2], [BTLName2], [BPyear], [BPRice], [BCNT], [BISBN], [BCCNT], [AutoID]) VALUES (N'006       ', N'123456    ', N'درس', N'رس                  ', N'درد                           ', N'سیبسی               ', N'مکتا                          ', N'اکتاا                         ', N'مامامانک            ', N'کاماام              ', N'اککماام             ', N'الذل                          ', N'2019 ', CAST(95000.00 AS Decimal(20, 2)), 1000, N'3                   ', 0, 6)
INSERT [dbo].[Book] ([BNo], [BStandardCode], [BTitle], [BOName], [BOLName], [BOName2], [BOLName2], [BPublisher], [BTName1], [BTLName1], [BTName2], [BTLName2], [BPyear], [BPRice], [BCNT], [BISBN], [BCCNT], [AutoID]) VALUES (N'007       ', N'9999999   ', N'کتاب جدبد', N'نویس                ', N'نواس                          ', N'-                   ', N'-                             ', N'علی                           ', N'مهدوی               ', N'-                   ', N'-                   ', N'قدس                           ', N'2018 ', CAST(9800.00 AS Decimal(20, 2)), 3, N'1000                ', 1, 7)
INSERT [dbo].[Book] ([BNo], [BStandardCode], [BTitle], [BOName], [BOLName], [BOName2], [BOLName2], [BPublisher], [BTName1], [BTLName1], [BTName2], [BTLName2], [BPyear], [BPRice], [BCNT], [BISBN], [BCCNT], [AutoID]) VALUES (N'010       ', N'199155    ', N'jj', N'jj                  ', N'jj                            ', N'jj                  ', N'jj                            ', N'jj                            ', N'jj                  ', N'jj                  ', N'jj                  ', N'jj                            ', N'1999 ', CAST(99.00 AS Decimal(20, 2)), 5, N'5000                ', 4, 10)
INSERT [dbo].[Book] ([BNo], [BStandardCode], [BTitle], [BOName], [BOLName], [BOName2], [BOLName2], [BPublisher], [BTName1], [BTLName1], [BTName2], [BTLName2], [BPyear], [BPRice], [BCNT], [BISBN], [BCCNT], [AutoID]) VALUES (N'011       ', N'7372334   ', N'راز مگو', N'علیرضا              ', N'اسفندیاری                     ', N'-                   ', N'-                             ', N'-                             ', N'-                   ', N'-                   ', N'-                   ', N'زیرابی                        ', N'2009 ', CAST(75000.00 AS Decimal(20, 2)), 3, N'2000                ', 2, 11)
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[Borrow] ON 

INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10000, N'3         ', N'006       ', CAST(N'2025-01-27T22:01:21.097' AS DateTime), CAST(N'2025-03-19T22:01:21.000' AS DateTime), CAST(N'2025-01-28T09:09:55.490' AS DateTime), CAST(2000.00 AS Decimal(20, 2)), N'Yes       ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10001, N'3         ', N'002       ', CAST(N'2025-01-27T22:01:21.097' AS DateTime), CAST(N'2025-02-17T22:01:21.000' AS DateTime), CAST(N'2025-01-28T08:57:58.140' AS DateTime), CAST(0.00 AS Decimal(20, 2)), N'Yes       ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10002, N'3         ', N'006       ', CAST(N'2025-01-07T10:20:18.000' AS DateTime), CAST(N'2025-01-14T10:20:18.000' AS DateTime), NULL, CAST(0.00 AS Decimal(20, 2)), N'No        ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10003, N'4         ', N'006       ', CAST(N'2025-01-28T12:47:57.543' AS DateTime), CAST(N'2025-02-04T12:47:57.000' AS DateTime), NULL, CAST(0.00 AS Decimal(20, 2)), N'No        ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10004, N'4         ', N'005       ', CAST(N'2025-01-28T12:47:57.543' AS DateTime), CAST(N'2025-03-04T12:47:57.000' AS DateTime), CAST(N'2025-01-28T12:51:16.010' AS DateTime), CAST(0.00 AS Decimal(20, 2)), N'Yes       ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10005, N'1         ', N'005       ', CAST(N'2025-01-28T12:51:54.240' AS DateTime), CAST(N'2025-02-04T12:51:54.000' AS DateTime), NULL, CAST(0.00 AS Decimal(20, 2)), N'No        ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10006, N'1         ', N'005       ', CAST(N'2024-12-03T12:52:14.000' AS DateTime), CAST(N'2025-01-20T12:52:14.000' AS DateTime), CAST(N'2025-01-31T12:21:29.220' AS DateTime), CAST(0.00 AS Decimal(20, 2)), N'Yes       ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10007, N'3         ', N'6         ', CAST(N'2025-01-28T16:20:12.610' AS DateTime), CAST(N'2025-02-11T16:20:12.610' AS DateTime), NULL, CAST(0.00 AS Decimal(20, 2)), N'No        ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10008, N'1         ', N'6         ', CAST(N'2022-01-28T08:51:54.240' AS DateTime), CAST(N'2023-01-28T12:51:54.240' AS DateTime), NULL, CAST(0.00 AS Decimal(20, 2)), N'No        ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10009, N'5         ', N'007       ', CAST(N'2025-01-30T20:11:17.077' AS DateTime), CAST(N'2025-01-31T20:11:17.000' AS DateTime), NULL, CAST(0.00 AS Decimal(20, 2)), N'No        ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10010, N'5         ', N'005       ', CAST(N'2025-01-23T20:11:50.000' AS DateTime), CAST(N'2025-01-29T20:11:50.000' AS DateTime), NULL, CAST(0.00 AS Decimal(20, 2)), N'No        ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10011, N'5         ', N'005       ', CAST(N'2025-01-02T20:12:36.000' AS DateTime), CAST(N'2025-01-03T20:12:36.000' AS DateTime), CAST(N'2025-01-30T20:24:09.667' AS DateTime), CAST(1000.00 AS Decimal(20, 2)), N'Yes       ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10012, N'4         ', N'007       ', CAST(N'2025-01-30T20:21:44.653' AS DateTime), CAST(N'2025-01-30T20:21:44.637' AS DateTime), NULL, CAST(0.00 AS Decimal(20, 2)), N'No        ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10013, N'7         ', N'010       ', CAST(N'2025-01-04T22:41:23.000' AS DateTime), CAST(N'2025-01-11T22:41:23.000' AS DateTime), NULL, CAST(0.00 AS Decimal(20, 2)), N'No        ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10014, N'3         ', N'6         ', CAST(N'2025-01-31T00:44:33.790' AS DateTime), CAST(N'2025-02-14T00:44:33.790' AS DateTime), CAST(N'2025-01-31T12:14:15.627' AS DateTime), CAST(0.00 AS Decimal(20, 2)), N'Yes       ')
INSERT [dbo].[Borrow] ([BRNo], [MNo], [BNo], [BSdate], [BEDate], [BRRDate], [BFine], [BRRET]) VALUES (10015, N'8         ', N'011       ', CAST(N'2024-12-31T12:01:16.000' AS DateTime), CAST(N'2025-01-01T12:01:16.000' AS DateTime), NULL, CAST(0.00 AS Decimal(20, 2)), N'No        ')
SET IDENTITY_INSERT [dbo].[Borrow] OFF
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MNCode], [MName], [MLastName], [MStartDate], [MExpireDate], [MBMax], [MBirthDate], [MAddress], [MTelNo], [MPostCode], [MFatherName], [MDebt], [MState], [MNo]) VALUES (N'1111      ', N'سید احسان           ', N'فرقانی                        ', CAST(N'2022-05-08T00:00:00.000' AS DateTime), CAST(N'2024-05-08T00:00:00.000' AS DateTime), 5, CAST(N'2000-01-03T00:00:00.000' AS DateTime), N'وکیل اباد', N'03988554   ', N'10001121  ', N'هادی                ', CAST(0.00 AS Decimal(20, 2)), 1, 1)
INSERT [dbo].[Member] ([MNCode], [MName], [MLastName], [MStartDate], [MExpireDate], [MBMax], [MBirthDate], [MAddress], [MTelNo], [MPostCode], [MFatherName], [MDebt], [MState], [MNo]) VALUES (N'9876      ', N'احمدرضا             ', N'سینایی                        ', CAST(N'2006-05-12T00:00:00.000' AS DateTime), CAST(N'2024-05-04T00:00:00.000' AS DateTime), 3, CAST(N'1996-08-09T00:00:00.000' AS DateTime), N'مشهد - وکیل آباد - صارمی', N'0924545454 ', N'44646     ', N'رضا                 ', CAST(2000.00 AS Decimal(20, 2)), 3, 3)
INSERT [dbo].[Member] ([MNCode], [MName], [MLastName], [MStartDate], [MExpireDate], [MBMax], [MBirthDate], [MAddress], [MTelNo], [MPostCode], [MFatherName], [MDebt], [MState], [MNo]) VALUES (N'8558      ', N'مهرداد              ', N'خراسانی                       ', CAST(N'2021-05-08T00:00:00.000' AS DateTime), CAST(N'2026-05-02T00:00:00.000' AS DateTime), 2, CAST(N'1996-09-03T00:00:00.000' AS DateTime), N'مشهد - صارمی', N'093262545  ', N'86565233  ', N'رضا                 ', CAST(0.00 AS Decimal(20, 2)), 1, 4)
INSERT [dbo].[Member] ([MNCode], [MName], [MLastName], [MStartDate], [MExpireDate], [MBMax], [MBirthDate], [MAddress], [MTelNo], [MPostCode], [MFatherName], [MDebt], [MState], [MNo]) VALUES (N'655644221 ', N'کاربر               ', N'جدید                          ', CAST(N'2023-05-01T00:00:00.000' AS DateTime), CAST(N'2024-05-06T00:00:00.000' AS DateTime), 3, CAST(N'1996-03-11T00:00:00.000' AS DateTime), N'مشهد', N'0999632555 ', N'879785    ', N'احمد                ', CAST(1000.00 AS Decimal(20, 2)), 3, 5)
INSERT [dbo].[Member] ([MNCode], [MName], [MLastName], [MStartDate], [MExpireDate], [MBMax], [MBirthDate], [MAddress], [MTelNo], [MPostCode], [MFatherName], [MDebt], [MState], [MNo]) VALUES (N'195648    ', N'ff                  ', N'ff                            ', CAST(N'2013-09-01T00:00:00.000' AS DateTime), CAST(N'2028-05-03T00:00:00.000' AS DateTime), 12, CAST(N'2000-02-02T00:00:00.000' AS DateTime), N'fdsfs', N'98765421   ', N'798465123 ', N'jfj                 ', CAST(0.00 AS Decimal(20, 2)), 1, 7)
INSERT [dbo].[Member] ([MNCode], [MName], [MLastName], [MStartDate], [MExpireDate], [MBMax], [MBirthDate], [MAddress], [MTelNo], [MPostCode], [MFatherName], [MDebt], [MState], [MNo]) VALUES (N'737       ', N'یاسمین              ', N'فراستی                        ', CAST(N'2021-06-03T00:00:00.000' AS DateTime), CAST(N'2029-03-03T00:00:00.000' AS DateTime), 5, CAST(N'2000-01-01T00:00:00.000' AS DateTime), N'خیام جنوبی 20', N'99885544   ', N'7755884   ', N'مسعود               ', CAST(-1000.00 AS Decimal(20, 2)), 1, 8)
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[Reserve] ON 

INSERT [dbo].[Reserve] ([RNo], [BNo], [MNo], [nearestDate], [isBorrowed]) VALUES (1, N'006       ', 3, CAST(N'2025-02-04' AS Date), N'Yes')
INSERT [dbo].[Reserve] ([RNo], [BNo], [MNo], [nearestDate], [isBorrowed]) VALUES (2, N'006       ', 3, CAST(N'2025-02-04' AS Date), N'Yes')
INSERT [dbo].[Reserve] ([RNo], [BNo], [MNo], [nearestDate], [isBorrowed]) VALUES (5, N'006       ', 1, CAST(N'2025-02-04' AS Date), N'Yes')
INSERT [dbo].[Reserve] ([RNo], [BNo], [MNo], [nearestDate], [isBorrowed]) VALUES (8, N'005       ', 8, CAST(N'2025-02-04' AS Date), N'No')
SET IDENTITY_INSERT [dbo].[Reserve] OFF
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_BNo]  DEFAULT ('001') FOR [BNo]
GO
ALTER TABLE [dbo].[Borrow] ADD  CONSTRAINT [DF_Borrow_BFine]  DEFAULT ((0)) FOR [BFine]
GO
ALTER TABLE [dbo].[Reserve]  WITH CHECK ADD FOREIGN KEY([BNo])
REFERENCES [dbo].[Book] ([BNo])
GO
ALTER TABLE [dbo].[Reserve]  WITH CHECK ADD FOREIGN KEY([MNo])
REFERENCES [dbo].[Member] ([MNo])
GO
ALTER TABLE [dbo].[Reserve]  WITH CHECK ADD CHECK  (([isBorrowed]='No' OR [isBorrowed]='Yes'))
GO
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
