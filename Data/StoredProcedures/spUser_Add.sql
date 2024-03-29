﻿CREATE PROCEDURE [dbo].[spUser_Add]
	@Name nvarchar(250),
	@Address nvarchar(250),
	@PhoneNumber1 nvarchar(11),
	@PhoneNumber2 nvarchar(11),
	@Password nvarchar(250),
	@Role nvarchar(250)
AS
begin
	
	insert into dbo.[User]([Name], [Address], PhoneNumber1, PhoneNumber2, [Password], [Role])
	values (@Name, @Address, @PhoneNumber1, @PhoneNumber2, @Password, @Role)

end