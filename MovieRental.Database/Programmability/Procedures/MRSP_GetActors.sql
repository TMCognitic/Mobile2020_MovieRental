CREATE PROCEDURE [dbo].[MRSP_GetActors]
AS
BEGIN
	SELECT [ActorId], [LastName], [FirstName]
	FROM [Actor];
END
