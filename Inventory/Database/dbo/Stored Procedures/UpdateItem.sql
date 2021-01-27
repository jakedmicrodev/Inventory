

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Update an item in the Items table
--              exec [dbo].[UpdateItem] 1, 'Unknown'
-- =============================================
CREATE PROCEDURE [dbo].[UpdateItem] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name nvarchar(255),
	@Description nvarchar(max),
	@CategoryId int,
	@SubcategoryId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Items]
	SET [Name] = @Name,
		[Description] = @Description,
		[CategoryId] = @CategoryId,
		[SubcategoryId] = @SubcategoryId
	WHERE [Id] = @Id
END