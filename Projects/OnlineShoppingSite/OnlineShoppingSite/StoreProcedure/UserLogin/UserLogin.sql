CREATE PROCEDURE [dbo].[SP_GetUser]
(
@EmailId VARCHAR(50)
)
AS
BEGIN
SELECT * FROM Customers WHERE EmailId=@EmailId
END

