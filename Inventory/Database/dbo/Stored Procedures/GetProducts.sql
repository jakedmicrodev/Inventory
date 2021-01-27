
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more products from the Products table
--              exec [dbo].[GetProducts] null
-- =============================================
CREATE PROCEDURE [dbo].[GetProducts] 
	-- Add the parameters for the stored procedure here
	@Id int = null,
	@CompanyId int = null,
	@MerchantId int = null,
	@SupportUrl nvarchar(100) = null,
	@StartAddDate smalldatetime = null,
	@EndAddDate smalldatetime = null,
	@StartRemoveDate smalldatetime = null,
	@EndRemoveDate smalldatetime = null,
	@ItemId int = null	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT p.[Id]
		  ,p.[CompanyId]
		  ,c.[Name] AS [Company]
		  ,p.[MerchantId]
		  ,m.[Name] AS [Merchant]
		  ,p.[SupportUrl]
		  ,p.[AddDate]
		  ,p.[RemoveDate]
		  ,p.[ItemId]
	  FROM [dbo].[Products] p
	  LEFT JOIN [dbo].[Companies] c ON p.[CompanyId] = c.[Id]
	  LEFT JOIN [dbo].[Merchants] m ON p.[MerchantId] = m.[Id]
	  WHERE (@Id IS NULL OR p.[Id] = @Id)
	  AND (@CompanyId IS NULL OR p.[CompanyId] = @CompanyId)
	  AND (@MerchantId IS NULL OR p.[MerchantId] = @MerchantId)
	  AND (@SupportUrl IS NULL OR p.[SupportUrl] LIKE '%' + @SupportUrl + '%')
	  AND ((@StartAddDate IS NULL AND @EndAddDate IS NULL) OR (p.[AddDate] BETWEEN @StartAddDate AND @EndAddDate))
	  AND ((@StartRemoveDate IS NULL AND @EndRemoveDate IS NULL) OR (p.[RemoveDate] BETWEEN @StartRemoveDate AND @EndRemoveDate))
	  AND (@ItemId IS NULL OR p.[ItemId] = @ItemId)
END