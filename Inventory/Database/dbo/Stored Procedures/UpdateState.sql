
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Update a state in the States table
--              exec [dbo].[UpdateState] 1, 'Unknown'
-- =============================================
CREATE PROCEDURE [dbo].[UpdateState] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[tdStates]
	SET [Name] = @Name
	WHERE [Id] = @Id
END