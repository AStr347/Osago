USE [MyOsago]
GO

/****** Object:  Table [dbo].[Osago]    Script Date: 20.01.2020 14:10:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Osago](
	[Id] [nchar](15) NOT NULL PRIMARY KEY, /*Серия + номер полиса формата ККК0000000000*/
	
	[IdInsurant] [nchar](20) NOT NULL FOREIGN KEY REFERENCES [dbo].[Insurant] ([Id]), /*id страхователя из таблицы Insurant*/
	[IdOwner] [nchar](20) NOT NULL FOREIGN KEY REFERENCES [dbo].[Owner] ([Id]), /*id Страхуемого из даблицы Owner*/
	[IdCar] [nchar](20) NOT NULL FOREIGN KEY REFERENCES [dbo].[Cars] ([Id]), /*id Машины из таблицы Cars*/
	[IdFaces] [nchar](20) NOT NULL, /*Ключ к таблице Faces*/
	
	[BegDate] [date] NOT NULL, /*Дата начала действия страховки*/
	[EndDate] [date] NOT NULL, /*Дата конца действия страховки*/
	[ConDate] [date] NOT NULL, /*Дата залючения страховки*/
	
	[Prize] [int] NOT NULL, /*Выплата по страховке с учетом тарифа*/
	
)
GO
