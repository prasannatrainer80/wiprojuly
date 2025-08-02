if exists(select * from sysobjects where name='prcEmployAutoGen') 
Drop Proc prcEmployAutoGen
GO

create  procedure prcEmployAutoGen
			@empno INT OUTPUT
AS
BEGIN
	select @empno = 
		case when max(empno) IS NULL THEN 1 else max(empno)+1 END from Employ 

END
GO

if exists(select * from sysobjects where name='PrcEmployInsert') 
Drop Proc PrcEmployInsert
GO

Create proc PrcEmployInsert
			@name varchar(30),
			@gender varchar(10),
			@dept varchar(30),
			@desig varchar(30),
			@basic numeric(9,2)
AS
BEGIN
	Declare
		@empno INT 
	BEGIN
		Exec prcEmployAutoGen @empno OUTPUT 
		Insert into Employ(Empno,Name,Gender,Dept,Desig,Basic) values(@empno,@name,@gender,
				@dept,@desig,@basic)
		Print 'Employ Record Inserted...'
	END
END
GO

Exec PrcEmployInsert 'Vasim','MALE','Dotnet','Manager',88233 
GO

select * from Employ 
GO
