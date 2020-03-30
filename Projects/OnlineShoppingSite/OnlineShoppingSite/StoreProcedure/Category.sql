CREATE PROCEDURE [dbo].[SP_Category]
(  
@CategoryId INT,
@CategoryName varchar(100),
@Descriptions varchar(600)
)

	AS
	BEGIN
	INSERT INTO Customers VALUES(
	@CategoryId,
	@CategoryName,
	@Descriptions
	)
	End
	

	--exec SP_Category 'Mobile','Good to Use'
	--exec SP_Category 'Dress','Stylish Life'

	