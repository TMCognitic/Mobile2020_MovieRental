CREATE PROCEDURE [dbo].[MRSP_GetActorsByFilm]
	@FilmId INT
AS
Begin
	SELECT A.[ActorId], [LastName], [FirstName]
	FROM [Actor] A
	JOIN [FilmActor] FA ON A.[ActorId] = FA.[ActorId]
	WHERE [FilmId] = @FilmId;
END
