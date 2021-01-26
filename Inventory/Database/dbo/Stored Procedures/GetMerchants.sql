
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more cities from the Cities table
--              exec [dbo].[GetMerchants] null
--              exec [dbo].[GetMerchants] 1
-- =============================================
CREATE PROCEDURE [dbo].[GetMerchants] 
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT m.[Id]
		  ,m.[Name]
		  ,m.[Address1]
		  ,m.[Address2]
		  ,m.[CityId]
		  ,ci.[Name] AS [City]
		  ,m.[StateId]
		  ,s.[Name] AS [State]
		  ,m.[CountryId]
		  ,co.[Name] AS [Country]
		  ,m.[PostalCode]
		  ,m.[Phone]
		  ,m.[Fax]
		  ,m.[Email]
	  FROM [dbo].[teMerchants] m
		  INNER JOIN [dbo].[tdCities] ci
		  ON ci.[Id] = m.[CityId]
		  INNER JOIN [dbo].[tdStates] s
		  ON s.[Id] = m.[StateId]
		  INNER JOIN [dbo].[tdCities] co
		  ON co.[Id] = m.[CountryId]
	  WHERE @Id IS NULL OR m.[Id] = @Id

END