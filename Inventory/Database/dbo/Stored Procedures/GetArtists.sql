

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more artists from the Artists table
--              exec [dbo].[GetArtists] null
--              exec [dbo].[GetArtists] 1
-- =============================================
CREATE PROCEDURE [dbo].[GetArtists] 
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
	  FROM [dbo].[Artists]
	  WHERE @Id IS NULL OR [Id] = @Id

END