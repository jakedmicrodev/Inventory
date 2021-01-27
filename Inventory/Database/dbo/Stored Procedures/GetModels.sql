


-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Select one or more models from the Models table
--              exec [dbo].[GetModels] null, null, null, null, null, null
-- =============================================
CREATE PROCEDURE [dbo].[GetModels] 
	-- Add the parameters for the stored procedure here
	@Id int = null,
	@Name nvarchar(50) = null,
	@ProductId int = null,
	@ModelNumber nvarchar(50) = null,
	@SerialNumber nvarchar(50) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT m.[Id]
		  ,m.[Name]
		  ,m.[ProductId]
		  ,m.[ModelNumber]
		  ,m.[SerialNumber]
		  ,m.[ImageName]
	  FROM [dbo].[Models] m
	  LEFT JOIN [dbo].[Products] p ON m.[ProductId] = p.[Id]
	  WHERE (@Id IS NULL OR m.[Id] = @Id)
	  AND (@Name IS NULL OR m.[Name] LIKE '%' +  @Name + '%')
	  AND (@ProductId IS NULL OR m.[ProductId] = @ProductId)
	  AND (@ModelNumber IS NULL OR m.[ModelNumber] LIKE '%' +  @ModelNumber + '%')
	  AND (@SerialNumber IS NULL OR m.[SerialNumber] LIKE '%' +  @SerialNumber + '%')
	  ORDER BY m.[Name]

END