-- String Functions

/* charindex() : Used to display the first occurence of the given character  */

select CHARINDEX('l','hello') 
GO

select Nam, CHARINDEX('a',nam) from Emp 
GO

/* Reverse() : Used to display string in reverse order */

select Reverse('Rajesh') 
GO

select Nam,Reverse(Nam) from Emp 
GO

/* Len() : Display's length of string  */ 

select len('Charishma Gada')
GO

select nam, len(nam) from Emp
GO

/* Left() : Displays no.of left-side chars */

select left('Prasanna',4) 
GO

/* Right() : Displays no.of right-side chars */ 

select right('Prasanna',4)
GO

/* Upper() : Dispalys string in Upper Case */ 

select nam, upper(nam) from Emp
GO

/* Lower() : Displays string in Lower Case */ 

select nam, Lower(nam) from Emp 
GO

/* Substring() : Used to display part of the string */ 

select SUBSTRING('welcome to sql',5,8) 
GO

/* Replace() : used to replace old value/string with new value/string in all occurrences */ 

SELECT REPLACE('Dotnet Training','Dotnet','Java') 
GO
