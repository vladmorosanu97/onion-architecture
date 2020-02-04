CREATE TABLE [dbo].[Section]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(255) NOT NULL, 
    [RestaurantId] INT NOT NULL, 
    CONSTRAINT [FK_Section_ToRestaurant] FOREIGN KEY ([RestaurantId]) REFERENCES [Restaurant]([Id])
)
