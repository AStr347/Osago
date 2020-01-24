USE /*[MyOsago]*/
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
DECLARE @OsagoId nchar(20)
DECLARE @InsurantId nchar(20)
DECLARE @OwnerId nchar(20)
DECLARE @CarId nchar(20)
DECLARE @FacesId nchar(20)
/*здесь выставь id шники что бы ниче не поломалось*/
SET @OsagoId = ''
SET @InsurantId = ''
SET @OwnerId = ''
SET @CarId = ''
SET @FacesKey = ''
GO
INSERT INTO Insurant VALUES (
	@InsurantId,/*[Id]*/
	'',/*[FullName]*/
	0,/*[TYPE] 0 - физ лицо 1 - юр лицо*/
	/*Для Физ лиц*/
	'',/*[SerNumPass]*/
	'',/*[SerNumVod]*/
	'',/*[Who]*/
	'',/*[Adress]*/
	'',/*[When]*/
	/*Для Юр лиц*/
	'',/*[INN]*/
	'',/*[OGRN]*/
	'',/*[PType]*/
	'',/*[Schet]*/
)

GO
INSERT INTO Owner VALUES (
	@OwnerId,/*[Id]*/
	'',/*[FullName]*/
	0,/*[TYPE] 0 - физ лицо 1 - юр лицо*/
	/*Для Физ лиц*/
	'',/*[SerNumPass]*/
	'',/*[SerNumVod]*/
	'',/*[Who]*/
	'',/*[Adress]*/
	'',/*[When]*/
)

GO

DECLARE @I INT
DECLARE @LastIdInFaces INT
DECLARE @CountNewFaces INT

SET @I = 0
SET @LastIdInFaces = COUNT();
SET @CountNewFaces = 1;

WHILE @I < @CountNewFaces
BEGIN

	INSERT INTO Faces VALUES (
		CONVERT(nchar(10),@LastIdInFaces + @I),/*[Id]*/
		'',/*[FullName]*/
		@FacesKey,/*[TKey] 0 - физ лицо 1 - юр лицо*/
		/*Для Физ лиц*/
		'',/*[SerNumPass]*/
		'',/*[SerNumVod]*/
		'',/*[Who]*/
		'',/*[Adress]*/
		'',/*[When]*/
	)
	SET @I = @I + 1
END

GO

INSERT INTO Cars Values(
	@CarId,/*[Id]*/
	'',/*[Number]*/
	
	'',/*[Brand]*/
	'',/*[Model]*/
	
	0,/*[Trailer]*/
	
	0,/*[ENGINEPOW]*/
	0,/*[VENGINE]*/
)

GO

INSERT INTO Osago VALUES (
	@OsagoId,/*/*[Id]*/*/
	
	@InsurantId,/*/*[IdInsurant]*/*/
	@OwnerId,/*/*[IdOwner]*/*/
	@CarId,/*/*[IdCar]*/*/
	@FacesId,/*/*[IdFaces]*/*/
	
	'',/*/*[BegDate]*/*/
	'',/*/*[EndDate]*/*/
	'',/*/*[ConDate]*/*/
	
	0/*/*[Prize]*/*/
)

GO