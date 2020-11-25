CREATE PROCEDURE [dbo].[MRSP_CheckCustomer]
	@Email NVARCHAR(320),
	@Passwd VARCHAR(20)
AS
BEGIN
	SELECT [CustomerId], [LastName], [FirstName], [Email]
	FROM [Customer] 
	WHERE [Email] = @Email and [Passwd] = HASHBYTES('SHA2_512', dbo.MRSF_GetPreSalt() + @Passwd + dbo.MRSF_GetPostSalt());
END
