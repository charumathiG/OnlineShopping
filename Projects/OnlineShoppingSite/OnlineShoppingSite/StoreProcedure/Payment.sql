CREATE PROCEDURE [dbo].[SP_Payment]
(
@CustomerId INT,
@ProductId VARCHAR(5),
@PurchasePrice NUMERIC(7,2)
)
AS
DECLARE @DATE DATE = (SELECT CONVERT(DATE,GETDATE()))
BEGIN
INSERT INTO Payment VALUES
(
@CustomerId,
@ProductId,
@PurchasePrice,
@DATE
)
END


