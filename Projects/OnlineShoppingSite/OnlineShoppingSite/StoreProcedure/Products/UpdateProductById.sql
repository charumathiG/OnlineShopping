CREATE PROCEDURE [dbo].[SP_UpdateProductById]
(
@ProductId varchar(100),
@ProductName varchar(100),
@CategoryId Int,
@Descriptions  VARCHAR(600),
@Price  NUMERIC(7,2),
@Quantity INT,
@Images IMAGE
)
AS
BEGIN
DECLARE @result int

UPDATE Product
SET 
    ProductName=@ProductName,
    CategoryId=@CategoryId,
    Descriptions=@Descriptions,
    Price=@Price, 
    Quantity=@Quantity,
    Images=@Images
WHERE
    ProductId=@ProductId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END

--exec SP_UpdateProductById  '1'
