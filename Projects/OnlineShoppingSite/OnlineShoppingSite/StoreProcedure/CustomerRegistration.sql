﻿CREATE PROCEDURE [dbo].[SP_CustomerRegistration]
(
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
	@CustomerPhone VARCHAR(11),
	@CustomerPassword VARCHAR(100),
	@CustomerEmail VARCHAR(100),
	@CustomerAddress VARCHAR(100)
)
	AS
	BEGIN
	INSERT INTO Customers VALUES
	(
	@FirstName,
	@LastName,
	@CustomerPhone,
	@CustomerPassword,
	@CustomerEmail,
	@CustomerAddress
)  
END 
