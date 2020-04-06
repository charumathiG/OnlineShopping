CREATE PROCEDURE [dbo].[SP_InsertProduct]
(
@ProductName varchar(100),
@CategoryId Int,
@Description  VARCHAR(600),
@Price  NUMERIC(7,2),
@Quantity INT,
@Image VARCHAR(50)

)
AS
BEGIN

INSERT INTO Products
(
ProductName,
CategoryId,
Description,
Price,
Quantity,
Image
) 
Values(@ProductName, @CategoryId,@Description,@Price,@Quantity,@Image)

SELECT CAST(SCOPE_IDENTITY() AS INT)

END

--Exec SP_InsertProduct 'Mobile','1','Happy Life','20000.',1,'image'
