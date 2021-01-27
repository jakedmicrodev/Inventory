-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Create an inventory item
-- =============================================
CREATE PROCEDURE [dbo].[CreateItem] 
	-- Add the parameters for the stored procedure here
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
	INSERT INTO [dbo].[Items]
	([Name]
	,[Description]
	,[CategoryId]
	,[SubcategoryId])
	VALUES
	(@Name
	,@Description
	,@CategoryId
	,@SubcategoryId)
END