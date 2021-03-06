USE [master]
GO
/****** Object:  Database [DB_OLA_CAB_Mgt_System]    Script Date: 23-05-2022 16:37:03 ******/
CREATE DATABASE [DB_OLA_CAB_Mgt_System] ON  PRIMARY 
( NAME = N'DB_OLA_CAB_Mgt_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\DB_OLA_CAB_Mgt_System.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_OLA_CAB_Mgt_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\DB_OLA_CAB_Mgt_System_log.LDF' , SIZE = 512KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_OLA_CAB_Mgt_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET  MULTI_USER 
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET DB_CHAINING OFF 
GO
USE [DB_OLA_CAB_Mgt_System]
GO
/****** Object:  Table [dbo].[Area_Detail]    Script Date: 23-05-2022 16:37:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area_Detail](
	[Area_Id] [int] NOT NULL,
	[Area_Name] [nvarchar](50) NOT NULL,
	[Km] [float] NOT NULL,
	[Bike_Km_Price] [float] NOT NULL,
	[Car_Km_Price] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Driver_Details]    Script Date: 23-05-2022 16:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Driver_Details](
	[Driver_Id] [int] NOT NULL,
	[Driver_Name] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Mobile_No] [decimal](10, 0) NOT NULL,
	[Alternate_Mobile_No] [decimal](10, 0) NULL,
	[Aadhar_No] [decimal](12, 0) NOT NULL,
	[PAN_No] [nvarchar](50) NOT NULL,
	[Licence_No] [nvarchar](50) NOT NULL,
	[Email_Id] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Experience] [nvarchar](50) NOT NULL,
	[Charges] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login_Details]    Script Date: 23-05-2022 16:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login_Details](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passenger_Bike_Details]    Script Date: 23-05-2022 16:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger_Bike_Details](
	[Passenger_Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Mobile_No] [numeric](10, 0) NOT NULL,
	[Alternate_Mobile_No] [numeric](10, 0) NULL,
	[Driver_Status] [nvarchar](50) NULL,
	[Driver_Name] [varchar](50) NULL,
	[Aadhar_No] [decimal](12, 0) NOT NULL,
	[Licence_No] [nvarchar](50) NOT NULL,
	[Email_Id] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Area] [nvarchar](50) NOT NULL,
	[Charges] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passenger_Car_Details]    Script Date: 23-05-2022 16:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger_Car_Details](
	[Passenger_Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Mobile_No] [numeric](10, 0) NOT NULL,
	[Alternate_Mobile_No] [numeric](10, 0) NULL,
	[Aadhar_No] [numeric](12, 0) NOT NULL,
	[Licence_No] [nvarchar](50) NOT NULL,
	[Email_Id] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Driver_Name] [nvarchar](50) NOT NULL,
	[Area] [nvarchar](50) NOT NULL,
	[Charges] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle_Details]    Script Date: 23-05-2022 16:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle_Details](
	[Vehicle_Id] [int] NOT NULL,
	[Vehicle_Name] [nvarchar](50) NOT NULL,
	[Vehicle_No] [nvarchar](50) NOT NULL,
	[Owner_Name] [nvarchar](50) NOT NULL,
	[Vehicle_Type] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [DB_OLA_CAB_Mgt_System] SET  READ_WRITE 
GO
