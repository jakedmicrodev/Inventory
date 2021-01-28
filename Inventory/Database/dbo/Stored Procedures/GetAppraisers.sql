


-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more appraisers from the Appraisers table
--              exec [dbo].[GetAppraisers] null, null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetAppraisers] 
	-- Add the parameters for the stored procedure here
	@Id int = null,
	@Name nvarchar(50) = null,
	@CompanyId int = null

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT a.[Id]
		  ,a.[Name]
		  ,a.[CompanyId]
		  ,c.[Name] AS [Company]
	  FROM [dbo].[Appraisers] a
	  LEFT JOIN [dbo].[Companies] c ON a.[CompanyId] = c.[Id]
	  WHERE (@Id IS NULL OR a.[Id] = @Id)
	  AND (@Name IS NULL OR a.[Name] LIKE '%' + @Name + '%')
	  AND (@CompanyId IS NULL OR a.[CompanyId] = @CompanyId)

END