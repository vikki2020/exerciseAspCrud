CREATE TABLE [dbo].[Dog]
(
	[DogId] INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    [DogName]       NVARCHAR (50)  NOT NULL,
    [Breed]          NVARCHAR (100) NOT NULL,
    [Gender]          NVARCHAR (100) NOT NULL,
    [comment]   NVARCHAR (1024) NULL,
);
