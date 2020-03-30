CREATE PROCEDURE [dbo].[SP_InsertProduct]
(
@ProductName varchar(100),
@CategoryId Int,
@Descriptions  VARCHAR(600),
@Price  NUMERIC(7,2),
@Quantity INT,
@Images IMAGE

)
AS
BEGIN

INSERT INTO Product(ProductName,CategoryId,Descriptions,Price,Quantity,Images) 
Values(@ProductName, @CategoryId,@Descriptions,@Price,@Quantity,@Images)

SELECT CAST(SCOPE_IDENTITY() AS INT)

END

--Exec SP_InsertProduct 'Mobile','1','Happy Life','20000.',1,'image'
