CREATE TABLE [dbo].[EMPLOYEES] (
    [Id]           INT        NOT NULL,
    [Name]         NCHAR (10) NULL,
    [Phone number] INT        NULL,
    [Email]        NCHAR (10) NULL,
    [Job]          NCHAR (10) NULL,
    [Date]         DATETIME   NULL,
    [Cover]        IMAGE      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

