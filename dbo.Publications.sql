CREATE TABLE [dbo].[Publications] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Title]    NVARCHAR (MAX) NOT NULL,
    [Text]     NVARCHAR (MAX) NOT NULL,
    [Author]   NVARCHAR (MAX) NOT NULL,
    [DateTime] DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Publications] PRIMARY KEY CLUSTERED ([Id] ASC)
);

