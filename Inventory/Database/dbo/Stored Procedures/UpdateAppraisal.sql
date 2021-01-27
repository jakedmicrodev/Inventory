

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Update an appraisal in the Appraisals table
--              exec [dbo].[UpdateAppraisal] 1, '1/1/2021', 2000.00, 1
-- =============================================
CREATE PROCEDURE [dbo].[UpdateAppraisal] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@ApparaiserId int,
	@AppraisalDate smalldatetime,
	@AppraisedValue money,
	@ArtworkId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Appraisals]
	SET [AppraiserId] = @ApparaiserId
		,[AppraisalDate] = @AppraisalDate
		,[AppraisedValue] = @AppraisedValue
		,[ArtworkId] = @ArtworkId
	WHERE [Id] = @Id
END