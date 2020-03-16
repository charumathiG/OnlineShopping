CREATE PROCEDURE [dbo].[SP_YourOrder](
@CustomerEmail VARCHAR(50)
)
AS
BEGIN
SELECT * FROM Status WHERE Email=@CustomerEmail
END
