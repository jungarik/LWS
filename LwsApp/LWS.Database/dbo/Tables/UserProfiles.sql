CREATE TABLE [dbo].[UserProfiles] (
    [Id]         INT           NOT NULL,
    [FirstName]  VARCHAR (50)  NULL,
    [LastName]   NVARCHAR (50) NULL,
    [City]       NVARCHAR (50) NULL,
    [Country]    NVARCHAR (50) NULL,
    [Region]     NVARCHAR (50) NULL,
    [AddressFst] NVARCHAR (50) NULL,
    [AddressSec] NVARCHAR (50) NULL,
    [ZipCode]    TINYINT       NULL,
    [Phone]      NVARCHAR (13) NULL,
    CONSTRAINT [PK_UserProfiles] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_UserProfiles_To_Users] FOREIGN KEY ([Id]) REFERENCES [dbo].[Users] ([Id])
);

