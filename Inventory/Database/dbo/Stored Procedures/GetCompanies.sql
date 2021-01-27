-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more cities from the Cities table
--              exec [dbo].[GetCompanies] null
--              exec [dbo].[GetCompanies] 1
-- =============================================
CREATE PROCEDURE [dbo].[GetCompanies] 
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT c.[Id]
		  ,c.[Name]
		  ,c.[Address1]
		  ,c.[Address2]
		  ,c.[CityId]
		  ,ci.[Name] AS [City]
		  ,c.[StateId]
		  ,s.[Name] AS [State]
		  ,c.[CountryId]
		  ,co.[Name] AS [Country]
		  ,c.[PostalCode]
		  ,c.[Phone]
		  ,c.[Fax]
		  ,c.[Email]
	  FROM [dbo].[Companies] c
		  INNER JOIN [dbo].[Cities] ci
		  ON ci.[Id] = c.[CityId]
		  INNER JOIN [dbo].[States] s
		  ON s.[Id] = c.[StateId]
		  INNER JOIN [dbo].[Countries] co
		  ON co.[Id] = c.[CountryId]
	  WHERE @Id IS NULL OR c.[Id] = @Id

END