CREATE PROCEDURE [dbo].[SP_UpdateDog]
	@ID int,
	@Name varchar(50),
	@Breed varchar(100),
	@Gender varchar(100),
	@Comment varchar(1024)
AS
BEGIN
UPDATE Dog SET DogName=@Name,Breed=@Breed,Gender=@Gender,Comment=@Comment WHERE DogId=@ID;
END