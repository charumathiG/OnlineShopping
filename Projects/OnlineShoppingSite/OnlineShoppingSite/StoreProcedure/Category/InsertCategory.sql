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
