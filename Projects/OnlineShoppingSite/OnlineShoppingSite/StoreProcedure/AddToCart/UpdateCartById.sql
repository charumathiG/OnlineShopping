CREATE PROCEDURE [dbo].[SP_UpdateCartById]
(
	@Id INT,
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
Id=@Id

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END


--exec SP_UpdateCartById '100'