--1
USE LwsDB
GO

IF OBJECT_ID('dbo.[States]', 'U') IS NOT NULL 
	DROP TABLE [dbo].[States];

CREATE TABLE [States](
	[Id] int NOT NULL IDENTITY,
	[SensorId] int NOT NULL,
	[LastTimeUpdate] datetime DEFAULT GETDATE(),
	[NextTimeUpdate] datetime DEFAULT DATEADD(HOUR, 12, CURRENT_TIMESTAMP),
	[VoltLevel] decimal(4,2),
	[CurrentBill] decimal(4,2),
	[Error] int,
	CONSTRAINT [PK_States] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_States_To_Sensors] FOREIGN KEY ([SensorId]) REFERENCES [Sensors]([Id])
)

INSERT INTO States ([SensorId], [VoltLevel], [Error])
VALUES 
	(1, '3.75', 0),
	(2, '3.71', 0),
	(3, '3.62', 0),
	(4, '3.80', 0);

SELECT * FROM States