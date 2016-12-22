--1
IF OBJECT_ID('dbo.[States]', 'U') IS NOT NULL 
	DROP TABLE [dbo].[States];

CREATE TABLE [States](
	[Id] int NOT NULL PRIMARY KEY IDENTITY,
	[SensorSsn] nvarchar(20) NOT NULL,
	[LastTimeUpdate] datetime DEFAULT GETDATE(),
	[NextTimeUpdate] datetime DEFAULT DATEADD(HOUR, 12, CURRENT_TIMESTAMP),
	[VoltLevel] decimal(4,2),
	[CurrentBill] decimal(4,2),
	[Error] int,
	--CONSTRAINT [PK_States] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_States_To_Sensors] FOREIGN KEY ([SensorSsn]) REFERENCES [Sensors]([Ssn])
)
INSERT INTO States ([SensorSsn], [VoltLevel], [Error])
VALUES 
	(N'0000001-AAA', '3.75', 0),
	(N'0000002-BBB', '3.71', 0),
	(N'0000003-CCC', '3.62', 0),
	(N'0000004-DDD', '3.80', 0);

SELECT * FROM States