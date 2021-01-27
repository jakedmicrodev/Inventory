-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Create an appraiser
-- =============================================
CREATE PROCEDURE [dbo].[CreateAppraiser] 
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50), 
	@CompanyId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Appraisers]
	([Name]
	,[CompanyId])
	VALUES
	(@Name
	,@CompanyId)
END