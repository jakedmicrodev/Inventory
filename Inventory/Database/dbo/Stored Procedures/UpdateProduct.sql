
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Update a product in the Products table
--              exec [dbo].[UpdateProduct] 1, 2, null, 'Name', 'Model', 'Serial', 'www.epson.com/america'
-- =============================================
CREATE PROCEDURE [dbo].[UpdateProduct] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@CompanyId int,
	@MerchantId int,
	@Name varchar(100),
	@Model varchar(100),
	@Serial varchar(100),
	@SupportUrl varchar(max),
	@ImageName varchar(20),
	@AddDate datetime,
	@RemoveDate datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[teProducts] 
	SET [CompanyId] = @CompanyId,
		[MerchantId] = @MerchantId,
		[Name] = @Name,
		[Model] = @Model,
		[Serial] = @Serial,
		[SupportUrl] = @SupportUrl,
		[ImageName] = @ImageName,
		[AddDate] = @AddDate,
		[RemoveDate] = @RemoveDate
	WHERE [Id] = @Id
END