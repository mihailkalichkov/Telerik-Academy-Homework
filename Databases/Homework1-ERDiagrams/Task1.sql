USE [master]
GO
/****** Object:  Database [FirstDatabaseHomework]    Script Date: 24.8.2014 г. 13:24:40 ******/
CREATE DATABASE [FirstDatabaseHomework]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FirstDatabaseHomework', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\FirstDatabaseHomework.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FirstDatabaseHomework_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\FirstDatabaseHomework_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FirstDatabaseHomework] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FirstDatabaseHomework].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FirstDatabaseHomework] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET ARITHABORT OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FirstDatabaseHomework] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FirstDatabaseHomework] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FirstDatabaseHomework] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FirstDatabaseHomework] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET RECOVERY FULL 
GO
ALTER DATABASE [FirstDatabaseHomework] SET  MULTI_USER 
GO
ALTER DATABASE [FirstDatabaseHomework] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FirstDatabaseHomework] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FirstDatabaseHomework] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FirstDatabaseHomework] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FirstDatabaseHomework] SET DELAYED_DURABILITY = DISABLED 
GO
USE [FirstDatabaseHomework]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 24.8.2014 г. 13:24:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[id] [int] NOT NULL,
	[address_text] [text] NULL,
	[town_id] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continent]    Script Date: 24.8.2014 г. 13:24:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continent](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Continent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 24.8.2014 г. 13:24:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[country_id] [int] NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 24.8.2014 г. 13:24:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [int] NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[address_id] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Town]    Script Date: 24.8.2014 г. 13:24:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[country_id] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Town] FOREIGN KEY([town_id])
REFERENCES [dbo].[Town] ([id])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Town]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continent] FOREIGN KEY([country_id])
REFERENCES [dbo].[Continent] ([id])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continent]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Address] FOREIGN KEY([address_id])
REFERENCES [dbo].[Address] ([id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Address]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_Country] FOREIGN KEY([country_id])
REFERENCES [dbo].[Country] ([id])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_Country]
GO
USE [master]
GO
ALTER DATABASE [FirstDatabaseHomework] SET  READ_WRITE 
GO
