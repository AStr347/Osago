USE [MyOsago]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
/*хз работает ли если попробуешь напиши че получилось*/
SELECT 
	Id,

	/*Инфа о Страховщике*/
	/*общая инфа*/ 
	Insurant.FullName, Insurant.Type,
	/*IF Insurant.Type = 0 BEGIN*/
	/*инфа физ лица хз как сделать зависимость от Type*/
	Insurant.SerNumPass, Insurant.SerNumVod, Insurant.Who, Insurant.Adress, Insurant.When, 
	/*END
	ELSE BEGIN*/
	/*инфа юр лица хз как сделать зависимость от Type*/
	Insurant.INN, Insurant.OGRN, Insurant.PType, Insurant.Schet,
	/*END*/
	/*Инфа о Владельце ТС*/
	/*общая инфа*/ 
	Owner.FullName,
	/*инфа физ лица*/
	Owner.SerNumPass, Owner.SerNumVod, Owner.Who, Owner.Adress, Owner.When, 

	/*инфа о тачке*/
	Cars.Id, Cars.Number, Cars.Brand, Cars.Model, Cars.Trailer, Cars.ENGINEPOW, Cars.VENGINE

	/*Инфа о Лицах допущенных к ТС*/
	/*общая инфа*/ 
	Faces.FullName,
	/*инфа физ лица*/
	Faces.SerNumPass, Faces.SerNumVod, Faces.Who, Faces.Adress, Faces.When, 

	/*дата начала, конца, заключения Осаго и Страховая премия*/
	BegDate, EndDate, ConDate, Prize

FROM Osago
JOIN Insurant 	ON Osago.IdInsurant = Insurant.Id
JOIN Owner		ON Osago.IdOwner = Owner.Id
JOIN Cars 		ON Osago.IdCar = Cars.Id
JOIN Faces		ON Osago.IdFaces = Fasec.TKey
/*объединение таблиц по условию*/

GO