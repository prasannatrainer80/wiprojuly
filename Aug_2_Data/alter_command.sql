
create table EmployDummy
(
   eno int,
   name int,
   basic int
)

-- Add primary key on Eno field 


alter table EmployDummy alter column eno int not null;

alter table EmployDummy add primary key(eno);

-- Change name field to varchar(30) 

alter table EmployDummy alter column name varchar(30) 

-- Change basic field to numeric(9,2) 

alter table EmployDummy Alter Column Basic Numeric(9,2);

sp_help EmployDummy
GO

alter table EmployDummy Add Gender varchar(10)


-- Drop Gender column from EmployDummy table 

alter table EmployDummy drop column Gender 
GO
