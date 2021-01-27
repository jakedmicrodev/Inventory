
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Insert a model into the Models table
--              
-- =============================================
CREATE PROCEDURE [dbo].[CreateModel] 
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50),
	@ProductId int,
	@ModelNumber nvarchar(50) = null,
	@SerialNumber nvarchar(50) = null,
	@ImageName nvarchar(50) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Models]
	([Name]
	,[ProductId]
	,[ModelNumber]
	,[SerialNumber]
	,[ImageName])
	VALUES
	(@Name
	,@ProductId
	,@ModelNumber
	,@SerialNumber
	,@ImageName)
END