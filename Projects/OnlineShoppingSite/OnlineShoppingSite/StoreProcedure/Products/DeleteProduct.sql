CREATE PROCEDURE [dbo].[SP_DeleteProduct]
(
@ProductId  varchar(10)
)

AS
BEGIN

DECLARE @result int

DELETE Products 
WHERE 
ProductId=@ProductId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END


--Exec SP_DeleteProduct 'P0004'

