CREATE TABLE [dbo].[Sensors] (
    [Ssn]         NVARCHAR (20)   NOT NULL,
    [UserId]      INT             NOT NULL,
    [QrCode]      VARBINARY (MAX) NULL,
    [Name]        NVARCHAR (10)   NULL,
    [IsOptMeter1] NVARCHAR (20)   NULL,
    [IsOptMeter2] NVARCHAR (20)   NULL,
    [IsOptMeter3] NVARCHAR (20)   NULL,
    [Latitude]    NVARCHAR (10)   NULL,
    [Longitude]   NVARCHAR (10)   NULL,
    PRIMARY KEY CLUSTERED ([Ssn] ASC),
    CONSTRAINT [FK_SensorsToUsers_To_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

