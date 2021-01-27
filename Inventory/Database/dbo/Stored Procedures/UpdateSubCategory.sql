

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Update a category in the Categories table
--              exec [dbo].[UpdateSubCategory] 1, 'Bathroom'
-- =============================================
CREATE PROCEDURE [dbo].[UpdateSubCategory] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Subcategories]
	SET [Name] = @Name
	WHERE [Id] = @Id
END