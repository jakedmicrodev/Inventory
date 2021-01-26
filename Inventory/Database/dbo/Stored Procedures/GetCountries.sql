
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more countries from the Countries table
--              exec [dbo].[GetCountries] null
--              exec [dbo].[GetCountries] 1
-- =============================================
CREATE PROCEDURE [dbo].[GetCountries] 
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
	  FROM [dbo].[tdCountries]
	  WHERE @Id IS NULL OR [Id] = @Id

END