CREATE PROCEDURE [dbo].[SP_Orders]
(
@CustomerID INT,
@ProductId VARCHAR(5),
@Quantity INT
)
AS
DECLARE @DATE DATE = (SELECT CONVERT(DATE,GETDATE()))
BEGIN
	INSERT INTO Orders VALUES
	(
	@ProductId,
	@DATE,@DATE,
	@CustomerId,
	@Quantity,
	'Place Order'
	)
END
