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
create table Category(
CategoryId INT IDENTITY(1,1) PRIMARY KEY,
CategoryName varchar(100) not null,
Descriptions varchar(600)not null
)

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
create table Payment(
        
    PaymentId INT IDENTITY(100,1) PRIMARY KEY,
    ProductId VARCHAR(5) FOREIGN KEY REFERENCES Product(ProductId),
    CustomerId INT NOT NULL  FOREIGN KEY REFERENCES Customers(CustomerId),
    Quantity INT,
    Price NUMERIC(7,2),
    TotalPrice NUMERIC(7,2),
    PaymentMode VARCHAR(20)NOT NULL,
	Date[date]
)

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
CREATE TABLE PaymentMode(
    PaymentId INT NOT NULL  FOREIGN KEY REFERENCES Payment(PaymentId),
    ModeOfPayment VARCHAR(50)
    )

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
	ProductId VARCHAR(5) FOREIGN KEY REFERENCES Product(ProductId) NOT NULL,
    CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerId),
	OrderDate DATE NOT NULL,
	OrderDeliveryDate DATETIME2(0)NULL,
	Status VARCHAR(20)
)

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

CREATE TABLE ErrorLog
(
Id INT IDENTITY(1,1) CONSTRAINT PK_ErId PRIMARY KEY,
ErrorLine INT, 
ErrorMessage VARCHAR(255), 
ErrorNumber INT, 
ErrorProcedure VARCHAR(255)

)


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
ShippingId INT IDENTITY(1,1) primary key,
OrderId INT NOT NULL FOREIGN KEY REFERENCES Orders(OrderId),
ShippingAddress VARCHAR(50),
ContactNumber VARCHAR(12)
)

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
create table OrderDetail(
    OrderId INT NOT NULL FOREIGN KEY REFERENCES Orders(OrderId),
    PaymentId INT NOT NULL FOREIGN KEY REFERENCES Payment(PaymentId),
    CustomerId INT NOT NULL CONSTRAINT fk_customerId FOREIGN KEY REFERENCES Customers(CustomerId),
    TotalPrice NUMERIC(7,2),
    Quantity INT
    )







GO
