CREATE PROCEDURE [dbo].[SP_CancelOrder]
(
@OrderId INT
)
AS
BEGIN
DELETE FROM Payment WHERE OrderId=@OrderId
END