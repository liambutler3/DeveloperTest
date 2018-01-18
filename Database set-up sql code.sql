GO
-- Database
CREATE DATABASE [TestDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'testDB', FILENAME = N'C:\Users\Liam Butler\testDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
GO

USE [TestDB]
GO


-- Users table
CREATE TABLE [dbo].[tbl_Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Email] [varchar] (100) NOT NULL,
	[Password] [varchar](50) NOT NULL
)
GO


-- Dev insert
INSERT INTO [dbo].[tbl_Users]
           ([Firstname]
           ,[Lastname]
		   ,[Email]
           ,[Password])
     VALUES
           ('Liam'
           ,'Butler'
		   ,'test email'
           ,'password')
GO

