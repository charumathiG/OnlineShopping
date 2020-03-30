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
create table AddToCart(
	Id INT IDENTITY(1,1),
	CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerId),
	ProductId VARCHAR(5) FOREIGN KEY REFERENCES Product(ProductId),
    Price NUMERIC(7,2),
    Quantity INT,
	[Date] Date
)