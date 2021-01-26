CREATE TABLE [dbo].[Products] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [CompanyId]  INT           NOT NULL,
    [MerchantId] INT           NULL,
    [SupportUrl] VARCHAR (MAX) NULL,
    [AddDate]    DATETIME      NULL,
    [RemoveDate] DATETIME      NULL,
    [ItemId]     INT           NOT NULL
);

