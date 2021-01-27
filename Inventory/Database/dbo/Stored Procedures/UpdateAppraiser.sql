

-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Update an appraiser in the Appraisers table
--              exec [dbo].[UpdateAppraiser] 1, 'Joe Appraiser', 1
-- =============================================
CREATE PROCEDURE [dbo].[UpdateAppraiser] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@CompanyId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Appraisers]
	SET [Name] = @Name
		,[CompanyId] = @CompanyId
	WHERE [Id] = @Id
END