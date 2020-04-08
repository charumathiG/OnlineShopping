CREATE PROCEDURE [dbo].[SP_UpdateUserLoggedInTime]
(
@EmailId VARCHAR(50),
@TokenNo NVARCHAR(225)
)
AS
BEGIN
UPDATE Customers 
SET 
TokenNo=@TokenNo, 
LastLoggedInTime=GETDATE()
WHERE EmailId=@EmailId
END