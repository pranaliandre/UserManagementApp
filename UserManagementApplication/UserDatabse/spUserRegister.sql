USE [UserManagementAppDB]
GO
/****** Object:  StoredProcedure [dbo].[spUserRegister]    Script Date: 05/26/2020 04:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spUserRegister]
	-- Add the parameters for the stored procedure here
	@FirstName varchar(50),
	@LastName varchar(50),
	@EmailId varchar(50),
	@Password varchar(50),
	@MobileNo varchar(50),
	@Gender varchar(50),
	@Address varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO UserRegisterManagement(FirstName,LastName,EmailId,Password,MobileNo,Gender,Address)
	VALUES(@FirstName,@LastName,@EmailId,@Password,@MobileNo,@Gender,@Address); 
END