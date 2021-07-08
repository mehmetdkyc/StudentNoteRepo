CREATE TABLE [dbo].[Departman] (
    [Id]   INT           IDENTITY (1, 101) NOT NULL,
    [Name] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Departman] PRIMARY KEY CLUSTERED ([Id] ASC)
);

