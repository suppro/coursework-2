USE [master]
GO
/****** Object:  Database [ARUDB]    Script Date: 23.11.2020 19:59:22 ******/
CREATE DATABASE [ARUDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ARUDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ARUDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ARUDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ARUDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ARUDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ARUDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ARUDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ARUDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ARUDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ARUDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ARUDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ARUDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ARUDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ARUDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ARUDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ARUDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ARUDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ARUDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ARUDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ARUDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ARUDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ARUDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ARUDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ARUDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ARUDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ARUDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ARUDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ARUDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ARUDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ARUDB] SET  MULTI_USER 
GO
ALTER DATABASE [ARUDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ARUDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ARUDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ARUDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ARUDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ARUDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ARUDB', N'ON'
GO
ALTER DATABASE [ARUDB] SET QUERY_STORE = OFF
GO
USE [ARUDB]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 23.11.2020 19:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[surname] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[patronymic] [varchar](50) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deceased]    Script Date: 23.11.2020 19:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deceased](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deceased_status_id] [int] NULL,
	[name] [varchar](50) NOT NULL,
	[surname] [varchar](50) NOT NULL,
	[patronymic] [varchar](50) NULL,
	[birth_date] [date] NOT NULL,
	[death_date] [date] NOT NULL,
 CONSTRAINT [PK_Deceased] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeceasedStatus]    Script Date: 23.11.2020 19:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeceasedStatus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deceased_status] [varchar](50) NULL,
 CONSTRAINT [PK_DeceasedStatus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 23.11.2020 19:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[position_id] [int] NOT NULL,
	[surname] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[patronymic] [varchar](50) NOT NULL,
	[login] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[age] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grave]    Script Date: 23.11.2020 19:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grave](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[gravestatus_id] [int] NOT NULL,
	[grave_number] [int] NOT NULL,
 CONSTRAINT [PK_Grave] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GraveStatus]    Script Date: 23.11.2020 19:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GraveStatus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[status_value] [varchar](50) NOT NULL,
 CONSTRAINT [PK_GraveStatus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 23.11.2020 19:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NOT NULL,
	[client_id] [int] NOT NULL,
	[order_num] [int] NOT NULL,
	[order_sum] [int] NOT NULL,
	[order_date] [date] NOT NULL,
	[parts_order] [int] NOT NULL,
	[added_parts] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Grave]    Script Date: 23.11.2020 19:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Grave](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deceased_id] [int] NOT NULL,
	[status_id] [int] NOT NULL,
	[order_id] [int] NOT NULL,
	[grave_id] [int] NOT NULL,
	[burial_date] [date] NOT NULL,
 CONSTRAINT [PK_Order_Grave] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 23.11.2020 19:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[position_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 23.11.2020 19:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[status_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([id], [surname], [name], [patronymic]) VALUES (1, N'Денисов', N'Олег', N'Петров')
INSERT [dbo].[Client] ([id], [surname], [name], [patronymic]) VALUES (2, N'Ольхов', N'Константин', N'Павлович')
INSERT [dbo].[Client] ([id], [surname], [name], [patronymic]) VALUES (3, N'Котов', N'Дмитрий', N'Олегович')
INSERT [dbo].[Client] ([id], [surname], [name], [patronymic]) VALUES (4, N'Грушев', N'Михаил', N'Павлович')
INSERT [dbo].[Client] ([id], [surname], [name], [patronymic]) VALUES (1004, N'Зарева', N'Татьяна', N'Игоревна')
INSERT [dbo].[Client] ([id], [surname], [name], [patronymic]) VALUES (1005, N'Попов', N'Сергей', N'Александрович')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Deceased] ON 

INSERT [dbo].[Deceased] ([id], [deceased_status_id], [name], [surname], [patronymic], [birth_date], [death_date]) VALUES (3, 2, N'Павел', N'Горов', N'Андреевич', CAST(N'1976-11-02' AS Date), CAST(N'2020-01-01' AS Date))
INSERT [dbo].[Deceased] ([id], [deceased_status_id], [name], [surname], [patronymic], [birth_date], [death_date]) VALUES (5, 2, N'Мария', N'Гусева', N'Павловна', CAST(N'1965-02-11' AS Date), CAST(N'2020-11-02' AS Date))
INSERT [dbo].[Deceased] ([id], [deceased_status_id], [name], [surname], [patronymic], [birth_date], [death_date]) VALUES (7, 2, N'Заухура', N'Турова', N'Давыдова', CAST(N'1988-03-21' AS Date), CAST(N'2020-10-11' AS Date))
INSERT [dbo].[Deceased] ([id], [deceased_status_id], [name], [surname], [patronymic], [birth_date], [death_date]) VALUES (8, 2, N'Генадий', N'Горкин', N'Олегович', CAST(N'1975-11-01' AS Date), CAST(N'2020-10-10' AS Date))
INSERT [dbo].[Deceased] ([id], [deceased_status_id], [name], [surname], [patronymic], [birth_date], [death_date]) VALUES (9, 2, N'Петрович', N'Гуляев', N'Петрович', CAST(N'1996-11-08' AS Date), CAST(N'2020-11-08' AS Date))
INSERT [dbo].[Deceased] ([id], [deceased_status_id], [name], [surname], [patronymic], [birth_date], [death_date]) VALUES (10, 1, N'Татьяна', N'Широкова', N'Александровна', CAST(N'1979-06-14' AS Date), CAST(N'2020-11-11' AS Date))
SET IDENTITY_INSERT [dbo].[Deceased] OFF
GO
SET IDENTITY_INSERT [dbo].[DeceasedStatus] ON 

INSERT [dbo].[DeceasedStatus] ([id], [deceased_status]) VALUES (1, N'Ожидание захоронения')
INSERT [dbo].[DeceasedStatus] ([id], [deceased_status]) VALUES (2, N'Похоронен')
SET IDENTITY_INSERT [dbo].[DeceasedStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([id], [position_id], [surname], [name], [patronymic], [login], [password], [age]) VALUES (1, 1, N'Носов', N'Павел', N'Андреевич', N'admin', N'c3284d0f94606de1fd2af172aba15bf3', 45)
INSERT [dbo].[Employee] ([id], [position_id], [surname], [name], [patronymic], [login], [password], [age]) VALUES (2, 2, N'Щукин', N'Григорий', N'Дмитреевич', N'shuka11', N'61f52f5bd7afa2d341970cd768f6f105', 33)
INSERT [dbo].[Employee] ([id], [position_id], [surname], [name], [patronymic], [login], [password], [age]) VALUES (3, 2, N'Зубов', N'Олег', N'Николаевич', N'zubov33', N'ee9d7936b362f5a60cd4a85d60ad8499', 41)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Grave] ON 

INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (26, 2, 1)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (27, 2, 2)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (28, 2, 3)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (29, 2, 4)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (30, 2, 5)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (31, 2, 6)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (32, 1, 7)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (33, 1, 8)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (34, 1, 9)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (35, 1, 10)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (36, 1, 11)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (37, 1, 12)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (38, 1, 13)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (39, 1, 14)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (40, 1, 15)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (41, 1, 16)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (42, 1, 17)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (43, 1, 18)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (44, 1, 19)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (45, 1, 20)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (46, 1, 21)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (47, 1, 22)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (48, 1, 25)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (49, 1, 23)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (50, 1, 24)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (51, 1, 26)
INSERT [dbo].[Grave] ([id], [gravestatus_id], [grave_number]) VALUES (52, 1, 27)
SET IDENTITY_INSERT [dbo].[Grave] OFF
GO
SET IDENTITY_INSERT [dbo].[GraveStatus] ON 

INSERT [dbo].[GraveStatus] ([id], [status_value]) VALUES (1, N'Доступно')
INSERT [dbo].[GraveStatus] ([id], [status_value]) VALUES (2, N'Занято')
SET IDENTITY_INSERT [dbo].[GraveStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([id], [employee_id], [client_id], [order_num], [order_sum], [order_date], [parts_order], [added_parts]) VALUES (1, 1, 1, 544001, 28000, CAST(N'2020-11-02' AS Date), 1, 1)
INSERT [dbo].[Order] ([id], [employee_id], [client_id], [order_num], [order_sum], [order_date], [parts_order], [added_parts]) VALUES (2, 1, 2, 544002, 45000, CAST(N'2020-11-02' AS Date), 1, 1)
INSERT [dbo].[Order] ([id], [employee_id], [client_id], [order_num], [order_sum], [order_date], [parts_order], [added_parts]) VALUES (4, 1, 3, 544003, 35000, CAST(N'2020-11-02' AS Date), 1, 1)
INSERT [dbo].[Order] ([id], [employee_id], [client_id], [order_num], [order_sum], [order_date], [parts_order], [added_parts]) VALUES (6, 1, 2, 544004, 30000, CAST(N'2020-11-06' AS Date), 1, 1)
INSERT [dbo].[Order] ([id], [employee_id], [client_id], [order_num], [order_sum], [order_date], [parts_order], [added_parts]) VALUES (7, 1, 3, 544005, 30000, CAST(N'2020-11-08' AS Date), 1, 1)
INSERT [dbo].[Order] ([id], [employee_id], [client_id], [order_num], [order_sum], [order_date], [parts_order], [added_parts]) VALUES (8, 1, 1005, 544006, 100000, CAST(N'2020-11-11' AS Date), 3, 0)
INSERT [dbo].[Order] ([id], [employee_id], [client_id], [order_num], [order_sum], [order_date], [parts_order], [added_parts]) VALUES (9, 1, 1005, 544007, 30000, CAST(N'2020-11-17' AS Date), 1, 0)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[Order_Grave] ON 

INSERT [dbo].[Order_Grave] ([id], [deceased_id], [status_id], [order_id], [grave_id], [burial_date]) VALUES (3, 3, 1, 1, 26, CAST(N'2020-11-07' AS Date))
INSERT [dbo].[Order_Grave] ([id], [deceased_id], [status_id], [order_id], [grave_id], [burial_date]) VALUES (5, 5, 1, 2, 27, CAST(N'2020-11-07' AS Date))
INSERT [dbo].[Order_Grave] ([id], [deceased_id], [status_id], [order_id], [grave_id], [burial_date]) VALUES (6, 7, 1, 4, 28, CAST(N'2020-11-07' AS Date))
INSERT [dbo].[Order_Grave] ([id], [deceased_id], [status_id], [order_id], [grave_id], [burial_date]) VALUES (1004, 8, 1, 1, 29, CAST(N'2020-11-07' AS Date))
INSERT [dbo].[Order_Grave] ([id], [deceased_id], [status_id], [order_id], [grave_id], [burial_date]) VALUES (1008, 9, 1, 7, 30, CAST(N'2020-11-08' AS Date))
INSERT [dbo].[Order_Grave] ([id], [deceased_id], [status_id], [order_id], [grave_id], [burial_date]) VALUES (1009, 9, 1, 7, 31, CAST(N'2020-11-09' AS Date))
SET IDENTITY_INSERT [dbo].[Order_Grave] OFF
GO
SET IDENTITY_INSERT [dbo].[Position] ON 

INSERT [dbo].[Position] ([id], [position_name]) VALUES (1, N'admin')
INSERT [dbo].[Position] ([id], [position_name]) VALUES (2, N'manager')
SET IDENTITY_INSERT [dbo].[Position] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([id], [status_name]) VALUES (1, N'В обработке')
INSERT [dbo].[Status] ([id], [status_name]) VALUES (2, N'Выполняется')
INSERT [dbo].[Status] ([id], [status_name]) VALUES (3, N'Выполнен')
INSERT [dbo].[Status] ([id], [status_name]) VALUES (4, N'Отменен')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
/****** Object:  Index [IX_Grave]    Script Date: 23.11.2020 19:59:22 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Grave] ON [dbo].[Grave]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Deceased]  WITH CHECK ADD  CONSTRAINT [FK_Deceased_DeceasedStatus] FOREIGN KEY([deceased_status_id])
REFERENCES [dbo].[DeceasedStatus] ([id])
GO
ALTER TABLE [dbo].[Deceased] CHECK CONSTRAINT [FK_Deceased_DeceasedStatus]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Position] FOREIGN KEY([position_id])
REFERENCES [dbo].[Position] ([id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Position]
GO
ALTER TABLE [dbo].[Grave]  WITH CHECK ADD  CONSTRAINT [FK_Grave_GraveStatus] FOREIGN KEY([gravestatus_id])
REFERENCES [dbo].[GraveStatus] ([id])
GO
ALTER TABLE [dbo].[Grave] CHECK CONSTRAINT [FK_Grave_GraveStatus]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Client] FOREIGN KEY([client_id])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Client]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Employee]
GO
ALTER TABLE [dbo].[Order_Grave]  WITH CHECK ADD  CONSTRAINT [FK_Order_Grave_Deceased] FOREIGN KEY([deceased_id])
REFERENCES [dbo].[Deceased] ([id])
GO
ALTER TABLE [dbo].[Order_Grave] CHECK CONSTRAINT [FK_Order_Grave_Deceased]
GO
ALTER TABLE [dbo].[Order_Grave]  WITH CHECK ADD  CONSTRAINT [FK_Order_Grave_Grave] FOREIGN KEY([grave_id])
REFERENCES [dbo].[Grave] ([id])
GO
ALTER TABLE [dbo].[Order_Grave] CHECK CONSTRAINT [FK_Order_Grave_Grave]
GO
ALTER TABLE [dbo].[Order_Grave]  WITH CHECK ADD  CONSTRAINT [FK_Order_Grave_Order] FOREIGN KEY([order_id])
REFERENCES [dbo].[Order] ([id])
GO
ALTER TABLE [dbo].[Order_Grave] CHECK CONSTRAINT [FK_Order_Grave_Order]
GO
ALTER TABLE [dbo].[Order_Grave]  WITH CHECK ADD  CONSTRAINT [FK_Order_Grave_Status] FOREIGN KEY([status_id])
REFERENCES [dbo].[Status] ([id])
GO
ALTER TABLE [dbo].[Order_Grave] CHECK CONSTRAINT [FK_Order_Grave_Status]
GO
USE [master]
GO
ALTER DATABASE [ARUDB] SET  READ_WRITE 
GO
