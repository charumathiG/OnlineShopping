CREATE PROCEDURE [dbo].[SP_GetOrderById]
(
@OrderId Int
)
AS
BEGIN

SELECT * FROM Orders 
WHERE OrderId=@OrderId

END



--Exec SP_GetOrderById 'P0001'