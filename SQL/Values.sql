--2
IF OBJECT_ID('dbo.[Values]', 'U') IS NOT NULL 
	DROP TABLE [dbo].[Values];

CREATE TABLE [Values](
	Id int NOT NULL IDENTITY,
	ServerDate datetime NOT NULL DEFAULT GETDATE(),
	SensorDate datetime,
	NumberOfNP int,
	NumberOfPP int,
	Meter1Value int,
	Meter2Value int,
	Meter3Value int,
	SensorSsn nvarchar(20) NOT NULL,
	CONSTRAINT [PK_Values] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Values_To_Sensors] FOREIGN KEY ([SensorSsn]) REFERENCES [Sensors]([Ssn])
)

DECLARE @counter smallint;  
SET @counter = 1;  
WHILE @counter < 6  
	BEGIN  
		INSERT INTO [Values] (SensorDate, NumberOfNP, NumberOfPP, SensorSsn)
		VALUES(GETDATE(), CAST((RAND()*1000) AS int), 0, N'0000004-DDD');
		WAITFOR DELAY '00:00:03.000'; 
		SET @counter = @counter + 1;  
   END;  
GO

SELECT * FROM [Values]