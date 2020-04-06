CREATE PROCEDURE [dbo].[SP_UserLogin]
(
@EmailId VARCHAR(50),
@Password VARCHAR(16)
)
AS
BEGIN
SELECT * FROM Customers WHERE EmailId = @EmailId
AND 
Password =@Password
END

