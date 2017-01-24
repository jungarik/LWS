CREATE TABLE [dbo].[States] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [SensorSsn]      NVARCHAR (20)  NOT NULL,
    [LastTimeUpdate] DATETIME       DEFAULT (getdate()) NULL,
    [NextTimeUpdate] DATETIME       DEFAULT (dateadd(hour,(12),getdate())) NULL,
    [VoltLevel]      DECIMAL (4, 2) NULL,
    [CurrentBill]    DECIMAL (4, 2) NULL,
    [Error]          INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_States_To_Sensors] FOREIGN KEY ([SensorSsn]) REFERENCES [dbo].[Sensors] ([Ssn])
);

