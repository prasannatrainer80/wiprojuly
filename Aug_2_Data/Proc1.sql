if exists(select * from sysobjects where name='PrcSayHello') 
Drop Proc PrcSayHello 
GO
Create proc prcSayHello
AS
BEGIN
	PRINT 'Welcome to T-Sql'
END
GO

Exec prcSayHello
GO


