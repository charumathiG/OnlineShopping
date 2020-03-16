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
PRINT N'Creating [dbo].[SP_AddToCart]...';


GO
CREATE PROCEDURE [dbo].[SP_AddToCart]
(
@CustomerID INT,
@ProductId VARCHAR(5)
)
AS
DECLARE @DATE DATE = (SELECT CONVERT(DATE,GETDATE()))
BEGIN
	INSERT INTO AddToCart VALUES
	(
	@ProductId,
	@CustomerId,
	@DATE
	)
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
    @CustomerName VARCHAR(50),
	@CustomerPhone VARCHAR(11),
	@CustomerPassword VARCHAR(100),
	@CustomerEmail VARCHAR(100),
	@CustomerAddress VARCHAR(100)
)
	AS
	BEGIN
	BEGIN TRY
	INSERT INTO Customers VALUES
	(
	@CustomerName,
	@CustomerPhone,
	@CustomerPassword,
	@CustomerEmail,
	@CustomerAddress
)  
END TRY
BEGIN CATCH
DECLARE @errorLine INT, @errorMessage VARCHAR(255), @errorNumber INT, @errorProcedure VARCHAR(255)
SET @errorLine=ERROR_LINE()
SET @errorMessage=ERROR_MESSAGE() 
SET @errorProcedure= ERROR_PROCEDURE() 
SET @errorNumber=ERROR_NUMBER() 
EXECUTE ErrorHandling @errorLine, @errorMessage, @errorProcedure, @errorNumber
END CATCH
END
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
PRINT N'Creating [dbo].[SP_Orders]...';


GO
CREATE PROCEDURE [dbo].[SP_Orders]
(
@CustomerID INT,
@ProductId VARCHAR(5),
@Quantity INT
)
AS
DECLARE @DATE DATE = (SELECT CONVERT(DATE,GETDATE()))
BEGIN
	INSERT INTO Orders VALUES
	(
	@ProductId,
	@DATE,@DATE,
	@CustomerId,
	@Quantity,
	'Place Order'
	)
END
GO
PRINT N'Creating [dbo].[SP_Payment]...';


GO
CREATE PROCEDURE [dbo].[SP_Payment]
(
@CustomerId INT,
@ProductId VARCHAR(5),
@PurchasePrice NUMERIC(7,2)
)
AS
DECLARE @DATE DATE = (SELECT CONVERT(DATE,GETDATE()))
BEGIN
INSERT INTO Payment VALUES
(
@CustomerId,
@ProductId,
@PurchasePrice,
@DATE
)
END
GO
PRINT N'Creating [dbo].[SP_PlaceOrder]...';


GO
CREATE PROCEDURE [dbo].[SP_PlaceOrder](
@OrderId INT,
@ProductName VARCHAR(255),
@ProductPrice NUMERIC(7,2),
@ProductId VARCHAR(255),
@Email VARCHAR(255),
@PaymentType VARCHAR(255),
@Name VARCHAR(200),
@Address VARCHAR(255),
@Pincode INT,
@PhoneNumber VARCHAR(200),
@Image IMAGE,
@Quantity INT
)
AS
BEGIN
INSERT INTO Status VALUES(
'Ordered',
@Email,
@ProductId,
@ProductName,
@ProductPrice,
@PaymentType,
@Name,
@Address,
@Pincode,
@PhoneNumber,
@Image,
@Quantity
)
UPDATE Products SET Quantity = Quantity- @Quantity WHERE ProductId = @ProductId 
DELETE orders WHERE OrderId = @OrderId
END
GO
PRINT N'Creating [dbo].[SP_Products]...';


GO
CREATE PROCEDURE [dbo].[SP_Products]
AS
BEGIN
SELECT * FROM Products
END
GO
PRINT N'Creating [dbo].[SP_SearchProduct]...';


GO
CREATE PROCEDURE [dbo].[SP_SearchProduct](
@ProductName VARCHAR(100)
)
AS
BEGIN
SELECT * FROM  Products WHERE ProductName
LIKE '%'+@ProductName+'%' OR
Category LIKE '%' +@ProductName+'%' OR ProductType LIKE '%'+@ProductName+'%'
ORDER BY Price ASC
END
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
PRINT N'Creating [dbo].[SP_YourOrder]...';


GO
CREATE PROCEDURE [dbo].[SP_YourOrder](
@CustomerEmail VARCHAR(50)
)
AS
BEGIN
SELECT * FROM Status WHERE Email=@CustomerEmail
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
  CustomerName VARCHAR(50) NOT NULL,
  CustomerPhone VARCHAR(12)NOT NULL,
  CustomerPassword VARCHAR(16)NOT NULL,
  CustomerEmail VARCHAR(50)NOT NULL CHECK(CustomerEmail LIKE '%___@___%') ,
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
create table Products(
  Id INT IDENTITY PRIMARY KEY,
  ProductId AS 'P'+RIGHT('0000'+CAST(Id AS VARCHAR(10)),4) PERSISTED UNIQUE,
  ProductName VARCHAR(100)NOT NULL,
  Category VARCHAR(50),
  ProductType VARCHAR(50),
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
        
    Id INT IDENTITY(100,1),
    ProductId VARCHAR(5) FOREIGN KEY REFERENCES Products(ProductId),
    CustomerId INT NOT NULL CONSTRAINT fk_customerId FOREIGN KEY REFERENCES Customers(CustomerId),
	PurchasePrice NUMERIC(7,2),
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
create table Orders(
	OrderID int IDENTITY(1,1) PRIMARY KEY CLUSTERED NOT NULL,
	ProductId VARCHAR(5) FOREIGN KEY REFERENCES Products(ProductId) NOT NULL,
    CustomerId INT NOT NULL CONSTRAINT fk_customer_Id  FOREIGN KEY REFERENCES Customers(CustomerId),
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
	CartId INT IDENTITY(1,1),
	CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerId),
	ProductId VARCHAR(5) FOREIGN KEY REFERENCES Products(ProductId),
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
create table OrderItem(
    OrderId INT NOT NULL CONSTRAINT fk_order_Id FOREIGN KEY REFERENCES Orders(OrderId),
    CustomerId INT NOT NULL CONSTRAINT fk_customer_Id FOREIGN KEY REFERENCES Customers(CustomerId),
    PurchasePrice NUMERIC(7,2),
    Quantity INT
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
create table Status(
StatusId INT IDENTITY(100,1),
Stage VARCHAR(255),
Email VARCHAR(255),
ProductId VARCHAR(5),
ProductName VARCHAR(100),
Price NUMERIC(7,2),
PaymentType VARCHAR(50),
Name VARCHAR(50),
Address VARCHAR(100),
Pincode VARCHAR(7),
PhoneNumber VARCHAR(12),
Image IMAGE,
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
