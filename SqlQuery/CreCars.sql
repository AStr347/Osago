USE [MyOsago]
GO

/****** Object:  Table [dbo].[Cars]    Script Date: 11.12.2019 17:11:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cars](
	[Id] [nchar](20) NOT NULL PRIMARY KEY,
	[Brand] [nchar](20) NOT NULL,
	[Model] [nchar](20) NOT NULL,
	[Number] [nchar](20) NULL,
	[Trailer] [bit] NOT NULL,
)
GO


