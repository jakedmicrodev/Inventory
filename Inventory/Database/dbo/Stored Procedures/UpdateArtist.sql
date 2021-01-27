

-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Update an artist in the Artists table
--              exec [dbo].[UpdateArtist] 1, 'Joe Artist'
-- =============================================
CREATE PROCEDURE [dbo].[UpdateArtist] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Artists]
	SET [Name] = @Name
	WHERE [Id] = @Id
END