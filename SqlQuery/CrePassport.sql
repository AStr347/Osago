USE [MyOsago]
GO

/****** Object:  Table [dbo].[Passport]    Script Date: 11.12.2019 17:11:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Passport](
	[Id] [nchar](20) NOT NULL PRIMARY KEY,
	[FullName] [nchar](100) NULL,
)
GO


