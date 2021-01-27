CREATE TABLE [dbo].[Appraisals] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [AppraiserId]    INT           NOT NULL,
    [AppraisalDate]  SMALLDATETIME NOT NULL,
    [AppraisedValue] MONEY         NOT NULL,
    [ArtworkId]      INT           NOT NULL
);



