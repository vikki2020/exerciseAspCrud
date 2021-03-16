CREATE TABLE [dbo].[Dog] (
    [DogId]   INT             IDENTITY (1, 1) NOT NULL,
    [DogName] NVARCHAR (50)   NOT NULL,
    [Breed]   NVARCHAR (100)  NOT NULL,
    [Gender]  NVARCHAR (100)  NOT NULL,
    [Comment] NVARCHAR (1024) NULL,
    PRIMARY KEY CLUSTERED ([DogId] ASC)
);



