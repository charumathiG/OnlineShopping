CREATE PROCEDURE [dbo].[SP_UpdateDetail]
(
@ShippingId INT ,
@OrderId INT,
@ShippingAddress VARCHAR(50),
@ContactNumber VARCHAR(12)
)
AS
BEGIN
DECLARE @result int

UPDATE Shipping
SET 
    ShippingId=@ShippingId,
    OrderId=@OrderId,
    ShippingAddress=@ShippingAddress,
    ContactNumber=@ContactNumber 
   
WHERE
     ShippingId=@ShippingId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END


	