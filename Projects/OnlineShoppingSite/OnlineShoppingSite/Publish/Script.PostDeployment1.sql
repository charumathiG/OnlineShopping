/*
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
:r ..\Shopping\Script.CustomerRegistration.sql
:r ..\Shopping\Script.Products.sql
:r ..\Shopping\Script.Payment.sql
:r ..\Shopping\Script.Orders.sql
:r ..\Shopping\Script.AddToCart.sql
:r ..\Shopping\Script.ErrorHandling.sql
:r ..\Shopping\Script.OrderItem.sql
:r ..\Shopping\Script.OrderStatus.sql






