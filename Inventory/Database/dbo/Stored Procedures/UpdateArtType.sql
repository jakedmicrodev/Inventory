

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Update an art type in the ArtTypes table
--              exec [dbo].[UpdateArtType] 1, 'Bathroom'
-- =============================================
CREATE PROCEDURE [dbo].[UpdateArtType] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[ArtTypes]
	SET [Name] = @Name
	WHERE [Id] = @Id
END