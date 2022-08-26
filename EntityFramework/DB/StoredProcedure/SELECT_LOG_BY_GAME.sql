USE [Console_Test]
GO

/****** Object:  StoredProcedure [dbo].[SELECT_LOG_BY_GAME]    Script Date: 2/12/2021 8:56:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SELECT_LOG_BY_GAME] 
	-- Add the parameters for the stored procedure here
	@Game VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].[Game_Logger] WHERE [Game] = @Game
END
GO


