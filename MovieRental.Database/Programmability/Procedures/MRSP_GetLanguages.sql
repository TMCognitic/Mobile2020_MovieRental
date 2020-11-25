CREATE PROCEDURE [dbo].[MRSP_GetLanguages]
AS
BEGIN
	SELECT [LanguageId], [Name]
	FROM [Language];
End
