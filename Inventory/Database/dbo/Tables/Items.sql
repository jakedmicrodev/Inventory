CREATE TABLE [dbo].[Items] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (255) NOT NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [CategoryId]    INT            NOT NULL,
    [SubcategoryId] INT            NOT NULL
);

