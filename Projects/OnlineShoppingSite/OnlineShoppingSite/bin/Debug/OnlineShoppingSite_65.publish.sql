﻿/*
Deployment script for OnlineShoppingSite

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "OnlineShoppingSite"
:setvar DefaultFilePrefix "OnlineShoppingSite"
:setvar DefaultDataPath "C:\Users\charumathi.gunasekar\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"
:setvar DefaultLogPath "C:\Users\charumathi.gunasekar\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[DeleteOrder]...';


GO
CREATE PROCEDURE [dbo].[DeleteOrder]
(
@OrderId  varchar(10)
)

AS
BEGIN

DECLARE @result int

DELETE Orders 
WHERE 
OrderId=@OrderId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END
GO
PRINT N'Creating [dbo].[SP_CancelOrder]...';


GO
CREATE PROCEDURE [dbo].[SP_CancelOrder]
(
@OrderId INT
)
AS
BEGIN
DELETE FROM Payment WHERE OrderId=@OrderId
END
GO
PRINT N'Creating [dbo].[SP_CustomerRegistration]...';


GO
CREATE PROCEDURE [dbo].[SP_CustomerRegistration]
(
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
	@PhoneNumber VARCHAR(12),
	@Password VARCHAR(100),
	@EmailId VARCHAR(100),
	@Address VARCHAR(100)
)
	AS
	BEGIN
	INSERT INTO Customers VALUES
	(
	@FirstName,
	@LastName,
	@PhoneNumber,
	@Password,
	@EmailId,
	@Address
)  
END
GO
PRINT N'Creating [dbo].[SP_DeleteCart]...';


GO
CREATE PROCEDURE [dbo].[SP_DeleteCart]
(
@CartId int
)

AS
BEGIN

DECLARE @result int

DELETE AddToCart 
WHERE 
CartId=@CartId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END
GO
PRINT N'Creating [dbo].[SP_DeleteProduct]...';


GO
CREATE PROCEDURE [dbo].[SP_DeleteProduct]
(
@ProductId  varchar(10)
)

AS
BEGIN

DECLARE @result int

DELETE Products 
WHERE 
ProductId=@ProductId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END


--Exec SP_DeleteProduct 'P0004'
GO
PRINT N'Creating [dbo].[SP_ErrorHandling]...';


GO
CREATE PROCEDURE [dbo].[SP_ErrorHandling]
(
@errorLine INT, 
@errorMessage VARCHAR(255), 
@errorNumber INT, 
@errorProcedure VARCHAR(255)
)
AS
BEGIN
INSERT INTO [dbo].[ErrorLog](
ErrorLine, 
ErrorMessage, 
ErrorNumber, 
ErrorProcedure
)
VALUES(
@errorLine, 
@errorMessage, 
@errorNumber, 
@errorProcedure
)
END
GO
PRINT N'Creating [dbo].[SP_ErrorSelectAll]...';


GO
CREATE PROCEDURE [dbo].[SP_ErrorSelectAll]
AS
BEGIN
SELECT 
ErrorLine, 
ErrorMessage, 
ErrorNumber, 
ErrorProcedure
FROM
ErrorLog

END
GO
PRINT N'Creating [dbo].[SP_GetCart]...';


GO
CREATE PROCEDURE [dbo].[SP_GetCart]
AS
BEGIN

SELECT * FROM AddToCart

END
GO
PRINT N'Creating [dbo].[SP_GetCartById]...';


GO
CREATE PROCEDURE [dbo].[SP_GetCartById]
(
@CartId INT
)
AS
BEGIN

SELECT * FROM AddToCart 
WHERE 
CartId=@CartId

END

--exec SP_GetCartById '1'
GO
PRINT N'Creating [dbo].[SP_GetCategory]...';


GO
CREATE PROCEDURE [dbo].[SP_GetCategory]
AS
BEGIN

SELECT * FROM Category

END
GO
PRINT N'Creating [dbo].[SP_GetDetail]...';


GO
CREATE PROCEDURE [dbo].[SP_GetDetail]
AS
BEGIN

SELECT * FROM Shipping

END
GO
PRINT N'Creating [dbo].[SP_GetOrder]...';


GO
CREATE PROCEDURE [dbo].[SP_GetOrder]

AS
BEGIN

SELECT * FROM Orders 

END
GO
PRINT N'Creating [dbo].[SP_GetOrderById]...';


GO
CREATE PROCEDURE [dbo].[SP_GetOrderById]
(
@OrderId Int
)
AS
BEGIN

SELECT * FROM Orders 
WHERE OrderId=@OrderId

END



--Exec SP_GetOrderById 'P0001'
GO
PRINT N'Creating [dbo].[SP_GetPayment]...';


GO
CREATE PROCEDURE [dbo].[SP_GetPayment]
AS
BEGIN

SELECT * FROM PaymentMode

END
GO
PRINT N'Creating [dbo].[SP_GetPaymentDetail]...';


GO
CREATE PROCEDURE [dbo].[SP_GetPaymentDetail]
	AS
BEGIN

SELECT * FROM Payment

END
GO
PRINT N'Creating [dbo].[SP_GetProductById]...';


GO
CREATE PROCEDURE [dbo].[SP_GetProductById]
(
@ProductId varchar(5)
)
AS
BEGIN

SELECT * FROM Products 
WHERE ProductId=@ProductId

END

--Exec SP_GetProductById 'P0001'
GO
PRINT N'Creating [dbo].[SP_GetProducts]...';


GO
CREATE PROCEDURE [dbo].[SP_GetProducts]

AS
BEGIN

SELECT * FROM Products 

END
	--Exec SP_GetProducts
GO
PRINT N'Creating [dbo].[SP_GetYourOrderDetails]...';


GO
CREATE PROCEDURE [dbo].[SP_GetYourOrderDetails]
AS
BEGIN

SELECT * FROM OrderDetail

END
GO
PRINT N'Creating [dbo].[SP_InsertAddress]...';


GO
CREATE PROCEDURE [dbo].[SP_InsertAddress]
(
@ShippingId INT ,
@OrderId INT,
@ShippingAddress VARCHAR(50),
@ContactNumber VARCHAR(12)
)
AS
BEGIN
INSERT INTO Shipping
(
ShippingId,
OrderId,
ShippingAddress,
ContactNumber
)
Values
(
@ShippingId,
@OrderId,
@ShippingAddress,
@ContactNumber
)
END
GO
PRINT N'Creating [dbo].[SP_InsertCart]...';


GO
CREATE PROCEDURE [dbo].[SP_InsertCart]
(
@CustomerId INT ,
@ProductId VARCHAR(5),
@Price NUMERIC(7,2),
@Quantity INT
)
AS
DECLARE @DATE DATE=GETDATE()

BEGIN
INSERT INTO AddToCart(CustomerId,ProductId,Price,Quantity,[DATE])
Values(@CustomerId,@ProductId,@Price,@Quantity,@DATE)
END

--exec InsertCart '101','P0001','2222.',2

--select * from Customers
--select * from Product
--select * from AddToCart
GO
PRINT N'Creating [dbo].[SP_InsertCategory]...';


GO
CREATE PROCEDURE [dbo].[SP_InsertCategory](
@CategoryId INT,
@CategoryName varchar(100),
@Description varchar(600)
)
AS
BEGIN
INSERT INTO Category
VALUES
(
@CategoryId,
@CategoryName,
@Description
)
End
GO
PRINT N'Creating [dbo].[SP_InsertOrder]...';


GO
CREATE PROCEDURE [dbo].[SP_InsertOrder]
(
@ProductId VARCHAR(5),
@CustomerId Int,
@Status VARCHAR(20)

)
AS
DECLARE @DATE DATE=GETDATE()
DECLARE @DATETIME2 DATE=GETDATE()+2
BEGIN

INSERT INTO Orders (ProductId,CustomerId,OrderDate,OrderDeliveryDate,Status) 
Values(@ProductId, @CustomerId,@DATE,@DATETIME2,@Status)

END


--exec SP_InsertOrder 'P0001','100','place order'
GO
PRINT N'Creating [dbo].[SP_InsertPayment]...';


GO
CREATE PROCEDURE [dbo].[SP_InsertPayment]
(
@PaymentModeId INT,
@ModeOfPayment VARCHAR(50)
)
AS

BEGIN
INSERT INTO PaymentMode
(
PaymentModeId,
ModeOfPayment
)
Values
(
@PaymentModeId,
@ModeOfPayment
)
END
GO
PRINT N'Creating [dbo].[SP_InsertProduct]...';


GO
CREATE PROCEDURE [dbo].[SP_InsertProduct]
(
@ProductName varchar(100),
@CategoryId Int,
@Description  VARCHAR(600),
@Price  NUMERIC(7,2),
@Quantity INT,
@Image VARCHAR(50)

)
AS
BEGIN

INSERT INTO Products
(
ProductName,
CategoryId,
Description,
Price,
Quantity,
Image
) 
Values(@ProductName, @CategoryId,@Description,@Price,@Quantity,@Image)

SELECT CAST(SCOPE_IDENTITY() AS INT)

END

--Exec SP_InsertProduct 'Mobile','1','Happy Life','20000.',1,'image'
GO
PRINT N'Creating [dbo].[SP_SearchProductByKeyword]...';


GO
CREATE PROCEDURE [dbo].[SP_SearchProductByKeyword]
	
(
@keyword varchar(1000)
)
AS
BEGIN

SELECT * From Products
WHERE
ProductId	  Like  '%'+@keyword+'%' OR
ProductName	Like  '%'+@keyword+'%' OR
CategoryId	Like  '%'+@keyword+'%' OR
Description	Like  '%'+@keyword+'%' OR
Price	Like  '%'+@keyword+'%' OR
Quantity	  Like  '%'+@keyword+'%' 

END

--exec SP_SearchProductByKeyword 'P0'

--select * from Product
GO
PRINT N'Creating [dbo].[SP_UpdateCartById]...';


GO
CREATE PROCEDURE [dbo].[SP_UpdateCartById]
(
	@CartId INT,
	@CustomerId INT ,
	@ProductId VARCHAR(5),
    @Price NUMERIC(7,2),
    @Quantity INT

)
AS
BEGIN
DECLARE @result int

UPDATE AddToCart
SET 
    CustomerId=@CustomerId,
    ProductId=@ProductId,
    Price=@Price,
    Quantity=@Quantity 
   
WHERE
CartId=@CartId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END


--exec SP_UpdateCartById '100'
GO
PRINT N'Creating [dbo].[SP_UpdateDetail]...';


GO
CREATE PROCEDURE [dbo].[SP_UpdateDetail]
(
@ShippingId INT ,
@OrderId INT,
@ShippingAddress VARCHAR(50),
@ContactNumber VARCHAR(12)
)
AS
BEGIN
DECLARE @result int

UPDATE Shipping
SET 
    ShippingId=@ShippingId,
    OrderId=@OrderId,
    ShippingAddress=@ShippingAddress,
    ContactNumber=@ContactNumber 
   
WHERE
     ShippingId=@ShippingId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END
GO
PRINT N'Creating [dbo].[SP_UpdateOrderById]...';


GO
CREATE PROCEDURE [dbo].[SP_UpdateOrderById]
(
@ProductId VARCHAR(5),
@CustomerId Int,
@Status VARCHAR(20)

)
AS
DECLARE @DATE DATE=GETDATE()
DECLARE @DATETIME2 DATE=GETDATE()+2
BEGIN
DECLARE @result int

UPDATE Orders
SET 
ProductId = @ProductId,
CustomerId = @CustomerId,
Status = @Status

WHERE
CustomerId=@CustomerId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END

--exec SP_UpdateProductById  '100'
GO
PRINT N'Creating [dbo].[SP_UpdatePayment]...';


GO
CREATE PROCEDURE [dbo].[SP_UpdatePayment]
(
@PaymentModeId INT,
@ModeOfPayment VARCHAR(50)
)
AS
BEGIN
DECLARE @result int

UPDATE AddToCart
SET 
    PaymentModeId=@PaymentModeId,
    ModeOfPayment=@ModeOfPayment
    
   
WHERE
    PaymentModeId=@PaymentModeId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END
GO
PRINT N'Creating [dbo].[SP_UpdateProductById]...';


GO
CREATE PROCEDURE [dbo].[SP_UpdateProductById]
(
@ProductId varchar(100),
@ProductName varchar(100),
@CategoryId Int,
@Descriptions  VARCHAR(600),
@Price  NUMERIC(7,2),
@Quantity INT,
@Images IMAGE
)
AS
BEGIN
DECLARE @result int

UPDATE Products
SET 
    ProductName=@ProductName,
    CategoryId=@CategoryId,
    Descriptions=@Descriptions,
    Price=@Price, 
    Quantity=@Quantity,
    Images=@Images
WHERE
    ProductId=@ProductId

IF @@ERROR=0
SET @result=1
ELSE
SET @result=0 

SELECT @result 

END

--exec SP_UpdateProductById  '1'
GO
PRINT N'Creating [dbo].[SP_UserLogin]...';


GO
CREATE PROCEDURE [dbo].[SP_UserLogin]
(
@CustomerEmail VARCHAR(100),
@CustomerPassword VARCHAR(100)
)
AS
BEGIN
SELECT * FROM Customers WHERE CustomerEmail = @CustomerEmail
AND 
CustomerPassword =@CustomerPassword
END
GO
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
  Name VARCHAR(100) NOT NULL,
  PhoneNumber VARCHAR(12)NOT NULL,
  Password VARCHAR(16)NOT NULL,
  EmailId VARCHAR(50)NOT NULL,
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
    PaymentTypeId INT NOT NULL FOREIGN KEY REFERENCES PaymentMode(PaymentModeId),
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
    CustomerId INT NOT NULL CONSTRAINT fk_customerId FOREIGN KEY REFERENCES Customers(CustomerId),
    TotalPrice NUMERIC(7,2),
    Quantity INT
    )







GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
