

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more appraisals from the Appraisals table
--              exec [dbo].[GetAppraisals] null

-- =============================================
CREATE PROCEDURE [dbo].[GetAppraisals] 
	-- Add the parameters for the stored procedure here
	@Id int = null,
	@AppraiserId int = null,
	@StartValue money = null,
	@EndValue money = null,
	@ArtworkId int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ap.[Id]
		  ,ap.[AppraiserId]
		  ,apr.[Name] AS [Appraiser]
		  ,ap.[AppraisalDate]
		  ,ap.[AppraisedValue]
		  ,ap.[ArtworkId]
	  FROM [dbo].[Appraisals] ap
	  LEFT JOIN [dbo].[Appraisers] apr ON ap.[AppraiserId] = apr.Id
	  LEFT JOIN [dbo].[Artworks] art ON ap.[ArtworkId] = art.[Id]
	  WHERE (@Id IS NULL OR ap.[Id] = @Id)
	  AND (@AppraiserId IS NULL OR ap.[AppraiserId] = @AppraiserId)
	  AND ((@StartValue IS NULL AND @EndValue IS NULL) OR (ap.[AppraisedValue] BETWEEN @StartValue AND @EndValue))
	  AND (@ArtworkId IS NULL OR ap.[ArtworkId] = @ArtworkId)


END