CREATE PROCEDURE [dbo].[SP_GetCartById]
(
@CartId INT
)
AS
BEGIN

SELECT * FROM AddToCart 
WHERE 
CartId=@CartId

END

--exec SP_GetCartById '1'
