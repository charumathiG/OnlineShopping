CREATE PROCEDURE [dbo].[SP_UpdateCartById]
(
	@CartId INT,
	@CustomerId INT ,
	@ProductId VARCHAR(5),
    @Price NUMERIC(7,2),
    @Quantity INT

)
AS
BEGIN
DECLARE @result int

UPDATE AddToCart
SET 
    CustomerId=@CustomerId,
    ProductId=@ProductId,
    Price=@Price,
    Quantity=@Quantity 
   
WHERE
CartId=@CartId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END


--exec SP_UpdateCartById '100'