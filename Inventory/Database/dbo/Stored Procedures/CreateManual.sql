﻿

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Insert a manual into the Manuals table
--              exec [dbo].[CreateManual]  'Oregon', 1
-- =============================================
CREATE PROCEDURE [dbo].[CreateManual] 
	-- Add the parameters for the stored procedure here
	@Name varchar(100),
	@ModelId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Manuals] 
	(
		[Name],
		[ModelId]
	)
	VALUES
	(	
		@Name,
		@ModelId
	)
END