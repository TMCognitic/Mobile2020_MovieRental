CREATE PROCEDURE [dbo].[MRSP_GetFilmsByCategory]
	@CategoryId INT
AS
BEGIN
	SELECT F.[FilmId], [Title], [Description], [ReleaseYear], [LanguageName] AS [Language], [RentalDuration], [RentalPrice], [Length], [ReplacementCost], [Rating]
	FROM [V_Film] F
	JOIN [FilmCategory] FC ON F.[FilmId] = FC.[FilmId]
	WHERE FC.[CategoryId] = @CategoryId;
END
