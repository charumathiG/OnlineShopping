CREATE PROCEDURE [dbo].[SP_UserLogin]
(
@CustomerEmail VARCHAR(100),
@CustomerPassword VARCHAR(100)
)
AS
BEGIN
SELECT * FROM Customers WHERE CustomerEmail = @CustomerEmail
AND 
CustomerPassword =@CustomerPassword
END

