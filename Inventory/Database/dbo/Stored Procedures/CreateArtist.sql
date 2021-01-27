
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Insert an artist into the Artists table
-- =============================================
CREATE PROCEDURE [dbo].[CreateArtist] 
	-- Add the parameters for the stored procedure here
	@Name varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Artists] 
	([Name])
	VALUES
	(@Name)
END