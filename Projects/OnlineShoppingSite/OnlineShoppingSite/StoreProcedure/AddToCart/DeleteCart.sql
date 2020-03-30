CREATE PROCEDURE [dbo].[SP_DeleteCart]
(
@Id int
)

AS
BEGIN

DECLARE @result int

DELETE AddToCart 
WHERE 
Id=@Id

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END




