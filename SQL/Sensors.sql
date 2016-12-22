--3
IF OBJECT_ID('dbo.Sensors', 'U') IS NOT NULL 
	DROP TABLE dbo.Sensors;

CREATE TABLE [Sensors](
	[Ssn] nvarchar(20) NOT NULL PRIMARY KEY,
	[UserId] int NOT NULL,
	[QrCode] varbinary(max),
	[Name] nvarchar(10),
	[IsOptMeter1] nvarchar(20),
	[IsOptMeter2] nvarchar(20),
	[IsOptMeter3] nvarchar(20),
	[Position] nvarchar(20)
	CONSTRAINT [FK_SensorsToUsers_To_Users] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id])
)

INSERT INTO Sensors ([Ssn],[Name],[Position],[UserId])
VALUES 
(N'0000001-AAA', N'X-1.0.0', N'41.40338, 2.17403', 1 ),(N'0000002-BBB', N'X-1.0.0', N'45.40338, 10.17403', 2),
(N'0000003-CCC', N'X-1.0.0', N'49.40338, 21.17403', 3 ),(N'0000004-DDD', N'X-1.0.0', N'35.40338, 810.17403', 2);

SELECT * FROM [Sensors]