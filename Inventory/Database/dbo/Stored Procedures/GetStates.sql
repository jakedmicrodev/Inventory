
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more states from the States table
--              exec [dbo].[GetStates] null
--              exec [dbo].[GetStates] 1
-- =============================================
CREATE PROCEDURE [dbo].[GetStates] 
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
	  FROM [dbo].[tdStates]
	  WHERE @Id IS NULL OR [Id] = @Id

END