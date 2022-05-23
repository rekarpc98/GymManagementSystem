﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Name] NVARCHAR(250) NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL, 
    [PhoneNumber1] NVARCHAR(11) NOT NULL, 
    [PhoneNumber2] NVARCHAR(11) NOT NULL,
    [Password] NVARCHAR(250) NOT NULL, 
    [Role] NVARCHAR(250) NOT NULL
)
