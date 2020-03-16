CREATE PROCEDURE [dbo].[SP_ErrorSelectAll]
AS
BEGIN
SELECT 
ErrorLine, 
ErrorMessage, 
ErrorNumber, 
ErrorProcedure
FROM
ErrorLog

END