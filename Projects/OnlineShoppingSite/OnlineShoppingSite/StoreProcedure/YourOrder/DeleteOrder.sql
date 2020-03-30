CREATE PROCEDURE [dbo].[DeleteOrder]
(
@OrderId  varchar(10)
)

AS
BEGIN

DECLARE @result int

DELETE Orders 
WHERE 
OrderId=@OrderId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END

