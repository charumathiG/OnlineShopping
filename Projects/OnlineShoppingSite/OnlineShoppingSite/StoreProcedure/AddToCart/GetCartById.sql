CREATE PROCEDURE [dbo].[SP_GetCartById]
(
@Id INT
)
AS
BEGIN

SELECT * FROM AddToCart 
WHERE Id=@Id

END

--exec SP_GetCartById '1'
