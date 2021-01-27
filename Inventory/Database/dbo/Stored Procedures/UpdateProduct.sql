
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Update a product in the Products table
--              exec [dbo].[UpdateProduct] 1, 2, 1, null, '', '', 1
-- =============================================
CREATE PROCEDURE [dbo].[UpdateProduct] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@CompanyId int,
	@MerchantId int,
	@SupportUrl varchar(max),
	@AddDate datetime,
	@RemoveDate datetime,
	@ItemId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Products] 
	SET [CompanyId] = @CompanyId,
		[MerchantId] = @MerchantId,
		[SupportUrl] = @SupportUrl,
		[AddDate] = @AddDate,
		[RemoveDate] = @RemoveDate,
		[ItemId] = @ItemId
	WHERE [Id] = @Id
END