
-- =============================================
-- Author:		jake
-- Create date: now
-- Description:	Insert an artwork into the Artworks table
-- =============================================
CREATE PROCEDURE [dbo].[CreateArtwork] 
	-- Add the parameters for the stored procedure here
	@Title nvarchar(100),
	@ArtTypeId int, 
	@ArtistId int,
	@Notes nvarchar(max),
	@ItemId int,
	@ImageName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Artworks]
	([Title]
	,[ArtTypeId]
	,[ArtistId]
	,[Notes]
	,[ItemId]
	,[ImageName])
	VALUES
	(@Title
	,@ArtTypeId
	,@ArtistId
	,@Notes
	,@ItemId
	,@ImageName)

END