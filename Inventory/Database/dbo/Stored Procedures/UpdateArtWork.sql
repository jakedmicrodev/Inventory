


-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Update an artwork in the ArtWorks table
-- exec [dbo].[UpdateArtWork] 1, 'Something', 1, 1, 1, 'IMG779', 'Nice use of color'
-- =============================================
CREATE PROCEDURE [dbo].[UpdateArtWork] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Title varchar(100),
	@ArtTypeId int,
	@ArtistId int,
	@ItemId int,
	@ImageName nvarchar(50),
	@Notes nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[ArtWorks]
	SET [Title] = @Title,
		[ArtTypeId] = @ArtTypeId,
		[ArtistId] = @ArtistId,
		[ItemId] = @ItemId,
		[ImageName] = @ImageName,
		[Notes] = @Notes
	WHERE [Id] = @Id
END