CREATE TABLE [dbo].[Values] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [ServerDate]  DATETIME      DEFAULT (getdate()) NOT NULL,
    [SensorDate]  DATETIME      NULL,
    [NumberOfNP]  INT           NULL,
    [NumberOfPP]  INT           NULL,
    [Meter1Value] INT           NULL,
    [Meter2Value] INT           NULL,
    [Meter3Value] INT           NULL,
    [SensorSsn]   NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Values] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Values_To_Sensors] FOREIGN KEY ([SensorSsn]) REFERENCES [dbo].[Sensors] ([Ssn])
);

