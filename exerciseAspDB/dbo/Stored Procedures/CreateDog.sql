-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CreateDog]

                @DogName VARCHAR(50),
                @Breed VARCHAR(100),
                @Gender  VARCHAR(100),
                @Comment  VARCHAR(1024)
              
AS
BEGIN
INSERT INTO Dog(DogName,Breed,Gender,Comment) Values(@DogName,@Breed,@Gender,@Comment)
	
END
