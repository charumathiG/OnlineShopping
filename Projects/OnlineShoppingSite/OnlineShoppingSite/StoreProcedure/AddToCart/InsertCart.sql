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
INSERT INTO AddToCart
(
CustomerId,
ProductId,
Price,
Quantity,
[DATE]
)
Values
(
@CustomerId,
@ProductId,
@Price,
@Quantity,
@DATE
)
END

exec SP_InsertCart '100','P0002','2200.',2

select * from Customers
select * from Product
select * from AddToCart

















