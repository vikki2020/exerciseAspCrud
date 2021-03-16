CREATE PROCEDURE [dbo].[SP_DeleteDog]
	@DogId int

AS
BEGIN
	DELETE FROM Dog WHERE DogId=@DogId;
	END
