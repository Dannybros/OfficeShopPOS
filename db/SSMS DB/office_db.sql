USE [master]
GO
/****** Object:  Database [office_db]    Script Date: 7/6/2022 11:38:09 AM ******/
CREATE DATABASE [office_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'office_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\office_db.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'office_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\office_db_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [office_db] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [office_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [office_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [office_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [office_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [office_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [office_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [office_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [office_db] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [office_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [office_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [office_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [office_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [office_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [office_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [office_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [office_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [office_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [office_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [office_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [office_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [office_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [office_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [office_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [office_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [office_db] SET RECOVERY FULL 
GO
ALTER DATABASE [office_db] SET  MULTI_USER 
GO
ALTER DATABASE [office_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [office_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [office_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [office_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [office_db]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 7/6/2022 11:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customer](
	[Customer_ID] [nvarchar](20) NOT NULL,
	[Customer_Name] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Customer_Image] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[employee]    Script Date: 7/6/2022 11:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee](
	[Employee_ID] [nvarchar](20) NOT NULL,
	[Employee_Name] [nvarchar](20) NOT NULL,
	[Employee_Phone] [nvarchar](20) NOT NULL,
	[Employee_Email] [nvarchar](20) NOT NULL,
	[Employee_Address] [nvarchar](20) NOT NULL,
	[Emp_Img] [varbinary](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[import_details]    Script Date: 7/6/2022 11:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[import_details](
	[Import_No] [int] IDENTITY(1,1) NOT NULL,
	[Order_ID] [nvarchar](20) NOT NULL,
	[Product_ID] [nvarchar](20) NOT NULL,
	[Product_Name] [nvarchar](30) NOT NULL,
	[Original_Price] [float] NOT NULL,
	[Amount] [int] NOT NULL,
	[Total_Price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Import_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[order_imports]    Script Date: 7/6/2022 11:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_imports](
	[Order_ID] [nvarchar](20) NOT NULL,
	[Supplier_Name] [nvarchar](20) NOT NULL,
	[Import_Date] [date] NOT NULL,
	[Total] [float] NOT NULL,
	[Checked] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_order_imports] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product_categories]    Script Date: 7/6/2022 11:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_categories](
	[Product_Type_ID] [nvarchar](20) NOT NULL,
	[Product_Type_Name] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[products]    Script Date: 7/6/2022 11:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[Product_ID] [nvarchar](20) NOT NULL,
	[Product_Name] [nvarchar](30) NOT NULL,
	[Product_Type_Name] [nvarchar](20) NOT NULL,
	[Product_Brand] [nvarchar](20) NOT NULL,
	[Size] [nvarchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Original_Price] [float] NOT NULL,
	[Selling_Price] [float] NOT NULL,
	[Production_Date] [nvarchar](30) NOT NULL,
	[Expiration_Date] [nvarchar](30) NOT NULL,
	[Product_Img] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sale]    Script Date: 7/6/2022 11:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sale](
	[Sale_ID] [nvarchar](20) NOT NULL,
	[Customer_Name] [nvarchar](30) NOT NULL,
	[Total] [float] NOT NULL,
	[Date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sale_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sale_details]    Script Date: 7/6/2022 11:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sale_details](
	[Sale_No] [int] IDENTITY(1,1) NOT NULL,
	[Sale_ID] [nvarchar](20) NOT NULL,
	[Product_ID] [nvarchar](30) NOT NULL,
	[Product_Name] [nvarchar](30) NOT NULL,
	[Price] [float] NOT NULL,
	[Amount] [int] NOT NULL,
	[Product_Total] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sale_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[supplier]    Script Date: 7/6/2022 11:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[supplier](
	[Supplier_ID] [nvarchar](15) NOT NULL,
	[Supplier_Name] [nvarchar](30) NOT NULL,
	[Supplier_Address] [nvarchar](100) NOT NULL,
	[Supplier_Email] [nvarchar](30) NOT NULL,
	[Supplier_Tel] [nvarchar](15) NOT NULL,
	[Supplier_Img] [varbinary](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[products] ADD  CONSTRAINT [DF_products_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
USE [master]
GO
ALTER DATABASE [office_db] SET  READ_WRITE 
GO
