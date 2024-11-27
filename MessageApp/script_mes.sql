USE [master]
GO
/****** Object:  Database [MessageDatabase]    Script Date: 27.11.2024 16:38:27 ******/
CREATE DATABASE [MessageDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MessageDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MessageDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MessageDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MessageDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MessageDatabase] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MessageDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MessageDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MessageDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MessageDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MessageDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MessageDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [MessageDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MessageDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MessageDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MessageDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MessageDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MessageDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MessageDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MessageDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MessageDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MessageDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MessageDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MessageDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MessageDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MessageDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MessageDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MessageDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MessageDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MessageDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [MessageDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [MessageDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MessageDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MessageDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MessageDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MessageDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MessageDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MessageDatabase', N'ON'
GO
ALTER DATABASE [MessageDatabase] SET QUERY_STORE = ON
GO
ALTER DATABASE [MessageDatabase] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MessageDatabase]
GO
/****** Object:  Table [dbo].[Tbl_Message]    Script Date: 27.11.2024 16:38:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Message](
	[MessageID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Sender] [char](4) NULL,
	[Receiver] [char](4) NULL,
	[Subject] [varchar](50) NULL,
	[Text] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_People]    Script Date: 27.11.2024 16:38:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_People](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Surname] [varchar](30) NULL,
	[Number] [char](4) NULL,
	[Password] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Names]    Script Date: 27.11.2024 16:38:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Names]
as
Begin
select MessageID, (SenderPeople.Name + ' ' + SenderPeople.Surname) as Sender, (ReceiverPeople.Name + ' ' + ReceiverPeople.Surname) as Receiver,Subject,Text from Tbl_Message
inner join Tbl_People as SenderPeople
on Tbl_Message.Sender = SenderPeople.Number
inner join Tbl_People as ReceiverPeople
on Tbl_Message.Receiver = ReceiverPeople.Number;
End
GO
USE [master]
GO
ALTER DATABASE [MessageDatabase] SET  READ_WRITE 
GO
