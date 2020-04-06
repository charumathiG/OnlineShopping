CREATE PROCEDURE [dbo].[SP_UpdatePayment]
(
@PaymentModeId INT,
@ModeOfPayment VARCHAR(50)
)
AS
BEGIN
DECLARE @result int

UPDATE AddToCart
SET 
    PaymentModeId=@PaymentModeId,
    ModeOfPayment=@ModeOfPayment
    
   
WHERE
    PaymentModeId=@PaymentModeId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END	