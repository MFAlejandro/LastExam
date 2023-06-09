USE [Parcial]
GO
/****** Object:  StoredProcedure [dbo].[spSaveCard]    Script Date: 4/5/2023 23:49:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spSaveCard]
	@Name varchar(max),
	@CardNumber varchar(max),
	@ExpirationDate date,
	@CVV varchar(max),
	@Banco varchar(max),
	@Color varchar(max),
	@Emisor varchar(max)
AS
BEGIN
	Insert into UserCardInformation
	( 
		Name,
		CardNumber,
		ExpirationDate,
		CVV,
		Banco,
		Color,
		Emisor
	)VALUES(@Name,@CardNumber,@ExpirationDate,@CVV,@Banco,@Color,@Emisor)
END
