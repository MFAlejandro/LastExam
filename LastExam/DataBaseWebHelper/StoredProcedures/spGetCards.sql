USE [Parcial]
GO
/****** Object:  StoredProcedure [dbo].[spGetCards]    Script Date: 4/5/2023 23:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spGetCards]

AS
BEGIN
	Select * from UserCardInformation
END
