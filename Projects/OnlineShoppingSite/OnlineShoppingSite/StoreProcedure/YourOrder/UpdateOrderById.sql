CREATE PROCEDURE [dbo].[SP_UpdateOrderById]
(
@ProductId VARCHAR(5),
@CustomerId Int,
@Status VARCHAR(20)

)
AS
DECLARE @DATE DATE=GETDATE()
DECLARE @DATETIME2 DATE=GETDATE()+2
BEGIN
DECLARE @result int

UPDATE Orders
SET 
ProductId = @ProductId,
CustomerId = @CustomerId,
Status = @Status

WHERE
CustomerId=@CustomerId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END

--exec SP_UpdateProductById  '100'
