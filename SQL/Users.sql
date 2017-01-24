--5
USE LwsDB
GO

IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL 
	DROP TABLE dbo.Users;

CREATE TABLE [Users](
	[Id] int NOT NULL PRIMARY KEY IDENTITY,
	[Email] nvarchar(50) NOT NULL UNIQUE,
	[Login] nvarchar(50),-- UNIQUE,
	[Password] nvarchar(50)
)

INSERT INTO [Users] ([Email],[Password])
VALUES 
(N'gor132@i.ua', N'20090710igor'),
(N'knyaz2@i.ua', N'qwerty123'),
(N'sshalamov@mail.ru', N'qwerty123');

SELECT * FROM [dbo].[Users]