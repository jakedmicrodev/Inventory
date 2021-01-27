-- =============================================
-- Author:		jake
-- Create date: now
-- Description:	Create an appraisal
-- =============================================
CREATE PROCEDURE [dbo].[CreateAppraisal] 
	-- Add the parameters for the stored procedure here
	@AppraiserId int, 
	@AppraisalDate smalldatetime,
	@AppraisedValue money,
	@ArtworkId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Appraisals]
	([AppraiserId]
	,[AppraisalDate]
	,[AppraisedValue]
	,[ArtworkId])
	VALUES
	(@AppraiserId
	,@AppraisalDate
	,@AppraisedValue
	,@ArtworkId)

END