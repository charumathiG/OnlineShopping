﻿CREATE PROCEDURE [dbo].[SP_AddToCart]
(
@CustomerID INT,
@ProductId VARCHAR(5)
)
AS
DECLARE @DATE DATE = (SELECT CONVERT(DATE,GETDATE()))
BEGIN
	INSERT INTO AddToCart VALUES
	(
	@ProductId,
	@CustomerId,
	@DATE
	)
END



