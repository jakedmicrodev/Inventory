

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more art types from the ArtTypes table
--              exec [dbo].[GetArtTypes] null
--              exec [dbo].[GetArtTypes] 1
-- =============================================
CREATE PROCEDURE [dbo].[GetArtTypes] 
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [Id]
		  ,[Name]
	  FROM [dbo].[ArtTypes]
	  WHERE @Id IS NULL OR [Id] = @Id
	  ORDER BY [Name]

END