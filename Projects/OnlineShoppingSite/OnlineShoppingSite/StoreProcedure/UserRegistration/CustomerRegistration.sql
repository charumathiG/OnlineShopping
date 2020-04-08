CREATE PROCEDURE [dbo].[SP_CustomerRegistration]
(
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
	@FullName VARCHAR(100),
	@PhoneNumber VARCHAR(12),
	@EmailId VARCHAR(100),
	@Password VARCHAR(100),
	@Address VARCHAR(100)
)
	AS
	BEGIN
	INSERT INTO Customers
	(
	FirstName,
	LastName,
	FullName,
	PhoneNumber,
	EmailId,
	Password,
	Address
	) 
	VALUES
	(
	@FirstName,
	@LastName,
	@FullName,
	@PhoneNumber,
	@EmailId,
	@Password,
	@Address
)  
END


