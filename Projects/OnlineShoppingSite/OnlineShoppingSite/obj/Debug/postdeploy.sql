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
  LastName VARCHAR (50) NOT NULL,
  FullName VARCHAR(100) NOT NULL,
  PhoneNumber VARCHAR(12)NOT NULL,
  EmailId VARCHAR(50)NOT NULL,
  Password VARCHAR(16)NOT NULL,
  Address VARCHAR(100) NOT NULL
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
CategoryId INT IDENTITY(1,1) PRIMARY KEY ,
CategoryName VARCHAR(100) NOT NULL,
Description VARCHAR(600)NOT NULL
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
create table Products(
  Id INT IDENTITY PRIMARY KEY,
  ProductId AS 'P'+RIGHT('0000'+CAST(Id AS VARCHAR(10)),4) PERSISTED UNIQUE,
  ProductName VARCHAR(100)NOT NULL,
  CategoryId INT NOT NULL  FOREIGN KEY REFERENCES Category(CategoryId),
  Description VARCHAR(600)NOT NULL,
  Price NUMERIC(7,2)NOT NULL,
  Quantity INT,
  Image VARCHAR(50)
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
    PaymentModeId INT Primary key,
    ModeOfPayment VARCHAR(50) NOT NULL
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
    PaymentId INT Primary key,   
    ProductId VARCHAR(5) NOT NULL FOREIGN KEY REFERENCES Products(ProductId),    
    PaymentModeId INT NOT NULL FOREIGN KEY REFERENCES PaymentMode(PaymentModeId),
    CustomerId INT NOT NULL  FOREIGN KEY REFERENCES Customers(CustomerId),
    Quantity INT,
    Price NUMERIC(7,2),
    TotalPrice NUMERIC(7,2),
    Status bit,
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
create table Orders(
	OrderId int IDENTITY(1,1) PRIMARY KEY CLUSTERED NOT NULL,
	ProductId VARCHAR(5) NOT NULL FOREIGN KEY REFERENCES Products(ProductId),
    CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerId),
	OrderDate DATE NOT NULL,
	OrderDeliveryDate DATETIME2(0)NULL,
    Price NUMERIC(7,2),
	Status bit
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
	CartId INT IDENTITY(1,1) PRIMARY KEY,
	CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerId),
	ProductId VARCHAR(5) NOT NULL FOREIGN KEY REFERENCES Products(ProductId),
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
    ShippingId INT NOT NULL FOREIGN KEY REFERENCES Shipping(ShippingId),
    CustomerId INT NOT NULL CONSTRAINT fk_customerId FOREIGN KEY REFERENCES Customers(CustomerId),
    Price NUMERIC(7,2),
    TotalPrice NUMERIC(7,2),
    Quantity INT
    )







GO
