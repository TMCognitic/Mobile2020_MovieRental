CREATE PROCEDURE [dbo].[MRSP_GetFilmsByLanguage]
	@LanguageId INT
AS
BEGIN
	SELECT F.[FilmId], [Title], [Description], [ReleaseYear], [LanguageName] AS [Language], [RentalDuration], [RentalPrice], [Length], [ReplacementCost], [Rating]
	FROM [V_Film] F
	WHERE F.[LanguageId] = @LanguageId;
END
