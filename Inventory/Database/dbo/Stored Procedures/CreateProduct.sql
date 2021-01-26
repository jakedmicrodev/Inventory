

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Insert a product into the Products table
--              exec [dbo].[CreateProduct]  'Oregon', 'Model', 'Serial', 'www.epson.com/america'
-- =============================================
CREATE PROCEDURE [dbo].[CreateProduct] 
	-- Add the parameters for the stored procedure here
	@Name varchar(100),
	@Model varchar(100),
	@Serial varchar(100),
	@SupportUrl varchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[teProducts] 
	(
		[Name],
		[Model],
		[Serial],
		[SupportUrl]
	)
	VALUES
	(	
		@Name,
		@Model,
		@Serial,
		@SupportUrl
	)
END