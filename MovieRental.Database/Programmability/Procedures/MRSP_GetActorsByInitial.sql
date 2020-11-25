CREATE PROCEDURE [dbo].[MRSP_GetActorsByInitial]
	@Initial CHAR
AS
BEGIN
	SELECT [ActorId], [LastName], [FirstName]
	FROM [Actor] WHERE LEFT([LastName], 1) = @Initial;
END
