USE [devrimme_ramazanBeyDb]
GO
/****** Object:  User [devrimme_RamazanBeyUser]    Script Date: 02/02/2023 11:10:37 ******/
CREATE USER [devrimme_RamazanBeyUser] FOR LOGIN [devrimme_RamazanBeyUser] WITH DEFAULT_SCHEMA=[devrimme_RamazanBeyUser]
GO
ALTER ROLE [db_owner] ADD MEMBER [devrimme_RamazanBeyUser]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [devrimme_RamazanBeyUser]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [devrimme_RamazanBeyUser]
GO
ALTER ROLE [db_datareader] ADD MEMBER [devrimme_RamazanBeyUser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [devrimme_RamazanBeyUser]
GO
/****** Object:  Schema [devrimme_RamazanBeyUser]    Script Date: 02/02/2023 11:10:38 ******/
CREATE SCHEMA [devrimme_RamazanBeyUser]
GO
/****** Object:  Table [devrimme_RamazanBeyUser].[Tbl_Department]    Script Date: 02/02/2023 11:10:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [devrimme_RamazanBeyUser].[Tbl_Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [devrimme_RamazanBeyUser].[Tbl_Employee]    Script Date: 02/02/2023 11:10:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [devrimme_RamazanBeyUser].[Tbl_Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Department_Id] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[DateOfBirth] [datetime] NULL,
	[Gender] [nvarchar](50) NULL,
	[IsMarried] [bit] NULL,
 CONSTRAINT [PK_Tbl_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [devrimme_RamazanBeyUser].[Tbl_User]    Script Date: 02/02/2023 11:10:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [devrimme_RamazanBeyUser].[Tbl_User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ON 

INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (1, N'Acil Servis')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (2, N'Beslenme ve Diyet')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (3, N'Beyin ve Sinir Cerrahisi')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (4, N'Cildiye')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (5, N'Çocuk Sağlığı ve Hastalıkları')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (6, N'Fizik Tedavi ve Rehabilitasyon')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (7, N'Gastroenteroloji')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (8, N'Göğüs Hastalıkları ve Alerji')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (9, N'Endoskopi')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (10, N'Genel Cerrahi')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (11, N'Tıbbi Laboratuvar')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (12, N'Kulak Burun Boğaz (KBB)')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (13, N'Ağız, Çene ve Diş Sağlığı')
INSERT [devrimme_RamazanBeyUser].[Tbl_Department] ([Id], [DepartmentName]) VALUES (14, N'Başhekimlik')
SET IDENTITY_INSERT [devrimme_RamazanBeyUser].[Tbl_Department] OFF
GO
SET IDENTITY_INSERT [devrimme_RamazanBeyUser].[Tbl_Employee] ON 

INSERT [devrimme_RamazanBeyUser].[Tbl_Employee] ([Id], [Department_Id], [Name], [Surname], [DateOfBirth], [Gender], [IsMarried]) VALUES (1, 14, N'Ramazan', N'Akpınar', CAST(N'1990-10-10T00:00:00.000' AS DateTime), N'Erkek', 0)
INSERT [devrimme_RamazanBeyUser].[Tbl_Employee] ([Id], [Department_Id], [Name], [Surname], [DateOfBirth], [Gender], [IsMarried]) VALUES (2, 1, N'Zeynep', N'Aydoğdu', CAST(N'1989-10-10T00:00:00.000' AS DateTime), N'Kadın', 1)
INSERT [devrimme_RamazanBeyUser].[Tbl_Employee] ([Id], [Department_Id], [Name], [Surname], [DateOfBirth], [Gender], [IsMarried]) VALUES (3, 10, N'Burak', N'Koca', CAST(N'1993-01-01T00:00:00.000' AS DateTime), N'Erkek', 1)
SET IDENTITY_INSERT [devrimme_RamazanBeyUser].[Tbl_Employee] OFF
GO
SET IDENTITY_INSERT [devrimme_RamazanBeyUser].[Tbl_User] ON 

INSERT [devrimme_RamazanBeyUser].[Tbl_User] ([Id], [Username], [Password], [Role]) VALUES (1, N'devrimmehmet', N'1923', N'admin')
INSERT [devrimme_RamazanBeyUser].[Tbl_User] ([Id], [Username], [Password], [Role]) VALUES (2, N'ramazanakpinar', N'1990', N'admin')
INSERT [devrimme_RamazanBeyUser].[Tbl_User] ([Id], [Username], [Password], [Role]) VALUES (3, N'sena', N'1999', N'user')
INSERT [devrimme_RamazanBeyUser].[Tbl_User] ([Id], [Username], [Password], [Role]) VALUES (6, N'ramazanakpinaruser', N'1990', N'user')
SET IDENTITY_INSERT [devrimme_RamazanBeyUser].[Tbl_User] OFF
GO
ALTER TABLE [devrimme_RamazanBeyUser].[Tbl_Employee]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Employee_Tbl_Department] FOREIGN KEY([Department_Id])
REFERENCES [devrimme_RamazanBeyUser].[Tbl_Department] ([Id])
GO
ALTER TABLE [devrimme_RamazanBeyUser].[Tbl_Employee] CHECK CONSTRAINT [FK_Tbl_Employee_Tbl_Department]
GO
