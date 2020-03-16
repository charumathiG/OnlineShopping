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
create table OrderItem(
    OrderId INT NOT NULL CONSTRAINT fk_order_Id FOREIGN KEY REFERENCES Orders(OrderId),
    CustomerId INT NOT NULL CONSTRAINT fk_customerId FOREIGN KEY REFERENCES Customers(CustomerId),
    PurchasePrice NUMERIC(7,2),
    Quantity INT
    )
