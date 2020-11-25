CREATE PROCEDURE [dbo].[MRSP_CreateRental]
	@CustomerId int,
	@FilmIds FilmIds READONLY
AS
BEGIN
	INSERT INTO [Rental] ([CustomerId])
	VALUES (@CustomerId);
	DECLARE @RentalId INT = SCOPE_IDENTITY();

	INSERT INTO [RentalDetail] ([RentalId], [FilmId], [RentalPrice])
	SELECT @RentalId, FI.[FilmId], F.[RentalPrice]
	From @FilmIds FI
	JOIN [Film] F ON FI.[FilmId] = F.[FilmId];

	Select @RentalId;
END
