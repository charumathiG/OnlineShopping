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
create table Customers(
  CustomerId INT IDENTITY(100,1) PRIMARY KEY ,
  FirstName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  CustomerPhone VARCHAR(12)NOT NULL,
  CustomerPassword VARCHAR(16)NOT NULL,
  CustomerEmail VARCHAR(50)NOT NULL,
  CustomerAddress VARCHAR(100) NOT NULL
  )