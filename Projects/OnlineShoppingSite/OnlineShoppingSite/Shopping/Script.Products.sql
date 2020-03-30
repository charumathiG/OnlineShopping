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
create table Product(
  Id INT IDENTITY PRIMARY KEY,
  ProductId AS 'P'+RIGHT('0000'+CAST(Id AS VARCHAR(10)),4) PERSISTED UNIQUE,
  ProductName VARCHAR(100)NOT NULL,
  CategoryId INT NOT NULL  FOREIGN KEY REFERENCES Category(CategoryId),
  Descriptions VARCHAR(600)NOT NULL,
  Price NUMERIC(7,2)NOT NULL,
  Quantity INT,
  Images IMAGE
)


