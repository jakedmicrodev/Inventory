
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more states from the States table
--              exec [dbo].[GetManuals] null, null
--              exec [dbo].[GetManuals] null, 1
--              exec [dbo].[GetManuals] 1, null
--              exec [dbo].[GetManuals] 1, 1
-- =============================================
CREATE PROCEDURE [dbo].[GetManuals] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@ProductId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT m.[Id]
		  ,m.[Name]
		  ,m.[ProductId]
		  ,p.[Name] AS [Product]
	  FROM [dbo].[teManuals] m
	  LEFT JOIN [dbo].[teProducts] p
	  ON p.[Id] = m.[ProductId]
	  WHERE @Id IS NULL OR m.[Id] = @Id OR @ProductId IS NULL OR m.[ProductId] = @ProductId

END