
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more categories from the Categories table
--              exec [dbo].[GetCategories] null
--              exec [dbo].[GetCategories] 1
-- =============================================
CREATE PROCEDURE [dbo].[GetCategories] 
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [Id]
		  ,[Name]
	  FROM [dbo].[Categories]
	  WHERE @Id IS NULL OR [Id] = @Id

END