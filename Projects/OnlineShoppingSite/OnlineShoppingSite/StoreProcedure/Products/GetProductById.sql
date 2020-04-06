CREATE PROCEDURE [dbo].[SP_GetProductById]
(
@ProductId varchar(5)
)
AS
BEGIN

SELECT * FROM Products 
WHERE ProductId=@ProductId

END

--Exec SP_GetProductById 'P0001'
