CREATE PROCEDURE [dbo].[SP_ReadDog]
	@DogId int
AS
BEGIN
	SELECT * FROM Dog WHERE DogId=@DogId;
	END
