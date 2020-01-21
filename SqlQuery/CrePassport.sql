USE [MyOsago]
GO

/****** Object:  Table [dbo].[Insurant]    Script Date: 20.01.2020 14:10:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Insurant](
	[Id] [nchar](20) NOT NULL,
	[FullName] [nchar](100) NOT NULL,
	[TYPE] [bit] NOT NULL,
	
	[SerNumPass] [nchar](20) NULL,
	[SerNumVod] [nchar](20) NULL,
	[Who] [nchar](20) NULL,
	[Adress] [nchar](50) NULL,
	[When] [date] NULL,
	
	[INN] [nchar](20) NULL,
	[OGRN] [nchar](20) NULL,
	[PType] [nchar](20) NULL,
	[Schet] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Owner](
	[Id] [nchar](20) NOT NULL,
	[FullName] [nchar](100) NOT NULL,
	[TYPE] [bit] NOT NULL,
	
	[SerNumPass] [nchar](20) NULL,
	[SerNumVod] [nchar](20) NULL,
	[Who] [nchar](20) NULL,
	[Adress] [nchar](50) NULL,
	[When] [date] NULL,
	
	[INN] [nchar](20) NULL,
	[OGRN] [nchar](20) NULL,
	[PType] [nchar](20) NULL,
	[Schet] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CarMans](
	[Id] [nchar](20) NOT NULL,
	[FullName] [nchar](100) NOT NULL,
	[TYPE] [bit] NOT NULL,
	
	[SerNumPass] [nchar](20) NULL,
	[SerNumVod] [nchar](20) NULL,
	[Who] [nchar](20) NULL,
	[Adress] [nchar](50) NULL,
	[When] [date] NULL,
	
	[INN] [nchar](20) NULL,
	[OGRN] [nchar](20) NULL,
	[PType] [nchar](20) NULL,
	[Schet] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


