
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more products from the Products table
--              exec [dbo].[GetProducts] null
--              exec [dbo].[GetProducts] 1
-- =============================================
CREATE PROCEDURE [dbo].[GetProducts] 
	-- Add the parameters for the stored procedure here
	@Id int
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
		  ,p.[Name] AS [Product]
		  ,p.[Model]
		  ,p.[Serial]
		  ,p.[SupportUrl]
		  ,p.[ImageName]
		  ,p.[AddDate]
		  ,p.[RemoveDate]
	  FROM [dbo].[teProducts] p
	  LEFT JOIN [dbo].[teCompanies] c
	  ON c.[Id] = p.[CompanyId]
	  LEFT JOIN [dbo].[teMerchants] m
	  ON m.[Id] = p.[CompanyId]
END