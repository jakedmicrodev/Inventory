

-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Insert a sub category into the Subcategories table
-- =============================================
CREATE PROCEDURE [dbo].[CreateSubCategory] 
	-- Add the parameters for the stored procedure here
	@Name varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Subcategories] ([Name])
	SELECT @Name
END