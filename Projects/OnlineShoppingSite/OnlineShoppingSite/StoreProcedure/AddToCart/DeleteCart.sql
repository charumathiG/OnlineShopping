CREATE PROCEDURE [dbo].[SP_DeleteCart]
(
@CartId int
)

AS
BEGIN

DECLARE @result int

DELETE AddToCart 
WHERE 
CartId=@CartId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END




