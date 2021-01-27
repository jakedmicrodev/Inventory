
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Update a manual in the Manuals table
--              exec [dbo].[UpdateManual] 1, 'Unknown', 0
-- =============================================
CREATE PROCEDURE [dbo].[UpdateManual] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(100),
	@ModelId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Manuals]
	SET [Name] = @Name,
		[ModelId] = @ModelId
	WHERE [Id] = @Id
END