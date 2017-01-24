--4
USE LwsDB
GO

IF OBJECT_ID('dbo.UserProfiles', 'U') IS NOT NULL 
	DROP TABLE dbo.UserProfiles;

CREATE TABLE UserProfiles(
	Id int NOT NULL,
	FirstName varchar(50),
	LastName nvarchar(50),
	City nvarchar(50),
	Country nvarchar(50),
	Region nvarchar(50),
	AddressFst nvarchar(50),
	AddressSec nvarchar(50), 
	ZipCode tinyint,
	Phone nvarchar(13)
	CONSTRAINT [PK_UserProfiles] PRIMARY KEY CLUSTERED (Id ASC),
	CONSTRAINT [FK_UserProfiles_To_Users] FOREIGN KEY ([Id]) REFERENCES [Users]([Id])
)

INSERT INTO UserProfiles (Id, FirstName, LastName, Phone)
VALUES 
	(1, N'Igor', N'Postinyk', N'+380971663359'),
	(2, N'Vladymir', N'Knyazev', N'+380961343210'),
	(3, N'Stats', N'Shalamov', N'+380972229989');

SELECT * FROM [UserProfiles]