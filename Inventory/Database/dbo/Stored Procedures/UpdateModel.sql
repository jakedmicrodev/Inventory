

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Update a model in the Models table
--              exec [dbo].[UpdateModel] 1, 'Unknown', 1, null, null, null
-- =============================================
CREATE PROCEDURE [dbo].[UpdateModel] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(100),
	@ProductId int,
	@ModelNumber nvarchar(50),	
	@SerialNumber nvarchar(50),	
	@ImageName nvarchar(50)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Models]
   SET [Name] = @Name
      ,[ProductId] = @ProductId
      ,[ModelNumber] = @ModelNumber
      ,[SerialNumber] = @SerialNumber
      ,[ImageName] = @ImageName
	WHERE [Id] = @Id
END