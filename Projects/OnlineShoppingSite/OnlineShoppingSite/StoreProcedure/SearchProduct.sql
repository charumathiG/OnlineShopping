CREATE PROCEDURE [dbo].[SP_SearchProduct](
@ProductName VARCHAR(100)
)
AS
BEGIN
SELECT * FROM  Products WHERE ProductName
LIKE '%'+@ProductName+'%' OR
Category LIKE '%' +@ProductName+'%' OR ProductType LIKE '%'+@ProductName+'%'
ORDER BY Price ASC
END

