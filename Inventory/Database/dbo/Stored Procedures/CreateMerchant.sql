

-- =============================================
-- Author:		Jake
-- Create date: 2020-09-19
-- Description:	Insert a merchant into the Merchants table
-- =============================================
CREATE PROCEDURE [dbo].[CreateMerchant] 
	-- Add the parameters for the stored procedure here
	@Name varchar(100),
	@Address1 varchar(100),
	@Address2 varchar(100),
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
	INSERT INTO [dbo].[teMerchants] 
	(
		[Name],
		[Address1],
		[Address2],
		[CityId],
		[StateId],
		[CountryId],
		[PostalCode],
		[Phone],
		[Fax],
		[Email]
	)
	VALUES
	( 
		@Name,
		@Address1,
		@Address2,
		@CityId,
		@StateId,
		@CountryId,
		@PostalCode,
		@Phone,
		@Fax,
		@Email
	)
END