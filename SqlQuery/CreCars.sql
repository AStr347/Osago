USE [MyOsago]
GO

/****** Object:  Table [dbo].[Cars]    Script Date: 20.01.2020 14:09:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cars](
	[Id] [nchar](20) NOT NULL,
	[Number] [nchar](20) NULL,
	[Brand] [nchar](20) NOT NULL,
	[Model] [nchar](20) NOT NULL,
	[Trailer] [bit] NOT NULL,
	[ENGINEPOW] [int] NULL,
	[VENGINE] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


