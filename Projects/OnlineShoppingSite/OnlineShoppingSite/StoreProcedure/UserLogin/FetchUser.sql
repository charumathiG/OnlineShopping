CREATE PROCEDURE [dbo].[FetchUser]
(
@EmailId VARCHAR(50)
)
as
begin
select EmailId from Customers where EmailId=@EmailId
end
