CREATE PROCEDURE [dbo].[SP_InsertCart]
(
@CustomerId INT ,
@ProductId VARCHAR(5),
@Price NUMERIC(7,2),
@Quantity INT
)
AS
DECLARE @DATE DATE=GETDATE()

BEGIN
INSERT INTO AddToCart(CustomerId,ProductId,Price,Quantity,[DATE])
Values(@CustomerId,@ProductId,@Price,@Quantity,@DATE)
END

--exec InsertCart '101','P0001','2222.',2

--select * from Customers
--select * from Product
--select * from AddToCart



















