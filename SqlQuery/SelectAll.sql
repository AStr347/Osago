USE [MyOsago]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SELECT 
Id,/*серия и номер*/

/*подзапросы*/
(SELECT * FROM Insurant WHERE Insurant.Id = Osago.IdInsurant),/*все данные о Страховщике*/

(SELECT * FROM Owner WHERE Owner.Id = Osago.IdOwner),/*все данные о Владельце ТС*/

(SELECT * FROM Cars WHERE Cars.Id = Osago.IdCar),/*все данные о ТС*/

(SELECT * FROM Faces WHERE Faces.TKey = Osago.IdFaces),/*Должна получиться таблица допущенных лиц но хз*/

BegDate, EndDate, ConDate, Prize /*дата начала, конца, заключения Осаго и Страховая премия*/

FROM Osago

GO