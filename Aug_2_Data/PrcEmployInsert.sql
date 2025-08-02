if exists(select * from sysobjects where name='prcEmployInsert') 
Drop Proc PrcEmployInsert 
GO

Create Proc PrcEmployInsert
				@Name varchar(30),
				@gender varchar(10),
				@dept varchar(30),
				@desig varchar(30),
				@basic Numeric(9,2)
AS
BEGIN
	Declare
		@empno INT 
	begin
		select @empno= case when max(empno) is NULL THEN 1 else 
			max(empno)+1 END from Employ
		Insert into Employ(empno,Name,Gender,Dept,Desig,Basic) 
			values(@empno,@name,@gender,@dept,@desig,@basic) 
		Print 'Employ Record Inserted...'
	end
END
GO
Exec PrcEmployInsert 'Madhu','Male','Dotnet','Expert',88323 
GO