CREATE PROCEDURE [dbo].[SP_GetProductById]
(@CategoryId int)
as
begin
select ProductId,Image,Price,ProductName
from Products 
where CategoryId = @CategoryId

end

