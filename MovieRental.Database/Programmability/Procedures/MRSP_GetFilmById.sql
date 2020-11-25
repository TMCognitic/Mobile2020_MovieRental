CREATE PROCEDURE [dbo].[MRSP_GetFilmById]
	@FilmId int
AS
BEGIN
	SELECT [FilmId], [Title], [Description], [ReleaseYear], [LanguageName] AS [Language], [RentalDuration], [RentalPrice], [Length], [ReplacementCost], [Rating]
	FROM [V_Film]
	WHERE [FilmId] = @FilmId;
END
