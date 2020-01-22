USE [MyOsago]
GO

/****** Object:  Table [dbo].[Insurant]    Script Date: 20.01.2020 14:10:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
/*Таблица страховщиков*/
CREATE TABLE [dbo].[Insurant](
	[Id] [nchar](20) NOT NULL PRIMARY KEY, /*id в таблице*/
	[FullName] [nchar](100) NOT NULL, /*ФИО или Название организации*/
	[TYPE] [bit] NOT NULL, /*Тип Страховщика (0 - Физ лицо 1 - Юр лицо)*/
	/*Для Физ лиц*/
	[SerNumPass] [nchar](20) NULL,/*Серия и номер паспорта*/
	[SerNumVod] [nchar](20) NULL,/*Серия и номер водительских прав*/
	[Who] [nchar](20) NULL,/*Кем выдан паспорт*/
	[Adress] [nchar](50) NULL,/*Прописка*/
	[When] [date] NULL,/*Когда выдан паспорт*/
	/*Для Юр лиц*/
	[INN] [nchar](20) NULL,
	[OGRN] [nchar](20) NULL,
	[PType] [nchar](20) NULL,/*Организационно правовая форма*/
	[Schet] [nchar](20) NULL,/*Расчетный счет*/
	
)
GO
GO

SET QUOTED_IDENTIFIER ON
GO
/*Таблица Собственников*/
CREATE TABLE [dbo].[Owner](
	[Id] [nchar](20) NOT NULL PRIMARY KEY, /*id в таблице*/
	[FullName] [nchar](100) NOT NULL, /*ФИО*/
	/*Для Физ лиц*/
	[SerNumPass] [nchar](20) NULL,/*Серия и номер паспорта*/
	[SerNumVod] [nchar](20) NULL,/*Серия и номер водительских прав*/
	[Who] [nchar](20) NULL,/*Кем выдан паспорт*/
	[Adress] [nchar](50) NULL,/*Прописка*/
	[When] [date] NULL,/*Когда выдан паспорт*/
)
GO
GO

SET QUOTED_IDENTIFIER ON
GO
/*Таблица Лиц допущенных к управлению ТС*/
CREATE TABLE [dbo].[Faces](
	[Id] [nchar](20) NOT NULL PRIMARY KEY, /*id в таблице*/
	[FullName] [nchar](100) NOT NULL, /*ФИО*/
	[TKey] [nchar](20) NOT NULL, /*Ключ для осуществления выборки лиц допущенных к управлению по опред полису ОСАГО*/
	/*Для Физ лиц*/
	[SerNumPass] [nchar](20) NULL,/*Серия и номер паспорта*/
	[SerNumVod] [nchar](20) NULL,/*Серия и номер водительских прав*/
	[Who] [nchar](20) NULL,/*Кем выдан паспорт*/
	[Adress] [nchar](50) NULL,/*Прописка*/
	[When] [date] NULL,/*Когда выдан паспорт*/
)
GO


