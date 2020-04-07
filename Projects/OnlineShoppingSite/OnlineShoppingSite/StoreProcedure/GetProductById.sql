CREATE PROCEDURE [dbo].[GetProductById]
(
@ProductId VARCHAR(5)
)
AS
BEGIN
SELECT
a.ProductId,
a.CustomerId,
c.FullName,
p.ProductName,
a.Price,
a.Quantity,
a.Date

FROM AddToCart a INNER JOIN Products p 
ON
a.ProductId = p.ProductId

INNER JOIN Customers c 
ON 
c.CustomerId = a.CustomerId

WHERE 
a.ProductId = @ProductId

END

exec test 'P0002'