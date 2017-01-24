CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Email]    NVARCHAR (50) NOT NULL,
    [Login]    NVARCHAR (50) NULL,
    [Password] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC)
);

