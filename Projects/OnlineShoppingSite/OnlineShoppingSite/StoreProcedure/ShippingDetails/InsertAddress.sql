CREATE PROCEDURE [dbo].[SP_InsertAddress]
(
@ShippingId INT ,
@OrderId INT,
@ShippingAddress VARCHAR(50),
@ContactNumber VARCHAR(12)
)
AS
BEGIN
INSERT INTO Shipping
(
ShippingId,
OrderId,
ShippingAddress,
ContactNumber
)
Values
(
@ShippingId,
@OrderId,
@ShippingAddress,
@ContactNumber
)
END



	