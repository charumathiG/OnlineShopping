CREATE PROCEDURE [dbo].[Cart]
	(
	@ProductId varchar(5),
	@CustomerId varchar(100),
	@Price numeric(7,2),
	@Image varchar(50),
	@Quantity int
	)
as
begin
select @Price = (select Price from Products where ProductId=@ProductId) 
update OrderDetail set Price=@Price*@Quantity where ProductId=@ProductId
end


