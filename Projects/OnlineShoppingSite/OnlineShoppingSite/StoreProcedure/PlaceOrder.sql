CREATE PROCEDURE [dbo].[SP_PlaceOrder](
@OrderId INT,
@ProductName VARCHAR(255),
@ProductPrice NUMERIC(7,2),
@ProductId VARCHAR(255),
@Email VARCHAR(255),
@PaymentType VARCHAR(255),
@Name VARCHAR(200),
@Address VARCHAR(255),
@Pincode INT,
@PhoneNumber VARCHAR(200),
@Image IMAGE,
@Quantity INT
)
AS
BEGIN
INSERT INTO Status VALUES(
'Ordered',
@Email,
@ProductId,
@ProductName,
@ProductPrice,
@PaymentType,
@Name,
@Address,
@Pincode,
@PhoneNumber,
@Image,
@Quantity
)
UPDATE Products SET Quantity = Quantity- @Quantity WHERE ProductId = @ProductId 
DELETE orders WHERE OrderId = @OrderId
END
