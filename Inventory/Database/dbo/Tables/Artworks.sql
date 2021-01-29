CREATE TABLE [dbo].[Artworks] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Title]     NVARCHAR (100) NOT NULL,
    [ArtTypeId] INT            NOT NULL,
    [ArtistId]  INT            NOT NULL,
    [Notes]     NVARCHAR (MAX) NULL,
    [ItemId]    INT            NOT NULL,
    [ImageName] NVARCHAR (50)  NULL
);



