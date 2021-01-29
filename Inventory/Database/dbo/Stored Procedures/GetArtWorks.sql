


-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more art types from the ArtTypes table
--              exec [dbo].[GetArtWorks] null
--              exec [dbo].[GetArtWorks] 1
-- =============================================
CREATE PROCEDURE [dbo].[GetArtWorks] 
	-- Add the parameters for the stored procedure here
	@Id int = null,
	@Title nvarchar(100) = null,
	@ArtTypeId int = null,
	@ArtistId int = null,
	@ItemId int = null,
	@ImageName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT a.[Id]
		  ,a.[Title]
		  ,a.[ArtTypeId]
		  ,ty.[Name] AS [ArtType]
		  ,a.[ArtistId]
		  ,art.[Name] AS [Artist]
		  ,a.[Notes]
		  ,a.[ItemId]
		  ,a.[ImageName]
		  ,i.[Name] AS [Item]
		  ,i.[Description]
	  FROM [dbo].[Artworks] a
	  LEFT JOIN [dbo].[ArtTypes] ty ON a.[ArtTypeId] = ty.[Id]
	  LEFT JOIN [dbo].[Artists] art ON a.[ArtistId] = art.[Id]
	  LEFT JOIN [dbo].[Items] i ON a.[ItemId] = i.[Id]
	  WHERE (@Id IS NULL OR a.[Id] = @Id)
	  AND (@Title IS NULL OR a.[Title] LIKE '%' +  @Title + '%')
	  AND (@ArtTypeId IS NULL OR a.[ArtTypeId] = @ArtTypeId)
	  AND (@ArtTypeId IS NULL OR a.[ArtistId] = @ArtTypeId)
	  AND (@ItemId IS NULL OR a.[ItemId] = @ItemId)
	  AND (@ImageName IS NULL OR a.[ImageName] LIKE '%' + @ImageName + '%')
	  ORDER BY [Title]

END