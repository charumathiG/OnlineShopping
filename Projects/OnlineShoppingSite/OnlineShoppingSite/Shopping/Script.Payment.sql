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
create table Payment(
        
    Id INT IDENTITY(100,1),
    ProductId VARCHAR(5) FOREIGN KEY REFERENCES Products(ProductId),
    CustomerId INT NOT NULL  FOREIGN KEY REFERENCES Customers(CustomerId),
	PurchasePrice NUMERIC(7,2),
    PaymentMode VARCHAR(20)NOT NULL,
	Date[date]
)
