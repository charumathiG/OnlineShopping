CREATE PROCEDURE [dbo].[SP_GetProductById]
(
@ProductId varchar(5)
)
AS
BEGIN

SELECT * FROM Product 
WHERE ProductId=@ProductId

END

--Exec SP_GetProductById 'P0001'
