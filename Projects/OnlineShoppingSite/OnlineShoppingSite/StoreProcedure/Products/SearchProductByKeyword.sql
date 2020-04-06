CREATE PROCEDURE [dbo].[SP_SearchProductByKeyword]
	
(
@keyword varchar(1000)
)
AS
BEGIN

SELECT * From Products
WHERE
ProductId	  Like  '%'+@keyword+'%' OR
ProductName	Like  '%'+@keyword+'%' OR
CategoryId	Like  '%'+@keyword+'%' OR
Description	Like  '%'+@keyword+'%' OR
Price	Like  '%'+@keyword+'%' OR
Quantity	  Like  '%'+@keyword+'%' 

END

--exec SP_SearchProductByKeyword 'P0'

--select * from Product
