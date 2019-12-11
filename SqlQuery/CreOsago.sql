USE [MyOsago]
GO

/****** Object:  Table [dbo].[Osago]    Script Date: 11.12.2019 17:11:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Osago](
	[Id] [nchar](15) NOT NULL PRIMARY KEY,
	[IdInsurant] [nchar](20) NOT NULL,
	FOREIGN KEY([IdInsurant]) REFERENCES [dbo].[Passport] ([Id]),
	[IdOwner] [nchar](20) NOT NULL,
	FOREIGN KEY([IdOwner]) REFERENCES [dbo].[Passport] ([Id]),
	[IdCar] [nchar](20) NOT NULL UNIQUE,
	FOREIGN KEY([IdCar]) REFERENCES [dbo].[Cars] ([Id]),
	[IdFaces] [nchar](20) NOT NULL,
	[BegDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[ConDate] [date] NOT NULL,
	[Prize] [int] NOT NULL,
)
GO


