-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Get items
-- =============================================
CREATE PROCEDURE [dbo].[GetItems] 
	-- Add the parameters for the stored procedure here
	@Id int = null, 
	@Name nvarchar(255) = null,
	@Description nvarchar(255) = null,
	@CategoryId int = null,
	@SubcategoryId int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT i.[Id]
		  ,i.[Name]
		  ,i.[Description]
		  ,i.[CategoryId]
		  ,c.[Name] AS [Category]
		  ,i.[SubcategoryId]
		  ,s.[Name] AS [Subcategory]
	  FROM [dbo].[Items] i
	  LEFT JOIN [dbo].[Categories] c ON i.[CategoryId] = c.[Id]
	  LEFT JOIN [dbo].[Subcategories] s ON i.[SubcategoryId] = s.[Id]
	  WHERE (@Id IS NULL OR i.[Id] = @Id)
	  AND (@Name IS NULL OR i.[Name] LIKE '%' + @Name + '%')
	  AND (@Description IS NULL OR i.[Description] LIKE '%' + @Description + '%')
	  AND (@CategoryId IS NULL OR i.[CategoryId] = @CategoryId)
	  AND (@SubcategoryId IS NULL OR i.[SubcategoryId] = @SubcategoryId)

END