﻿CREATE PROCEDURE [dbo].[ListDog]
AS
BEGIN
	SELECT * FROM Dog ORDER BY DogId;
	END