CREATE TABLE [dbo].[Companies] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (100) NOT NULL,
    [Address1]   VARCHAR (100) NOT NULL,
    [Address2]   VARCHAR (100) NULL,
    [CityId]     INT           NULL,
    [StateId]    INT           NULL,
    [CountryId]  INT           NULL,
    [PostalCode] VARCHAR (20)  NULL,
    [Phone]      VARCHAR (20)  NULL,
    [Fax]        VARCHAR (20)  NULL,
    [Email]      VARCHAR (100) NULL
);

