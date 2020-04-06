CREATE PROCEDURE [dbo].[SP_InsertPayment]
(
@PaymentModeId INT,
@ModeOfPayment VARCHAR(50)
)
AS

BEGIN
INSERT INTO PaymentMode
(
PaymentModeId,
ModeOfPayment
)
Values
(
@PaymentModeId,
@ModeOfPayment
)
END

	