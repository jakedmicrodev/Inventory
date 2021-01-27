

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Insert a product into the Products table
--              exec [dbo].[CreateProduct]  'Oregon', 'Model', 'Serial', 'www.epson.com/america'
-- =============================================
CREATE PROCEDURE [dbo].[CreateProduct] 
	-- Add the parameters for the stored procedure here
	@CompanyId int,
	@ItemId int,
	@MerchantId int = null,
	@SupportUrl varchar(max) = null,
	@AddDate datetime = null,
	@RemoveDate datetime = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Products] 
	(
		[CompanyId],
		[MerchantId],
		[SupportUrl],
		[AddDate],
		[RemoveDate],
		[ItemId]
	)
	VALUES
	(	
		@CompanyId,
		@MerchantId,
		@SupportUrl,
		@AddDate,
		@RemoveDate,
		@ItemId
	)
END