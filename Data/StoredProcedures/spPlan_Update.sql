﻿CREATE PROCEDURE [dbo].[spPlan_Update]
	@Id int,
	@Name nvarchar(250),
	@Start DATETIME2,
	@End DATETIME2,
	@Fee money

AS
begin
	
	update [Plan]

	set [Name] = @Name,
		[Start] = @Start,
		[End] = @End,
		Fee = @Fee

	where Id = @Id;
	

end
