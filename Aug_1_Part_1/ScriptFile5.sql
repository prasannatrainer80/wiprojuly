-- Aggregate Functions 

-- sum() : used to perform sum operation 

select sum(basic) from Emp 
GO

-- Avg() : Displays avg operation 

select avg(basic) from Emp 
GO

-- Max() : Display max value 

select max(basic) from Emp 
GO

-- Min() : Displays Min. Value

select min(basic) from Emp 
GO

-- count(*) : Displays total no.of records 

select count(*) from Emp 
GO

-- count(column_name) : displays count for that column not null values 

select count(basic) from Emp
Go
