﻿/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

CREATE TABLE ErrorLog
(
Id INT IDENTITY(1,1) CONSTRAINT PK_ErId PRIMARY KEY,
ErrorLine INT, 
ErrorMessage VARCHAR(255), 
ErrorNumber INT, 
ErrorProcedure VARCHAR(255)

)
