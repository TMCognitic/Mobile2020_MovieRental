CREATE PROCEDURE [dbo].[MRSP_GetActorInitials]
AS
Begin
	SELECT DISTINCT UPPER(LEFT([LastName], 1)) AS Initial
	FROM [Actor];
End
