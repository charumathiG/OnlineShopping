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
create table Orders(
	OrderId int IDENTITY(1,1) PRIMARY KEY CLUSTERED NOT NULL,
	ProductId VARCHAR(5) NOT NULL FOREIGN KEY REFERENCES Products(ProductId),
    CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerId),
	OrderDate DATE NOT NULL,
	OrderDeliveryDate DATETIME2(0)NULL,
    Price NUMERIC(7,2),
	Status bit
)
