CREATE PROCEDURE [dbo].[MRSP_GetFilmsByActor]
	@ActorId INT
AS
BEGIN
	SELECT F.[FilmId], [Title], [Description], [ReleaseYear], [LanguageName] AS [Language], [RentalDuration], [RentalPrice], [Length], [ReplacementCost], [Rating]
	FROM [V_Film] F
	JOIN [FilmActor] FA ON F.[FilmId] = FA.[FilmId]
	WHERE FA.[ActorId] = @ActorId;
END
