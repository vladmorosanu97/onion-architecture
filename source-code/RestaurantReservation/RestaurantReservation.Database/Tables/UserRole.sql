﻿CREATE TABLE [dbo].[UserRole]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(255) NOT NULL, 
    [Description] NVARCHAR(512) NOT NULL
)
