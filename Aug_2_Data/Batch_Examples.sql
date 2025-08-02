use wiprojuly
GO

declare 
	@name varchar(30)
BEGIN
  SET @name = 'Uday'
  Print 'Name is ' + @name
END 

select count(*) from Employ

Declare 
	@count INT 
BEGIN
   Select @count = Count(*) From Employ 
   Print 'Total No.of Records are  ' +convert(varchar,@count)
END

Declare 
	@count INT 
BEGIN
   Select @count = Count(*) From Employ 
   if @count >= 10 
   BEGIN
	print 'Cardinality is Good'
   END
   ELSE
   BEGIN
     print 'Please add More Records'
   END
   Print 'Total No.of Records are  ' +convert(varchar,@count)
END

select * from Employ where empno = 1;

declare
    @empno INT,
	@name varchar(30),
	@Gender varchar(10),
	@dept varchar(30),
	@desig varchar(30),
	@basic numeric(9,2)
BEGIN
	set @empno = 33 
	if Exists(select * from Employ where empno = @empno) 
	BEGIN
		select @name = name, @gender=Gender, @dept = Dept, 
			@Desig=Desig, @Basic = Basic
		from EMploy where empno = @empno 
		Print 'Employ Name ' +@name
		Print 'Gender ' +@gender
		Print 'Department ' +@dept 
		Print 'Designation ' +@desig
		print 'Salary ' +Convert(varchar,@basic)
	END
	ELSE 
	BEGIN	
		PRINT 'Record Not Found...'
	END
END

Declare
   @empno INT,
   @name varchar(30),
   @gender varchar(10),
   @dept varchar(30),
   @desig varchar(30),
   @basic numeric(9,2)
BEGIN
	select @empno = max(empno) from Employ
	set @empno = @empno + 1
	set @name = 'Venkata Narayana'
	set @gender = 'MALE'
	set @dept = 'Dotnet'
	set @desig = 'Manager'
	set @basic = 84823
    Insert into Employ(Empno,Name,Gender,Dept, Desig,Basic) 
		values(@empno,@name,@Gender,@dept,@desig,@basic)
	Print 'Employ Record Inserted...'
END

select * from Employ