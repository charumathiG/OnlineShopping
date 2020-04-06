CREATE PROCEDURE [dbo].[SP_InsertOrder]
(
@ProductId VARCHAR(5),
@CustomerId Int,
@Status VARCHAR(20)

)
AS
DECLARE @DATE DATE=GETDATE()
DECLARE @DATETIME2 DATE=GETDATE()+2
BEGIN

INSERT INTO Orders (ProductId,CustomerId,OrderDate,OrderDeliveryDate,Status) 
Values(@ProductId, @CustomerId,@DATE,@DATETIME2,@Status)

END


exec SP_InsertOrder 'P0002','100','0'
select * from Orders

