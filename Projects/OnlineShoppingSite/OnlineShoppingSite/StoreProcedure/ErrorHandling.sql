CREATE PROCEDURE [dbo].[SP_ErrorHandling]
(
@errorLine INT, 
@errorMessage VARCHAR(255), 
@errorNumber INT, 
@errorProcedure VARCHAR(255)
)
AS
BEGIN
INSERT INTO [dbo].[ErrorLog](
ErrorLine, 
ErrorMessage, 
ErrorNumber, 
ErrorProcedure
)
VALUES(
@errorLine, 
@errorMessage, 
@errorNumber, 
@errorProcedure
)
END


