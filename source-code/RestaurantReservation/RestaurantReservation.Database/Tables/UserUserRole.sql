CREATE TABLE [dbo].[UserUserRole]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [UserId] INT NOT NULL, 
    [UserRoleId] INT NOT NULL, 
    [BeginDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NULL
)
