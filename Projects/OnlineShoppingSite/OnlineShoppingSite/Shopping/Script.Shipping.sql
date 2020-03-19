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
CREATE TABLE Shipping(
ShippingId INT IDENTITY(1,1),
OrderId INT NOT NULL FOREIGN KEY REFERENCES Orders(OrderId),
ShippingAddress VARCHAR(50),
ContactNumber VARCHAR(12)
)
