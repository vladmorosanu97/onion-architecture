CREATE TABLE [dbo].[Table]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(255) NOT NULL, 
    [Seats] INT NOT NULL, 
    [SectionId] INT NOT NULL, 
    [ShapeId] INT NOT NULL, 
    CONSTRAINT [FK_Table_ToSection] FOREIGN KEY ([SectionId]) REFERENCES [Section]([Id]), 
    CONSTRAINT [FK_Table_ToShape] FOREIGN KEY ([ShapeId]) REFERENCES [Shape]([Id])
)
