CREATE PROCEDURE [dbo].[MRSP_GetCategories]
AS
BEGIN
	SELECT [CategoryId], [Name]
	FROM [Category]
END
