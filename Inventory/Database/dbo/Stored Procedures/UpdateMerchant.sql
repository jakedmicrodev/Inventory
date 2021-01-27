
-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Update a merchant in the Merchants table
--              exec [dbo].[UpdateMerchant] 1, 'Unknown', 'Unknown' , null, 1, 1, 1, null, null, null, null
-- =============================================
CREATE PROCEDURE [dbo].[UpdateMerchant] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(100),
	@Address1 int,
	@Address2 int,	
	@CityId int,	
	@StateId int,	
	@CountryId int,	
	@PostalCode varchar(20),	
	@Phone varchar(20),	
	@Fax varchar(20),
	@Email varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
UPDATE [dbo].[Merchants]
   SET [Name] = @Name
      ,[Address1] = @Address1
      ,[Address2] = @Address2
      ,[CityId] = @CityId
      ,[StateId] = @StateId
      ,[CountryId] = @CountryId
      ,[PostalCode] = @PostalCode
      ,[Phone] = @Phone
      ,[Fax] = @Fax
      ,[Email] = @Email
	WHERE [Id] = @Id
END