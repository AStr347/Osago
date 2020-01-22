USE [MyOsago]
GO

/****** Object:  Table [dbo].[Cars]    Script Date: 20.01.2020 14:09:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cars](
	[Id] [nchar](20) NOT NULL PRIMARY KEY, /*VIN*/
	[Number] [nchar](20) NULL, /*Гос номер*/
	
	[Brand] [nchar](20) NOT NULL,
	[Model] [nchar](20) NOT NULL,
	
	[Trailer] [bit] NOT NULL,
	
	[ENGINEPOW] [int] NULL, /*Мощьность двигателя*/
	[VENGINE] [int] NULL, /*Объем двигателя*/
) ON [PRIMARY]
GO


