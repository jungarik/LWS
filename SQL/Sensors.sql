--3
USE LwsDB
GO

IF OBJECT_ID('dbo.Sensors', 'U') IS NOT NULL 
	DROP TABLE dbo.Sensors;

CREATE TABLE [Sensors](
	[Id] int NOT NULL IDENTITY,
	[UserId] int NOT NULL,
	[QrCode] varbinary(max),
	[Name] nvarchar(10),
	[IsOptMeter1] nvarchar(20),
	[IsOptMeter2] nvarchar(20),
	[IsOptMeter3] nvarchar(20),
	[Latitude] nvarchar(10),
	[Longitude] nvarchar(10)
	CONSTRAINT [PK_Sensor] PRIMARY KEY ([Id])
	CONSTRAINT [FK_SensorsToUsers_To_Users] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id])
)

INSERT INTO Sensors ([Name],[Latitude],[Longitude],[UserId])
VALUES 
(N'X-1.0.0', N'49.997167', N'36.251793', 1 ),(N'X-1.0.0', N'50.010310', N'36.228983', 2),
( N'X-1.0.0', N'50.034932', N'36.219906', 3 ),(N'X-1.0.0', N'50.027820', N'36.317485', 2);

SELECT * FROM [Sensors]