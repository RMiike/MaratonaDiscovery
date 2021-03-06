USE [master]
GO
/****** Object:  Database [DevFinanceDb]    Script Date: 21/02/2021 16:59:47 ******/
CREATE DATABASE [DevFinanceDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DevFinanceDb', FILENAME = N'C:\Users\miike\DevFinanceDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DevFinanceDb_log', FILENAME = N'C:\Users\miike\DevFinanceDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DevFinanceDb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DevFinanceDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DevFinanceDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DevFinanceDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DevFinanceDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DevFinanceDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DevFinanceDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [DevFinanceDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DevFinanceDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DevFinanceDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DevFinanceDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DevFinanceDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DevFinanceDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DevFinanceDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DevFinanceDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DevFinanceDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DevFinanceDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DevFinanceDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DevFinanceDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DevFinanceDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DevFinanceDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DevFinanceDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DevFinanceDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DevFinanceDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DevFinanceDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DevFinanceDb] SET  MULTI_USER 
GO
ALTER DATABASE [DevFinanceDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DevFinanceDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DevFinanceDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DevFinanceDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DevFinanceDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DevFinanceDb] SET QUERY_STORE = OFF
GO
USE [DevFinanceDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [DevFinanceDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 21/02/2021 16:59:48 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 21/02/2021 16:59:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[Id] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](250) NOT NULL,
	[Amount] [money] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210219172550_init', N'5.0.3')
GO
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'b3f88b06-6769-4090-03fa-08d8d5107e30', N'descrição', 5000.0000, CAST(N'2019-01-06T17:16:40.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'66f0ad76-7325-4a6c-03fb-08d8d5107e30', N'descrição', 5000.0000, CAST(N'2019-01-06T17:16:40.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'ff64342d-544d-44d6-03fc-08d8d5107e30', N'descrição', 5000.0000, CAST(N'2019-01-06T17:16:40.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'b4f63886-84f1-478b-03fd-08d8d5107e30', N'descrição', 5000.0000, CAST(N'2019-01-06T17:16:40.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'5864b7e7-adf1-481e-03fe-08d8d5107e30', N'descrição', 5000.0000, CAST(N'2019-01-06T17:16:40.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'0e543500-848d-4947-a334-08d8d517ac04', N'descrição', 5000.0000, CAST(N'2019-01-06T17:16:40.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'68a63b48-8305-45af-edcb-08d8d5184dee', N'descrição', 5000.5500, CAST(N'2019-01-06T17:16:40.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'6ac677dd-df03-4814-f195-08d8d51a5df5', N'descrição', -5000.5500, CAST(N'2019-01-06T17:16:40.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'633c84e6-1c77-48f1-f196-08d8d51a5df5', N'descrição', -5000.5500, CAST(N'2019-01-06T17:16:40.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'd27410d1-6f04-4e21-f197-08d8d51a5df5', N'descrição', -5000.5500, CAST(N'2019-01-06T17:16:40.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'f34fe92f-cedd-472c-f198-08d8d51a5df5', N'descrição', -5000.5500, CAST(N'2019-01-06T17:16:40.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'faaafb0b-76ff-487c-f199-08d8d51a5df5', N'descrição', -5000.5500, CAST(N'2019-01-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'5fc2c6be-f30c-4203-f19a-08d8d51a5df5', N'descrição', -5000.5500, CAST(N'2019-01-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'b537aafd-d1df-4db4-f19b-08d8d51a5df5', N'descrição', -5000.5500, CAST(N'2019-01-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'26c82b59-30f8-4cc1-f19c-08d8d51a5df5', N'descrição', -5000.5500, CAST(N'2019-01-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'b46f4637-edef-46e0-f19d-08d8d51a5df5', N'descrição', -5000.5500, CAST(N'2019-01-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'ba43fc1d-df6f-43c5-f19e-08d8d51a5df5', N'descrição', 5000.5500, CAST(N'2019-01-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'a3bb56b4-9f0c-4e0b-f19f-08d8d51a5df5', N'descrição', 5000.5500, CAST(N'2019-01-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'f54ce4c3-1058-4889-f1a0-08d8d51a5df5', N'descrição', 5000.5500, CAST(N'2019-01-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'7eb8b98d-0bdd-440b-f1a1-08d8d51a5df5', N'descrição', 500.5500, CAST(N'2019-01-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Transaction] ([Id], [Description], [Amount], [Date]) VALUES (N'a34258d2-3e43-41cd-f1a2-08d8d51a5df5', N'descrição', 500.5500, CAST(N'2019-01-06T00:00:00.000' AS DateTime))
GO
USE [master]
GO
ALTER DATABASE [DevFinanceDb] SET  READ_WRITE 
GO
