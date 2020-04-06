CREATE PROCEDURE [dbo].[SP_CustomerRegistration]
(
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
	@FullName VARCHAR(100),
	@PhoneNumber VARCHAR(12),
	@Password VARCHAR(100),
	@EmailId VARCHAR(100),
	@Address VARCHAR(100)
)
	AS
	BEGIN
	INSERT INTO Customers VALUES
	(
	@FirstName,
	@LastName,
	@FullName,
	@PhoneNumber,
	@Password,
	@EmailId,
	@Address
)  
END


