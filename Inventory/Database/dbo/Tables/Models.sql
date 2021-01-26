CREATE TABLE [dbo].[Models] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         VARCHAR (50)  NOT NULL,
    [ProductId]    INT           NOT NULL,
    [ModelNumber]  NVARCHAR (50) NULL,
    [SerialNumber] VARCHAR (50)  NULL,
    [ImageName]    NVARCHAR (50) NULL,
    CONSTRAINT [PK_teModels] PRIMARY KEY CLUSTERED ([Id] ASC)
);

